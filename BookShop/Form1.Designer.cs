namespace BookShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتگروهجدبدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتکتابجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تنظیماتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // تنظیماتToolStripMenuItem
            // 
            this.تنظیماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتگروهجدبدToolStripMenuItem,
            this.ثبتکتابجدیدToolStripMenuItem});
            this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.تنظیماتToolStripMenuItem.Text = "تنظیمات";
            // 
            // ثبتگروهجدبدToolStripMenuItem
            // 
            this.ثبتگروهجدبدToolStripMenuItem.Name = "ثبتگروهجدبدToolStripMenuItem";
            this.ثبتگروهجدبدToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ثبتگروهجدبدToolStripMenuItem.Text = "ثبت گروه جدید";
            this.ثبتگروهجدبدToolStripMenuItem.Click += new System.EventHandler(this.ثبتگروهجدبدToolStripMenuItem_Click);
            // 
            // ثبتکتابجدیدToolStripMenuItem
            // 
            this.ثبتکتابجدیدToolStripMenuItem.Name = "ثبتکتابجدیدToolStripMenuItem";
            this.ثبتکتابجدیدToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ثبتکتابجدیدToolStripMenuItem.Text = "ثبت کتاب جدید";
            this.ثبتکتابجدیدToolStripMenuItem.Click += new System.EventHandler(this.ثبتکتابجدیدToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "فروشگاه کتاب آراد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem تنظیماتToolStripMenuItem;
        private ToolStripMenuItem ثبتگروهجدبدToolStripMenuItem;
        private ToolStripMenuItem ثبتکتابجدیدToolStripMenuItem;
    }
}