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

            //var data1 = data.Cargos
            //    .SelectMany(cargo => new { cargo.Name, cargo.})

            foreach (var item in data.Cargos)
            {
                dgrdResult.Rows.Add(new { item.Name, item.ArrivalDate/*, item.DepartureDate*/ });
            }
            
            
        }
    }
}
