namespace LucaToysLite.Widgets
{
    partial class Clock
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
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.ctxOptions = new LucaToysLite.Controls.LTContextMenu();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x150ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "LTClock";
            this.Size = new System.Drawing.Size(200, 200);
            this.ResumeLayout(false);
            // 
            // tmrTick
            // 
            this.tmrTick.Enabled = true;
            this.tmrTick.Interval = 250;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // ctxOptions
            // 
            this.ctxOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.digitalToolStripMenuItem,
            this.keepOnTopToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.ctxOptions.Name = "contextMenuStrip1";
            this.ctxOptions.Size = new System.Drawing.Size(187, 138);
            // 
            // toolStripMenuItem1
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x100ToolStripMenuItem,
            this.x150ToolStripMenuItem,
            this.x200ToolStripMenuItem,});
            this.sizeToolStripMenuItem.Name = "toolStripMenuItem1";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.sizeToolStripMenuItem.Text = "&Size";
            // 
            // ctxSize100x100
            // 
            this.x100ToolStripMenuItem.Name = "ctxSize100x100";
            this.x100ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.x100ToolStripMenuItem.Tag = "";
            this.x100ToolStripMenuItem.Text = "&100x100";
            this.x100ToolStripMenuItem.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxSize150x150
            // 
            this.x150ToolStripMenuItem.Name = "ctxSize150x150";
            this.x150ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.x150ToolStripMenuItem.Tag = "";
            this.x150ToolStripMenuItem.Text = "1&50x150";
            this.x150ToolStripMenuItem.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxSize200x200
            // 
            this.x200ToolStripMenuItem.Checked = true;
            this.x200ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.x200ToolStripMenuItem.Name = "ctxSize200x200";
            this.x200ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.x200ToolStripMenuItem.Tag = "";
            this.x200ToolStripMenuItem.Text = "&200x200";
            this.x200ToolStripMenuItem.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxDigital
            // 
            this.digitalToolStripMenuItem.Name = "ctxDigital";
            this.digitalToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.digitalToolStripMenuItem.Text = "&Digital";
            this.digitalToolStripMenuItem.Click += new System.EventHandler(this.ctxDigital_Click);
            // 
            // ctxKeepOnTop
            // 
            this.keepOnTopToolStripMenuItem.Name = "ctxKeepOnTop";
            this.keepOnTopToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.keepOnTopToolStripMenuItem.Text = "&Keep On Top";
            this.keepOnTopToolStripMenuItem.Click += new System.EventHandler(this.ctxKeepOnTop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // ctxExit
            // 
            this.exitToolStripMenuItem.Name = "ctxExit";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ctxExit_Click);
            // 
            // LTClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LTClock";
            this.Size = new System.Drawing.Size(300, 308);
            this.Load += new System.EventHandler(this.LTClock_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LTClock_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LTClock_MouseDown);
            this.ctxOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.LTContextMenu ctxOptions;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x150ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x200ToolStripMenuItem;
    }
}
