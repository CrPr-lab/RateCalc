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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.dtpCalcTo = new System.Windows.Forms.DateTimePicker();
            this.dtpCalcFrom = new System.Windows.Forms.DateTimePicker();
            this.grbxInitialData = new System.Windows.Forms.GroupBox();
            this.txbxFilePath = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbxInitialData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrdResult
            // 
            this.dgrdResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdResult.Location = new System.Drawing.Point(0, 186);
            this.dgrdResult.Name = "dgrdResult";
            this.dgrdResult.ReadOnly = true;
            this.dgrdResult.RowHeadersWidth = 62;
            this.dgrdResult.RowTemplate.Height = 28;
            this.dgrdResult.Size = new System.Drawing.Size(1003, 331);
            this.dgrdResult.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grbxInitialData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 187);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Controls.Add(this.dtpCalcTo);
            this.groupBox1.Controls.Add(this.dtpCalcFrom);
            this.groupBox1.Location = new System.Drawing.Point(0, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расчёт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Конец периода";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Начало периода";
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Enabled = false;
            this.btnCalc.Location = new System.Drawing.Point(825, 28);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(155, 38);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // dtpCalcTo
            // 
            this.dtpCalcTo.Location = new System.Drawing.Point(520, 34);
            this.dtpCalcTo.Name = "dtpCalcTo";
            this.dtpCalcTo.Size = new System.Drawing.Size(209, 26);
            this.dtpCalcTo.TabIndex = 14;
            // 
            // dtpCalcFrom
            // 
            this.dtpCalcFrom.Location = new System.Drawing.Point(154, 34);
            this.dtpCalcFrom.Name = "dtpCalcFrom";
            this.dtpCalcFrom.Size = new System.Drawing.Size(209, 26);
            this.dtpCalcFrom.TabIndex = 13;
            // 
            // grbxInitialData
            // 
            this.grbxInitialData.Controls.Add(this.txbxFilePath);
            this.grbxInitialData.Controls.Add(this.btnLoadFile);
            this.grbxInitialData.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbxInitialData.Location = new System.Drawing.Point(0, 0);
            this.grbxInitialData.Name = "grbxInitialData";
            this.grbxInitialData.Size = new System.Drawing.Size(1003, 85);
            this.grbxInitialData.TabIndex = 10;
            this.grbxInitialData.TabStop = false;
            this.grbxInitialData.Text = "Данные";
            // 
            // txbxFilePath
            // 
            this.txbxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxFilePath.Location = new System.Drawing.Point(24, 34);
            this.txbxFilePath.Name = "txbxFilePath";
            this.txbxFilePath.ReadOnly = true;
            this.txbxFilePath.Size = new System.Drawing.Size(771, 26);
            this.txbxFilePath.TabIndex = 10;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFile.Location = new System.Drawing.Point(825, 28);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(155, 38);
            this.btnLoadFile.TabIndex = 9;
            this.btnLoadFile.Text = "Загрузить файл";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файлы данных Excel(*.xlsx;*.xls)|*.xlsx;*.xls";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgrdResult);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "MainForm";
            this.Text = "Расчёт прогрессивной ставки по хранению груза";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbxInitialData.ResumeLayout(false);
            this.grbxInitialData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgrdResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbxInitialData;
        private System.Windows.Forms.TextBox txbxFilePath;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DateTimePicker dtpCalcTo;
        private System.Windows.Forms.DateTimePicker dtpCalcFrom;
    }
}

