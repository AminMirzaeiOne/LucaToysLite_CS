namespace LucaToysLite.Forms
{
    partial class Login
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
            this.roundedPanel4 = new LucaToysLite.Controls.RoundedPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roundedPanel1 = new LucaToysLite.Controls.RoundedPanel();
            this.roundedButton3 = new LucaToysLite.Controls.RoundedButton();
            this.roundedPanel2 = new LucaToysLite.Controls.RoundedPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.roundedButton4 = new LucaToysLite.Controls.RoundedButton();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
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
            this.windowToolbar1.MaximizeButton = false;
            this.windowToolbar1.MinimizeButton = true;
            this.windowToolbar1.MoveOption = true;
            this.windowToolbar1.Name = "windowToolbar1";
            this.windowToolbar1.Size = new System.Drawing.Size(530, 45);
            this.windowToolbar1.StartupSound = LucaToysLite.Controls.WindowToolbar.StartupSounds.None;
            this.windowToolbar1.TabIndex = 0;
            this.windowToolbar1.TitleText = "Login Manager";
            this.windowToolbar1.WindowBorderSize = ((byte)(3));
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel4.BorderSize = ((byte)(3));
            this.roundedPanel4.Controls.Add(this.textBox1);
            this.roundedPanel4.EnableBorder = true;
            this.roundedPanel4.Location = new System.Drawing.Point(86, 316);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(343, 54);
            this.roundedPanel4.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(14, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Username";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackgroundImage = global::LucaToysLite.Properties.Resources.icons8_manager_96;
            this.roundedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel1.BorderSize = ((byte)(3));
            this.roundedPanel1.EnableBorder = true;
            this.roundedPanel1.Location = new System.Drawing.Point(161, 75);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(200, 200);
            this.roundedPanel1.TabIndex = 2;
            // 
            // roundedButton3
            // 
            this.roundedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton3.BackColor = System.Drawing.Color.Crimson;
            this.roundedButton3.BorderRadius = ((byte)(20));
            this.roundedButton3.BorderSize = ((byte)(3));
            this.roundedButton3.EnableBorder = true;
            this.roundedButton3.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Location = new System.Drawing.Point(161, 482);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(178, 60);
            this.roundedButton3.TabIndex = 4;
            this.roundedButton3.Text = "Login";
            this.roundedButton3.UseVisualStyleBackColor = false;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel2.BorderSize = ((byte)(3));
            this.roundedPanel2.Controls.Add(this.textBox2);
            this.roundedPanel2.EnableBorder = true;
            this.roundedPanel2.Location = new System.Drawing.Point(86, 392);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(343, 54);
            this.roundedPanel2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(14, 9);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 38);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Password";
            // 
            // roundedButton4
            // 
            this.roundedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton4.BorderRadius = ((byte)(20));
            this.roundedButton4.BorderSize = ((byte)(3));
            this.roundedButton4.EnableBorder = true;
            this.roundedButton4.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton4.ForeColor = System.Drawing.Color.White;
            this.roundedButton4.Location = new System.Drawing.Point(161, 562);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(178, 60);
            this.roundedButton4.TabIndex = 5;
            this.roundedButton4.Text = "Problem";
            this.roundedButton4.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(530, 655);
            this.Controls.Add(this.roundedButton4);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.windowToolbar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.WindowToolbar windowToolbar1;
        private Controls.RoundedPanel roundedPanel4;
        private System.Windows.Forms.TextBox textBox1;
        private Controls.RoundedPanel roundedPanel1;
        private Controls.RoundedButton roundedButton3;
        private Controls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.TextBox textBox2;
        private Controls.RoundedButton roundedButton4;
    }
}