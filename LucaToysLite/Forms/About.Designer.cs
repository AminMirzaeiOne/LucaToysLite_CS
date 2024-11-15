namespace LucaToysLite.Forms
{
    partial class About
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.roundedRadioButton5 = new LucaToysLite.Controls.RoundedRadioButton();
            this.roundedRadioButton4 = new LucaToysLite.Controls.RoundedRadioButton();
            this.roundedRadioButton3 = new LucaToysLite.Controls.RoundedRadioButton();
            this.roundedRadioButton2 = new LucaToysLite.Controls.RoundedRadioButton();
            this.roundedRadioButton1 = new LucaToysLite.Controls.RoundedRadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.roundedRadioButton5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.roundedRadioButton4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.roundedRadioButton3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.roundedRadioButton2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundedRadioButton1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 533);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(232, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 559);
            this.label1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(252, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 521);
            this.panel1.TabIndex = 3;
            // 
            // windowToolbar1
            // 
            this.windowToolbar1.BackColor = System.Drawing.Color.Crimson;
            this.windowToolbar1.BorderStyleRadius = true;
            this.windowToolbar1.CloseMessage = true;
            this.windowToolbar1.ColorPalette = System.Drawing.Color.Crimson;
            this.windowToolbar1.DarkTheme = true;
            this.windowToolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowToolbar1.IconButton = true;
            this.windowToolbar1.IconButtonImage = null;
            this.windowToolbar1.IconButtonSybmol = "";
            this.windowToolbar1.IconMenu = true;
            this.windowToolbar1.Location = new System.Drawing.Point(0, 0);
            this.windowToolbar1.MaximizeButton = false;
            this.windowToolbar1.MinimizeButton = true;
            this.windowToolbar1.MoveOption = true;
            this.windowToolbar1.Name = "windowToolbar1";
            this.windowToolbar1.Size = new System.Drawing.Size(1030, 45);
            this.windowToolbar1.StartupSound = LucaToysLite.Controls.WindowToolbar.StartupSounds.None;
            this.windowToolbar1.TabIndex = 0;
            this.windowToolbar1.TitleText = "About";
            this.windowToolbar1.WindowBorderSize = ((byte)(3));
            // 
            // roundedRadioButton5
            // 
            this.roundedRadioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.roundedRadioButton5.BorderSize = ((byte)(2));
            this.roundedRadioButton5.ColorPallet = System.Drawing.Color.Crimson;
            this.roundedRadioButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedRadioButton5.FlatAppearance.BorderSize = 0;
            this.roundedRadioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.roundedRadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRadioButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButton5.ForeColor = System.Drawing.Color.White;
            this.roundedRadioButton5.Image = global::LucaToysLite.Properties.Resources.icons8_comments_48;
            this.roundedRadioButton5.Location = new System.Drawing.Point(5, 429);
            this.roundedRadioButton5.Margin = new System.Windows.Forms.Padding(5);
            this.roundedRadioButton5.Name = "roundedRadioButton5";
            this.roundedRadioButton5.Size = new System.Drawing.Size(200, 99);
            this.roundedRadioButton5.TabIndex = 4;
            this.roundedRadioButton5.Text = "Feedback";
            this.roundedRadioButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roundedRadioButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roundedRadioButton5.UseVisualStyleBackColor = true;
            this.roundedRadioButton5.CheckedChanged += new System.EventHandler(this.roundedRadioButton5_CheckedChanged);
            // 
            // roundedRadioButton4
            // 
            this.roundedRadioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.roundedRadioButton4.BorderSize = ((byte)(2));
            this.roundedRadioButton4.ColorPallet = System.Drawing.Color.Crimson;
            this.roundedRadioButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedRadioButton4.FlatAppearance.BorderSize = 0;
            this.roundedRadioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.roundedRadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRadioButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButton4.ForeColor = System.Drawing.Color.White;
            this.roundedRadioButton4.Image = global::LucaToysLite.Properties.Resources.icons8_working_with_a_laptop_48;
            this.roundedRadioButton4.Location = new System.Drawing.Point(5, 323);
            this.roundedRadioButton4.Margin = new System.Windows.Forms.Padding(5);
            this.roundedRadioButton4.Name = "roundedRadioButton4";
            this.roundedRadioButton4.Size = new System.Drawing.Size(200, 96);
            this.roundedRadioButton4.TabIndex = 3;
            this.roundedRadioButton4.Text = "Developer";
            this.roundedRadioButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roundedRadioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roundedRadioButton4.UseVisualStyleBackColor = true;
            this.roundedRadioButton4.CheckedChanged += new System.EventHandler(this.roundedRadioButton4_CheckedChanged);
            // 
            // roundedRadioButton3
            // 
            this.roundedRadioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.roundedRadioButton3.BorderSize = ((byte)(2));
            this.roundedRadioButton3.ColorPallet = System.Drawing.Color.Crimson;
            this.roundedRadioButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedRadioButton3.FlatAppearance.BorderSize = 0;
            this.roundedRadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.roundedRadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRadioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButton3.ForeColor = System.Drawing.Color.White;
            this.roundedRadioButton3.Image = global::LucaToysLite.Properties.Resources.icons8_update_48_1_;
            this.roundedRadioButton3.Location = new System.Drawing.Point(5, 217);
            this.roundedRadioButton3.Margin = new System.Windows.Forms.Padding(5);
            this.roundedRadioButton3.Name = "roundedRadioButton3";
            this.roundedRadioButton3.Size = new System.Drawing.Size(200, 96);
            this.roundedRadioButton3.TabIndex = 2;
            this.roundedRadioButton3.Text = "Update";
            this.roundedRadioButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roundedRadioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roundedRadioButton3.UseVisualStyleBackColor = true;
            this.roundedRadioButton3.CheckedChanged += new System.EventHandler(this.roundedRadioButton3_CheckedChanged);
            // 
            // roundedRadioButton2
            // 
            this.roundedRadioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.roundedRadioButton2.BorderSize = ((byte)(2));
            this.roundedRadioButton2.ColorPallet = System.Drawing.Color.Crimson;
            this.roundedRadioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedRadioButton2.FlatAppearance.BorderSize = 0;
            this.roundedRadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.roundedRadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRadioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButton2.ForeColor = System.Drawing.Color.White;
            this.roundedRadioButton2.Image = global::LucaToysLite.Properties.Resources.icons8_software_license_48;
            this.roundedRadioButton2.Location = new System.Drawing.Point(5, 111);
            this.roundedRadioButton2.Margin = new System.Windows.Forms.Padding(5);
            this.roundedRadioButton2.Name = "roundedRadioButton2";
            this.roundedRadioButton2.Size = new System.Drawing.Size(200, 96);
            this.roundedRadioButton2.TabIndex = 1;
            this.roundedRadioButton2.Text = "License";
            this.roundedRadioButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roundedRadioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roundedRadioButton2.UseVisualStyleBackColor = true;
            this.roundedRadioButton2.CheckedChanged += new System.EventHandler(this.roundedRadioButton2_CheckedChanged);
            // 
            // roundedRadioButton1
            // 
            this.roundedRadioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.roundedRadioButton1.BorderSize = ((byte)(2));
            this.roundedRadioButton1.Checked = true;
            this.roundedRadioButton1.ColorPallet = System.Drawing.Color.Crimson;
            this.roundedRadioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedRadioButton1.FlatAppearance.BorderSize = 0;
            this.roundedRadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.roundedRadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRadioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButton1.ForeColor = System.Drawing.Color.White;
            this.roundedRadioButton1.Image = global::LucaToysLite.Properties.Resources.icons8_version_481;
            this.roundedRadioButton1.Location = new System.Drawing.Point(5, 5);
            this.roundedRadioButton1.Margin = new System.Windows.Forms.Padding(5);
            this.roundedRadioButton1.Name = "roundedRadioButton1";
            this.roundedRadioButton1.Size = new System.Drawing.Size(200, 96);
            this.roundedRadioButton1.TabIndex = 0;
            this.roundedRadioButton1.TabStop = true;
            this.roundedRadioButton1.Text = "Version";
            this.roundedRadioButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roundedRadioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roundedRadioButton1.UseVisualStyleBackColor = true;
            this.roundedRadioButton1.CheckedChanged += new System.EventHandler(this.roundedRadioButton1_CheckedChanged);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.windowToolbar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.Text = "About";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.WindowToolbar windowToolbar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.RoundedRadioButton roundedRadioButton1;
        private Controls.RoundedRadioButton roundedRadioButton4;
        private Controls.RoundedRadioButton roundedRadioButton3;
        private Controls.RoundedRadioButton roundedRadioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Controls.RoundedRadioButton roundedRadioButton5;
    }
}