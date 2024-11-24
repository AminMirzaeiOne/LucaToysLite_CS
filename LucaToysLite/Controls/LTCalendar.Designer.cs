namespace LucaToysLite.Controls
{
    partial class LTCalendar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(3));
            this.roundedButton1.EnableBorder = true;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Image = global::LucaToysLite.Properties.Resources.icons8_calendar_48;
            this.roundedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton1.Location = new System.Drawing.Point(24, 24);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(398, 85);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedButton1_Paint);
            // 
            // LTCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.roundedButton1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LTCalendar";
            this.Size = new System.Drawing.Size(450, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton roundedButton1;
    }
}
