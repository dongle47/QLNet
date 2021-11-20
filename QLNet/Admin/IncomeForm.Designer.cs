
namespace QLNet
{
    partial class IncomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.radioButtonMoney = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.dateTimePickerNKT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerNBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonFood = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelIncomeAvg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 249);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(382, 196);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.radioButtonMoney);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButtonFood);
            this.groupBox1.Controls.Add(this.radioButtonAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(130, 192);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(91, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // radioButtonMoney
            // 
            this.radioButtonMoney.AutoSize = true;
            this.radioButtonMoney.Location = new System.Drawing.Point(224, 19);
            this.radioButtonMoney.Name = "radioButtonMoney";
            this.radioButtonMoney.Size = new System.Drawing.Size(65, 17);
            this.radioButtonMoney.TabIndex = 2;
            this.radioButtonMoney.TabStop = true;
            this.radioButtonMoney.Text = "Nạp tiền";
            this.radioButtonMoney.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonNo);
            this.groupBox2.Controls.Add(this.radioButtonYes);
            this.groupBox2.Controls.Add(this.dateTimePickerNKT);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePickerNBD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(60, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm theo ngày";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(134, 32);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 12;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(85, 32);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYes.TabIndex = 11;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNKT
            // 
            this.dateTimePickerNKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNKT.Location = new System.Drawing.Point(117, 88);
            this.dateTimePickerNKT.Name = "dateTimePickerNKT";
            this.dateTimePickerNKT.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerNKT.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // dateTimePickerNBD
            // 
            this.dateTimePickerNBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNBD.Location = new System.Drawing.Point(117, 55);
            this.dateTimePickerNBD.Name = "dateTimePickerNBD";
            this.dateTimePickerNBD.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerNBD.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày kết thúc";
            // 
            // radioButtonFood
            // 
            this.radioButtonFood.AutoSize = true;
            this.radioButtonFood.Location = new System.Drawing.Point(157, 19);
            this.radioButtonFood.Name = "radioButtonFood";
            this.radioButtonFood.Size = new System.Drawing.Size(61, 17);
            this.radioButtonFood.TabIndex = 1;
            this.radioButtonFood.TabStop = true;
            this.radioButtonFood.Text = "Món ăn";
            this.radioButtonFood.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(86, 19);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(65, 17);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Toàn bộ";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // labelIncomeAvg
            // 
            this.labelIncomeAvg.AutoSize = true;
            this.labelIncomeAvg.Location = new System.Drawing.Point(12, 448);
            this.labelIncomeAvg.Name = "labelIncomeAvg";
            this.labelIncomeAvg.Size = new System.Drawing.Size(35, 13);
            this.labelIncomeAvg.TabIndex = 3;
            this.labelIncomeAvg.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(133, 477);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(143, 29);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Thoát";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 518);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelIncomeAvg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMoney;
        private System.Windows.Forms.RadioButton radioButtonFood;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.DateTimePicker dateTimePickerNKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Label labelIncomeAvg;
    }
}