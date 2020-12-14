
namespace OTOBÜS_BİLETİ_UYGULAMASI_PROJESİ
{
    partial class KayitFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.rdeMan = new System.Windows.Forms.RadioButton();
            this.rdWomen = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOkey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName : ";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(70, 51);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(209, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "LastName : ";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(70, 107);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(209, 20);
            this.txtLastname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "PhoneNumber :";
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.Location = new System.Drawing.Point(70, 165);
            this.mskPhoneNumber.Mask = "(999) 000-0000";
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.Size = new System.Drawing.Size(209, 20);
            this.mskPhoneNumber.TabIndex = 2;
            // 
            // rdeMan
            // 
            this.rdeMan.AutoSize = true;
            this.rdeMan.Location = new System.Drawing.Point(119, 205);
            this.rdeMan.Name = "rdeMan";
            this.rdeMan.Size = new System.Drawing.Size(49, 17);
            this.rdeMan.TabIndex = 3;
            this.rdeMan.TabStop = true;
            this.rdeMan.Text = "MAN";
            this.rdeMan.UseVisualStyleBackColor = true;
            // 
            // rdWomen
            // 
            this.rdWomen.AutoSize = true;
            this.rdWomen.Location = new System.Drawing.Point(185, 205);
            this.rdWomen.Name = "rdWomen";
            this.rdWomen.Size = new System.Drawing.Size(68, 17);
            this.rdWomen.TabIndex = 4;
            this.rdWomen.TabStop = true;
            this.rdWomen.Text = "WOMEN";
            this.rdWomen.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOkey
            // 
            this.btnOkey.Location = new System.Drawing.Point(199, 240);
            this.btnOkey.Name = "btnOkey";
            this.btnOkey.Size = new System.Drawing.Size(80, 23);
            this.btnOkey.TabIndex = 6;
            this.btnOkey.Text = "Okey";
            this.btnOkey.UseVisualStyleBackColor = true;
            this.btnOkey.Click += new System.EventHandler(this.btnOkey_Click);
            // 
            // KayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 307);
            this.Controls.Add(this.btnOkey);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rdWomen);
            this.Controls.Add(this.rdeMan);
            this.Controls.Add(this.mskPhoneNumber);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KayitFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkey;
        public System.Windows.Forms.TextBox txtFirstname;
        public System.Windows.Forms.TextBox txtLastname;
        public System.Windows.Forms.MaskedTextBox mskPhoneNumber;
        public System.Windows.Forms.RadioButton rdeMan;
        public System.Windows.Forms.RadioButton rdWomen;
    }
}