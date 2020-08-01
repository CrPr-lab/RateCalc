using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using Microsoft.Office.Interop.Excel;

namespace RateCalc
{
    public class InputDataParser
    {
        public InputDataParser(string dataFileName, DateTime fromDate, DateTime toDate)
        {

            using (var excel = new ExcelQueryFactory(dataFileName))
            {

                Cargos = excel.Worksheet<Cargo>("Груз")
                    //.Where(cargo => cargo.ArrivalDate >= fromDate && cargo.ArrivalDate <= toDate)
                    //.Where(cargo => cargo.Name.Length == 3)
                    .ToList()
                    .Where(cargo => cargo.ArrivalDate >= fromDate && cargo.ArrivalDate <= toDate)
                    .ToList();

                //var Cargos2 = excel.Worksheet("Груз")
                //    .Where(row => row["Дата прихода на склад"].Cast<DateTime>() >= fromDate && row["Дата прихода на склад"].Cast<DateTime>() <= toDate)
                //    .Select(row => new Cargo() { Name = row["Груз"].Cast<string>(), ArrivalDate = row["Дата прихода на склад"].Cast<DateTime>() })
                //    .ToList()
                //    .Where(cargo => cargo.Name.Length == 3)
                //    .ToList();

                //var Cargos1 = from cargo in excel.Worksheet<Cargo>("Груз")
                //              //where (cargo.ArrivalDate >= fromDate && cargo.ArrivalDate <= toDate)
                //              //where cargo.Name == "Z"
                //              where cargo.Name.Length == 3
                //              select cargo;

               // Cargos = Cargos2.ToList();

                //for (int i = Cargos.Count - 1; i >= 0; i--)                
                //{
                //    if (!(Cargos[i].ArrivalDate >= fromDate && Cargos[i].ArrivalDate <= toDate))
                //    {
                //        Cargos.Remove(Cargos[i]);
                //    }
                //}

                Rates = excel.Worksheet<Rate>("Тариф").ToList();
            }
                                 
        }

        public List<Cargo> Cargos { get; }

        public List<Rate> Rates { get; }
    }
}
