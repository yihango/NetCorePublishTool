using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECode.Commons
{
    public static class FormHelper
    {
        static List<Form> FrmList { get; set; } = new List<Form>();

        /// <summary>
        /// 获得一个窗体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetForm<T>(this Form mdiParent)
            where T : Form, new()
        {
            var findRes = FindForm<T>();

            if (findRes == null)
            {
                findRes = CreateForm<T>();
                FrmList.Add(findRes);
            }
            findRes.WindowState = FormWindowState.Maximized;
            findRes.MdiParent = mdiParent;
            return findRes;
        }

        /// <summary>
        /// 释放窗体
        /// </summary>
        /// <param name="form"></param>
        public static void DisposeForm(Form form)
        {
            // 从集合中移除
            for (int i = 0; i < FrmList.Count; i++)
            {
                if (FrmList[i].Equals(form))
                {
                    FrmList.RemoveAt(i);
                    break;
                }
            }
            // 未释放则释放窗体
            if (!form.IsDisposed)
            {
                form.Dispose();
            }
        }

        public static void DisposeForm()
        {
            foreach (var item in FrmList)
            {
                if (!item.IsDisposed)
                {
                    item.Dispose();
                }
            }
            FrmList.Clear();
        }

        /// <summary>
        /// 创建新窗体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        static T CreateForm<T>()
            where T : new()
        {
            return new T();
        }

        /// <summary>
        /// 查找现有列表是否已存在此窗体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        static T FindForm<T>()
            where T : Form
        {

            for (int i = 0; i < FrmList.Count; i++)
            {
                if (!FrmList[i].IsDisposed)
                {
                    FrmList[i].WindowState = FormWindowState.Minimized;
                }
                else
                {
                    DisposeForm(FrmList[i]);
                    i -= 1;
                }
            }
            // 
            foreach (Form item in FrmList)
            {
                if (item is T)
                {
                    return (T)item;
                }
            }
            return default(T);
        }
    }
}
