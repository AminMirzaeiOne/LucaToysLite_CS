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
            this.item3 = new LucaToysLite.Controls.Item();
            this.item2 = new LucaToysLite.Controls.Item();
            this.item1 = new LucaToysLite.Controls.Item();
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // item3
            // 
            this.item3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.item3.ColorPalette = System.Drawing.Color.Crimson;
            this.item3.DarkTheme = true;
            this.item3.Location = new System.Drawing.Point(708, 356);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(207, 204);
            this.item3.TabIndex = 3;
            // 
            // item2
            // 
            this.item2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.item2.ColorPalette = System.Drawing.Color.Crimson;
            this.item2.DarkTheme = true;
            this.item2.Location = new System.Drawing.Point(747, 96);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(207, 204);
            this.item2.TabIndex = 2;
            // 
            // item1
            // 
            this.item1.BackColor = System.Drawing.Color.Crimson;
            this.item1.ColorPalette = System.Drawing.Color.Crimson;
            this.item1.DarkTheme = true;
            this.item1.Location = new System.Drawing.Point(309, 150);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(207, 204);
            this.item1.TabIndex = 1;
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
            // roundedButton1
            // 
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(0));
            this.roundedButton1.EnableBorder = false;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(128, 428);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(274, 149);
            this.roundedButton1.TabIndex = 4;
            this.roundedButton1.Text = "wefwf";
            this.roundedButton1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1090, 650);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.item3);
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
        private Controls.Item item3;
        private Controls.RoundedButton roundedButton1;
    }
}