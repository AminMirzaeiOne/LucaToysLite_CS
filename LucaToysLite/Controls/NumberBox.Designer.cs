namespace LucaToysLite.Controls
{
    partial class NumberBox
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton2 = new LucaToysLite.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(8, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(3));
            this.roundedButton1.EnableBorder = true;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(178, 5);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(25, 25);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.Text = "";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.roundedButton2.BorderRadius = ((byte)(20));
            this.roundedButton2.BorderSize = ((byte)(3));
            this.roundedButton2.EnableBorder = true;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F, System.Drawing.FontStyle.Bold);
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(178, 34);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(25, 25);
            this.roundedButton2.TabIndex = 1;
            this.roundedButton2.Text = "";
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // NumberBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.textBox1);
            this.Name = "NumberBox";
            this.Size = new System.Drawing.Size(210, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
    }
}
