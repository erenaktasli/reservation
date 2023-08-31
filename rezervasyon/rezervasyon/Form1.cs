using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection dbbaglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\db\\bilet.mdb");
        private void verileriGetir()
        {
            listViewRez.Items.Clear();
            dbbaglan.Open();
            OleDbCommand getirKomut = new OleDbCommand();
            getirKomut.Connection = dbbaglan;
            getirKomut.CommandText = "select * from rezervasyon";

            OleDbDataReader rezervasyonveri = getirKomut.ExecuteReader();

            while (rezervasyonveri.Read())

            {

                ListViewItem verilistesi = new ListViewItem();

                verilistesi.Text = rezervasyonveri["Sıra"].ToString();
                verilistesi.SubItems.Add(rezervasyonveri["Adı"].ToString());
                verilistesi.SubItems.Add(rezervasyonveri["Soyadı"].ToString());
                verilistesi.SubItems.Add(rezervasyonveri["Tarih"].ToString());
                verilistesi.SubItems.Add(rezervasyonveri["Seans"].ToString());
                verilistesi.SubItems.Add(rezervasyonveri["Koltuk"].ToString());

                listViewRez.Items.Add(verilistesi);

            }

            dbbaglan.Close();


        }

        private void buttonTum_Click(object sender, EventArgs e)
        {
            verileriGetir();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            dbbaglan.Open();
            OleDbCommand ekleKomut = new OleDbCommand();
            ekleKomut.Connection = dbbaglan;
            ekleKomut.CommandText = "insert into rezervasyon(Adı, Soyadı, Tarih, Seans, Koltuk) values ('"+textBoxAdı.Text.ToString()+"','"+textBoxSoyadı.Text.ToString()+"','"+dateTimePickerRez.Value.ToString()+"','"+comboBoxSeans.Text+"','"+comboBoxKoltuk.Text.ToString()+"')";
            ekleKomut.ExecuteNonQuery();

            dbbaglan.Close();

            verileriGetir();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            dbbaglan.Open();
            OleDbCommand silKomut = new OleDbCommand();
            silKomut.Connection = dbbaglan;
            silKomut.CommandText = "delete from rezervasyon where Adı='"+textBoxSilAdı.Text+"' ";
            silKomut.ExecuteNonQuery();

            dbbaglan.Close();

            verileriGetir();

        }

        private void buttonGuncel_Click(object sender, EventArgs e)
        {
            dbbaglan.Open();
            OleDbCommand guncelleKomut = new OleDbCommand();
            guncelleKomut.Connection = dbbaglan;
            guncelleKomut.CommandText = "update rezervasyon set Tarih='" + dateTimePickerRez.Value + "', Seans='"+comboBoxSeans.Text+"',Koltuk='"+comboBoxKoltuk.Text+"' where Adı='"+textBoxAdı.Text+"' ";
            guncelleKomut.ExecuteNonQuery();

            dbbaglan.Close();

            verileriGetir();
        }
    }
}
