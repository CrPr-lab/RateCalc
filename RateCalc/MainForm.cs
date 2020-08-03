using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RateCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                txbxFilePath.Text = openFileDialog.FileName;

                btnCalc.Enabled = true;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var data = new InputDataParser(txbxFilePath.Text, dtpCalcFrom.Value, dtpCalcTo.Value);



            
            var storePeriods = data.Cargos.SelectMany(cargo => // создаем периоды хранения для каждого груза
                    data.Rates.Select((rate, i) =>
                        new 
                        {
                            Cargo = cargo,
                            Rate = rate,
                            BegCalc = cargo.ArrivalDate.AddDays(rate.PeriodFrom - 1),
                            EndCalc = /*Min(cargo.DepartureDate,*/ cargo.ArrivalDate.AddDays(rate.PeriodTo - 1/*)*/),
                        }
                    )
                ).Where(period => period.Cargo.DepartureDate >= period.BegCalc); // убираем периоды хранения, вышедшие за дату отгрузки

            // отбираем те периоды, которые попадают в диапазон расчёта
            var storePeriodsVDiapoz = storePeriods.Where(period => !(period.BegCalc > dtpCalcTo.Value || period.EndCalc < dtpCalcFrom.Value));
            // корректируем границы периодов в соответствии с границами расёта
            //var pe = storePeriodsVDiapoz.Select(period =>
            //    {
            //        if (period.BegCalc < dtpCalcFrom.Value)
            //            period.BegCalc = dtpCalcFrom.Value;
            //        if (period.EndCalc > dtpCalcTo.Value)
            //            period.EndCalc = dtpCalcTo.Value;
            //        return period;
            //    }
            //);

            var pe = storePeriodsVDiapoz.Select(period =>
                new
                {
                    period.Cargo,
                    period.Rate,
                    BegCalc = new[] { period.BegCalc, dtpCalcFrom.Value }.Max(), // корректируем границы периода
                    EndCalc = new[] { period.EndCalc, dtpCalcTo.Value, period.Cargo.DepartureDate }.Min(), // корректируем границы периода
                }               
            );

            var rows = pe.Select(period => // формируем строки отчёта
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

            dgrdResult.DataSource = rows.ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dtpCalcFrom.Value = DateTime.Parse("01.10.2017");
            dtpCalcTo.Value = DateTime.Parse("15.10.2017");
        }
    }
}
