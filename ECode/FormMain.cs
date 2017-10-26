using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToNative;
using static ECode.Commons.FormHelper;

using DecompilationAndroidManifest;
using ERegex;
using NetCorePublishTool;

namespace ECode
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            EventBind();
        }

        void EventBind()
        {
            this.btnNetCorePub.Click += BtnNCorePub_Click;
            this.btnDeAndroidManifest.Click += BtnDeAndroidManifest_Click;
            this.btnToNative.Click += BtnToNavite_Click;
            this.btnRegexTool.Click += BtnRegexTool_Click;

            this.btnAbout.Click += BtnAbout_Click;

            this.menus.ItemAdded += Menus_ItemAdded; ;

            this.FormClosing += FormMain_FormClosing;
        }

        private void Menus_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            // 不显示子窗体最前面的icon
            if (e.Item.Text.Length == 0)
            {
                e.Item.Visible = false;
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("玩双截棍的熊猫自制及整合第三方工具的工具集\r\n若有侵权请联系邮箱:MSMADAOE@msn.com", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void BtnRegexTool_Click(object sender, EventArgs e)
        {
            this.GetForm<FormRegex>().Show();
        }


        private void BtnToNavite_Click(object sender, EventArgs e)
        {
            this.GetForm<FormToNative>().Show();
        }

        private void BtnDeAndroidManifest_Click(object sender, EventArgs e)
        {
            this.GetForm<FormDeAndroidManifest>().Show();
        }

        private void BtnNCorePub_Click(object sender, EventArgs e)
        {
            this.GetForm<FormNCorePub>().Show();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeForm();
        }
    }
}
