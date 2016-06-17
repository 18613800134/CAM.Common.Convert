
namespace CAM.Common.Convert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public static class DateTimeConvertor
    {
        /// <summary>
        /// 获取日期属于当年的第几周
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int GetWeekOfYear(this DateTime date)
        {
            GregorianCalendar gc = new GregorianCalendar();
            int weekOfYear = gc.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            return weekOfYear;
        }

        /// <summary>
        /// 获取日期属于当年的第几季度
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int GetQuarterOfYear(this DateTime date)
        {
            int quarter = (date.Month - 1) / 3 + 1;
            return quarter;
        }
    }

}
