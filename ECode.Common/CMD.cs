using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECode.Commons
{
    public class CMD
    {
        /// <summary>
        /// 命令字符串
        /// </summary>
        public string CmdStr { get; set; }

        /// <summary>
        /// 执行命令的过程
        /// </summary>
        public string Res { get; set; }

        /// <summary>
        /// 错误信息,没有错误信息则为null
        /// </summary>
        public Exception Exception { get; set; }


        /// <summary>
        /// 调用cmd执行cmd命令
        /// </summary>
        /// <param name="cmd">命令信息对象</param>
        /// <returns>执行成功返回true,执行失败返回false</returns>

        /// <summary>
        /// 调用cmd执行cmd命令
        /// </summary>
        /// <param name="cmd">命令信息对象</param>
        /// <param name="action">执行</param>
        /// <returns>执行成功返回true,执行失败返回false</returns>
        public bool Exec(CMD cmd, Action<string> action = null)
        {
            var sb = new StringBuilder();
            try
            {
                var p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;        //是否使用操作系统shell启动  
                p.StartInfo.RedirectStandardInput = true;   //接受来自调用程序的输入信息  
                p.StartInfo.RedirectStandardOutput = true;  //由调用程序获取输出信息  
                p.StartInfo.RedirectStandardError = true;   //重定向标准错误输出  
                p.StartInfo.CreateNoWindow = true;          //不显示程序窗口  
                p.Start();//启动程序

                // 向cmd窗口写入命令  
                p.StandardInput.WriteLine(cmd.CmdStr);
                p.StandardInput.WriteLine("exit");
                //
                p.StandardInput.AutoFlush = true;

                // 读流
                var reader = p.StandardOutput;//截取输出流  
                var line = string.Empty;
                var startFlag = false;
                do
                {
                    line = reader.ReadLine();
                    // 过滤命令,如果存在执行命令则开始记录
                    if (!startFlag && line.Contains(cmd.CmdStr))
                    {
                        startFlag = true;
                        continue;
                    }
                    // 过滤命令,如果已经达到命令行并且读到的不是exit
                    if (startFlag && !line.EndsWith("exit"))
                    {
                        action?.Invoke($"{line}\r\n");
                        sb.AppendLine(line);
                    }
                } while (!reader.EndOfStream);
                p.Close();
                cmd.Res = sb.ToString();
                return true;
            }
            catch (Exception e)
            {
                cmd.Exception = e;
            }
            return false;
        }
    }
}
