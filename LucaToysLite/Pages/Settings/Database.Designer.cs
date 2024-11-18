namespace LucaToysLite.Pages.Settings
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.panel1 = new System.Windows.Forms.Panel();
            this.animator1 = new WFAnimations.Animator(this.components);
            this.roundedPanel5 = new LucaToysLite.Controls.RoundedPanel();
            this.roundedPanel1 = new LucaToysLite.Controls.RoundedPanel();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.roundedRadioButton5 = new LucaToysLite.Controls.RoundedRadioButton();
            this.roundedRadioButton2 = new LucaToysLite.Controls.RoundedRadioButton();
            this.roundedRadioButton4 = new LucaToysLite.Controls.RoundedRadioButton();
            this.roundedRadioButton3 = new LucaToysLite.Controls.RoundedRadioButton();
            this.roundedRadioButton1 = new LucaToysLite.Controls.RoundedRadioButton();
            this.roundedPanel5.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.animator1.SetDecoration(this.panel1, WFAnimations.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 434);
            this.panel1.TabIndex = 4;
            // 
            // animator1
            // 
            this.animator1.AnimationType = WFAnimations.AnimationType.Leaf;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
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
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.roundedPanel5.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel5.BorderSize = ((byte)(3));
            this.roundedPanel5.Controls.Add(this.roundedButton1);
            this.animator1.SetDecoration(this.roundedPanel5, WFAnimations.DecorationType.None);
            this.roundedPanel5.Location = new System.Drawing.Point(673, 5);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(67, 70);
            this.roundedPanel5.TabIndex = 2;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel1.BorderSize = ((byte)(3));
            this.roundedPanel1.Controls.Add(this.roundedRadioButton5);
            this.roundedPanel1.Controls.Add(this.roundedRadioButton2);
            this.roundedPanel1.Controls.Add(this.roundedRadioButton4);
            this.roundedPanel1.Controls.Add(this.roundedRadioButton3);
            this.roundedPanel1.Controls.Add(this.roundedRadioButton1);
            this.animator1.SetDecoration(this.roundedPanel1, WFAnimations.DecorationType.None);
            this.roundedPanel1.Location = new System.Drawing.Point(14, 5);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(653, 70);
            this.roundedPanel1.TabIndex = 3;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(2));
            this.animator1.SetDecoration(this.roundedButton1, WFAnimations.DecorationType.None);
            this.roundedButton1.EnableBorder = false;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Image = global::LucaToysLite.Properties.Resources.icons8_restore_28;
            this.roundedButton1.Location = new System.Drawing.Point(13, 13);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(42, 45);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedRadioButton5
            // 
            this.roundedRadioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.roundedRadioButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedRadioButton5.BorderSize = ((byte)(0));
            this.roundedRadioButton5.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.roundedRadioButton5, WFAnimations.DecorationType.None);
            this.roundedRadioButton5.EnableBorder = false;
            this.roundedRadioButton5.FlatAppearance.BorderSize = 0;
            this.roundedRadioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.roundedRadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRadioButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedRadioButton5.ForeColor = System.Drawing.Color.White;
            this.roundedRadioButton5.Image = global::LucaToysLite.Properties.Resources.icons8_effect_28;
            this.roundedRadioButton5.Location = new System.Drawing.Point(487, 11);
            this.roundedRadioButton5.Name = "roundedRadioButton5";
            this.roundedRadioButton5.Size = new System.Drawing.Size(146, 50);
            this.roundedRadioButton5.TabIndex = 0;
            this.roundedRadioButton5.Text = "Animation";
            this.roundedRadioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundedRadioButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedRadioButton5.UseVisualStyleBackColor = false;
            // 
            // roundedRadioButton2
            // 
            this.roundedRadioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.roundedRadioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedRadioButton2.BorderSize = ((byte)(0));
            this.roundedRadioButton2.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.roundedRadioButton2, WFAnimations.DecorationType.None);
            this.roundedRadioButton2.EnableBorder = false;
            this.roundedRadioButton2.FlatAppearance.BorderSize = 0;
            this.roundedRadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.roundedRadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRadioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedRadioButton2.ForeColor = System.Drawing.Color.White;
            this.roundedRadioButton2.Image = global::LucaToysLite.Properties.Resources.icons8_media_28;
            this.roundedRadioButton2.Location = new System.Drawing.Point(369, 11);
            this.roundedRadioButton2.Name = "roundedRadioButton2";
            this.roundedRadioButton2.Size = new System.Drawing.Size(107, 50);
            this.roundedRadioButton2.TabIndex = 0;
            this.roundedRadioButton2.Text = "Sound";
            this.roundedRadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundedRadioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedRadioButton2.UseVisualStyleBackColor = false;
            // 
            // roundedRadioButton4
            // 
            this.roundedRadioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.roundedRadioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedRadioButton4.BorderSize = ((byte)(0));
            this.roundedRadioButton4.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.roundedRadioButton4, WFAnimations.DecorationType.None);
            this.roundedRadioButton4.EnableBorder = false;
            this.roundedRadioButton4.FlatAppearance.BorderSize = 0;
            this.roundedRadioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.roundedRadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRadioButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedRadioButton4.ForeColor = System.Drawing.Color.White;
            this.roundedRadioButton4.Image = global::LucaToysLite.Properties.Resources.icons8_english_to_arabic_28;
            this.roundedRadioButton4.Location = new System.Drawing.Point(252, 11);
            this.roundedRadioButton4.Name = "roundedRadioButton4";
            this.roundedRadioButton4.Size = new System.Drawing.Size(107, 50);
            this.roundedRadioButton4.TabIndex = 0;
            this.roundedRadioButton4.Text = "Region";
            this.roundedRadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundedRadioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedRadioButton4.UseVisualStyleBackColor = false;
            // 
            // roundedRadioButton3
            // 
            this.roundedRadioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.roundedRadioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedRadioButton3.BorderSize = ((byte)(0));
            this.roundedRadioButton3.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.roundedRadioButton3, WFAnimations.DecorationType.None);
            this.roundedRadioButton3.EnableBorder = false;
            this.roundedRadioButton3.FlatAppearance.BorderSize = 0;
            this.roundedRadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.roundedRadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRadioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedRadioButton3.ForeColor = System.Drawing.Color.White;
            this.roundedRadioButton3.Image = global::LucaToysLite.Properties.Resources.icons8_font_28;
            this.roundedRadioButton3.Location = new System.Drawing.Point(137, 11);
            this.roundedRadioButton3.Name = "roundedRadioButton3";
            this.roundedRadioButton3.Size = new System.Drawing.Size(105, 50);
            this.roundedRadioButton3.TabIndex = 0;
            this.roundedRadioButton3.Text = " Fonts";
            this.roundedRadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundedRadioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedRadioButton3.UseVisualStyleBackColor = false;
            // 
            // roundedRadioButton1
            // 
            this.roundedRadioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.roundedRadioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedRadioButton1.BorderSize = ((byte)(0));
            this.roundedRadioButton1.Checked = true;
            this.roundedRadioButton1.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.roundedRadioButton1, WFAnimations.DecorationType.None);
            this.roundedRadioButton1.EnableBorder = false;
            this.roundedRadioButton1.FlatAppearance.BorderSize = 0;
            this.roundedRadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.roundedRadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRadioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedRadioButton1.ForeColor = System.Drawing.Color.White;
            this.roundedRadioButton1.Image = global::LucaToysLite.Properties.Resources.icons8_theme_28;
            this.roundedRadioButton1.Location = new System.Drawing.Point(21, 11);
            this.roundedRadioButton1.Name = "roundedRadioButton1";
            this.roundedRadioButton1.Size = new System.Drawing.Size(105, 50);
            this.roundedRadioButton1.TabIndex = 0;
            this.roundedRadioButton1.TabStop = true;
            this.roundedRadioButton1.Text = " Based";
            this.roundedRadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundedRadioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedRadioButton1.UseVisualStyleBackColor = false;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.roundedPanel1);
            this.animator1.SetDecoration(this, WFAnimations.DecorationType.None);
            this.Name = "Database";
            this.Size = new System.Drawing.Size(753, 521);
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WFAnimations.Animator animator1;
        private Controls.RoundedPanel roundedPanel5;
        private Controls.RoundedButton roundedButton1;
        private Controls.RoundedPanel roundedPanel1;
        private Controls.RoundedRadioButton roundedRadioButton5;
        private Controls.RoundedRadioButton roundedRadioButton2;
        private Controls.RoundedRadioButton roundedRadioButton4;
        private Controls.RoundedRadioButton roundedRadioButton3;
        private Controls.RoundedRadioButton roundedRadioButton1;
    }
}
