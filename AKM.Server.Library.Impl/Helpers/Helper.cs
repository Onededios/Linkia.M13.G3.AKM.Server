using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Library.Impl.Helpers
{
    public class Helper
    {
        private static readonly string lastAvailableDate = "9999/12/31";

        public static DateTime parseDate(string dateString)
        {
            return DateTime.Parse(dateString ?? lastAvailableDate).ToUniversalTime();
        }
    }
}
