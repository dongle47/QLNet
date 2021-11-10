
namespace QLNet
{
    partial class ListMenu
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFoodName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(342, 12);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.Size = new System.Drawing.Size(307, 150);
            this.dataGridViewMenu.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(374, 214);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "CHỈNH SỬA";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(471, 214);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "XÓA";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(574, 214);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "THOÁT";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(144, 191);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "THÊM";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(160, 113);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 8;
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Location = new System.Drawing.Point(160, 68);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFoodName.TabIndex = 7;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(109, 116);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 13);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Giá tiền";
            // 
            // labelFoodName
            // 
            this.labelFoodName.AutoSize = true;
            this.labelFoodName.Location = new System.Drawing.Point(90, 71);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.Size = new System.Drawing.Size(64, 13);
            this.labelFoodName.TabIndex = 5;
            this.labelFoodName.Text = "Tên món ăn";
            // 
            // ListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 304);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxFoodName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelFoodName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewMenu);
            this.Name = "ListMenu";
            this.Text = "ListMenu";
            this.Load += new System.EventHandler(this.ListMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFoodName;
    }
}