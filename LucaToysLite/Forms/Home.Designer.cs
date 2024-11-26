namespace LucaToysLite.Forms
{
    partial class Home
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
            this.homeMenu1 = new LucaToysLite.Menus.HomeMenu();
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.numberBox1 = new LucaToysLite.Controls.NumberBox();
            this.SuspendLayout();
            // 
            // homeMenu1
            // 
            this.homeMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.homeMenu1.BorderColor = System.Drawing.Color.Crimson;
            this.homeMenu1.BorderSize = ((byte)(2));
            this.homeMenu1.Location = new System.Drawing.Point(12, 52);
            this.homeMenu1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeMenu1.Name = "homeMenu1";
            this.homeMenu1.Size = new System.Drawing.Size(1066, 230);
            this.homeMenu1.TabIndex = 1;
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
            this.windowToolbar1.Size = new System.Drawing.Size(1090, 45);
            this.windowToolbar1.StartupSound = LucaToysLite.Controls.WindowToolbar.StartupSounds.None;
            this.windowToolbar1.TabIndex = 0;
            this.windowToolbar1.TitleText = "Window";
            this.windowToolbar1.WindowBorderSize = ((byte)(3));
            // 
            // numberBox1
            // 
            this.numberBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.numberBox1.BorderColor = System.Drawing.Color.Crimson;
            this.numberBox1.BorderSize = ((byte)(2));
            this.numberBox1.EnableBorder = true;
            this.numberBox1.Location = new System.Drawing.Point(426, 390);
            this.numberBox1.MaximumNumber = 1000;
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(210, 63);
            this.numberBox1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1090, 650);
            this.Controls.Add(this.numberBox1);
            this.Controls.Add(this.homeMenu1);
            this.Controls.Add(this.windowToolbar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.WindowToolbar windowToolbar1;
        private Menus.HomeMenu homeMenu1;
        private Controls.NumberBox numberBox1;
    }
}