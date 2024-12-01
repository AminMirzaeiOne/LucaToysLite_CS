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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manuscripts";
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
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.ltCheckBox1);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ToDoList";
            this.Size = new System.Drawing.Size(360, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.RoundedLabel roundedLabel1;
        private Controls.LTCheckBox ltCheckBox1;
    }
}
