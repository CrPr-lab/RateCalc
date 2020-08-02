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

        private DateTime Min(DateTime d1, DateTime d2)
        {
            return d1 < d2 ? d1 : d2;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var data = new InputDataParser(txbxFilePath.Text, dtpCalcFrom.Value, dtpCalcTo.Value);

            //var rrr = data.Rates
            //    .SelectMany((r, i) => new List<int>() {1, i}, (a, b) => { });

            //var rrrrr = from cargo in data.Cargos
            //            from rate in data.Rates
            //            select new
            //            {
            //                colCargo = cargo.Name,
            //                arrivalDate = cargo.ArrivalDate,
            //                departureDate = cargo.DepartureDate,

            //                begCalc = cargo.ArrivalDate.AddDays(rate.PeriodFrom - 1),
            //                endCalc = cargo.ArrivalDate.AddDays(rate.PeriodTo - 1), //Min(cargo.DepartureDate, cargo.ArrivalDate.AddDays(rate.PeriodTo)),

            //                //from = rate.PeriodFrom,
            //                //to = rate.PeriodTo,
            //                storageDaysCount = rate.PeriodTo - rate.PeriodFrom + 1,
            //                cost = rate.Cost,
            //                note = $"Период №{1 + 1}"
            //            };

            var rows = data.Cargos.SelectMany(cargo =>
                    data.Rates.Select((rate, i) =>
                        new
                        {
                            colCargo = cargo.Name,
                            arrivalDate = cargo.ArrivalDate,
                            departureDate = cargo.DepartureDate,

                            begCalc = cargo.ArrivalDate.AddDays(rate.PeriodFrom - 1),
                            endCalc = Min(cargo.DepartureDate, cargo.ArrivalDate.AddDays(rate.PeriodTo - 1)),

                            storageDaysCount = rate.PeriodTo - rate.PeriodFrom + 1,
                            cost = rate.Cost,
                            note = $"Период №{i + 1}"
                        }
                    )
                ).Where(row => row.departureDate >= row.begCalc).ToList();
            //dgrdResult.DataSource = rows;

            var storePeriods = data.Cargos.SelectMany(cargo =>
                data.Rates.Select(rate =>
                {
                    if (cargo.DepartureDate > cargo.ArrivalDate.AddDays(rate.PeriodTo - 1))
                    {
                        return null;
                    }

                    return new Period() 
                    { 
                        Cargo = cargo,
                        BegCalc = cargo.ArrivalDate.AddDays(rate.PeriodFrom - 1),
                        EndCalc = Min(cargo.DepartureDate, cargo.ArrivalDate.AddDays(rate.PeriodTo - 1)),
                    };
                })).Where(p => p != null);

            dgrdResult.DataSource = storePeriods.ToList();

            //var rows = data.Cargos.SelectMany(cargo => data.Rates.Select((rate, i) => {
            //    if (i > 2)
            //        return null;
            //    else
            //        return new
            //        {
            //            colCargo = cargo.Name,
            //            arrivalDate = cargo.ArrivalDate,
            //            departureDate = cargo.DepartureDate,

            //            begCalc = cargo.ArrivalDate.AddDays(rate.PeriodFrom - 1),
            //            endCalc = cargo.ArrivalDate.AddDays(rate.PeriodTo - 1), //Min(cargo.DepartureDate, cargo.ArrivalDate.AddDays(rate.PeriodTo)),

            //            //from = rate.PeriodFrom,
            //            //to = rate.PeriodTo,
            //            storageDaysCount = rate.PeriodTo - rate.PeriodFrom + 1,
            //            cost = rate.Cost,
            //            note = $"Период №{i + 1}"
            //        };
            //})).ToList();





            //dgrdResult.AutoGenerateColumns = false;


            //foreach (var item in rows)
            //{
            //    dgrdResult.Rows.Add(item);
            //}


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dtpCalcFrom.Value = DateTime.Parse("01.10.2017");
            dtpCalcTo.Value = DateTime.Parse("15.10.2017");
        }
    }
}
