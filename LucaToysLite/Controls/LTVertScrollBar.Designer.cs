namespace LucaToysLite.Controls
{
    partial class LTVertScrollBar
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
            this.components = new System.ComponentModel.Container();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton2 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton3 = new LucaToysLite.Controls.RoundedButton();
            this.timerBottom = new System.Windows.Forms.Timer(this.components);
            this.timerTop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Crimson;
            this.roundedButton1.BorderRadius = ((byte)(10));
            this.roundedButton1.BorderSize = ((byte)(3));
            this.roundedButton1.EnableBorder = true;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(8, 6);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(25, 25);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = "";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedButton1_MouseDown);
            this.roundedButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundedButton1_MouseUp);
            // 
            // roundedButton2
            // 
            this.roundedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.roundedButton2.BackColor = System.Drawing.Color.Crimson;
            this.roundedButton2.BorderRadius = ((byte)(10));
            this.roundedButton2.BorderSize = ((byte)(3));
            this.roundedButton2.EnableBorder = true;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F, System.Drawing.FontStyle.Bold);
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(8, 369);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(25, 25);
            this.roundedButton2.TabIndex = 0;
            this.roundedButton2.Text = "";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedButton2_MouseDown);
            this.roundedButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundedButton2_MouseUp);
            // 
            // roundedButton3
            // 
            this.roundedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.roundedButton3.BackColor = System.Drawing.Color.Crimson;
            this.roundedButton3.BorderRadius = ((byte)(10));
            this.roundedButton3.BorderSize = ((byte)(3));
            this.roundedButton3.EnableBorder = true;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8F, System.Drawing.FontStyle.Bold);
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Location = new System.Drawing.Point(8, 122);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(25, 207);
            this.roundedButton3.TabIndex = 0;
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedButton3_MouseDown);
            this.roundedButton3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.roundedButton3_MouseMove);
            this.roundedButton3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundedButton3_MouseUp);
            // 
            // timerBottom
            // 
            this.timerBottom.Interval = 10;
            this.timerBottom.Tick += new System.EventHandler(this.timerBottom_Tick);
            // 
            // timerTop
            // 
            this.timerTop.Interval = 10;
            this.timerTop.Tick += new System.EventHandler(this.timerTop_Tick);
            // 
            // LTVertScrollBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Name = "LTVertScrollBar";
            this.Size = new System.Drawing.Size(40, 400);
            this.DoubleClick += new System.EventHandler(this.LTVertScrollBar_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
        private System.Windows.Forms.Timer timerBottom;
        private System.Windows.Forms.Timer timerTop;
    }
}
