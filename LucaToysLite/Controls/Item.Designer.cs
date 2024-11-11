namespace LucaToysLite.Controls
{
    partial class Item
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
            this.roundedButton2 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // roundedButton2
            // 
            this.roundedButton2.BorderRadius = ((byte)(20));
            this.roundedButton2.BorderSize = ((byte)(0));
            this.roundedButton2.EnableBorder = false;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.roundedButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Bold);
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(20, 160);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(166, 30);
            this.roundedButton2.TabIndex = 0;
            this.roundedButton2.Text = "";
            this.roundedButton2.UseVisualStyleBackColor = true;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(0));
            this.roundedButton1.EnableBorder = false;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(20, 16);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(166, 130);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = "Accounting";
            this.roundedButton1.UseVisualStyleBackColor = true;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(207, 204);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
    }
}
