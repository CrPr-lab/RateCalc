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
            if (dtpCalcFrom.Value > dtpCalcTo.Value)
            {
                MessageBox.Show("Начало периода расчёта не может быть больше конца периода расчёта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = new InputDataParser(txbxFilePath.Text, dtpCalcFrom.Value, dtpCalcTo.Value);

            var calcReport = new CalcReport();

            dgrdResult.DataSource = calcReport.Calc(data.Cargos, data.Rates, dtpCalcFrom.Value, dtpCalcTo.Value);
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            dtpCalcFrom.Value = DateTime.Parse("01.10.2017");
            dtpCalcTo.Value = DateTime.Parse("15.10.2017");
        }
    }
}
