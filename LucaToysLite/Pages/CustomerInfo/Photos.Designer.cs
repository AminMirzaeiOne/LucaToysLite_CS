namespace LucaToysLite.Pages.CustomerInfo
{
    partial class Photos
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
            this.roundedButton2 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.roundedPanel3 = new LucaToysLite.Controls.RoundedPanel();
            this.roundedPanel1 = new LucaToysLite.Controls.RoundedPanel();
            this.SuspendLayout();
            // 
            // roundedButton2
            // 
            this.roundedButton2.BorderRadius = ((byte)(20));
            this.roundedButton2.BorderSize = ((byte)(3));
            this.roundedButton2.EnableBorder = true;
            this.roundedButton2.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(443, 356);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(240, 70);
            this.roundedButton2.TabIndex = 5;
            this.roundedButton2.Text = "Change Photo";
            this.roundedButton2.UseVisualStyleBackColor = true;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(3));
            this.roundedButton1.EnableBorder = true;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(76, 356);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(240, 70);
            this.roundedButton1.TabIndex = 6;
            this.roundedButton1.Text = "Change Photo";
            this.roundedButton1.UseVisualStyleBackColor = true;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackgroundImage = global::LucaToysLite.Properties.Resources.Group_19;
            this.roundedPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPanel3.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel3.BorderSize = ((byte)(3));
            this.roundedPanel3.EnableBorder = true;
            this.roundedPanel3.Location = new System.Drawing.Point(443, 87);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(240, 240);
            this.roundedPanel3.TabIndex = 3;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackgroundImage = global::LucaToysLite.Properties.Resources.Group_18_1_;
            this.roundedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel1.BorderSize = ((byte)(3));
            this.roundedPanel1.EnableBorder = true;
            this.roundedPanel1.Location = new System.Drawing.Point(76, 87);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(240, 240);
            this.roundedPanel1.TabIndex = 4;
            // 
            // Photos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.roundedPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Photos";
            this.Size = new System.Drawing.Size(773, 538);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedPanel roundedPanel3;
        private Controls.RoundedButton roundedButton2;
        private Controls.RoundedButton roundedButton1;
        private Controls.RoundedPanel roundedPanel1;
    }
}
