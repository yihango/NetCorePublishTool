using E.StringEx;
using ECode.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static ECode.Commons.TimeEx;

namespace NetCorePublishTool
{
    public partial class FormNCorePub : Form
    {
        public FormNCorePub()
        {
            InitializeComponent();

            this.Load += FormMain_Load;

            this.btnSelectSourcePath.Click += BtnSelectSourcePath_Click;
            this.btnSelectOutPath.Click += BtnSelectOutPath_Click;
            this.btnPubNow.Click += BtnPubNow_Click;

            this.txtInPath.TextChanged += TxtInPath_TextChanged;

            this.linkDoc.LinkClicked += LinkDoc_LinkClicked;
            this.ckbRuntime.CheckedChanged += CkbRuntime_CheckedChanged;
            this.cmbRuntime.SelectedIndexChanged += CmbRuntime_SelectedIndexChanged;

            this.txtLog.TextChanged += TxtLog_TextChanged;
        }


        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.cmbPubMode.SelectedIndex = 0;

            var os = File.ReadAllLines(@".\AppData\netcorepub\os.txt");
            cmbRuntime.Items.AddRange(os);
        }



        bool isBtnSelectInPath = false;
        /// <summary>
        /// 选择项目文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectSourcePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "项目文件|*.csproj";
            ofd.Multiselect = false;
            ofd.Title = "选择.Net Core项目文件";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtInPath.Text = ofd.FileName;
                isBtnSelectInPath = true;

                cmbFrameworks.Items.Clear();
                var isSuccess = ReadTargetFramework(txtInPath.Text, out string[] targets);
                if (!isSuccess)
                {
                    MessageBox.Show("项目配置TargetFramework(s)不正确,请检查!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmbFrameworks.Items.AddRange(targets);
                cmbFrameworks.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 项目路径输入框改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtInPath_TextChanged(object sender, EventArgs e)
        {
            // 不是通过选择按钮执行的
            if (!isBtnSelectInPath)
            {
                // 如果是目录则检测目录下是否存在.csproj文件
                if (!txtInPath.Text.EndsWith(".csproj") && Directory.Exists(txtInPath.Text))
                {
                    var files = Directory.GetFiles(txtInPath.Text);
                    // 遍历检测
                    bool flag = false;
                    foreach (var item in files)
                    {
                        if (item.EndsWith(".csproj"))
                        {
                            flag = true;
                            txtOutPath.Focus();

                            if (txtInPath.Text.EndsWith("\\"))
                                txtInPath.Text = item;
                            else
                                txtInPath.Text = item;
                            break;
                        }
                    }

                    // 是否检测到项目文件
                    if (flag)
                    {
                        // 检测到项目文件则读取运行时配置
                        cmbFrameworks.Items.Clear();
                        var isSuccess = ReadTargetFramework(txtInPath.Text, out string[] targets);
                        if (!isSuccess)
                        {
                            MessageBox.Show("项目配置TargetFramework(s)不正确,请检查!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        cmbFrameworks.Items.AddRange(targets);
                        cmbFrameworks.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("未找到项目文件!请检查是否存在.csproj项目文件!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


                isBtnSelectInPath = false;
            }
        }


        /// <summary>
        /// 选择输出目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectOutPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtOutPath.Text = fbd.SelectedPath;
            }
        }


        /// <summary>
        /// 目标框架官方文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", linkDoc.Text);
        }

        /// <summary>
        /// 运行时启用框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CkbRuntime_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRuntime.Checked && cmbRuntime.SelectedIndex == -1)
            {
                cmbRuntime.SelectedIndex = 1;
            }
        }

        /// <summary>
        /// 运行时选择框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbRuntime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRuntime.SelectedIndex != -1)
            {
                if (cmbRuntime.SelectedItem.ToString().StartsWith("---"))
                {
                    cmbRuntime.SelectedIndex += 1;
                }
            }
        }

        /// <summary>
        /// 日志发生改变滑动到低端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtLog_TextChanged(object sender, EventArgs e)
        {
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }



        /// <summary>
        /// 立即发布
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPubNow_Click(object sender, EventArgs e)
        {
            #region 校验数据

            txtInPath.Text = txtInPath.Text.Trim();
            txtOutPath.Text = txtOutPath.Text.Trim();

            if (txtInPath.Text.IsNull()
                || txtOutPath.Text.IsNull())
            {
                MessageBox.Show("请选择项目文件和输出目录!", "提示");
                return;
            }

            if (cmbFrameworks.SelectedIndex < 0)
            {
                MessageBox.Show("请选择目标框架!", "提示");
                return;
            }

            if (!Directory.Exists(txtOutPath.Text))
            {
                Directory.CreateDirectory(txtOutPath.Text);
            }

            #endregion


            #region 拼接命令

            var sb = new StringBuilder();
            sb.Append("dotnet publish ");

            sb.Append("\"");
            sb.Append(txtInPath.Text);
            sb.Append("\"");

            sb.Append(" -c ");
            sb.Append(cmbPubMode.SelectedItem.ToString());

            if (ckbRuntime.Checked)
            {
                sb.Append(" -r ");
                sb.Append(cmbRuntime.SelectedItem.ToString());
            }

            sb.Append(" -f ");
            sb.Append(cmbFrameworks.SelectedItem.ToString());

            sb.Append(" -o ");
            sb.Append("\"");
            sb.Append(txtOutPath.Text);
            sb.Append("\"");



            #endregion


            var tmpCmd = sb.ToString();

            this.AppendText($"{TimeNow()}  正在执行:\r\n{tmpCmd}\r\n");

            var cmd = new CMD() { CmdStr = tmpCmd };

            Task.Factory.StartNew(() =>
            {
                if (cmd.Exec(cmd, str => this.AppendText(str)))
                {
                    this.AppendText("==================== 执行完成! ====================\r\n\r\n");
                }
                else
                {
                    this.AppendText($"{TimeNow()}  执行命令出错！错误信息:{cmd.Exception.Message}\r\n{cmd.Exception.ToString()}\r\n");
                    this.AppendText("==================== 执行命令出错! ====================\r\n\r\n");
                }
            });
        }

        private void AppendText(string str)
        {
            this.txtLog.Invoke(new Action<string>((par) =>
            {
                this.txtLog.AppendText(par);
            }), str);
        }



        /// <summary>
        /// 读取目标运行时
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="targets"></param>
        /// <returns></returns>
        public bool ReadTargetFramework(string xmlPath, out string[] targets)
        {
            targets = null;
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            var runTimeElement = (XmlElement)xmlDoc.SelectSingleNode("Project/PropertyGroup/TargetFramework");
            if (runTimeElement == null)
            {
                runTimeElement = (XmlElement)xmlDoc.SelectSingleNode("Project/PropertyGroup/TargetFrameworks");
            }

            if (runTimeElement != null)
            {
                var runtimes = runTimeElement.InnerText.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (runtimes != null || runtimes.Length >= 0)
                {
                    targets = runtimes;
                    return true;
                }
            }
            return false;
        }
    }
}
