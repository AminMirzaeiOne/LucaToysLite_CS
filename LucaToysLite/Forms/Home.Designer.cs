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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homeBottomMenu1 = new LucaToysLite.Menus.HomeBottomMenu();
            this.homeMenu1 = new LucaToysLite.Menus.HomeMenu();
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(444, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change Background Image";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(386, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "";
            // 
            // homeBottomMenu1
            // 
            this.homeBottomMenu1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.homeBottomMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.homeBottomMenu1.BorderColor = System.Drawing.Color.Crimson;
            this.homeBottomMenu1.BorderSize = ((byte)(3));
            this.homeBottomMenu1.EnableBorder = true;
            this.homeBottomMenu1.Location = new System.Drawing.Point(438, 657);
            this.homeBottomMenu1.Name = "homeBottomMenu1";
            this.homeBottomMenu1.Size = new System.Drawing.Size(590, 70);
            this.homeBottomMenu1.TabIndex = 3;
            // 
            // homeMenu1
            // 
            this.homeMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.homeMenu1.BorderColor = System.Drawing.Color.Crimson;
            this.homeMenu1.BorderSize = ((byte)(3));
            this.homeMenu1.Location = new System.Drawing.Point(12, 52);
            this.homeMenu1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeMenu1.Name = "homeMenu1";
            this.homeMenu1.Size = new System.Drawing.Size(1427, 230);
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
            this.windowToolbar1.Size = new System.Drawing.Size(1451, 45);
            this.windowToolbar1.StartupSound = LucaToysLite.Controls.WindowToolbar.StartupSounds.None;
            this.windowToolbar1.TabIndex = 0;
            this.windowToolbar1.TitleText = "Home Window";
            this.windowToolbar1.WindowBorderSize = ((byte)(3));
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1451, 751);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homeBottomMenu1);
            this.Controls.Add(this.homeMenu1);
            this.Controls.Add(this.windowToolbar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.WindowToolbar windowToolbar1;
        private Menus.HomeMenu homeMenu1;
        private Menus.HomeBottomMenu homeBottomMenu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}