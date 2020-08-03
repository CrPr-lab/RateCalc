using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCalc
{
    public class Rate
    {
        [ExcelColumn("№")]
        public int Number { get; set; }

        [ExcelColumn("Начало периода")]
        public int PeriodFrom { get; set; }

        [ExcelColumn("Окончание периода")]
        public int PeriodTo { get; set; }

        [ExcelColumn("Ставка")]
        public double Cost { get; set; }
    }
}
