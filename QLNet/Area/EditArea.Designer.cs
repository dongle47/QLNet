
namespace QLNet
{
    partial class EditArea
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.ForeColor = System.Drawing.SystemColors.Control;
            this.labelId.Location = new System.Drawing.Point(12, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(35, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "label1";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(37, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Tên khu vực";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(111, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(40, 83);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(156, 83);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Thoát";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EditArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 142);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Name = "EditArea";
            this.Text = "EditArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
    }
}