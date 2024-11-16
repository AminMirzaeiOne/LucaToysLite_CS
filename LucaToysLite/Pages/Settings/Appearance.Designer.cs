namespace LucaToysLite.Pages.Settings
{
    partial class Appearance
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
            this.roundedPanel1 = new LucaToysLite.Controls.RoundedPanel();
            this.ltComboBox1 = new LucaToysLite.Controls.LTComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Crimson;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel1.BorderSize = ((byte)(0));
            this.roundedPanel1.Controls.Add(this.ltComboBox1);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Location = new System.Drawing.Point(25, 35);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(696, 128);
            this.roundedPanel1.TabIndex = 1;
            // 
            // ltComboBox1
            // 
            this.ltComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltComboBox1.BorderRadius = ((byte)(20));
            this.ltComboBox1.BorderSize = ((byte)(0));
            this.ltComboBox1.ColorPallet = System.Drawing.Color.Crimson;
            this.ltComboBox1.EnableBorder = true;
            this.ltComboBox1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.ltComboBox1.FlatAppearance.BorderSize = 0;
            this.ltComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltComboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltComboBox1.ForeColor = System.Drawing.Color.White;
            this.ltComboBox1.Items = new string[] {
        "Light",
        "Dark",
        "Gray"};
            this.ltComboBox1.ItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltComboBox1.ItemsCheckedColor = System.Drawing.Color.Crimson;
            this.ltComboBox1.ItemsFont = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ltComboBox1.ItemsForeColor = System.Drawing.Color.White;
            this.ltComboBox1.ItemsHeight = ((byte)(40));
            this.ltComboBox1.Location = new System.Drawing.Point(475, 41);
            this.ltComboBox1.Name = "ltComboBox1";
            this.ltComboBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ltComboBox1.Size = new System.Drawing.Size(200, 50);
            this.ltComboBox1.TabIndex = 1;
            this.ltComboBox1.Text = "Select Theme";
            this.ltComboBox1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ltComboBox1.TopDirection = false;
            this.ltComboBox1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 79);
            this.label2.TabIndex = 0;
            this.label2.Text = "Theme : Dark";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::LucaToysLite.Properties.Resources.icons8_change_theme_48_1_;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 79);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Appearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.roundedPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Appearance";
            this.Size = new System.Drawing.Size(753, 521);
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.LTComboBox ltComboBox1;
    }
}
