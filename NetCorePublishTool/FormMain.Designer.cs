namespace NetCorePublishTool
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnSelectSourcePath = new System.Windows.Forms.Button();
            this.txtInPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPubMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutPath = new System.Windows.Forms.TextBox();
            this.btnSelectOutPath = new System.Windows.Forms.Button();
            this.cmbRuntime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ckbRuntime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCmd = new System.Windows.Forms.RichTextBox();
            this.btnPubNow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkDoc = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectSourcePath
            // 
            this.btnSelectSourcePath.Location = new System.Drawing.Point(500, 23);
            this.btnSelectSourcePath.Name = "btnSelectSourcePath";
            this.btnSelectSourcePath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSourcePath.TabIndex = 0;
            this.btnSelectSourcePath.Text = "选择";
            this.btnSelectSourcePath.UseVisualStyleBackColor = true;
            // 
            // txtInPath
            // 
            this.txtInPath.Location = new System.Drawing.Point(13, 25);
            this.txtInPath.Name = "txtInPath";
            this.txtInPath.Size = new System.Drawing.Size(481, 21);
            this.txtInPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "项目目录(.csproj文件,输入目录将检测是否存在项目文件)";
            // 
            // cmbPubMode
            // 
            this.cmbPubMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPubMode.FormattingEnabled = true;
            this.cmbPubMode.Items.AddRange(new object[] {
            "Release",
            "Debug"});
            this.cmbPubMode.Location = new System.Drawing.Point(13, 113);
            this.cmbPubMode.Name = "cmbPubMode";
            this.cmbPubMode.Size = new System.Drawing.Size(121, 20);
            this.cmbPubMode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "发布路径";
            // 
            // txtOutPath
            // 
            this.txtOutPath.Location = new System.Drawing.Point(13, 69);
            this.txtOutPath.Name = "txtOutPath";
            this.txtOutPath.Size = new System.Drawing.Size(481, 21);
            this.txtOutPath.TabIndex = 8;
            // 
            // btnSelectOutPath
            // 
            this.btnSelectOutPath.Location = new System.Drawing.Point(500, 69);
            this.btnSelectOutPath.Name = "btnSelectOutPath";
            this.btnSelectOutPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOutPath.TabIndex = 7;
            this.btnSelectOutPath.Text = "选择";
            this.btnSelectOutPath.UseVisualStyleBackColor = true;
            // 
            // cmbRuntime
            // 
            this.cmbRuntime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuntime.FormattingEnabled = true;
            this.cmbRuntime.Location = new System.Drawing.Point(140, 113);
            this.cmbRuntime.Name = "cmbRuntime";
            this.cmbRuntime.Size = new System.Drawing.Size(152, 20);
            this.cmbRuntime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "目标框架(暂时无效)";
            this.label5.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(299, 113);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.Visible = false;
            // 
            // ckbRuntime
            // 
            this.ckbRuntime.AutoSize = true;
            this.ckbRuntime.Location = new System.Drawing.Point(141, 94);
            this.ckbRuntime.Name = "ckbRuntime";
            this.ckbRuntime.Size = new System.Drawing.Size(84, 16);
            this.ckbRuntime.TabIndex = 14;
            this.ckbRuntime.Text = "发布运行时";
            this.ckbRuntime.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "发布模式";
            // 
            // txtCmd
            // 
            this.txtCmd.Location = new System.Drawing.Point(95, 171);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.ReadOnly = true;
            this.txtCmd.Size = new System.Drawing.Size(490, 67);
            this.txtCmd.TabIndex = 17;
            this.txtCmd.Text = "";
            // 
            // btnPubNow
            // 
            this.btnPubNow.Location = new System.Drawing.Point(13, 171);
            this.btnPubNow.Name = "btnPubNow";
            this.btnPubNow.Size = new System.Drawing.Size(75, 67);
            this.btnPubNow.TabIndex = 18;
            this.btnPubNow.Text = "立即发布";
            this.btnPubNow.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "注:目标框架需要配置项目文件,详情查看:";
            // 
            // linkDoc
            // 
            this.linkDoc.AutoSize = true;
            this.linkDoc.Location = new System.Drawing.Point(14, 156);
            this.linkDoc.Name = "linkDoc";
            this.linkDoc.Size = new System.Drawing.Size(359, 12);
            this.linkDoc.TabIndex = 20;
            this.linkDoc.TabStop = true;
            this.linkDoc.Text = "https://docs.microsoft.com/en-us/dotnet/standard/frameworks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "注:工具只负责拼接发布命令,所有执行操作均为.NetCore SDK,目前只支持2.x版本";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 271);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPubNow);
            this.Controls.Add(this.txtCmd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbRuntime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cmbRuntime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutPath);
            this.Controls.Add(this.btnSelectOutPath);
            this.Controls.Add(this.cmbPubMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInPath);
            this.Controls.Add(this.btnSelectSourcePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(613, 310);
            this.MinimumSize = new System.Drawing.Size(613, 310);
            this.Name = "FormMain";
            this.Text = "NETCorePublishTools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectSourcePath;
        private System.Windows.Forms.TextBox txtInPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPubMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutPath;
        private System.Windows.Forms.Button btnSelectOutPath;
        private System.Windows.Forms.ComboBox cmbRuntime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox ckbRuntime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtCmd;
        private System.Windows.Forms.Button btnPubNow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkDoc;
        private System.Windows.Forms.Label label6;
    }
}

