namespace LucaToysLite.Panels.Purchase
{
    partial class FixedCustomer
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
            this.label14 = new System.Windows.Forms.Label();
            this.roundedButton10 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.roundedLabel1 = new LucaToysLite.Controls.RoundedLabel();
            this.roundedLabel2 = new LucaToysLite.Controls.RoundedLabel();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(56, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 30);
            this.label14.TabIndex = 20;
            this.label14.Text = "Amin Mirzaei";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedButton10
            // 
            this.roundedButton10.BorderRadius = ((byte)(20));
            this.roundedButton10.BorderSize = ((byte)(3));
            this.roundedButton10.EnableBorder = true;
            this.roundedButton10.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton10.FlatAppearance.BorderSize = 0;
            this.roundedButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.roundedButton10.ForeColor = System.Drawing.Color.White;
            this.roundedButton10.Location = new System.Drawing.Point(201, 12);
            this.roundedButton10.Name = "roundedButton10";
            this.roundedButton10.Size = new System.Drawing.Size(160, 45);
            this.roundedButton10.TabIndex = 21;
            this.roundedButton10.Text = "Select Customer";
            this.roundedButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roundedButton10.UseVisualStyleBackColor = true;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(3));
            this.roundedButton1.EnableBorder = true;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(376, 12);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(160, 45);
            this.roundedButton1.TabIndex = 21;
            this.roundedButton1.Text = "Add Customer";
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roundedButton1.UseVisualStyleBackColor = true;
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.BorderRadius = ((byte)(20));
            this.roundedLabel1.Image = global::LucaToysLite.Properties.Resources.icons8_test_account_42;
            this.roundedLabel1.Location = new System.Drawing.Point(7, 13);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(42, 42);
            this.roundedLabel1.TabIndex = 19;
            // 
            // roundedLabel2
            // 
            this.roundedLabel2.BackColor = System.Drawing.Color.Crimson;
            this.roundedLabel2.BorderRadius = ((byte)(20));
            this.roundedLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel2.ForeColor = System.Drawing.Color.White;
            this.roundedLabel2.Location = new System.Drawing.Point(549, 16);
            this.roundedLabel2.Name = "roundedLabel2";
            this.roundedLabel2.Size = new System.Drawing.Size(40, 40);
            this.roundedLabel2.TabIndex = 22;
            this.roundedLabel2.Text = "12";
            this.roundedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FixedCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.roundedLabel2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.roundedButton10);
            this.Name = "FixedCustomer";
            this.Size = new System.Drawing.Size(600, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private Controls.RoundedLabel roundedLabel1;
        private Controls.RoundedButton roundedButton10;
        private Controls.RoundedButton roundedButton1;
        private Controls.RoundedLabel roundedLabel2;
    }
}
