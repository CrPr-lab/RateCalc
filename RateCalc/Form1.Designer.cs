namespace RateCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrdResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbxInitialData = new System.Windows.Forms.GroupBox();
            this.txbxFilePath = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.dtpCalcTo = new System.Windows.Forms.DateTimePicker();
            this.dtpCalcFrom = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateBegCalc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateEndCalc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaysStorageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbxInitialData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrdResult
            // 
            this.dgrdResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgrdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCargo,
            this.colAddivalDate,
            this.colDepartureDate,
            this.colDateBegCalc,
            this.colDateEndCalc,
            this.colDaysStorageCount,
            this.colRate,
            this.colNote});
            this.dgrdResult.Location = new System.Drawing.Point(0, 169);
            this.dgrdResult.Name = "dgrdResult";
            this.dgrdResult.ReadOnly = true;
            this.dgrdResult.RowHeadersWidth = 62;
            this.dgrdResult.RowTemplate.Height = 28;
            this.dgrdResult.Size = new System.Drawing.Size(1013, 300);
            this.dgrdResult.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbxInitialData);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.dtpCalcTo);
            this.panel1.Controls.Add(this.dtpCalcFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 169);
            this.panel1.TabIndex = 5;
            // 
            // grbxInitialData
            // 
            this.grbxInitialData.Controls.Add(this.txbxFilePath);
            this.grbxInitialData.Controls.Add(this.btnLoadFile);
            this.grbxInitialData.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbxInitialData.Location = new System.Drawing.Point(0, 0);
            this.grbxInitialData.Name = "grbxInitialData";
            this.grbxInitialData.Size = new System.Drawing.Size(1049, 85);
            this.grbxInitialData.TabIndex = 10;
            this.grbxInitialData.TabStop = false;
            this.grbxInitialData.Text = "Данные для расчёта";
            // 
            // txbxFilePath
            // 
            this.txbxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxFilePath.Location = new System.Drawing.Point(24, 34);
            this.txbxFilePath.Name = "txbxFilePath";
            this.txbxFilePath.ReadOnly = true;
            this.txbxFilePath.Size = new System.Drawing.Size(817, 26);
            this.txbxFilePath.TabIndex = 10;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFile.Location = new System.Drawing.Point(871, 28);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(155, 38);
            this.btnLoadFile.TabIndex = 9;
            this.btnLoadFile.Text = "Загрузить файл";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCalc.Enabled = false;
            this.btnCalc.Location = new System.Drawing.Point(807, 113);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(155, 38);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // dtpCalcTo
            // 
            this.dtpCalcTo.Location = new System.Drawing.Point(341, 117);
            this.dtpCalcTo.Name = "dtpCalcTo";
            this.dtpCalcTo.Size = new System.Drawing.Size(209, 26);
            this.dtpCalcTo.TabIndex = 6;
            // 
            // dtpCalcFrom
            // 
            this.dtpCalcFrom.Location = new System.Drawing.Point(49, 117);
            this.dtpCalcFrom.Name = "dtpCalcFrom";
            this.dtpCalcFrom.Size = new System.Drawing.Size(209, 26);
            this.dtpCalcFrom.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файлы данных Excel(*.xlsx;*.xls)|*.xlsx;*.xls";
            // 
            // colCargo
            // 
            this.colCargo.HeaderText = "Груз";
            this.colCargo.MinimumWidth = 8;
            this.colCargo.Name = "colCargo";
            this.colCargo.ReadOnly = true;
            this.colCargo.Width = 150;
            // 
            // colAddivalDate
            // 
            this.colAddivalDate.HeaderText = "Дата прихода на склад";
            this.colAddivalDate.MinimumWidth = 8;
            this.colAddivalDate.Name = "colAddivalDate";
            this.colAddivalDate.ReadOnly = true;
            this.colAddivalDate.Width = 150;
            // 
            // colDepartureDate
            // 
            this.colDepartureDate.HeaderText = "Дата ухода со склада";
            this.colDepartureDate.MinimumWidth = 8;
            this.colDepartureDate.Name = "colDepartureDate";
            this.colDepartureDate.ReadOnly = true;
            this.colDepartureDate.Width = 150;
            // 
            // colDateBegCalc
            // 
            this.colDateBegCalc.HeaderText = "Начало расчета";
            this.colDateBegCalc.MinimumWidth = 8;
            this.colDateBegCalc.Name = "colDateBegCalc";
            this.colDateBegCalc.ReadOnly = true;
            this.colDateBegCalc.Width = 150;
            // 
            // colDateEndCalc
            // 
            this.colDateEndCalc.HeaderText = "Окончание расчета";
            this.colDateEndCalc.MinimumWidth = 8;
            this.colDateEndCalc.Name = "colDateEndCalc";
            this.colDateEndCalc.ReadOnly = true;
            this.colDateEndCalc.Width = 150;
            // 
            // colDaysStorageCount
            // 
            this.colDaysStorageCount.HeaderText = "Кол-во дней хранения";
            this.colDaysStorageCount.MinimumWidth = 8;
            this.colDaysStorageCount.Name = "colDaysStorageCount";
            this.colDaysStorageCount.ReadOnly = true;
            this.colDaysStorageCount.Width = 150;
            // 
            // colRate
            // 
            this.colRate.HeaderText = "Ставка";
            this.colRate.MinimumWidth = 8;
            this.colRate.Name = "colRate";
            this.colRate.ReadOnly = true;
            this.colRate.Width = 150;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "Примечание";
            this.colNote.MinimumWidth = 8;
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            this.colNote.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgrdResult);
            this.Name = "MainForm";
            this.Text = "Расчёт прогрессивной ставки по хранению груза";
            ((System.ComponentModel.ISupportInitialize)(this.dgrdResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbxInitialData.ResumeLayout(false);
            this.grbxInitialData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgrdResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DateTimePicker dtpCalcTo;
        private System.Windows.Forms.DateTimePicker dtpCalcFrom;
        private System.Windows.Forms.GroupBox grbxInitialData;
        private System.Windows.Forms.TextBox txbxFilePath;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateBegCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateEndCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDaysStorageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
    }
}

