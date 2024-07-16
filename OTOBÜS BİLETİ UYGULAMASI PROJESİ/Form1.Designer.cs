namespace OTOBÜS_BİLETİ_UYGULAMASI_PROJESİ
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOtobus = new System.Windows.Forms.ComboBox();
            this.İstikamet = new System.Windows.Forms.GroupBox();
            this.cmbNerden = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numUpFiyat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezervasyonYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.İstikamet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpFiyat)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbOtobus);
            this.groupBox2.Controls.Add(this.İstikamet);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.numUpFiyat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpTarih);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Location = new System.Drawing.Point(397, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 347);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Otobüs Seçin : ";
            // 
            // cmbOtobus
            // 
            this.cmbOtobus.FormattingEnabled = true;
            this.cmbOtobus.Items.AddRange(new object[] {
            "Metro",
            "Nilüfer",
            "Pamukkale"});
            this.cmbOtobus.Location = new System.Drawing.Point(84, 38);
            this.cmbOtobus.Name = "cmbOtobus";
            this.cmbOtobus.Size = new System.Drawing.Size(129, 21);
            this.cmbOtobus.TabIndex = 9;
            this.cmbOtobus.SelectedIndexChanged += new System.EventHandler(this.cmbOtobus_SelectedIndexChanged);
            // 
            // İstikamet
            // 
            this.İstikamet.Controls.Add(this.cmbNerden);
            this.İstikamet.Controls.Add(this.label3);
            this.İstikamet.Controls.Add(this.cmbNereye);
            this.İstikamet.Controls.Add(this.label4);
            this.İstikamet.Location = new System.Drawing.Point(85, 65);
            this.İstikamet.Name = "İstikamet";
            this.İstikamet.Size = new System.Drawing.Size(128, 118);
            this.İstikamet.TabIndex = 6;
            this.İstikamet.TabStop = false;
            this.İstikamet.Text = "İstikamet";
            // 
            // cmbNerden
            // 
            this.cmbNerden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNerden.FormattingEnabled = true;
            this.cmbNerden.Items.AddRange(new object[] {
            "ANKARA",
            "ANTALYA",
            "AYDIN",
            "BALIKESİR",
            "BURSA",
            "DENİZLİ",
            "EDİRNE",
            "ESKİŞEHİR",
            "İSTANBUL",
            "İZMİR"});
            this.cmbNerden.Location = new System.Drawing.Point(6, 46);
            this.cmbNerden.Name = "cmbNerden";
            this.cmbNerden.Size = new System.Drawing.Size(115, 21);
            this.cmbNerden.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nereden : ";
            // 
            // cmbNereye
            // 
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "ANKARA",
            "ANTALYA",
            "AYDIN",
            "BALIKESİR",
            "BURSA",
            "DENİZLİ",
            "EDİRNE",
            "ESKİŞEHİR",
            "İSTANBUL",
            "İZMİR"});
            this.cmbNereye.Location = new System.Drawing.Point(6, 97);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(115, 21);
            this.cmbNereye.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nereye :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numUpFiyat
            // 
            this.numUpFiyat.Location = new System.Drawing.Point(92, 292);
            this.numUpFiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpFiyat.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpFiyat.Name = "numUpFiyat";
            this.numUpFiyat.Size = new System.Drawing.Size(115, 20);
            this.numUpFiyat.TabIndex = 6;
            this.numUpFiyat.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tarih : ";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(91, 202);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(115, 20);
            this.dtpTarih.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sefer Saatleri : ";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00"});
            this.comboBox3.Location = new System.Drawing.Point(92, 249);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(116, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader1});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(682, 212);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Customer";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PhoneNumber";
            this.columnHeader5.Width = 91;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cinsiyet";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nereden";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nereye";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Koltuk no";
            this.columnHeader9.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tarih";
            this.columnHeader10.Width = 103;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Sefer Saatleri";
            this.columnHeader11.Width = 62;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 26);
            // 
            // rezervasyonYapToolStripMenuItem
            // 
            this.rezervasyonYapToolStripMenuItem.Name = "rezervasyonYapToolStripMenuItem";
            this.rezervasyonYapToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rezervasyonYapToolStripMenuItem.Text = "Rezervasyon yap";
            this.rezervasyonYapToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonYapToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(21, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 231);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ticket ";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fiyat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 642);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.İstikamet.ResumeLayout(false);
            this.İstikamet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpFiyat)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNerden;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numUpFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox İstikamet;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonYapToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
