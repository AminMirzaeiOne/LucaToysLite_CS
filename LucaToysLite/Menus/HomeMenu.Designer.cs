namespace LucaToysLite.Menus
{
    partial class HomeMenu
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
            this.components = new System.ComponentModel.Container();
            WFAnimations.Animation animation1 = new WFAnimations.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.animator1 = new WFAnimations.Animator(this.components);
            this.roundedPanel1 = new LucaToysLite.Controls.RoundedPanel();
            this.radioUsers = new LucaToysLite.Controls.RoundedRadioButton();
            this.radioHelp = new LucaToysLite.Controls.RoundedRadioButton();
            this.radioWidgets = new LucaToysLite.Controls.RoundedRadioButton();
            this.radioApps = new LucaToysLite.Controls.RoundedRadioButton();
            this.radioSettings = new LucaToysLite.Controls.RoundedRadioButton();
            this.radioExport = new LucaToysLite.Controls.RoundedRadioButton();
            this.radioDocuments = new LucaToysLite.Controls.RoundedRadioButton();
            this.radioInvoice = new LucaToysLite.Controls.RoundedRadioButton();
            this.radioAccounting = new LucaToysLite.Controls.RoundedRadioButton();
            this.radioFinance = new LucaToysLite.Controls.RoundedRadioButton();
            this.radioProduct = new LucaToysLite.Controls.RoundedRadioButton();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.animator1.SetDecoration(this.panel1, WFAnimations.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(3, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1951, 140);
            this.panel1.TabIndex = 2;
            // 
            // animator1
            // 
            this.animator1.AnimationType = WFAnimations.AnimationType.Transparent;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation1;
            this.animator1.Upside = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.Crimson;
            this.roundedPanel1.BorderSize = ((byte)(0));
            this.roundedPanel1.Controls.Add(this.radioUsers);
            this.roundedPanel1.Controls.Add(this.radioHelp);
            this.roundedPanel1.Controls.Add(this.radioWidgets);
            this.roundedPanel1.Controls.Add(this.radioApps);
            this.roundedPanel1.Controls.Add(this.radioSettings);
            this.roundedPanel1.Controls.Add(this.radioExport);
            this.roundedPanel1.Controls.Add(this.radioDocuments);
            this.roundedPanel1.Controls.Add(this.radioInvoice);
            this.roundedPanel1.Controls.Add(this.radioAccounting);
            this.roundedPanel1.Controls.Add(this.radioFinance);
            this.roundedPanel1.Controls.Add(this.radioProduct);
            this.animator1.SetDecoration(this.roundedPanel1, WFAnimations.DecorationType.None);
            this.roundedPanel1.EnableBorder = false;
            this.roundedPanel1.Location = new System.Drawing.Point(3, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1951, 80);
            this.roundedPanel1.TabIndex = 1;
            // 
            // radioUsers
            // 
            this.radioUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioUsers.BorderSize = ((byte)(2));
            this.radioUsers.Checked = true;
            this.radioUsers.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioUsers, WFAnimations.DecorationType.None);
            this.radioUsers.EnableBorder = true;
            this.radioUsers.FlatAppearance.BorderSize = 0;
            this.radioUsers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUsers.ForeColor = System.Drawing.Color.White;
            this.radioUsers.Image = global::LucaToysLite.Properties.Resources.icons8_user_groups_34;
            this.radioUsers.Location = new System.Drawing.Point(14, 8);
            this.radioUsers.Name = "radioUsers";
            this.radioUsers.Size = new System.Drawing.Size(160, 64);
            this.radioUsers.TabIndex = 0;
            this.radioUsers.TabStop = true;
            this.radioUsers.Text = " Users";
            this.radioUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioUsers.UseVisualStyleBackColor = true;
            this.radioUsers.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioHelp
            // 
            this.radioHelp.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioHelp.BorderSize = ((byte)(2));
            this.radioHelp.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioHelp, WFAnimations.DecorationType.None);
            this.radioHelp.EnableBorder = true;
            this.radioHelp.FlatAppearance.BorderSize = 0;
            this.radioHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHelp.ForeColor = System.Drawing.Color.White;
            this.radioHelp.Image = global::LucaToysLite.Properties.Resources.icons8_help_34;
            this.radioHelp.Location = new System.Drawing.Point(1778, 8);
            this.radioHelp.Name = "radioHelp";
            this.radioHelp.Size = new System.Drawing.Size(160, 64);
            this.radioHelp.TabIndex = 0;
            this.radioHelp.Text = " Help";
            this.radioHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioHelp.UseVisualStyleBackColor = true;
            this.radioHelp.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioWidgets
            // 
            this.radioWidgets.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioWidgets.BorderSize = ((byte)(2));
            this.radioWidgets.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioWidgets, WFAnimations.DecorationType.None);
            this.radioWidgets.EnableBorder = true;
            this.radioWidgets.FlatAppearance.BorderSize = 0;
            this.radioWidgets.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioWidgets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioWidgets.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWidgets.ForeColor = System.Drawing.Color.White;
            this.radioWidgets.Image = global::LucaToysLite.Properties.Resources.icons8_widget_34;
            this.radioWidgets.Location = new System.Drawing.Point(1421, 8);
            this.radioWidgets.Name = "radioWidgets";
            this.radioWidgets.Size = new System.Drawing.Size(160, 64);
            this.radioWidgets.TabIndex = 0;
            this.radioWidgets.Text = " Widgets";
            this.radioWidgets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioWidgets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioWidgets.UseVisualStyleBackColor = true;
            this.radioWidgets.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioApps
            // 
            this.radioApps.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioApps.BorderSize = ((byte)(2));
            this.radioApps.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioApps, WFAnimations.DecorationType.None);
            this.radioApps.EnableBorder = true;
            this.radioApps.FlatAppearance.BorderSize = 0;
            this.radioApps.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioApps.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioApps.ForeColor = System.Drawing.Color.White;
            this.radioApps.Image = global::LucaToysLite.Properties.Resources.icons8_android_app_drawer_34;
            this.radioApps.Location = new System.Drawing.Point(1244, 8);
            this.radioApps.Name = "radioApps";
            this.radioApps.Size = new System.Drawing.Size(160, 64);
            this.radioApps.TabIndex = 0;
            this.radioApps.Text = "App Tools";
            this.radioApps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioApps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioApps.UseVisualStyleBackColor = true;
            this.radioApps.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioSettings
            // 
            this.radioSettings.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSettings.BorderSize = ((byte)(2));
            this.radioSettings.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioSettings, WFAnimations.DecorationType.None);
            this.radioSettings.EnableBorder = true;
            this.radioSettings.FlatAppearance.BorderSize = 0;
            this.radioSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSettings.ForeColor = System.Drawing.Color.White;
            this.radioSettings.Image = global::LucaToysLite.Properties.Resources.icons8_settings_34;
            this.radioSettings.Location = new System.Drawing.Point(1599, 8);
            this.radioSettings.Name = "radioSettings";
            this.radioSettings.Size = new System.Drawing.Size(160, 64);
            this.radioSettings.TabIndex = 0;
            this.radioSettings.Text = "Settings";
            this.radioSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioSettings.UseVisualStyleBackColor = true;
            this.radioSettings.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioExport
            // 
            this.radioExport.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioExport.BorderSize = ((byte)(2));
            this.radioExport.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioExport, WFAnimations.DecorationType.None);
            this.radioExport.EnableBorder = true;
            this.radioExport.FlatAppearance.BorderSize = 0;
            this.radioExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioExport.ForeColor = System.Drawing.Color.White;
            this.radioExport.Image = global::LucaToysLite.Properties.Resources.icons8_data_migration_34;
            this.radioExport.Location = new System.Drawing.Point(1067, 8);
            this.radioExport.Name = "radioExport";
            this.radioExport.Size = new System.Drawing.Size(160, 64);
            this.radioExport.TabIndex = 0;
            this.radioExport.Text = " Export Data";
            this.radioExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioExport.UseVisualStyleBackColor = true;
            this.radioExport.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioDocuments
            // 
            this.radioDocuments.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioDocuments.BorderSize = ((byte)(2));
            this.radioDocuments.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioDocuments, WFAnimations.DecorationType.None);
            this.radioDocuments.EnableBorder = true;
            this.radioDocuments.FlatAppearance.BorderSize = 0;
            this.radioDocuments.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDocuments.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDocuments.ForeColor = System.Drawing.Color.White;
            this.radioDocuments.Image = global::LucaToysLite.Properties.Resources.icons8_petition_34;
            this.radioDocuments.Location = new System.Drawing.Point(890, 8);
            this.radioDocuments.Name = "radioDocuments";
            this.radioDocuments.Size = new System.Drawing.Size(160, 64);
            this.radioDocuments.TabIndex = 0;
            this.radioDocuments.Text = " Documents";
            this.radioDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioDocuments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioDocuments.UseVisualStyleBackColor = true;
            this.radioDocuments.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioInvoice
            // 
            this.radioInvoice.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioInvoice.BorderSize = ((byte)(2));
            this.radioInvoice.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioInvoice, WFAnimations.DecorationType.None);
            this.radioInvoice.EnableBorder = true;
            this.radioInvoice.FlatAppearance.BorderSize = 0;
            this.radioInvoice.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInvoice.ForeColor = System.Drawing.Color.White;
            this.radioInvoice.Image = global::LucaToysLite.Properties.Resources.icons8_invoice_34;
            this.radioInvoice.Location = new System.Drawing.Point(713, 8);
            this.radioInvoice.Name = "radioInvoice";
            this.radioInvoice.Size = new System.Drawing.Size(160, 64);
            this.radioInvoice.TabIndex = 0;
            this.radioInvoice.Text = " Invoice";
            this.radioInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioInvoice.UseVisualStyleBackColor = true;
            this.radioInvoice.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioAccounting
            // 
            this.radioAccounting.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioAccounting.BorderSize = ((byte)(2));
            this.radioAccounting.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioAccounting, WFAnimations.DecorationType.None);
            this.radioAccounting.EnableBorder = true;
            this.radioAccounting.FlatAppearance.BorderSize = 0;
            this.radioAccounting.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioAccounting.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAccounting.ForeColor = System.Drawing.Color.White;
            this.radioAccounting.Image = global::LucaToysLite.Properties.Resources.icons8_accounting_34;
            this.radioAccounting.Location = new System.Drawing.Point(537, 8);
            this.radioAccounting.Name = "radioAccounting";
            this.radioAccounting.Size = new System.Drawing.Size(160, 64);
            this.radioAccounting.TabIndex = 0;
            this.radioAccounting.Text = " Accounting";
            this.radioAccounting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioAccounting.UseVisualStyleBackColor = true;
            this.radioAccounting.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioFinance
            // 
            this.radioFinance.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFinance.BorderSize = ((byte)(2));
            this.radioFinance.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioFinance, WFAnimations.DecorationType.None);
            this.radioFinance.EnableBorder = true;
            this.radioFinance.FlatAppearance.BorderSize = 0;
            this.radioFinance.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioFinance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFinance.ForeColor = System.Drawing.Color.White;
            this.radioFinance.Image = global::LucaToysLite.Properties.Resources.icons8_stock_share_34;
            this.radioFinance.Location = new System.Drawing.Point(362, 8);
            this.radioFinance.Name = "radioFinance";
            this.radioFinance.Size = new System.Drawing.Size(160, 64);
            this.radioFinance.TabIndex = 0;
            this.radioFinance.Text = " Finance";
            this.radioFinance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioFinance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioFinance.UseVisualStyleBackColor = true;
            this.radioFinance.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioProduct
            // 
            this.radioProduct.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioProduct.BorderSize = ((byte)(2));
            this.radioProduct.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.radioProduct, WFAnimations.DecorationType.None);
            this.radioProduct.EnableBorder = true;
            this.radioProduct.FlatAppearance.BorderSize = 0;
            this.radioProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radioProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioProduct.ForeColor = System.Drawing.Color.White;
            this.radioProduct.Image = global::LucaToysLite.Properties.Resources.icons8_code_blocks_34;
            this.radioProduct.Location = new System.Drawing.Point(188, 8);
            this.radioProduct.Name = "radioProduct";
            this.radioProduct.Size = new System.Drawing.Size(160, 64);
            this.radioProduct.TabIndex = 0;
            this.radioProduct.Text = " Products";
            this.radioProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioProduct.UseVisualStyleBackColor = true;
            this.radioProduct.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundedPanel1);
            this.animator1.SetDecoration(this, WFAnimations.DecorationType.None);
            this.Name = "HomeMenu";
            this.Size = new System.Drawing.Size(1957, 230);
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.RoundedRadioButton radioUsers;
        private Controls.RoundedRadioButton radioProduct;
        private Controls.RoundedPanel roundedPanel1;
        private Controls.RoundedRadioButton radioFinance;
        private Controls.RoundedRadioButton radioAccounting;
        private Controls.RoundedRadioButton radioInvoice;
        private Controls.RoundedRadioButton radioDocuments;
        private Controls.RoundedRadioButton radioExport;
        private Controls.RoundedRadioButton radioSettings;
        private Controls.RoundedRadioButton radioApps;
        private System.Windows.Forms.Panel panel1;
        private WFAnimations.Animator animator1;
        private Controls.RoundedRadioButton radioWidgets;
        private Controls.RoundedRadioButton radioHelp;
    }
}
