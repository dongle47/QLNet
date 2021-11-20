
namespace QLNet
{
    partial class HistoryLoginForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePickerNKT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNBD = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonDateYes = new System.Windows.Forms.RadioButton();
            this.radioButtonDateNo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonUserNo = new System.Windows.Forms.RadioButton();
            this.radioButtonUserYes = new System.Windows.Forms.RadioButton();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày kết thúc";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(121, 196);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 28);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePickerNKT
            // 
            this.dateTimePickerNKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNKT.Location = new System.Drawing.Point(108, 68);
            this.dateTimePickerNKT.Name = "dateTimePickerNKT";
            this.dateTimePickerNKT.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerNKT.TabIndex = 5;
            // 
            // dateTimePickerNBD
            // 
            this.dateTimePickerNBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNBD.Location = new System.Drawing.Point(108, 41);
            this.dateTimePickerNBD.Name = "dateTimePickerNBD";
            this.dateTimePickerNBD.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerNBD.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(399, 252);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 32);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Thoát";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerNKT);
            this.panel1.Controls.Add(this.dateTimePickerNBD);
            this.panel1.Controls.Add(this.radioButtonDateYes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButtonDateNo);
            this.panel1.Location = new System.Drawing.Point(22, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 104);
            this.panel1.TabIndex = 5;
            // 
            // radioButtonDateYes
            // 
            this.radioButtonDateYes.AutoSize = true;
            this.radioButtonDateYes.Location = new System.Drawing.Point(133, 13);
            this.radioButtonDateYes.Name = "radioButtonDateYes";
            this.radioButtonDateYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonDateYes.TabIndex = 6;
            this.radioButtonDateYes.TabStop = true;
            this.radioButtonDateYes.Text = "Yes";
            this.radioButtonDateYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonDateNo
            // 
            this.radioButtonDateNo.AutoSize = true;
            this.radioButtonDateNo.Location = new System.Drawing.Point(182, 13);
            this.radioButtonDateNo.Name = "radioButtonDateNo";
            this.radioButtonDateNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonDateNo.TabIndex = 7;
            this.radioButtonDateNo.TabStop = true;
            this.radioButtonDateNo.Text = "No";
            this.radioButtonDateNo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tìm kiếm theo ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tìm kiếm theo username";
            // 
            // radioButtonUserNo
            // 
            this.radioButtonUserNo.AutoSize = true;
            this.radioButtonUserNo.Location = new System.Drawing.Point(85, 32);
            this.radioButtonUserNo.Name = "radioButtonUserNo";
            this.radioButtonUserNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonUserNo.TabIndex = 10;
            this.radioButtonUserNo.TabStop = true;
            this.radioButtonUserNo.Text = "No";
            this.radioButtonUserNo.UseVisualStyleBackColor = true;
            this.radioButtonUserNo.CheckedChanged += new System.EventHandler(this.radioButtonUserNo_CheckedChanged);
            // 
            // radioButtonUserYes
            // 
            this.radioButtonUserYes.AutoSize = true;
            this.radioButtonUserYes.Location = new System.Drawing.Point(40, 32);
            this.radioButtonUserYes.Name = "radioButtonUserYes";
            this.radioButtonUserYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonUserYes.TabIndex = 9;
            this.radioButtonUserYes.TabStop = true;
            this.radioButtonUserYes.Text = "Yes";
            this.radioButtonUserYes.UseVisualStyleBackColor = true;
            this.radioButtonUserYes.CheckedChanged += new System.EventHandler(this.radioButtonUserYes_CheckedChanged);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(165, 16);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(93, 20);
            this.textBoxUser.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxUser);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.radioButtonUserNo);
            this.panel2.Controls.Add(this.radioButtonUserYes);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 178);
            this.panel2.TabIndex = 13;
            // 
            // HistoryLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 309);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HistoryLoginForm";
            this.Text = "HistoryLoginForm";
            this.Load += new System.EventHandler(this.HistoryLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerNKT;
        private System.Windows.Forms.DateTimePicker dateTimePickerNBD;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonDateYes;
        private System.Windows.Forms.RadioButton radioButtonDateNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonUserNo;
        private System.Windows.Forms.RadioButton radioButtonUserYes;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Panel panel2;
    }
}