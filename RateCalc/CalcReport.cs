using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCalc
{
    class CalcReport
    {
        public List<ReportRow> Calc(List<Cargo> cargos, List<Rate> rates, DateTime calcFrom, DateTime calcTo)
        {
            var Rows = cargos
                // создаем периоды хранения для каждого груза
                .SelectMany(cargo => rates
                    .Select((rate, i) =>
                        new
                        {
                            Cargo = cargo,
                            Rate = rate,
                            BegCalc = cargo.ArrivalDate.AddDays(rate.PeriodFrom - 1),
                            EndCalc = cargo.ArrivalDate.AddDays(rate.PeriodTo - 1),
                        }
                    )
                )
                // убираем периоды хранения, вышедшие за дату отгрузки
                .Where(period => period.Cargo.DepartureDate >= period.BegCalc)
                // отбираем те периоды, которые попадают в диапазон расчёта
                .Where(period => !(period.BegCalc > calcTo || period.EndCalc < calcFrom))
                // корректируем границы периодов в соответствии с границами расёта
                .Select(period =>
                    new
                    {
                        period.Cargo,
                        period.Rate,
                        BegCalc = new[] { period.BegCalc, calcFrom }.Max(), // корректируем границы периода
                        EndCalc = new[] { period.EndCalc, calcTo, period.Cargo.DepartureDate }.Min(), // корректируем границы периода
                    }
                )
                // формируем строки отчёта
                .Select(period =>
                    new ReportRow()
                    {
                        CargoName = period.Cargo.Name,
                        ArrivalDate = period.Cargo.ArrivalDate,
                        DepartureDate = period.Cargo.DepartureDate,
                        BegCalc = period.BegCalc,
                        EndCalc = period.EndCalc,
                        StoreDays = (int)(period.EndCalc - period.BegCalc).TotalDays + 1,
                        RateCost = period.Rate.Cost,
                        Note = $"Период №{period.Rate.Number}"
                    }
                );

            return Rows.ToList();
        }
    }
}
