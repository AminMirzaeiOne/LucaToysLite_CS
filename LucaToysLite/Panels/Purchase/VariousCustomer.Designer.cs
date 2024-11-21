namespace LucaToysLite.Panels.Purchase
{
    partial class VariousCustomer
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
            this.ltTextBox1 = new LucaToysLite.Controls.LTTextBox();
            this.roundedLabel1 = new LucaToysLite.Controls.RoundedLabel();
            this.ltTextBox2 = new LucaToysLite.Controls.LTTextBox();
            this.ltTextBox3 = new LucaToysLite.Controls.LTTextBox();
            this.SuspendLayout();
            // 
            // ltTextBox1
            // 
            this.ltTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltTextBox1.BorderSize = ((byte)(2));
            this.ltTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltTextBox1.ClearLocation = new System.Drawing.Point(0, 0);
            this.ltTextBox1.ClearSize = new System.Drawing.Size(75, 23);
            this.ltTextBox1.ColorPallet = System.Drawing.Color.Crimson;
            this.ltTextBox1.HolderColor = System.Drawing.Color.White;
            this.ltTextBox1.HolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltTextBox1.HolderLocation = new System.Drawing.Point(5, 8);
            this.ltTextBox1.HolderText = "Enter Name";
            this.ltTextBox1.Location = new System.Drawing.Point(73, 19);
            this.ltTextBox1.Multiline = true;
            this.ltTextBox1.Name = "ltTextBox1";
            this.ltTextBox1.Size = new System.Drawing.Size(143, 35);
            this.ltTextBox1.TabIndex = 22;
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.BorderRadius = ((byte)(20));
            this.roundedLabel1.Image = global::LucaToysLite.Properties.Resources.icons8_name_42;
            this.roundedLabel1.Location = new System.Drawing.Point(16, 14);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(42, 42);
            this.roundedLabel1.TabIndex = 21;
            // 
            // ltTextBox2
            // 
            this.ltTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltTextBox2.BorderSize = ((byte)(2));
            this.ltTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltTextBox2.ClearLocation = new System.Drawing.Point(0, 0);
            this.ltTextBox2.ClearSize = new System.Drawing.Size(75, 23);
            this.ltTextBox2.ColorPallet = System.Drawing.Color.Crimson;
            this.ltTextBox2.HolderColor = System.Drawing.Color.White;
            this.ltTextBox2.HolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltTextBox2.HolderLocation = new System.Drawing.Point(5, 8);
            this.ltTextBox2.HolderText = "Enter Family";
            this.ltTextBox2.Location = new System.Drawing.Point(240, 19);
            this.ltTextBox2.Multiline = true;
            this.ltTextBox2.Name = "ltTextBox2";
            this.ltTextBox2.Size = new System.Drawing.Size(150, 35);
            this.ltTextBox2.TabIndex = 22;
            // 
            // ltTextBox3
            // 
            this.ltTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltTextBox3.BorderSize = ((byte)(2));
            this.ltTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltTextBox3.ClearLocation = new System.Drawing.Point(0, 0);
            this.ltTextBox3.ClearSize = new System.Drawing.Size(75, 23);
            this.ltTextBox3.ColorPallet = System.Drawing.Color.Crimson;
            this.ltTextBox3.HolderColor = System.Drawing.Color.White;
            this.ltTextBox3.HolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltTextBox3.HolderLocation = new System.Drawing.Point(5, 8);
            this.ltTextBox3.HolderText = "Enter Phone";
            this.ltTextBox3.Location = new System.Drawing.Point(418, 19);
            this.ltTextBox3.Multiline = true;
            this.ltTextBox3.Name = "ltTextBox3";
            this.ltTextBox3.Size = new System.Drawing.Size(150, 35);
            this.ltTextBox3.TabIndex = 22;
            // 
            // VariousCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.ltTextBox3);
            this.Controls.Add(this.ltTextBox2);
            this.Controls.Add(this.ltTextBox1);
            this.Controls.Add(this.roundedLabel1);
            this.Name = "VariousCustomer";
            this.Size = new System.Drawing.Size(600, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.RoundedLabel roundedLabel1;
        private Controls.LTTextBox ltTextBox1;
        private Controls.LTTextBox ltTextBox2;
        private Controls.LTTextBox ltTextBox3;
    }
}
