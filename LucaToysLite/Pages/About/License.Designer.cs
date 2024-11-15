namespace LucaToysLite.Pages.About
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.roundedPanel1 = new LucaToysLite.Controls.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new LucaToysLite.Controls.RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.ltContextMenu1 = new LucaToysLite.Controls.LTContextMenu();
            this.copyLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.ltContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Crimson;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel1.BorderSize = ((byte)(0));
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Location = new System.Drawing.Point(25, 24);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(696, 115);
            this.roundedPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 79);
            this.label2.TabIndex = 0;
            this.label2.Text = "License : MIT + Maxelite LS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::LucaToysLite.Properties.Resources.icons8_license_48;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 79);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel2.BorderSize = ((byte)(3));
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Location = new System.Drawing.Point(25, 159);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(696, 340);
            this.roundedPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.ContextMenuStrip = this.ltContextMenu1;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(652, 292);
            this.label4.TabIndex = 0;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // ltContextMenu1
            // 
            this.ltContextMenu1.BorderSize = ((byte)(2));
            this.ltContextMenu1.ColorPallet = System.Drawing.Color.Crimson;
            this.ltContextMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ltContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyLicenseToolStripMenuItem,
            this.searchLicenseToolStripMenuItem});
            this.ltContextMenu1.Name = "ltContextMenu1";
            this.ltContextMenu1.Size = new System.Drawing.Size(198, 68);
            // 
            // copyLicenseToolStripMenuItem
            // 
            this.copyLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copyLicenseToolStripMenuItem.Name = "copyLicenseToolStripMenuItem";
            this.copyLicenseToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.copyLicenseToolStripMenuItem.Text = "Copy License";
            // 
            // searchLicenseToolStripMenuItem
            // 
            this.searchLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchLicenseToolStripMenuItem.Name = "searchLicenseToolStripMenuItem";
            this.searchLicenseToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.searchLicenseToolStripMenuItem.Text = "Search License";
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "License";
            this.Size = new System.Drawing.Size(753, 521);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.ltContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label4;
        private Controls.LTContextMenu ltContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem copyLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchLicenseToolStripMenuItem;
    }
}
