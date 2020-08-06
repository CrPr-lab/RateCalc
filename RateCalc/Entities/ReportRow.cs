using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCalc
{
    public class ReportRow
    {
        [DisplayName("Груз")]
        public string CargoName { get; set; }

        [DisplayName("Дата прихода на склад")]
        public string ArrivalDate { get; set; }

        [DisplayName("Дата ухода со склада")]
        public string DepartureDate { get; set; }

        [DisplayName("Начало расчёта")]
        public DateTime BegCalc { get; set; }

        [DisplayName("Окончание расчёта")]
        public DateTime EndCalc { get; set; }

        [DisplayName("Кол-во дней хранения")]
        public int StoreDays { get; set; }

        [DisplayName("Ставка")]
        public double RateCost { get; set; }

        [DisplayName("Примечание")]
        public string Note { get; set; }
    }
}
