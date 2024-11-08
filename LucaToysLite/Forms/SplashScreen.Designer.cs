namespace LucaToysLite.Forms
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lucaToysLogo1 = new LucaToysLite.Controls.LucaToysLogo();
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.lucaToysLogo1);
            this.panel1.Controls.Add(this.windowToolbar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 594);
            this.panel1.TabIndex = 0;
            // 
            // lucaToysLogo1
            // 
            this.lucaToysLogo1.BackColor = System.Drawing.Color.RoyalBlue;
            this.lucaToysLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lucaToysLogo1.BackgroundImage")));
            this.lucaToysLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lucaToysLogo1.Location = new System.Drawing.Point(336, 121);
            this.lucaToysLogo1.Name = "lucaToysLogo1";
            this.lucaToysLogo1.Radius = 100;
            this.lucaToysLogo1.Size = new System.Drawing.Size(207, 200);
            this.lucaToysLogo1.TabIndex = 1;
            // 
            // windowToolbar1
            // 
            this.windowToolbar1.BackColor = System.Drawing.Color.RoyalBlue;
            this.windowToolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowToolbar1.IconButton = true;
            this.windowToolbar1.Location = new System.Drawing.Point(0, 0);
            this.windowToolbar1.MaximizeButton = false;
            this.windowToolbar1.MinimizeButton = true;
            this.windowToolbar1.MoveOption = true;
            this.windowToolbar1.Name = "windowToolbar1";
            this.windowToolbar1.Size = new System.Drawing.Size(894, 45);
            this.windowToolbar1.TabIndex = 0;
            this.windowToolbar1.Window = this;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Controls.WindowToolbar windowToolbar1;
        private Controls.LucaToysLogo lucaToysLogo1;
    }
}