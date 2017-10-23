using E.StringEx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERegex
{
    public partial class FormRegex : Form
    {
        const string regstr_cache_path = "./AppData/regcache/regstr.cache";
        const string source_cache_path = "./AppData/regcache/source.cache";

        string RegStr { get; set; } = string.Empty;


        public FormRegex()
        {
            InitializeComponent();

            BindEvent();


            var caches = ReadCache();
            txtRegStrs.Text = caches[0];
            txtSource.Text = caches[1];
        }

        void BindEvent()
        {
            this.btnExec.Click += BtnExec_Click;


            this.dgvResult.SelectionChanged += DgvResult_SelectionChanged;

            this.dgvResult.ReadOnly = true;
            this.dgvResult.MultiSelect = false;

            this.txtSelect.ReadOnly = true;
        }

        private void DgvResult_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResult.SelectedCells.Count > 0)
            {
                var val = string.Empty;


                var temp = dgvResult.SelectedCells[0];

                foreach (DataGridViewCell item in dgvResult.SelectedCells)
                {
                    if (item.Selected)
                    {
                        txtSelect.Text = item.Value.ToString();
                        break;
                    }
                }
            }
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            WriteCache();

            if (txtRegStrs.SelectedText.IsNull())
            {
                var strs = txtRegStrs.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if (strs != null && strs.Length > 0)
                {
                    RegStr = strs[0];
                }
            }
            else
            {
                RegStr = txtRegStrs.SelectedText;
            }
            if (RegStr.IsNull())
                return;

            GetResult(txtSource.Text, RegStr);
        }

        void GetResult(string source, string regStr)
        {
            var dt = new DataTable();

            var cols = new List<DataColumn>();
            DataRow row = null;
            var count = 0;

            MatchCollection mcs = null;

            try
            {
                mcs = Regex.Matches(source, regStr);

                if (mcs != null && mcs.Count > 0)
                {
                    if (mcs[0].Groups != null && mcs[0].Groups.Count > 0)
                    {
                        for (int i = 0; i < mcs[0].Groups.Count; i++)
                        {
                            cols.Add(new DataColumn(i.ToString()));
                        }
                    }

                    dt.Columns.AddRange(cols.ToArray());

                    foreach (Match mc in mcs)
                    {
                        if (mc.Groups != null && mc.Groups.Count > 0)
                        {
                            row = dt.NewRow();
                            for (int i = 0; i < mc.Groups.Count; i++)
                            {
                                row[i.ToString()] = mc.Groups[i].Value ?? string.Empty;
                            }
                            dt.Rows.Add(row);
                        }
                    }

                    count = mcs.Count;
                }

                dgvResult.DataSource = dt;
            }
            catch (Exception e)
            {
                txtSelect.Text = $"发生错误！错误信息:{e.Message}\r\n{e.ToString()}";
            }
            lblCount.Text = $"匹配到 {count} 条数据";
        }

        void WriteCache()
        {
            WriteFile(regstr_cache_path, txtRegStrs.Text);

            WriteFile(source_cache_path, txtSource.Text);
        }

        string[] ReadCache()
        {
            string[] caches = { string.Empty, string.Empty };


            caches[0] = ReadFile(regstr_cache_path);
            caches[1] = ReadFile(source_cache_path);


            return caches;
        }

        string ReadFile(string path)
        {
            try
            {
                var dir = Path.GetDirectoryName(path);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }


                using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    var buffer = new byte[1024 * 1024 * 1];
                    var stopFlag = fs.Read(buffer, 0, buffer.Length);
                    return Encoding.UTF8.GetString(buffer, 0, stopFlag);
                }
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }

        void WriteFile(string path, string content)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    var buffer = Encoding.UTF8.GetBytes(content ?? string.Empty);
                    fs.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception e)
            {

            }
        }
    }

}
