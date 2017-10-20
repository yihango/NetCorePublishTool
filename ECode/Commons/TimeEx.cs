using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECode.Commons
{
    public static class TimeEx
    {
        public static string TimeNow()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:sss");
        }
    }
}
