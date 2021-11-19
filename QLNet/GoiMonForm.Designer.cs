
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.Size = new System.Drawing.Size(307, 221);
            this.dataGridViewMenu.TabIndex = 1;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Location = new System.Drawing.Point(348, 12);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.Size = new System.Drawing.Size(307, 221);
            this.dataGridViewBill.TabIndex = 2;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(127, 239);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Chọn";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // labelIdBill
            // 
            this.labelIdBill.AutoSize = true;
            this.labelIdBill.Location = new System.Drawing.Point(504, 342);
            this.labelIdBill.Name = "labelIdBill";
            this.labelIdBill.Size = new System.Drawing.Size(35, 13);
            this.labelIdBill.TabIndex = 4;
            this.labelIdBill.Text = "label1";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(477, 249);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(58, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total Price";
            // 
            // GoiMonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}