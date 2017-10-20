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
            this.btnNCorePub.Click += BtnNCorePub_Click;
            this.btnDeAndroidManifest.Click += BtnDeAndroidManifest_Click;
            this.btnToNavite.Click += BtnToNavite_Click;
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
    }
}
