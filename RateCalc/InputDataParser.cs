using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace RateCalc
{
    public class InputDataParser
    {
        public InputDataParser(string dataFileName, DateTime fromDate, DateTime toDate)
        {
            using (var excel = new ExcelQueryFactory(dataFileName))
            {
                try
                {
                    Cargos = excel.Worksheet<Cargo>("Груз")
                    .ToList()
                    .Select(cargo =>
                    {
                        cargo.ArrivalDate = cargo.ArrivalDate.Date;
                        cargo.DepartureDate = cargo.DepartureDate.Date;
                        return cargo;
                    })
                    // выбираем грузы, у которых дата прибытия попадает в выбранный диапазон
                    .Where(cargo => !(cargo.ArrivalDate > toDate || cargo.DepartureDate < fromDate))

                    .Where(c => c.Name == "B")
                    .ToList();

                    Rates = excel.Worksheet<Rate>("Тариф").ToList();
      
                    Rates.First().PeriodFrom = 1;
                    Rates.Last().PeriodTo = short.MaxValue;
                }
                catch (Exception E)
                {
                    MessageBox.Show($"При чтении данных произошла ошибка: {E.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }                                 
        }

        public List<Cargo> Cargos { get; }

        public List<Rate> Rates { get; }
    }
}
