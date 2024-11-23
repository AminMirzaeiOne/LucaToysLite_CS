namespace LucaToysLite.Forms
{
    partial class SearchUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new LucaToysLite.Controls.RoundedPanel();
            this.ltComboBox1 = new LucaToysLite.Controls.LTComboBox();
            this.ltComboBox4 = new LucaToysLite.Controls.LTComboBox();
            this.ltComboBox3 = new LucaToysLite.Controls.LTComboBox();
            this.ltComboBox2 = new LucaToysLite.Controls.LTComboBox();
            this.roundedPanel5 = new LucaToysLite.Controls.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel6 = new LucaToysLite.Controls.RoundedPanel();
            this.roundedButton3 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton2 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.roundedPanel3 = new LucaToysLite.Controls.RoundedPanel();
            this.roundedPanel1 = new LucaToysLite.Controls.RoundedPanel();
            this.roundedPanel4 = new LucaToysLite.Controls.RoundedPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roundedButton5 = new LucaToysLite.Controls.RoundedButton();
            this.windowToolbar1 = new LucaToysLite.Controls.WindowToolbar();
            this.roundedButton4 = new LucaToysLite.Controls.RoundedButton();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = " Search Result";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(581, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = " Search Filter";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel2.BorderSize = ((byte)(3));
            this.roundedPanel2.Controls.Add(this.ltComboBox1);
            this.roundedPanel2.Controls.Add(this.ltComboBox4);
            this.roundedPanel2.Controls.Add(this.ltComboBox3);
            this.roundedPanel2.Controls.Add(this.ltComboBox2);
            this.roundedPanel2.EnableBorder = true;
            this.roundedPanel2.Location = new System.Drawing.Point(566, 69);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(789, 85);
            this.roundedPanel2.TabIndex = 4;
            // 
            // ltComboBox1
            // 
            this.ltComboBox1.BorderRadius = ((byte)(20));
            this.ltComboBox1.BorderSize = ((byte)(3));
            this.ltComboBox1.ColorPallet = System.Drawing.Color.Crimson;
            this.ltComboBox1.EnableBorder = true;
            this.ltComboBox1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.ltComboBox1.FlatAppearance.BorderSize = 0;
            this.ltComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltComboBox1.ForeColor = System.Drawing.Color.White;
            this.ltComboBox1.Items = new string[] {
        "Sellers",
        "Customers",
        "Sundrys"};
            this.ltComboBox1.ItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltComboBox1.ItemsCheckedColor = System.Drawing.Color.Crimson;
            this.ltComboBox1.ItemsFont = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ltComboBox1.ItemsForeColor = System.Drawing.Color.White;
            this.ltComboBox1.ItemsHeight = ((byte)(40));
            this.ltComboBox1.Location = new System.Drawing.Point(19, 21);
            this.ltComboBox1.Name = "ltComboBox1";
            this.ltComboBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ltComboBox1.Size = new System.Drawing.Size(175, 45);
            this.ltComboBox1.TabIndex = 1;
            this.ltComboBox1.Text = "User Type";
            this.ltComboBox1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ltComboBox1.TopDirection = false;
            this.ltComboBox1.UseVisualStyleBackColor = true;
            // 
            // ltComboBox4
            // 
            this.ltComboBox4.BorderRadius = ((byte)(20));
            this.ltComboBox4.BorderSize = ((byte)(3));
            this.ltComboBox4.ColorPallet = System.Drawing.Color.Crimson;
            this.ltComboBox4.EnableBorder = true;
            this.ltComboBox4.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.ltComboBox4.FlatAppearance.BorderSize = 0;
            this.ltComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltComboBox4.ForeColor = System.Drawing.Color.White;
            this.ltComboBox4.Items = new string[] {
        "Name",
        "Family",
        "Age",
        "Usercode",
        "Phone",
        "Address",
        "Account Number 1",
        "Account Number 2"};
            this.ltComboBox4.ItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltComboBox4.ItemsCheckedColor = System.Drawing.Color.Crimson;
            this.ltComboBox4.ItemsFont = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ltComboBox4.ItemsForeColor = System.Drawing.Color.White;
            this.ltComboBox4.ItemsHeight = ((byte)(40));
            this.ltComboBox4.Location = new System.Drawing.Point(592, 21);
            this.ltComboBox4.Name = "ltComboBox4";
            this.ltComboBox4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ltComboBox4.Size = new System.Drawing.Size(175, 45);
            this.ltComboBox4.TabIndex = 1;
            this.ltComboBox4.Text = "Search Based";
            this.ltComboBox4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ltComboBox4.TopDirection = false;
            this.ltComboBox4.UseVisualStyleBackColor = true;
            // 
            // ltComboBox3
            // 
            this.ltComboBox3.BorderRadius = ((byte)(20));
            this.ltComboBox3.BorderSize = ((byte)(3));
            this.ltComboBox3.ColorPallet = System.Drawing.Color.Crimson;
            this.ltComboBox3.EnableBorder = true;
            this.ltComboBox3.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.ltComboBox3.FlatAppearance.BorderSize = 0;
            this.ltComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltComboBox3.ForeColor = System.Drawing.Color.White;
            this.ltComboBox3.Items = new string[] {
        "Name",
        "Family",
        "Age",
        "Usercode",
        "Phone",
        "Address",
        "Account Number 1",
        "Account Number 2"};
            this.ltComboBox3.ItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltComboBox3.ItemsCheckedColor = System.Drawing.Color.Crimson;
            this.ltComboBox3.ItemsFont = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ltComboBox3.ItemsForeColor = System.Drawing.Color.White;
            this.ltComboBox3.ItemsHeight = ((byte)(40));
            this.ltComboBox3.Location = new System.Drawing.Point(401, 21);
            this.ltComboBox3.Name = "ltComboBox3";
            this.ltComboBox3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ltComboBox3.Size = new System.Drawing.Size(175, 45);
            this.ltComboBox3.TabIndex = 1;
            this.ltComboBox3.Text = "Search Based";
            this.ltComboBox3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ltComboBox3.TopDirection = false;
            this.ltComboBox3.UseVisualStyleBackColor = true;
            // 
            // ltComboBox2
            // 
            this.ltComboBox2.BorderRadius = ((byte)(20));
            this.ltComboBox2.BorderSize = ((byte)(3));
            this.ltComboBox2.ColorPallet = System.Drawing.Color.Crimson;
            this.ltComboBox2.EnableBorder = true;
            this.ltComboBox2.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.ltComboBox2.FlatAppearance.BorderSize = 0;
            this.ltComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltComboBox2.ForeColor = System.Drawing.Color.White;
            this.ltComboBox2.Items = new string[] {
        "Name",
        "Family",
        "Age",
        "Usercode",
        "Phone",
        "Address",
        "Account Number 1",
        "Account Number 2"};
            this.ltComboBox2.ItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltComboBox2.ItemsCheckedColor = System.Drawing.Color.Crimson;
            this.ltComboBox2.ItemsFont = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ltComboBox2.ItemsForeColor = System.Drawing.Color.White;
            this.ltComboBox2.ItemsHeight = ((byte)(40));
            this.ltComboBox2.Location = new System.Drawing.Point(211, 21);
            this.ltComboBox2.Name = "ltComboBox2";
            this.ltComboBox2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ltComboBox2.Size = new System.Drawing.Size(175, 45);
            this.ltComboBox2.TabIndex = 1;
            this.ltComboBox2.Text = "Search Based";
            this.ltComboBox2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ltComboBox2.TopDirection = false;
            this.ltComboBox2.UseVisualStyleBackColor = true;
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.roundedPanel5.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel5.BorderSize = ((byte)(3));
            this.roundedPanel5.Controls.Add(this.label3);
            this.roundedPanel5.Controls.Add(this.roundedPanel6);
            this.roundedPanel5.Controls.Add(this.roundedButton3);
            this.roundedPanel5.Controls.Add(this.roundedButton2);
            this.roundedPanel5.Controls.Add(this.roundedButton4);
            this.roundedPanel5.Controls.Add(this.roundedButton1);
            this.roundedPanel5.EnableBorder = true;
            this.roundedPanel5.Location = new System.Drawing.Point(941, 169);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(411, 650);
            this.roundedPanel5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name : Amin Mirzaei";
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.roundedPanel6.BackgroundImage = global::LucaToysLite.Properties.Resources.Group_19_1_;
            this.roundedPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPanel6.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel6.BorderSize = ((byte)(3));
            this.roundedPanel6.EnableBorder = true;
            this.roundedPanel6.Location = new System.Drawing.Point(27, 26);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(155, 155);
            this.roundedPanel6.TabIndex = 4;
            this.roundedPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel3_Paint);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BorderRadius = ((byte)(20));
            this.roundedButton3.BorderSize = ((byte)(3));
            this.roundedButton3.EnableBorder = true;
            this.roundedButton3.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Image = global::LucaToysLite.Properties.Resources.icons8_update_user_68;
            this.roundedButton3.Location = new System.Drawing.Point(21, 208);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(375, 90);
            this.roundedButton3.TabIndex = 0;
            this.roundedButton3.Text = "Update User";
            this.roundedButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton3.UseVisualStyleBackColor = true;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BorderRadius = ((byte)(20));
            this.roundedButton2.BorderSize = ((byte)(3));
            this.roundedButton2.EnableBorder = true;
            this.roundedButton2.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Image = global::LucaToysLite.Properties.Resources.icons8_about_me_68;
            this.roundedButton2.Location = new System.Drawing.Point(21, 320);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(375, 90);
            this.roundedButton2.TabIndex = 0;
            this.roundedButton2.Text = " User Inforamtion";
            this.roundedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton2.UseVisualStyleBackColor = true;
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
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Image = global::LucaToysLite.Properties.Resources.icons8_delete_user_group_woman_man_68;
            this.roundedButton1.Location = new System.Drawing.Point(21, 428);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(375, 90);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = " Delete User";
            this.roundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton1.UseVisualStyleBackColor = true;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.roundedPanel3.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel3.BorderSize = ((byte)(3));
            this.roundedPanel3.EnableBorder = true;
            this.roundedPanel3.Location = new System.Drawing.Point(25, 169);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(900, 650);
            this.roundedPanel3.TabIndex = 4;
            this.roundedPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel3_Paint);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel1.BorderSize = ((byte)(3));
            this.roundedPanel1.Controls.Add(this.roundedPanel4);
            this.roundedPanel1.Controls.Add(this.roundedButton5);
            this.roundedPanel1.EnableBorder = true;
            this.roundedPanel1.Location = new System.Drawing.Point(25, 69);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(523, 85);
            this.roundedPanel1.TabIndex = 4;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel4.BorderSize = ((byte)(3));
            this.roundedPanel4.Controls.Add(this.textBox1);
            this.roundedPanel4.EnableBorder = true;
            this.roundedPanel4.Location = new System.Drawing.Point(15, 22);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(342, 45);
            this.roundedPanel4.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(14, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search Customer";
            // 
            // roundedButton5
            // 
            this.roundedButton5.BorderRadius = ((byte)(20));
            this.roundedButton5.BorderSize = ((byte)(3));
            this.roundedButton5.EnableBorder = true;
            this.roundedButton5.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton5.FlatAppearance.BorderSize = 0;
            this.roundedButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton5.ForeColor = System.Drawing.Color.White;
            this.roundedButton5.Image = global::LucaToysLite.Properties.Resources.icons8_search_32;
            this.roundedButton5.Location = new System.Drawing.Point(369, 22);
            this.roundedButton5.Name = "roundedButton5";
            this.roundedButton5.Size = new System.Drawing.Size(130, 45);
            this.roundedButton5.TabIndex = 0;
            this.roundedButton5.Text = " Search";
            this.roundedButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton5.UseVisualStyleBackColor = true;
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
            this.windowToolbar1.MaximizeButton = true;
            this.windowToolbar1.MinimizeButton = true;
            this.windowToolbar1.MoveOption = true;
            this.windowToolbar1.Name = "windowToolbar1";
            this.windowToolbar1.Size = new System.Drawing.Size(1371, 45);
            this.windowToolbar1.StartupSound = LucaToysLite.Controls.WindowToolbar.StartupSounds.None;
            this.windowToolbar1.TabIndex = 0;
            this.windowToolbar1.TitleText = "Search User";
            this.windowToolbar1.WindowBorderSize = ((byte)(3));
            // 
            // roundedButton4
            // 
            this.roundedButton4.BorderRadius = ((byte)(20));
            this.roundedButton4.BorderSize = ((byte)(3));
            this.roundedButton4.EnableBorder = true;
            this.roundedButton4.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.roundedButton4.ForeColor = System.Drawing.Color.White;
            this.roundedButton4.Image = global::LucaToysLite.Properties.Resources.icons8_close_window_68;
            this.roundedButton4.Location = new System.Drawing.Point(21, 536);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(375, 90);
            this.roundedButton4.TabIndex = 0;
            this.roundedButton4.Text = " Close Window";
            this.roundedButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton4.UseVisualStyleBackColor = true;
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1371, 844);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.windowToolbar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchUser";
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.WindowToolbar windowToolbar1;
        private Controls.RoundedPanel roundedPanel1;
        private Controls.LTComboBox ltComboBox1;
        private Controls.RoundedPanel roundedPanel4;
        private System.Windows.Forms.TextBox textBox1;
        private Controls.RoundedButton roundedButton5;
        private Controls.RoundedPanel roundedPanel2;
        private Controls.LTComboBox ltComboBox2;
        private Controls.LTComboBox ltComboBox4;
        private Controls.LTComboBox ltComboBox3;
        private Controls.RoundedPanel roundedPanel3;
        private Controls.RoundedPanel roundedPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.RoundedButton roundedButton1;
        private Controls.RoundedButton roundedButton2;
        private Controls.RoundedButton roundedButton3;
        private Controls.RoundedPanel roundedPanel6;
        private System.Windows.Forms.Label label3;
        private Controls.RoundedButton roundedButton4;
    }
}