using ECode.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecompilationAndroidManifest
{
    public partial class FormDeAndroidManifest : Form
    {
        public FormDeAndroidManifest()
        {
            InitializeComponent();

            txtShow.AllowDrop = true;
            txtShow.DragDrop += TxtShow_DragDrop;
            txtShow.DragEnter += TxtShow_DragEnter;
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
                var cmd = new CMD() { CmdStr = $@"java -jar .\AppData\jars\AXMLPrinter2.jar {path}" };

                Task.Factory.StartNew(() =>
                {
                    if (cmd.Exec(cmd, null))
                    {
                        this.SetText(cmd.Res);
                    }
                    else
                    {
                        this.SetText($"发生错误,错误信息:{cmd.Exception.Message}\r\n{cmd.Exception.ToString()}");
                    }
                });
            }
        }
        private void SetText(string str)
        {
            this.txtShow.Invoke(new Action<string>((par) =>
            {
                this.txtShow.Text = par;
            }), str);
        }
    }
}