using Gunluk1._0WF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gunluk1._0WF
{
    public partial class Form1 : Form
    {

        string conStr = @"server=(localdb)\MSSQLLocalDb; Database= OdevNotlarDb; Trusted_Connection=True;";
        BindingList<Notlar> notlar = new BindingList<Notlar>();
        BindingList<Notlar> arananlar = new BindingList<Notlar>();
        public Form1()
        {
            VeriTabanıYoksaOlustur();
            InitializeComponent();
            lstNotlar.DataSource = notlar;
            lstAranan.DataSource = arananlar;
            NotlariListele();
        }



        private void NotlariListele()
        {
            using (var con = BaglantiOlustur())
            {
                var cmd = new SqlCommand("SELECT Id, Baslik, Icerik FROM Notlar", con);
                var sdr = cmd.ExecuteReader();

                notlar.Clear();
                while (sdr.Read())
                {
                    notlar.Add(new Notlar
                    {
                        Id = (int)sdr["Id"],
                        Baslik = (string)sdr["Baslik"],
                        Icerik = (string)sdr["Icerik"]
                    });
                }
                lstNotlar.Visible = true;
                lstAranan.Visible = false;
            }
        }

        private SqlConnection BaglantiOlustur()
        {
            var con = new SqlConnection(conStr);
            con.Open();
            return con;
        }

        private void VeriTabanıYoksaOlustur()
        {
            using (var con = new SqlConnection(@"server=(localdb)\MSSQLLocalDb; Database=master; Trusted_Connection=True;"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"IF(DB_ID('OdevNotlarDb') IS NULL)
	CREATE DATABASE OdevNotlarDb;", con);
                cmd.ExecuteNonQuery();
            }

            using (var con = BaglantiOlustur())
            {
                SqlCommand cmd = new SqlCommand(@"IF OBJECT_ID(N'dbo.Notlar', N'U') IS NULL
	            CREATE TABLE Notlar
	            (
	            Id INT PRIMARY KEY IDENTITY,
	            Baslik NVARCHAR(MAX) NOT NULL,
	            Icerik NVARCHAR(MAX) NOT NULL
	            );", con);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            NotEkle();
            txtBaslik.Clear();
            rtxtIcerik.Clear();
        }

        private void NotEkle()
        {
            string baslik = txtBaslik.Text.Trim();
            string icerik = rtxtIcerik.Text.Trim();
            using (var con = BaglantiOlustur())
            {
                var cmd = new SqlCommand("INSERT INTO Notlar(Baslik, Icerik) VALUES(@p1,@p2)", con);
                cmd.Parameters.AddWithValue("@p1", baslik);
                cmd.Parameters.AddWithValue("@p2", icerik);
                cmd.ExecuteNonQuery();

            }
            NotlariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliNotIndex = lstNotlar.SelectedIndex;
            if (lstNotlar.Items.Count > 0)
            {
                Notlar seciliNot = notlar[seciliNotIndex];
                using (var con = BaglantiOlustur())
                {
                    var cmd = new SqlCommand("DELETE FROM Notlar WHERE Id = @p1;", con);
                    cmd.Parameters.AddWithValue("@p1", seciliNot.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            NotlariListele();
            if (lstNotlar.Items.Count > 0)
            {
                lstNotlar.ClearSelected();
                int secilecekIndeks = seciliNotIndex >= lstNotlar.Items.Count ? lstNotlar.Items.Count - 1 : seciliNotIndex;
                lstNotlar.SelectedIndex = secilecekIndeks;
            }
            FormuResetle();
        }

        int duzenlenenId = 0;
        private void FormuResetle()
        {
            duzenlenenId = 0;
            txtBaslik.Clear();
            rtxtIcerik.Clear();
        }

        private void lstNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliNotIndex = lstNotlar.SelectedIndex;
            if (seciliNotIndex > -1)
            {
                duzenlenenId = notlar[seciliNotIndex].Id;
                txtBaslik.Text = notlar[seciliNotIndex].Baslik;
                rtxtIcerik.Text = notlar[seciliNotIndex].Icerik;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            string arananKelime = txtAra.Text;
            using (var con = BaglantiOlustur())
            {
                var cmd = new SqlCommand("SELECT * FROM Notlar WHERE Baslik  LIKE '%'+@text+'%' OR Icerik LIKE '%'+@text+'%'", con);
                cmd.Parameters.AddWithValue("@text", arananKelime);
                var dr = cmd.ExecuteReader();
                arananlar.Clear();
                while (dr.Read())
                {
                    arananlar.Add(new Notlar
                    {
                        Id = (int)dr["Id"],
                        Baslik = (string)dr["Baslik"],
                        Icerik = (string)dr["Icerik"]
                    });
                }
                lstNotlar.Visible = false;
                lstAranan.Visible = true;
                btnAramaIptal.Visible = true;
            }

            #region yöntem1
            //string aranan = txtAra.Text.Trim();
            //int seciliNotIndex = lstNotlar.SelectedIndex;
            //if (seciliNotIndex < 0)
            //{
            //    return;
            //}
            //using (var con = BaglantiOlustur())
            //{
            //    var cmd = new SqlCommand("SELECT * FROM Notlar WHERE Baslik LIKE '%'+@ara+'%' OR Icerik LIKE '%'+@ara+'%'", con);
            //    cmd.Parameters.AddWithValue("@ara", aranan);
            //    var sdr = cmd.ExecuteReader();
            //    notlar.Clear();
            //    NotlariListele();
            //} 
            #endregion
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {

            NotlariKaydet();
            Text = "Gunluk1.0";
        }

        private void NotlariKaydet()
        {
            int seciliNotIndex = lstNotlar.SelectedIndex;
            string duzenlenenBaslik = txtBaslik.Text.Trim();
            string duzenlenenIcerik = rtxtIcerik.Text.Trim();
            Notlar seciliNot = notlar[seciliNotIndex];
            using (var con = BaglantiOlustur())
            {
                var cmd = new SqlCommand("UPDATE Notlar SET Baslik=@p1, Icerik=@p2 WHERE Id = @p0", con);
                cmd.Parameters.AddWithValue("@p1", duzenlenenBaslik);
                cmd.Parameters.AddWithValue("@p2", duzenlenenIcerik);
                cmd.Parameters.AddWithValue("@p0", seciliNot.Id);
                cmd.ExecuteNonQuery();

            }
            if (lstAranan.Visible == true)
            {
                Notlar arananNot = arananlar[seciliNotIndex];
                using (var con = BaglantiOlustur())
                {
                    var cmd = new SqlCommand("UPDATE Notlar SET Baslik=@p1, Icerik=@p2 WHERE Id = @p0", con);
                    cmd.Parameters.AddWithValue("@p1", duzenlenenBaslik);
                    cmd.Parameters.AddWithValue("@p2", duzenlenenIcerik);
                    cmd.Parameters.AddWithValue("@p0", arananNot.Id);
                    cmd.ExecuteNonQuery();

                }
            }
            btnAramaIptal.Visible = false;
            NotlariListele();
            Text = "Günlük 1.0";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            int seciliNotIndex = lstNotlar.SelectedIndex;
            Notlar n = notlar[seciliNotIndex];
            if (rtxtIcerik.Text != n.Icerik || txtBaslik.Text != n.Baslik)
            {
                DialogResult dr = MessageBox.Show("İçerikte değişiklikler algılandı ve kaydedilmedi kaydedip çıkılsın mı ?", "Programdan Çıkılıyor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                switch (dr)
                {

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        NotlariKaydet();
                        break;
                    case DialogResult.No:
                        break;

                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Programdan çıkılsın mı ?", "Programdan Çıkılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                switch (dr)
                {

                    case DialogResult.Yes:
                        NotlariKaydet();
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;

                }
            }


        }

        private void btnAramaIptal_Click(object sender, EventArgs e)
        {
            lstAranan.Visible = false;
            btnAramaIptal.Visible = false;
            lstNotlar.Visible = true;
        }

        private void txtBaslik_TextChanged(object sender, EventArgs e)
        {
            int seciliNotIndeks = lstNotlar.SelectedIndex;
            Notlar n = notlar[seciliNotIndeks];
            if (n.Baslik != txtBaslik.Text)
            {
                Text = "Gunluk1.0(*)";
            }
            else
            {
                Text = "Gunluk1.0";
            }
        }

        private void rtxtIcerik_TextChanged(object sender, EventArgs e)
        {
            int seciliNotIndeks = lstNotlar.SelectedIndex;
            Notlar n = notlar[seciliNotIndeks];
            if (n.Icerik != rtxtIcerik.Text)
            {
                Text = "Gunluk1.0(*)";
            }
            else
            {
                Text = "Gunluk1.0";
            }
        }
    }
}
