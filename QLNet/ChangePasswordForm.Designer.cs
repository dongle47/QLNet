
namespace QLNet
{
    partial class ChangePasswordForm
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
            this.labelNewPass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass2 = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Location = new System.Drawing.Point(22, 85);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(99, 13);
            this.labelNewPass.TabIndex = 0;
            this.labelNewPass.Text = "Nhập mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Location = new System.Drawing.Point(140, 41);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxOldPass.TabIndex = 3;
            // 
            // textBoxNewPass2
            // 
            this.textBoxNewPass2.Location = new System.Drawing.Point(140, 119);
            this.textBoxNewPass2.Name = "textBoxNewPass2";
            this.textBoxNewPass2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewPass2.TabIndex = 4;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(140, 82);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewPass.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(25, 165);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 34);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Xác nhận";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.ForeColor = System.Drawing.SystemColors.Control;
            this.labelId.Location = new System.Drawing.Point(47, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(35, 13);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "label1";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(153, 165);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 34);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Thoát";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 235);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.textBoxNewPass2);
            this.Controls.Add(this.textBoxOldPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNewPass);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass2;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Button buttonConfirm;
        public System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonCancel;
    }
}