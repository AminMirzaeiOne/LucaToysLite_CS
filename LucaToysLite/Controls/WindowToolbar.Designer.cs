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
            this.components = new System.ComponentModel.Container();
            WFAnimations.Animation animation1 = new WFAnimations.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowToolbar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.animator1 = new WFAnimations.Animator(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedButton4 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton3 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton1 = new LucaToysLite.Controls.RoundedButton();
            this.roundedButton2 = new LucaToysLite.Controls.RoundedButton();
            this.ltContextMenu1 = new LucaToysLite.Controls.LTContextMenu();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.ltContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.roundedButton3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.roundedButton1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.roundedButton2, 1, 0);
            this.animator1.SetDecoration(this.tableLayoutPanel1, WFAnimations.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(436, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(160, 45);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label1, WFAnimations.DecorationType.None);
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(596, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(4, 45);
            this.label1.TabIndex = 6;
            // 
            // animator1
            // 
            this.animator1.AnimationType = WFAnimations.AnimationType.Scale;
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
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            this.animator1.Upside = false;
            // 
            // label2
            // 
            this.animator1.SetDecoration(this.label2, WFAnimations.DecorationType.None);
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Window";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label3, WFAnimations.DecorationType.None);
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(4, 45);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label4, WFAnimations.DecorationType.None);
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(49, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(4, 45);
            this.label4.TabIndex = 11;
            // 
            // roundedButton4
            // 
            this.roundedButton4.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundedButton4.BorderRadius = ((byte)(25));
            this.roundedButton4.BorderSize = ((byte)(0));
            this.animator1.SetDecoration(this.roundedButton4, WFAnimations.DecorationType.None);
            this.roundedButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundedButton4.EnableBorder = true;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8F);
            this.roundedButton4.ForeColor = System.Drawing.Color.White;
            this.roundedButton4.Location = new System.Drawing.Point(4, 0);
            this.roundedButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(45, 45);
            this.roundedButton4.TabIndex = 8;
            this.roundedButton4.Text = "";
            this.roundedButton4.UseVisualStyleBackColor = false;
            this.roundedButton4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedButton4_MouseDown);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundedButton3.BorderRadius = ((byte)(25));
            this.roundedButton3.BorderSize = ((byte)(0));
            this.animator1.SetDecoration(this.roundedButton3, WFAnimations.DecorationType.None);
            this.roundedButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedButton3.EnableBorder = true;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F);
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Location = new System.Drawing.Point(4, 3);
            this.roundedButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(45, 39);
            this.roundedButton3.TabIndex = 4;
            this.roundedButton3.Text = "";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundedButton1.BorderRadius = ((byte)(25));
            this.roundedButton1.BorderSize = ((byte)(0));
            this.animator1.SetDecoration(this.roundedButton1, WFAnimations.DecorationType.None);
            this.roundedButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedButton1.EnableBorder = true;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(110, 3);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(46, 39);
            this.roundedButton1.TabIndex = 4;
            this.roundedButton1.Text = "";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundedButton2.BorderRadius = ((byte)(25));
            this.roundedButton2.BorderSize = ((byte)(0));
            this.animator1.SetDecoration(this.roundedButton2, WFAnimations.DecorationType.None);
            this.roundedButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedButton2.EnableBorder = true;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F);
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(57, 3);
            this.roundedButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(45, 39);
            this.roundedButton2.TabIndex = 4;
            this.roundedButton2.Text = "";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ltContextMenu1
            // 
            this.ltContextMenu1.BorderSize = ((byte)(2));
            this.ltContextMenu1.ColorPallet = System.Drawing.Color.Crimson;
            this.animator1.SetDecoration(this.ltContextMenu1, WFAnimations.DecorationType.None);
            this.ltContextMenu1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltContextMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ltContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.toolStripSeparator1,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitAppToolStripMenuItem,
            this.restartAppToolStripMenuItem});
            this.ltContextMenu1.Name = "ltContextMenu1";
            this.ltContextMenu1.Size = new System.Drawing.Size(199, 268);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.maximizeToolStripMenuItem.Text = "Maximize";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.exitAppToolStripMenuItem.Text = "Exit App";
            // 
            // restartAppToolStripMenuItem
            // 
            this.restartAppToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.restartAppToolStripMenuItem.Name = "restartAppToolStripMenuItem";
            this.restartAppToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.restartAppToolStripMenuItem.Text = "Restart App";
            // 
            // WindowToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roundedButton4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.animator1.SetDecoration(this, WFAnimations.DecorationType.None);
            this.Name = "WindowToolbar";
            this.Size = new System.Drawing.Size(600, 45);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowToolbar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowToolbar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowToolbar_MouseUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ltContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private RoundedButton roundedButton4;
        private WFAnimations.Animator animator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private LTContextMenu ltContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartAppToolStripMenuItem;
    }
}
