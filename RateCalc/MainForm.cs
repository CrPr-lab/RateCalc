using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            try
            {
                var data = new InputDataParser(txbxFilePath.Text, dtpCalcFrom.Value, dtpCalcTo.Value);

                var calcReport = new CalcReport();

                dgrdResult.DataSource = calcReport.Calc(data.Cargos, data.Rates, dtpCalcFrom.Value, dtpCalcTo.Value);
            }
            catch(InvalidOperationException E)
            {
                if (MessageBox.Show("Поставщик 'Microsoft.ACE.OLEDB.12.0' не зарегистрирован на локальном компьютере. Необходимо установить пакет Microsoft Access Database Engine. Перейти на страницу загрузки?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    Process.Start("https://www.microsoft.com/en-in/download/details.aspx?id=13255");
            }
            catch (Exception E)
            {
                MessageBox.Show($"При чтении данных произошла ошибка: \n{E.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            dtpCalcFrom.Value = DateTime.Parse("01.10.2017");
            dtpCalcTo.Value = DateTime.Parse("15.10.2017");
        }
    }
}
