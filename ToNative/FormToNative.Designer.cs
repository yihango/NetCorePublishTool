namespace ToNative
{
    partial class FormToNative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToNative));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.btnSelectSourcePath = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.txtOutPutAppName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectOutPutPath = new System.Windows.Forms.Button();
            this.txtOutPutPath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "源程序全路径:";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(102, 12);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(447, 21);
            this.txtSourcePath.TabIndex = 1;
            // 
            // btnSelectSourcePath
            // 
            this.btnSelectSourcePath.Location = new System.Drawing.Point(555, 11);
            this.btnSelectSourcePath.Name = "btnSelectSourcePath";
            this.btnSelectSourcePath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSourcePath.TabIndex = 2;
            this.btnSelectSourcePath.Text = "选择";
            this.btnSelectSourcePath.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbMode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnExec);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.txtOutPutAppName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSelectOutPutPath);
            this.panel1.Controls.Add(this.txtOutPutPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSelectSourcePath);
            this.panel1.Controls.Add(this.txtSourcePath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 127);
            this.panel1.TabIndex = 3;
            // 
            // cmbMode
            // 
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "default        默认生成x64控制台程序",
            "winform      生成Windows窗体程序",
            "win7 x86     生成支持32位 Win7 以上系统的程序",
            "winXP x86   生成支持32位 Win XP 以上系统的程序",
            "linux           生成Linux程序  --  暂未支持"});
            this.cmbMode.Location = new System.Drawing.Point(102, 96);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(447, 20);
            this.cmbMode.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "生成程序模式:";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(555, 94);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 9;
            this.btnExec.Text = "Native";
            this.btnExec.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "输出程序名称:";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(555, 66);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // txtOutPutAppName
            // 
            this.txtOutPutAppName.Location = new System.Drawing.Point(102, 67);
            this.txtOutPutAppName.Name = "txtOutPutAppName";
            this.txtOutPutAppName.Size = new System.Drawing.Size(447, 21);
            this.txtOutPutAppName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出程序路径:";
            // 
            // btnSelectOutPutPath
            // 
            this.btnSelectOutPutPath.Location = new System.Drawing.Point(555, 38);
            this.btnSelectOutPutPath.Name = "btnSelectOutPutPath";
            this.btnSelectOutPutPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOutPutPath.TabIndex = 5;
            this.btnSelectOutPutPath.Text = "选择";
            this.btnSelectOutPutPath.UseVisualStyleBackColor = true;
            // 
            // txtOutPutPath
            // 
            this.txtOutPutPath.Location = new System.Drawing.Point(102, 39);
            this.txtOutPutPath.Name = "txtOutPutPath";
            this.txtOutPutPath.Size = new System.Drawing.Size(447, 21);
            this.txtOutPutPath.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 321);
            this.panel2.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(652, 321);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // FormToNative
            // 
            this.ClientSize = new System.Drawing.Size(652, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormToNative";
            this.Text = "EXE ToNative   by.宇内流云(源)  玩双截棍的熊猫(窗体整合)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Button btnSelectSourcePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TextBox txtOutPutAppName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectOutPutPath;
        private System.Windows.Forms.TextBox txtOutPutPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}