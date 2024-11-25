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
            this.components = new System.ComponentModel.Container();
            WFAnimations.Animation animation1 = new WFAnimations.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LTCalendar));
            this.animator1 = new WFAnimations.Animator(this.components);
            this.roundedPanel1 = new LucaToysLite.Controls.RoundedPanel();
            this.roundedButton3 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton2 = new LucaToysLite.Controls.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.ltContextMenu1 = new LucaToysLite.Controls.LTContextMenu();
            this.showBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.ltContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animator1
            // 
            this.animator1.AnimationType = WFAnimations.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            this.animator1.Upside = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel1.BorderSize = ((byte)(3));
            this.roundedPanel1.Controls.Add(this.roundedButton3);
            this.roundedPanel1.Controls.Add(this.roundedButton2);
            this.roundedPanel1.Controls.Add(this.label8);
            this.roundedPanel1.Controls.Add(this.label7);
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label1);
            this.animator1.SetDecoration(this.roundedPanel1, WFAnimations.DecorationType.None);
            this.roundedPanel1.EnableBorder = true;
            this.roundedPanel1.Location = new System.Drawing.Point(24, 135);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(398, 291);
            this.roundedPanel1.TabIndex = 1;
            // 
            // roundedButton3
            // 
            this.roundedButton3.BorderRadius = ((byte)(20));
            this.roundedButton3.BorderSize = ((byte)(3));
            this.animator1.SetDecoration(this.roundedButton3, WFAnimations.DecorationType.None);
            this.roundedButton3.EnableBorder = true;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Location = new System.Drawing.Point(342, 25);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(30, 30);
            this.roundedButton3.TabIndex = 2;
            this.roundedButton3.Text = "";
            this.roundedButton3.UseVisualStyleBackColor = true;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BorderRadius = ((byte)(20));
            this.roundedButton2.BorderSize = ((byte)(3));
            this.animator1.SetDecoration(this.roundedButton2, WFAnimations.DecorationType.None);
            this.roundedButton2.EnableBorder = true;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(301, 25);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(30, 30);
            this.roundedButton2.TabIndex = 2;
            this.roundedButton2.Text = "";
            this.roundedButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator1.SetDecoration(this.label1, WFAnimations.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "July 2019";
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(3));
            this.animator1.SetDecoration(this.roundedButton1, WFAnimations.DecorationType.None);
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
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            this.roundedButton1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedButton1_Paint);
            // 
            // ltContextMenu1
            // 
            this.ltContextMenu1.Background = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ltContextMenu1.BorderSize = ((byte)(2));
            this.ltContextMenu1.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.ltContextMenu1, WFAnimations.DecorationType.None);
            this.ltContextMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ltContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBorderToolStripMenuItem,
            this.hideBorderToolStripMenuItem});
            this.ltContextMenu1.Name = "ltContextMenu1";
            this.ltContextMenu1.Size = new System.Drawing.Size(187, 68);
            // 
            // showBorderToolStripMenuItem
            // 
            this.showBorderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showBorderToolStripMenuItem.Name = "showBorderToolStripMenuItem";
            this.showBorderToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.showBorderToolStripMenuItem.Text = "Show Border";
            this.showBorderToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showBorderToolStripMenuItem_CheckedChanged);
            this.showBorderToolStripMenuItem.Click += new System.EventHandler(this.showBorderToolStripMenuItem_Click);
            // 
            // hideBorderToolStripMenuItem
            // 
            this.hideBorderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hideBorderToolStripMenuItem.Name = "hideBorderToolStripMenuItem";
            this.hideBorderToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.hideBorderToolStripMenuItem.Text = "Hide Border";
            this.hideBorderToolStripMenuItem.Click += new System.EventHandler(this.hideBorderToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animator1.SetDecoration(this.label2, WFAnimations.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(58, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator1.SetDecoration(this.label3, WFAnimations.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(106, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "T";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.animator1.SetDecoration(this.label4, WFAnimations.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(148, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.animator1.SetDecoration(this.label5, WFAnimations.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(197, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "T";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.animator1.SetDecoration(this.label6, WFAnimations.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(231, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.animator1.SetDecoration(this.label7, WFAnimations.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(272, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "T";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.animator1.SetDecoration(this.label8, WFAnimations.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(319, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "T";
            // 
            // LTCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedButton1);
            this.animator1.SetDecoration(this, WFAnimations.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LTCalendar";
            this.Size = new System.Drawing.Size(450, 450);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ltContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton roundedButton1;
        private RoundedPanel roundedPanel1;
        private WFAnimations.Animator animator1;
        private LTContextMenu ltContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem showBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideBorderToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
