
namespace SS_SOFTWARE_SMS
{
    partial class FRM_SMS
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
            this.cmbcom = new System.Windows.Forms.ComboBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbcom
            // 
            this.cmbcom.FormattingEnabled = true;
            this.cmbcom.Location = new System.Drawing.Point(376, 102);
            this.cmbcom.Name = "cmbcom";
            this.cmbcom.Size = new System.Drawing.Size(121, 21);
            this.cmbcom.TabIndex = 0;
            this.cmbcom.SelectedIndexChanged += new System.EventHandler(this.cmbcom_SelectedIndexChanged);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(291, 210);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(284, 20);
            this.txtphone.TabIndex = 1;
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(291, 236);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(284, 20);
            this.txtmessage.TabIndex = 2;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(291, 275);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(284, 48);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "button1";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.cmbcom);
            this.Name = "FRM_SMS";
            this.Text = "FRM_SMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_SMS_FormClosing);
            this.Load += new System.EventHandler(this.FRM_SMS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcom;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button button1;
    }
}