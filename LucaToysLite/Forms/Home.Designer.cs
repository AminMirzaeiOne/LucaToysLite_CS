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
            this.ltTextBox1 = new LucaToysLite.Controls.LTTextBox();
            this.ltCheckBox1 = new LucaToysLite.Controls.LTCheckBox();
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.ltContextMenu1 = new LucaToysLite.Controls.LTContextMenu();
            this.microsoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.androidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ltContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltTextBox1
            // 
            this.ltTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ltTextBox1.BorderSize = ((byte)(2));
            this.ltTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltTextBox1.ClearLocation = new System.Drawing.Point(265, 5);
            this.ltTextBox1.ClearSize = new System.Drawing.Size(25, 25);
            this.ltTextBox1.ColorPallet = System.Drawing.Color.Crimson;
            this.ltTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltTextBox1.ForeColor = System.Drawing.Color.White;
            this.ltTextBox1.HolderColor = System.Drawing.Color.Gray;
            this.ltTextBox1.HolderFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltTextBox1.HolderLocation = new System.Drawing.Point(10, 5);
            this.ltTextBox1.HolderText = "Enter Text";
            this.ltTextBox1.Location = new System.Drawing.Point(613, 228);
            this.ltTextBox1.Multiline = true;
            this.ltTextBox1.Name = "ltTextBox1";
            this.ltTextBox1.Radius = 10;
            this.ltTextBox1.Size = new System.Drawing.Size(305, 38);
            this.ltTextBox1.TabIndex = 5;
            // 
            // ltCheckBox1
            // 
            this.ltCheckBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.ltCheckBox1.BorderSize = ((byte)(2));
            this.ltCheckBox1.ColorPallet = System.Drawing.Color.DarkGreen;
            this.ltCheckBox1.FlatAppearance.BorderSize = 0;
            this.ltCheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.ltCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltCheckBox1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltCheckBox1.ForeColor = System.Drawing.Color.White;
            this.ltCheckBox1.Location = new System.Drawing.Point(187, 367);
            this.ltCheckBox1.Name = "ltCheckBox1";
            this.ltCheckBox1.Radius = 10;
            this.ltCheckBox1.Size = new System.Drawing.Size(35, 33);
            this.ltCheckBox1.TabIndex = 4;
            this.ltCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ltCheckBox1.UseVisualStyleBackColor = true;
            // 
            // windowToolbar1
            // 
            this.windowToolbar1.BackColor = System.Drawing.Color.Crimson;
            this.windowToolbar1.BorderStyleRadius = true;
            this.windowToolbar1.ColorPalette = System.Drawing.Color.Crimson;
            this.windowToolbar1.DarkTheme = true;
            this.windowToolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowToolbar1.IconButton = true;
            this.windowToolbar1.Location = new System.Drawing.Point(0, 0);
            this.windowToolbar1.MaximizeButton = true;
            this.windowToolbar1.MinimizeButton = true;
            this.windowToolbar1.MoveOption = true;
            this.windowToolbar1.Name = "windowToolbar1";
            this.windowToolbar1.Size = new System.Drawing.Size(1090, 45);
            this.windowToolbar1.StartupSound = LucaToysLite.Controls.WindowToolbar.StartupSounds.None;
            this.windowToolbar1.TabIndex = 0;
            this.windowToolbar1.WindowBorderSize = ((byte)(3));
            // 
            // ltContextMenu1
            // 
            this.ltContextMenu1.BorderSize = ((byte)(2));
            this.ltContextMenu1.ColorPallet = System.Drawing.Color.Crimson;
            this.ltContextMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ltContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microsoftToolStripMenuItem,
            this.androidToolStripMenuItem,
            this.youbeToolStripMenuItem});
            this.ltContextMenu1.Name = "ltContextMenu1";
            this.ltContextMenu1.Size = new System.Drawing.Size(161, 100);
            // 
            // microsoftToolStripMenuItem
            // 
            this.microsoftToolStripMenuItem.Name = "microsoftToolStripMenuItem";
            this.microsoftToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.microsoftToolStripMenuItem.Text = "Microsoft";
            // 
            // androidToolStripMenuItem
            // 
            this.androidToolStripMenuItem.Name = "androidToolStripMenuItem";
            this.androidToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.androidToolStripMenuItem.Text = "Android";
            // 
            // youbeToolStripMenuItem
            // 
            this.youbeToolStripMenuItem.Name = "youbeToolStripMenuItem";
            this.youbeToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.youbeToolStripMenuItem.Text = "Yoube";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1090, 650);
            this.Controls.Add(this.ltTextBox1);
            this.Controls.Add(this.ltCheckBox1);
            this.Controls.Add(this.windowToolbar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ltContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.WindowToolbar windowToolbar1;
        private Controls.LTCheckBox ltCheckBox1;
        private Controls.LTTextBox ltTextBox1;
        private Controls.LTContextMenu ltContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem microsoftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem androidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youbeToolStripMenuItem;
    }
}