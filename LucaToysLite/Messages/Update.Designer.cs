namespace LucaToysLite.Messages
{
    partial class Update
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.loadingControl1 = new LucaToysLite.Controls.LoadingControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // windowToolbar1
            // 
            this.windowToolbar1.BackColor = System.Drawing.Color.Crimson;
            this.windowToolbar1.BorderStyleRadius = true;
            this.windowToolbar1.CloseMessage = true;
            this.windowToolbar1.ColorPalette = System.Drawing.Color.Crimson;
            this.windowToolbar1.DarkTheme = true;
            this.windowToolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowToolbar1.IconButton = true;
            this.windowToolbar1.IconButtonImage = null;
            this.windowToolbar1.IconButtonSybmol = "";
            this.windowToolbar1.IconMenu = true;
            this.windowToolbar1.Location = new System.Drawing.Point(0, 0);
            this.windowToolbar1.MaximizeButton = true;
            this.windowToolbar1.MinimizeButton = true;
            this.windowToolbar1.MoveOption = true;
            this.windowToolbar1.Name = "windowToolbar1";
            this.windowToolbar1.Size = new System.Drawing.Size(750, 45);
            this.windowToolbar1.StartupSound = LucaToysLite.Controls.WindowToolbar.StartupSounds.None;
            this.windowToolbar1.TabIndex = 0;
            this.windowToolbar1.TitleText = "Update";
            this.windowToolbar1.WindowBorderSize = ((byte)(3));
            // 
            // loadingControl1
            // 
            this.loadingControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.loadingControl1.ColorPalette = System.Drawing.Color.Crimson;
            this.loadingControl1.DarkTheme = true;
            this.loadingControl1.Interval = ((byte)(15));
            this.loadingControl1.Location = new System.Drawing.Point(36, 319);
            this.loadingControl1.Name = "loadingControl1";
            this.loadingControl1.Size = new System.Drawing.Size(680, 30);
            this.loadingControl1.Speed = ((byte)(15));
            this.loadingControl1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::LucaToysLite.Properties.Resources.icons8_success_96;
            this.pictureBox1.Location = new System.Drawing.Point(35, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 115);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vendor update completed successfully";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 116);
            this.label2.TabIndex = 9;
            this.label2.Text = "Update Login Manager";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Crimson;
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(3));
            this.roundedButton1.EnableBorder = false;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(609, 393);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(124, 40);
            this.roundedButton1.TabIndex = 7;
            this.roundedButton1.Text = "OK";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.loadingControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.windowToolbar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.WindowToolbar windowToolbar1;
        private Controls.LoadingControl loadingControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.RoundedButton roundedButton1;
    }
}