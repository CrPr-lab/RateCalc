using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCalc
{
    public class Cargo
    {
        [ExcelColumn("Груз")]
        public string Name { get; set; }

        [ExcelColumn("Дата прихода на склад")]
        public DateTime ArrivalDate { get; set; }

        [ExcelColumn("Дата ухода со склада")]
        public DateTime DepartureDate { get; set; }
    }
}
