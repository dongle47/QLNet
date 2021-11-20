
namespace QLNet
{
    partial class GoiMonForm
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
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelIdBill = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelMaHoaDon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(11, 68);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.Size = new System.Drawing.Size(263, 195);
            this.dataGridViewMenu.TabIndex = 1;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Location = new System.Drawing.Point(289, 68);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.Size = new System.Drawing.Size(250, 195);
            this.dataGridViewBill.TabIndex = 2;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(85, 279);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(101, 28);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Chọn";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelIdBill
            // 
            this.labelIdBill.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelIdBill.AutoSize = true;
            this.labelIdBill.BackColor = System.Drawing.SystemColors.Control;
            this.labelIdBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelIdBill.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIdBill.Location = new System.Drawing.Point(33, 335);
            this.labelIdBill.Name = "labelIdBill";
            this.labelIdBill.Size = new System.Drawing.Size(65, 13);
            this.labelIdBill.TabIndex = 4;
            this.labelIdBill.Text = "Mã hóa đơn";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(334, 279);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(58, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total Price";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(125, 52);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(39, 13);
            this.labelMenu.TabIndex = 6;
            this.labelMenu.Text = "MENU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MÓN ĂN ĐÃ CHỌN";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(307, 327);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(141, 29);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Thoát";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(117, 327);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(141, 29);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "Xác nhận";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelMaHoaDon
            // 
            this.labelMaHoaDon.AutoSize = true;
            this.labelMaHoaDon.Location = new System.Drawing.Point(212, 23);
            this.labelMaHoaDon.Name = "labelMaHoaDon";
            this.labelMaHoaDon.Size = new System.Drawing.Size(35, 13);
            this.labelMaHoaDon.TabIndex = 10;
            this.labelMaHoaDon.Text = "label2";
            // 
            // GoiMonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 385);
            this.Controls.Add(this.labelMaHoaDon);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelIdBill);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.dataGridViewMenu);
            this.Name = "GoiMonForm";
            this.Text = "GoiMonForm";
            this.Load += new System.EventHandler(this.GoiMonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.Button buttonSelect;
        public System.Windows.Forms.Label labelIdBill;
        public System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        public System.Windows.Forms.Label labelMaHoaDon;
    }
}