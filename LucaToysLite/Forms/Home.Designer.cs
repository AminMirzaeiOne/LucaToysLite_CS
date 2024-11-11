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
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.item1 = new LucaToysLite.Controls.Item();
            this.item2 = new LucaToysLite.Controls.Item();
            this.roundedPanel1 = new LucaToysLite.Controls.RoundedPanel();
            this.SuspendLayout();
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
            // item1
            // 
            this.item1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.item1.ColorPalette = System.Drawing.Color.Crimson;
            this.item1.DarkTheme = true;
            this.item1.Location = new System.Drawing.Point(514, 138);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(207, 204);
            this.item1.TabIndex = 1;
            this.item1.TitleText = "Accounting";
            // 
            // item2
            // 
            this.item2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.item2.ColorPalette = System.Drawing.Color.Crimson;
            this.item2.DarkTheme = true;
            this.item2.Location = new System.Drawing.Point(253, 138);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(207, 204);
            this.item2.TabIndex = 1;
            this.item2.TitleText = "Accounting";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Location = new System.Drawing.Point(823, 242);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(200, 318);
            this.roundedPanel1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1090, 650);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.windowToolbar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.WindowToolbar windowToolbar1;
        private Controls.Item item1;
        private Controls.Item item2;
        private Controls.RoundedPanel roundedPanel1;
    }
}