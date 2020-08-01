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

            var rows = data.Cargos
                .SelectMany(cargo => data.Rates.Select((rate, i) => new
                {
                    colCargo = cargo.Name,
                    arrivalDate = cargo.ArrivalDate,
                    departureDate = cargo.DepartureDate,

                    begCalc = cargo.ArrivalDate.AddDays(rate.PeriodFrom - 1),
                    endCalc = cargo.ArrivalDate.AddDays(rate.PeriodTo - 1), //Min(cargo.DepartureDate, cargo.ArrivalDate.AddDays(rate.PeriodTo)),

                    //from = rate.PeriodFrom,
                    //to = rate.PeriodTo,
                    storageDaysCount = rate.PeriodTo - rate.PeriodFrom + 1,
                    cost = rate.Cost,
                    note = $"Период №{i + 1}"
                })).ToList() ;



            //dgrdResult.AutoGenerateColumns = false;
            dgrdResult.DataSource = rows;

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
