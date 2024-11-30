namespace LucaToysLite.Menus
{
    partial class Salesman
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
            this.roundedButton7 = new LucaToysLite.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // roundedButton7
            // 
            this.roundedButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundedButton7.BorderRadius = ((byte)(20));
            this.roundedButton7.BorderSize = ((byte)(3));
            this.roundedButton7.EnableBorder = true;
            this.roundedButton7.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton7.FlatAppearance.BorderSize = 0;
            this.roundedButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton7.ForeColor = System.Drawing.Color.White;
            this.roundedButton7.Image = global::LucaToysLite.Properties.Resources.Group_12;
            this.roundedButton7.Location = new System.Drawing.Point(10, 6);
            this.roundedButton7.Name = "roundedButton7";
            this.roundedButton7.Size = new System.Drawing.Size(200, 125);
            this.roundedButton7.TabIndex = 18;
            this.roundedButton7.Text = "Help Home";
            this.roundedButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roundedButton7.UseVisualStyleBackColor = false;
            // 
            // Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.roundedButton7);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Salesman";
            this.Size = new System.Drawing.Size(1843, 140);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedButton roundedButton7;
    }
}
