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
            this.button1 = new System.Windows.Forms.Button();
            this.roundedLabel1 = new LucaToysLite.Controls.RoundedLabel();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.loadingControl1 = new LucaToysLite.Controls.LoadingControl();
            this.lucaToysLogo1 = new LucaToysLite.Controls.LucaToysLogo();
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Version : 1.0.0";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundedLabel1.BorderRadius = ((byte)(30));
            this.roundedLabel1.ForeColor = System.Drawing.Color.White;
            this.roundedLabel1.Location = new System.Drawing.Point(477, 465);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(163, 65);
            this.roundedLabel1.TabIndex = 12;
            this.roundedLabel1.Text = "roundedLabel1";
            this.roundedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderRadius = ((byte)(30));
            this.roundedButton1.BorderSize = ((byte)(3));
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(251, 461);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(200, 73);
            this.roundedButton1.TabIndex = 11;
            this.roundedButton1.Text = "roundedButton1";
            this.roundedButton1.UseVisualStyleBackColor = true;
            // 
            // loadingControl1
            // 
            this.loadingControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.loadingControl1.Location = new System.Drawing.Point(160, 340);
            this.loadingControl1.Name = "loadingControl1";
            this.loadingControl1.Size = new System.Drawing.Size(560, 30);
            this.loadingControl1.TabIndex = 10;
            // 
            // lucaToysLogo1
            // 
            this.lucaToysLogo1.BackColor = System.Drawing.Color.RoyalBlue;
            this.lucaToysLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lucaToysLogo1.BackgroundImage")));
            this.lucaToysLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lucaToysLogo1.Location = new System.Drawing.Point(342, 104);
            this.lucaToysLogo1.Name = "lucaToysLogo1";
            this.lucaToysLogo1.Radius = 100;
            this.lucaToysLogo1.Size = new System.Drawing.Size(200, 200);
            this.lucaToysLogo1.TabIndex = 8;
            // 
            // windowToolbar1
            // 
            this.windowToolbar1.BackColor = System.Drawing.Color.RoyalBlue;
            this.windowToolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowToolbar1.IconButton = true;
            this.windowToolbar1.Location = new System.Drawing.Point(0, 0);
            this.windowToolbar1.MaximizeButton = true;
            this.windowToolbar1.MinimizeButton = true;
            this.windowToolbar1.MoveOption = true;
            this.windowToolbar1.Name = "windowToolbar1";
            this.windowToolbar1.Size = new System.Drawing.Size(900, 45);
            this.windowToolbar1.TabIndex = 7;
            this.windowToolbar1.Window = this;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.loadingControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lucaToysLogo1);
            this.Controls.Add(this.windowToolbar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SplashScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedLabel roundedLabel1;
        private Controls.RoundedButton roundedButton1;
        private Controls.LoadingControl loadingControl1;
        private System.Windows.Forms.Button button1;
        private Controls.LucaToysLogo lucaToysLogo1;
        private Controls.WindowToolbar windowToolbar1;
    }
}