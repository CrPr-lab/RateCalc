using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace RateCalc
{
    class InputDataParser
    {
        public async Task ParseAsync(string dataFileName, DateTime fromDate, DateTime toDate)
        {
            await Task.Run(() => Parse(dataFileName, fromDate, toDate));
        }

        public void Parse(string dataFileName, DateTime fromDate, DateTime toDate)
        {           
            using (var excel = new ExcelQueryFactory(dataFileName))
            {
                Cargos = excel.Worksheet<Cargo>("Груз")
                    .ToList()
                    .Select(cargo =>
                    {
                        cargo.ArrivalDate = cargo.ArrivalDate.Date;
                        cargo.DepartureDate = cargo.DepartureDate == default ? DateTime.MaxValue.Date : cargo.DepartureDate.Date;
                        return cargo;
                    })
                    // выбираем грузы, пересекающиеся с выбранным диапазоном расчёта
                    .Where(cargo => !(cargo.ArrivalDate > toDate || cargo.DepartureDate < fromDate))
                    .ToList();

                Rates = excel.Worksheet<Rate>("Тариф").ToList();

                Rates.First().PeriodFrom = 1;
                Rates.Last().PeriodTo = short.MaxValue;
            }
        }

        public List<Cargo> Cargos { get; private set; }

        public List<Rate> Rates { get; private set; }
    }
}
