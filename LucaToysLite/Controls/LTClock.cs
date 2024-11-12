using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Controls
{
    public partial class LTClock : UserControl
    {
        public LTClock()
        {
            InitializeComponent();
        }

        public System.Drawing.Color ColorPallet { get; set; } = Color.Crimson;

        // True to show the digital time.
        private bool ShowDigital = false;


        private void LTClock_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                this.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void LTClock_Load(object sender, EventArgs e)
        {
            // Attach the context menu.
            // (You could do this at design time.)
            ContextMenuStrip = ctxOptions;

            // Set the size to 200x200.
            SetSize(ctxSize200x200);

            // Use double-buffering.
            DoubleBuffered = true;

            // Set focus to the form. If you don't do this,
            // then Alt+F4 doesn't close the clock properly.
            Focus();
        }

        private void LTClock_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            // Translate to center the drawing.
            e.Graphics.TranslateTransform(
                ClientSize.Width / 2,
                ClientSize.Height / 2);

            // Draw the face including tick marks.
            DrawClockFace(e.Graphics);

            // Show the time digitally.
            ShowDigitalTime(e.Graphics);

            // Draw the hands.
            DrawClockHands(e.Graphics);

            // Draw the center.
            e.Graphics.FillEllipse(new SolidBrush(this.ColorPallet), -5, -5, 10, 10);
        }

        // Draw
        private void DrawClockFace(Graphics gr)
        {
            // Draw.
            using (Pen thick_pen = new Pen(this.ColorPallet, 4))
            {
                // Outline.
                gr.DrawEllipse(thick_pen,
                    -ClientSize.Width / 2, -ClientSize.Height / 2,
                    ClientSize.Width, ClientSize.Height);

                // Get scale factors.
                float outer_x_factor = 0.45f * ClientSize.Width;
                float outer_y_factor = 0.45f * ClientSize.Height;
                float inner_x_factor = 0.425f * ClientSize.Width;
                float inner_y_factor = 0.425f * ClientSize.Height;
                float big_x_factor = 0.4f * ClientSize.Width;
                float big_y_factor = 0.4f * ClientSize.Height;

                // Draw the tick marks.
                thick_pen.StartCap = LineCap.Triangle;
                for (int minute = 1; minute <= 60; minute++)
                {
                    double angle = Math.PI * minute / 30.0;
                    float cos_angle = (float)Math.Cos(angle);
                    float sin_angle = (float)Math.Sin(angle);
                    PointF outer_pt = new PointF(
                        outer_x_factor * cos_angle,
                        outer_y_factor * sin_angle);
                    if (minute % 5 == 0)
                    {
                        PointF inner_pt = new PointF(
                            big_x_factor * cos_angle,
                            big_y_factor * sin_angle);
                        gr.DrawLine(thick_pen, inner_pt, outer_pt);
                    }
                    else
                    {
                        PointF inner_pt = new PointF(
                            inner_x_factor * cos_angle,
                            inner_y_factor * sin_angle);
                        gr.DrawLine(new Pen(this.ColorPallet), inner_pt, outer_pt);
                    }
                }
            }
        }

        // Show the time digitally.
        private void ShowDigitalTime(Graphics gr)
        {
            // Display the time digitally.
            if (ShowDigital)
            {
                using (Font font = new Font("Times New Roman",
                    ClientSize.Height / 10, GraphicsUnit.Pixel))
                {
                    using (StringFormat string_format = new StringFormat())
                    {
                        string_format.Alignment = StringAlignment.Center;
                        string_format.LineAlignment = StringAlignment.Center;
                        gr.DrawString(DateTime.Now.ToLongTimeString(),
                            font, new SolidBrush(this.ColorPallet), 0, -font.Height,
                            string_format);
                    }
                }
            }
        }

        // Draw the clock's hands.
        private void DrawClockHands(Graphics gr)
        {
            using (Pen thick_pen = new Pen(this.ColorPallet, 4))
            {
                // Get the hour and minute plus any fraction that has elapsed.
                DateTime now = DateTime.Now;
                float hour = now.Hour +
                    now.Minute / 60f +      // Plus 60th of hours.
                    now.Second / 3600f;     // Plus 3600th of hours.
                float minute = now.Minute +
                    now.Second / 60f;       // Plus 60th of minutes.

                // Draw the hour hand.
                PointF center = new PointF(0, 0);
                float hour_x_factor = 0.2f * ClientSize.Width;
                float hour_y_factor = 0.2f * ClientSize.Height;
                double hour_angle = -Math.PI / 2 + 2 * Math.PI * hour / 12.0;
                PointF hour_pt = new PointF(
                    (float)(hour_x_factor * Math.Cos(hour_angle)),
                    (float)(hour_y_factor * Math.Sin(hour_angle)));
                thick_pen.Color = this.ColorPallet;
                gr.DrawLine(thick_pen, hour_pt, center);

                // Draw the minute hand.
                float minute_x_factor = 0.3f * ClientSize.Width;
                float minute_y_factor = 0.3f * ClientSize.Height;
                double minute_angle = -Math.PI / 2 + 2 * Math.PI * minute / 60.0;
                PointF minute_pt = new PointF(
                    (float)(minute_x_factor * Math.Cos(minute_angle)),
                    (float)(minute_y_factor * Math.Sin(minute_angle)));
                thick_pen.Width = 2;
                gr.DrawLine(thick_pen, minute_pt, center);

                // Draw the second hand.
                float second_x_factor = 0.4f * ClientSize.Width;
                float second_y_factor = 0.4f * ClientSize.Height;
                double second_angle = -Math.PI / 2 +
                    2 * Math.PI * (int)(now.Second) / 60.0;
                PointF second_pt = new PointF(
                    (float)(second_x_factor * Math.Cos(second_angle)),
                    (float)(second_y_factor * Math.Sin(second_angle)));
                gr.DrawLine(new Pen(this.ColorPallet), second_pt, center);
            }
        }

        // Redraw to show the current hand position.
        private void tmrTick_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        // Resize the form.
        private void mnuSize_Click(object sender, EventArgs e)
        {
            // Resize the form.
            SetSize(sender as ToolStripMenuItem);
        }

        // Set the form's size according to the menu item's caption.
        private void SetSize(ToolStripMenuItem menu_item)
        {
            // Resize the form.
            string text = menu_item.Text.Replace("&", "");
            int width = int.Parse(text.Split('x')[0]);
            int height = int.Parse(text.Split('x')[1]);
            ClientSize = new Size(width, height);

            // Set the form's region.
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(this.ClientRectangle);
            this.Region = new Region(path);

            // Redraw.
            Refresh();

            // Check the correct menu item.
            ToolStripMenuItem[] items =
            {
                ctxSize100x100,
                ctxSize150x150,
                ctxSize100x150,
                ctxSize200x200
            };
            foreach (ToolStripMenuItem item in items)
                item.Checked = (item == menu_item);
        }

        // Exit.
        private void ctxExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Show or hide the digital clock.
        private void ctxDigital_Click(object sender, EventArgs e)
        {
            ShowDigital = !ShowDigital;
            ctxDigital.Checked = ShowDigital;
        }

        // Toggle Keep On Top.
        private void ctxKeepOnTop_Click(object sender, EventArgs e)
        {
            ctxKeepOnTop.Checked = !ctxKeepOnTop.Checked;
        }


    }
}
