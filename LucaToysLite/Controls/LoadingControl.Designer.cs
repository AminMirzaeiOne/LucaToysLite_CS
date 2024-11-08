namespace LucaToysLite.Controls
{
    partial class LoadingControl
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
            this.roundedLabel1 = new LucaToysLite.Controls.RoundedLabel();
            this.SuspendLayout();
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundedLabel1.BorderRadius = ((byte)(20));
            this.roundedLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundedLabel1.Location = new System.Drawing.Point(0, 0);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(100, 30);
            this.roundedLabel1.TabIndex = 0;
            // 
            // LoadingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.roundedLabel1);
            this.Name = "LoadingControl";
            this.Size = new System.Drawing.Size(560, 30);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoadingControl_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedLabel roundedLabel1;
    }
}
