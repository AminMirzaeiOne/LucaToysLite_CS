using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.ClassLibrary
{
    public class XToolStripDropDown : ToolStripDropDown
    {
        private Control m_popedContainer;

        private ToolStripControlHost m_host;

        private bool m_fade = true;

        private const int frames = 5;

        private const int totalduration = 100;

        private const int frameduration = 20;

        public XToolStripDropDown(Control popedControl)
        {
            XToolStripDropDown xToolStripDropDown = this;
            if (popedControl == null)
            {
                throw new ArgumentNullException("content");
            }

            m_popedContainer = popedControl;
            m_fade = SystemInformation.IsMenuAnimationEnabled && SystemInformation.IsMenuFadeEnabled;
            m_host = new ToolStripControlHost(popedControl);
            m_host.AutoSize = false;
            base.Padding = (base.Margin = (m_host.Padding = (m_host.Margin = Padding.Empty)));
            popedControl.Location = Point.Empty;
            Items.Add(m_host);
            popedControl.Disposed += delegate
            {
                popedControl = null;
                xToolStripDropDown.Dispose(disposing: true);
            };
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((keyData & Keys.Alt) == Keys.Alt)
            {
                return false;
            }

            return base.ProcessDialogKey(keyData);
        }

        public void Show(Control control)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Show(control, control.ClientRectangle);
        }

        public void Show(UserControl control)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Show(control, control.ClientRectangle);
        }

        public void Show(Form f, Point p)
        {
            Show(f, new Rectangle(p, new Size(0, 0)));
        }

        private void Show(Control control, Rectangle area)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Point p = control.PointToScreen(new Point(area.Left, area.Top + area.Height));
            Rectangle workingArea = Screen.FromControl(control).WorkingArea;
            if (p.X + base.Size.Width > workingArea.Left + workingArea.Width)
            {
                p.X = workingArea.Left + workingArea.Width - base.Size.Width;
            }

            if (p.Y + base.Size.Height > workingArea.Top + workingArea.Height)
            {
                p.Y -= base.Size.Height + area.Height;
            }

            p = control.PointToClient(p);
            Show(control, p, ToolStripDropDownDirection.BelowRight);
        }

        protected override void SetVisibleCore(bool visible)
        {
            double opacity = base.Opacity;
            if (visible && m_fade)
            {
                base.Opacity = 0.0;
            }

            base.SetVisibleCore(visible);
            if (!visible || !m_fade)
            {
                return;
            }

            for (int i = 1; i <= 5; i++)
            {
                if (i > 1)
                {
                    Thread.Sleep(20);
                }

                base.Opacity = opacity * (double)i / 5.0;
            }

            base.Opacity = opacity;
        }

        protected override void OnOpening(CancelEventArgs e)
        {
            if (m_popedContainer.IsDisposed || m_popedContainer.Disposing)
            {
                e.Cancel = true;
            }
            else
            {
                base.OnOpening(e);
            }
        }

        protected override void OnOpened(EventArgs e)
        {
            m_popedContainer.Focus();
            base.OnOpened(e);
        }

        private int radius = 20;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }


    }
}
