
namespace QLNet
{
    partial class EditMenu
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFoodName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(179, 159);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "THOÁT";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(59, 159);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "CẬP NHẬT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(126, 96);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 9;
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Location = new System.Drawing.Point(126, 51);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFoodName.TabIndex = 8;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(75, 99);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 13);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Giá tiền";
            // 
            // labelFoodName
            // 
            this.labelFoodName.AutoSize = true;
            this.labelFoodName.Location = new System.Drawing.Point(56, 54);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.Size = new System.Drawing.Size(64, 13);
            this.labelFoodName.TabIndex = 6;
            this.labelFoodName.Text = "Tên món ăn";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.ForeColor = System.Drawing.SystemColors.Control;
            this.labelId.Location = new System.Drawing.Point(40, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(64, 13);
            this.labelId.TabIndex = 12;
            this.labelId.Text = "Tên món ăn";
            // 
            // EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 215);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxFoodName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelFoodName);
            this.Name = "EditMenu";
            this.Text = "EditMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFoodName;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.TextBox textBoxFoodName;
        public System.Windows.Forms.Label labelId;
    }
}