using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecompilationAndroidManifest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();


            txtShow.AllowDrop = true;
            txtShow.DragDrop += TxtShow_DragDrop;
            txtShow.DragEnter += TxtShow_DragEnter;

            this.WindowState = FormWindowState.Maximized;
        }

        private void TxtShow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;                                                              //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
        }

        private void TxtShow_DragDrop(object sender, DragEventArgs e)
        {
            var path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

            if (!string.IsNullOrWhiteSpace(path))
            {
                var cmdTxt = $@"java -jar .\jars\AXMLPrinter2.jar {path}";

                txtShow.Text = RunCmd(cmdTxt);
            }
        }

        /// <summary>
        /// cmd执行命令
        /// </summary>
        /// <param name="cmdTxt">命令</param>
        private string RunCmd(string cmdTxt)
        {
            var sb = new StringBuilder();

            using (Process p = new Process())
            {
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;        //是否使用操作系统shell启动  
                p.StartInfo.RedirectStandardInput = true;   //接受来自调用程序的输入信息  
                p.StartInfo.RedirectStandardOutput = true;  //由调用程序获取输出信息  
                p.StartInfo.RedirectStandardError = true;   //重定向标准错误输出  
                p.StartInfo.CreateNoWindow = true;          //不显示程序窗口  
                p.Start();//启动程序  
                //向cmd窗口写入命令  
                p.StandardInput.WriteLine(cmdTxt);
                p.StandardInput.AutoFlush = true;
                //获取cmd窗口的输出信息  
                var reader = p.StandardOutput;//截取输出流  
                string line = reader.ReadLine();//每次读取一行  
                sb.AppendLine(line);
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    sb.AppendLine(line);

                    if (line.Contains("</manifest>"))
                    {
                        break;
                    }
                }
                // </manifest>
                p.Close();
            }

            return sb.ToString();
        }
    }
}
