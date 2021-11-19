
namespace QLNet
{
    partial class NapTienWindow
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
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNap = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(165, 211);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(118, 20);
            this.textBoxMoney.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số tiền nạp";
            // 
            // buttonNap
            // 
            this.buttonNap.Location = new System.Drawing.Point(101, 254);
            this.buttonNap.Name = "buttonNap";
            this.buttonNap.Size = new System.Drawing.Size(75, 23);
            this.buttonNap.TabIndex = 3;
            this.buttonNap.Text = "NẠP";
            this.buttonNap.UseVisualStyleBackColor = true;
            this.buttonNap.Click += new System.EventHandler(this.buttonNap_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(238, 254);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "THOÁT";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(378, 216);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(35, 13);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "label2";
            // 
            // NapTienWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 314);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NapTienWindow";
            this.Text = "NapTienWindow";
            this.Load += new System.EventHandler(this.NapTienWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNap;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelId;
    }
}