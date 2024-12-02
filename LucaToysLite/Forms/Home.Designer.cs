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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.homeMenu1 = new LucaToysLite.Menus.HomeMenu();
            this.ltContextMenu1 = new LucaToysLite.Controls.LTContextMenu();
            this.hideLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.homeBottomMenu1 = new LucaToysLite.Menus.HomeBottomMenu();
            this.ltContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerHide
            // 
            this.timerHide.Interval = 20;
            this.timerHide.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerShow
            // 
            this.timerShow.Interval = 20;
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton1.BackColor = System.Drawing.Color.Crimson;
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(3));
            this.roundedButton1.EnableBorder = true;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 5F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(698, 717);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(80, 40);
            this.roundedButton1.TabIndex = 2;
            this.roundedButton1.Text = "  ";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // homeMenu1
            // 
            this.homeMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.homeMenu1.BorderColor = System.Drawing.Color.Crimson;
            this.homeMenu1.BorderSize = ((byte)(3));
            this.homeMenu1.ContextMenuStrip = this.ltContextMenu1;
            this.homeMenu1.LargeSub = true;
            this.homeMenu1.Location = new System.Drawing.Point(12, 52);
            this.homeMenu1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeMenu1.Name = "homeMenu1";
            this.homeMenu1.Size = new System.Drawing.Size(1427, 230);
            this.homeMenu1.TabIndex = 1;
            // 
            // ltContextMenu1
            // 
            this.ltContextMenu1.Background = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ltContextMenu1.BorderSize = ((byte)(2));
            this.ltContextMenu1.ColorPallet = System.Drawing.Color.Crimson;
            this.ltContextMenu1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltContextMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ltContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideLargeToolStripMenuItem});
            this.ltContextMenu1.Name = "ltContextMenu1";
            this.ltContextMenu1.Size = new System.Drawing.Size(179, 38);
            // 
            // hideLargeToolStripMenuItem
            // 
            this.hideLargeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hideLargeToolStripMenuItem.Name = "hideLargeToolStripMenuItem";
            this.hideLargeToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.hideLargeToolStripMenuItem.Text = "Hide Large";
            this.hideLargeToolStripMenuItem.Click += new System.EventHandler(this.hideLargeToolStripMenuItem_Click);
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
            // homeBottomMenu1
            // 
            this.homeBottomMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeBottomMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.homeBottomMenu1.BorderColor = System.Drawing.Color.Crimson;
            this.homeBottomMenu1.BorderSize = ((byte)(3));
            this.homeBottomMenu1.EnableBorder = true;
            this.homeBottomMenu1.Location = new System.Drawing.Point(350, 756);
            this.homeBottomMenu1.Name = "homeBottomMenu1";
            this.homeBottomMenu1.Size = new System.Drawing.Size(800, 70);
            this.homeBottomMenu1.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1451, 751);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.homeMenu1);
            this.Controls.Add(this.windowToolbar1);
            this.Controls.Add(this.homeBottomMenu1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ltContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.WindowToolbar windowToolbar1;
        private Menus.HomeMenu homeMenu1;
        private Controls.RoundedButton roundedButton1;
        private System.Windows.Forms.Timer timerHide;
        private Menus.HomeBottomMenu homeBottomMenu1;
        private System.Windows.Forms.Timer timerShow;
        private Controls.LTContextMenu ltContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem hideLargeToolStripMenuItem;
    }
}