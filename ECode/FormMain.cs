using ECode.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ECode.Commons.FormHelper;

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

            //this.menuStrip1.ItemAdded += MenuStrip1_ItemAdded;
        }

        //private void MenuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        //{
        //    if (e.Item.Text.Length == 0 || e.Item.Text == "还原(&R)" || e.Item.Text == "最小化(&N)" || e.Item.Text == "关闭(&C)")
        //    {
        //        e.Item.Visible = false;
        //    }
        //}

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
    }
}
