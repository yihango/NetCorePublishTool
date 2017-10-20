namespace ECode
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mdiMenuStrip = new System.Windows.Forms.MenuStrip();
            this.netCoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNCorePub = new System.Windows.Forms.ToolStripMenuItem();
            this.xamarinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeAndroidManifest = new System.Windows.Forms.ToolStripMenuItem();
            this.宇内流云ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToNavite = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdiMenuStrip
            // 
            this.mdiMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mdiMenuStrip.ImeMode = System.Windows.Forms.ImeMode.On;
            this.mdiMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.netCoreToolStripMenuItem,
            this.xamarinToolStripMenuItem,
            this.宇内流云ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.mdiMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mdiMenuStrip.Name = "mdiMenuStrip";
            this.mdiMenuStrip.Size = new System.Drawing.Size(801, 25);
            this.mdiMenuStrip.TabIndex = 2;
            this.mdiMenuStrip.Text = "menuStrip1";
            // 
            // netCoreToolStripMenuItem
            // 
            this.netCoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNCorePub});
            this.netCoreToolStripMenuItem.Name = "netCoreToolStripMenuItem";
            this.netCoreToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.netCoreToolStripMenuItem.Text = "Net Core";
            // 
            // btnNCorePub
            // 
            this.btnNCorePub.Name = "btnNCorePub";
            this.btnNCorePub.Size = new System.Drawing.Size(124, 22);
            this.btnNCorePub.Text = "发布工具";
            // 
            // xamarinToolStripMenuItem
            // 
            this.xamarinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeAndroidManifest});
            this.xamarinToolStripMenuItem.Name = "xamarinToolStripMenuItem";
            this.xamarinToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.xamarinToolStripMenuItem.Text = "Xamarin";
            // 
            // btnDeAndroidManifest
            // 
            this.btnDeAndroidManifest.Name = "btnDeAndroidManifest";
            this.btnDeAndroidManifest.Size = new System.Drawing.Size(233, 22);
            this.btnDeAndroidManifest.Text = "AndroidManifest反编译工具";
            // 
            // 宇内流云ToolStripMenuItem
            // 
            this.宇内流云ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToNavite});
            this.宇内流云ToolStripMenuItem.Name = "宇内流云ToolStripMenuItem";
            this.宇内流云ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.宇内流云ToolStripMenuItem.Text = "宇内流云";
            // 
            // btnToNavite
            // 
            this.btnToNavite.Name = "btnToNavite";
            this.btnToNavite.Size = new System.Drawing.Size(154, 22);
            this.btnToNavite.Text = "EXE ToNative";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(801, 427);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mdiMenuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.mdiMenuStrip.ResumeLayout(false);
            this.mdiMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mdiMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem netCoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNCorePub;
        private System.Windows.Forms.ToolStripMenuItem xamarinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDeAndroidManifest;
        private System.Windows.Forms.ToolStripMenuItem 宇内流云ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnToNavite;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}