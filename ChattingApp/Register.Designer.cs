namespace ChattingApp
{
    partial class Registration
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
            this.buttonRequest = new System.Windows.Forms.Button();
            this.RequestCode = new System.Windows.Forms.GroupBox();
            this.textFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmCode = new System.Windows.Forms.GroupBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.smsCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RequestCode.SuspendLayout();
            this.ConfirmCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(171, 74);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonRequest.TabIndex = 2;
            this.buttonRequest.Text = "Request";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // RequestCode
            // 
            this.RequestCode.Controls.Add(this.textFullName);
            this.RequestCode.Controls.Add(this.buttonRequest);
            this.RequestCode.Controls.Add(this.label2);
            this.RequestCode.Controls.Add(this.textPhoneNumber);
            this.RequestCode.Controls.Add(this.label1);
            this.RequestCode.Location = new System.Drawing.Point(12, 12);
            this.RequestCode.Name = "RequestCode";
            this.RequestCode.Size = new System.Drawing.Size(252, 109);
            this.RequestCode.TabIndex = 1;
            this.RequestCode.TabStop = false;
            this.RequestCode.Text = "Step 1: Request Code";
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(91, 48);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(155, 20);
            this.textFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(91, 22);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(155, 20);
            this.textPhoneNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number";
            // 
            // ConfirmCode
            // 
            this.ConfirmCode.Controls.Add(this.buttonConfirm);
            this.ConfirmCode.Controls.Add(this.smsCode);
            this.ConfirmCode.Controls.Add(this.label4);
            this.ConfirmCode.Enabled = false;
            this.ConfirmCode.Location = new System.Drawing.Point(12, 127);
            this.ConfirmCode.Name = "ConfirmCode";
            this.ConfirmCode.Size = new System.Drawing.Size(252, 81);
            this.ConfirmCode.TabIndex = 2;
            this.ConfirmCode.TabStop = false;
            this.ConfirmCode.Text = "Step 2: Confirm Code";
            this.ConfirmCode.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(171, 48);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // smsCode
            // 
            this.smsCode.Location = new System.Drawing.Point(91, 22);
            this.smsCode.Name = "smsCode";
            this.smsCode.Size = new System.Drawing.Size(155, 20);
            this.smsCode.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SMS Code:";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 214);
            this.Controls.Add(this.ConfirmCode);
            this.Controls.Add(this.RequestCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.RequestCode.ResumeLayout(false);
            this.RequestCode.PerformLayout();
            this.ConfirmCode.ResumeLayout(false);
            this.ConfirmCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.GroupBox RequestCode;
        private System.Windows.Forms.TextBox textFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ConfirmCode;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox smsCode;
        private System.Windows.Forms.Label label4;
    }
}