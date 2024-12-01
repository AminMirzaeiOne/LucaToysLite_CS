namespace LucaToysLite.Widgets
{
    partial class ToDoList
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
            this.label1 = new System.Windows.Forms.Label();
            this.roundedLabel1 = new LucaToysLite.Controls.RoundedLabel();
            this.ltCheckBox1 = new LucaToysLite.Controls.LTCheckBox();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton4 = new LucaToysLite.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::LucaToysLite.Properties.Resources.icons8_to_do_list_48;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Manuscripts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.BackColor = System.Drawing.Color.Crimson;
            this.roundedLabel1.BorderRadius = ((byte)(4));
            this.roundedLabel1.Location = new System.Drawing.Point(3, 78);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(357, 4);
            this.roundedLabel1.TabIndex = 25;
            // 
            // ltCheckBox1
            // 
            this.ltCheckBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.ltCheckBox1.BorderSize = ((byte)(3));
            this.ltCheckBox1.Checked = true;
            this.ltCheckBox1.CheckedSymbol = "";
            this.ltCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ltCheckBox1.ColorPallet = System.Drawing.Color.Crimson;
            this.ltCheckBox1.FlatAppearance.BorderSize = 0;
            this.ltCheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.ltCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltCheckBox1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltCheckBox1.ForeColor = System.Drawing.Color.White;
            this.ltCheckBox1.Location = new System.Drawing.Point(300, 18);
            this.ltCheckBox1.Name = "ltCheckBox1";
            this.ltCheckBox1.Size = new System.Drawing.Size(45, 45);
            this.ltCheckBox1.TabIndex = 26;
            this.ltCheckBox1.Text = "";
            this.ltCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ltCheckBox1.UnCheckedSymbol = "";
            this.ltCheckBox1.UseVisualStyleBackColor = true;
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(3));
            this.roundedButton1.EnableBorder = true;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Image = global::LucaToysLite.Properties.Resources.icons8_settings_38;
            this.roundedButton1.Location = new System.Drawing.Point(289, 554);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(59, 60);
            this.roundedButton1.TabIndex = 27;
            this.roundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton1.UseVisualStyleBackColor = true;
            // 
            // roundedButton4
            // 
            this.roundedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton4.BorderRadius = ((byte)(20));
            this.roundedButton4.BorderSize = ((byte)(3));
            this.roundedButton4.EnableBorder = true;
            this.roundedButton4.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton4.ForeColor = System.Drawing.Color.White;
            this.roundedButton4.Image = global::LucaToysLite.Properties.Resources.icons8_plus_38;
            this.roundedButton4.Location = new System.Drawing.Point(9, 554);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(270, 60);
            this.roundedButton4.TabIndex = 27;
            this.roundedButton4.Text = " Add New Task";
            this.roundedButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton4.UseVisualStyleBackColor = true;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.roundedButton4);
            this.Controls.Add(this.ltCheckBox1);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ToDoList";
            this.Size = new System.Drawing.Size(360, 630);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.RoundedLabel roundedLabel1;
        private Controls.LTCheckBox ltCheckBox1;
        private Controls.RoundedButton roundedButton4;
        private Controls.RoundedButton roundedButton1;
    }
}
