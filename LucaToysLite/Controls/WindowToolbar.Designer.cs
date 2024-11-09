namespace LucaToysLite.Controls
{
    partial class WindowToolbar
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
            this.button4 = new System.Windows.Forms.Button();
            this.roundedButton3 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton2 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // roundedButton3
            // 
            this.roundedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton3.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundedButton3.BorderRadius = ((byte)(20));
            this.roundedButton3.BorderSize = ((byte)(0));
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F);
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Location = new System.Drawing.Point(457, 2);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(40, 40);
            this.roundedButton3.TabIndex = 4;
            this.roundedButton3.Text = "";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundedButton2.BorderRadius = ((byte)(20));
            this.roundedButton2.BorderSize = ((byte)(0));
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F);
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(503, 2);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(40, 40);
            this.roundedButton2.TabIndex = 4;
            this.roundedButton2.Text = "";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundedButton1.BorderRadius = ((byte)(20));
            this.roundedButton1.BorderSize = ((byte)(0));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(549, 2);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(40, 40);
            this.roundedButton1.TabIndex = 4;
            this.roundedButton1.Text = "";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WindowToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.button4);
            this.Name = "WindowToolbar";
            this.Size = new System.Drawing.Size(600, 45);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowToolbar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowToolbar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowToolbar_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
    }
}
