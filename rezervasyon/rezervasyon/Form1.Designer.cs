
namespace rezervasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTum = new System.Windows.Forms.Button();
            this.listViewRez = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAdı = new System.Windows.Forms.TextBox();
            this.textBoxSoyadı = new System.Windows.Forms.TextBox();
            this.dateTimePickerRez = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSeans = new System.Windows.Forms.ComboBox();
            this.comboBoxKoltuk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxSilAdı = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGuncel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTum
            // 
            this.buttonTum.Location = new System.Drawing.Point(572, 223);
            this.buttonTum.Name = "buttonTum";
            this.buttonTum.Size = new System.Drawing.Size(113, 37);
            this.buttonTum.TabIndex = 0;
            this.buttonTum.TabStop = false;
            this.buttonTum.Text = "Tüm Veri";
            this.buttonTum.UseVisualStyleBackColor = true;
            this.buttonTum.Click += new System.EventHandler(this.buttonTum_Click);
            // 
            // listViewRez
            // 
            this.listViewRez.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewRez.HideSelection = false;
            this.listViewRez.Location = new System.Drawing.Point(60, 266);
            this.listViewRez.Name = "listViewRez";
            this.listViewRez.Size = new System.Drawing.Size(625, 144);
            this.listViewRez.TabIndex = 1;
            this.listViewRez.UseCompatibleStateImageBehavior = false;
            this.listViewRez.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sıra";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tarih";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Seans";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Koltuk";
            // 
            // textBoxAdı
            // 
            this.textBoxAdı.Location = new System.Drawing.Point(214, 44);
            this.textBoxAdı.Name = "textBoxAdı";
            this.textBoxAdı.Size = new System.Drawing.Size(100, 26);
            this.textBoxAdı.TabIndex = 2;
            // 
            // textBoxSoyadı
            // 
            this.textBoxSoyadı.Location = new System.Drawing.Point(214, 85);
            this.textBoxSoyadı.Name = "textBoxSoyadı";
            this.textBoxSoyadı.Size = new System.Drawing.Size(100, 26);
            this.textBoxSoyadı.TabIndex = 3;
            // 
            // dateTimePickerRez
            // 
            this.dateTimePickerRez.Location = new System.Drawing.Point(481, 42);
            this.dateTimePickerRez.Name = "dateTimePickerRez";
            this.dateTimePickerRez.Size = new System.Drawing.Size(257, 26);
            this.dateTimePickerRez.TabIndex = 4;
            // 
            // comboBoxSeans
            // 
            this.comboBoxSeans.FormattingEnabled = true;
            this.comboBoxSeans.Items.AddRange(new object[] {
            "Seans1",
            "Seans2",
            "Seans3",
            "Seans4"});
            this.comboBoxSeans.Location = new System.Drawing.Point(481, 84);
            this.comboBoxSeans.Name = "comboBoxSeans";
            this.comboBoxSeans.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSeans.TabIndex = 5;
            // 
            // comboBoxKoltuk
            // 
            this.comboBoxKoltuk.FormattingEnabled = true;
            this.comboBoxKoltuk.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxKoltuk.Location = new System.Drawing.Point(481, 125);
            this.comboBoxKoltuk.Name = "comboBoxKoltuk";
            this.comboBoxKoltuk.Size = new System.Drawing.Size(121, 28);
            this.comboBoxKoltuk.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seans";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Koltuk";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(481, 223);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 37);
            this.buttonEkle.TabIndex = 12;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(224, 225);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(90, 35);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Sil";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxSilAdı
            // 
            this.textBoxSilAdı.Location = new System.Drawing.Point(118, 229);
            this.textBoxSilAdı.Name = "textBoxSilAdı";
            this.textBoxSilAdı.Size = new System.Drawing.Size(100, 26);
            this.textBoxSilAdı.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adı";
            // 
            // buttonGuncel
            // 
            this.buttonGuncel.Location = new System.Drawing.Point(575, 180);
            this.buttonGuncel.Name = "buttonGuncel";
            this.buttonGuncel.Size = new System.Drawing.Size(110, 37);
            this.buttonGuncel.TabIndex = 16;
            this.buttonGuncel.Text = "Güncelle";
            this.buttonGuncel.UseVisualStyleBackColor = true;
            this.buttonGuncel.Click += new System.EventHandler(this.buttonGuncel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGuncel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSilAdı);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKoltuk);
            this.Controls.Add(this.comboBoxSeans);
            this.Controls.Add(this.dateTimePickerRez);
            this.Controls.Add(this.textBoxSoyadı);
            this.Controls.Add(this.textBoxAdı);
            this.Controls.Add(this.listViewRez);
            this.Controls.Add(this.buttonTum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTum;
        private System.Windows.Forms.ListView listViewRez;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxAdı;
        private System.Windows.Forms.TextBox textBoxSoyadı;
        private System.Windows.Forms.DateTimePicker dateTimePickerRez;
        private System.Windows.Forms.ComboBox comboBoxSeans;
        private System.Windows.Forms.ComboBox comboBoxKoltuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxSilAdı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGuncel;
    }
}

