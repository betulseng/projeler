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
	
namespace dilÖgrenmeProgrami
{
	public partial class anaEkran : MetroFramework.Forms.MetroForm
	{
		public anaEkran()
		{
			InitializeComponent();
		}

		OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Sozluk.mdb");
		bool kontrol = true;
		private void KelimeKontrol()
		{
			kontrol = true;
			baglanti.Open();
			OleDbCommand kontrolKomut = new OleDbCommand("SELECT * FROM KelimeSozlugu", baglanti);
			OleDbDataReader read;
			read = kontrolKomut.ExecuteReader();
			while (read.Read())
			{
				if(txtBoxArama.Text == read["IngKelime"].ToString() || txtBoxArama.Text == read["TrKelime"].ToString())
				{
					kontrol = false;
				}
			}
			baglanti.Close();
		}

		public void KelimeEkle()
		{
			OleDbCommand komut = new OleDbCommand();
			if (txtBoxIngEkle.Text != "" & txtBoxTrEkle.Text != "" & txtBoxIngCumleEkle.Text != "" & txtBoxTrCumleEkle.Text != "" & txtBoxTurEkle.Text != "")
			{
				komut.Connection = baglanti;
				komut.CommandText = "INSERT INTO KelimeSozlugu(IngKelime,TrKelime,IngCumle,TrCumle,KelimeTuru) VALUES ('" + txtBoxIngEkle.Text + "','" + txtBoxTrEkle.Text + "','" + txtBoxIngCumleEkle.Text + "','" + txtBoxTrCumleEkle.Text + "','" + txtBoxTurEkle.Text + "')";
				baglanti.Open();
				komut.ExecuteNonQuery();
				komut.Dispose();
				baglanti.Close();
				MetroFramework.MetroMessageBox.Show(this, "Kayıt Tamamlandı.", "UYARI", MessageBoxButtons.OK);
			}
			else
			{
				MetroFramework.MetroMessageBox.Show(this, "Boş Alan Bırakmayınız.", "UYARI", MessageBoxButtons.OK);
			}

		}

		public void KelimeListele()
		{
			baglanti.Open();
			OleDbCommand komut = new OleDbCommand();
			komut.Connection = baglanti;
			komut.CommandText = "SELECT * FROM KelimeSozlugu";
			komut.ExecuteNonQuery();
			OleDbDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				listOgrenilmemisIng.Items.Add(reader["IngKelime"] + " (" + reader["TrKelime"] + ") ");

			}
			baglanti.Close();

		}

		public void OgrenilmisKelimeListele()
		{
			baglanti.Open();
			OleDbCommand komut = new OleDbCommand();
			komut.Connection = baglanti;
			komut.CommandText = "SELECT * FROM OgrenilmisKelimeler";
			komut.ExecuteNonQuery();
			OleDbDataReader read;
			read = komut.ExecuteReader();
			while (read.Read())
			{
				listOgrenilmis.Items.Add(read["IngKelime"].ToString() +" ->  " + read["TrKelime"].ToString() +"(" + read["OgrenildigiTarih"].ToString() + ")");
			}


		}

		public void SecilenKelimeler(List<int> index)
		{
			baglanti.Open();
			OleDbCommand kelimeBulmaKomutu = new OleDbCommand("SELECT * FROM KelimeSozlugu",baglanti);
			OleDbDataReader read;
			read = kelimeBulmaKomutu.ExecuteReader();
			while(read.Read())
			{
				foreach (int indx in index)
				{
					if (indx.ToString() == read["Kimlik"].ToString())
					{
						MetroFramework.MetroMessageBox.Show(this, "Ingilizce Kelime:" + read["IngKelime"].ToString() + "Türkçe Kelime:" + read["TrKelime"].ToString() +
							"Ingilizce Cümle:" + read["IngCumle"].ToString() + "Türkçe Cümle:" + read["TrCumle"].ToString() + "Kelime Türü:" + read["KelimeTuru"].ToString());

						OleDbCommand kelimeTasiKomut = new OleDbCommand();
						kelimeTasiKomut.Connection = baglanti;
						kelimeTasiKomut.CommandText = "INSERT INTO OgrenilmisKelimeler(IngKelime,TrKelime,IngCumle,TrCumle,KelimeTuru,OgrenildigiTarih) VALUES ('" + read["IngKelime"].ToString() + "','" +
							read["TrKelime"].ToString() + "','" + read["IngCumle"].ToString() + "','" + read["TrCumle"].ToString() + "','" + read["KelimeTuru"].ToString() + "','" + DateTime.Today.ToString() + "')";
						kelimeTasiKomut.ExecuteNonQuery();
						kelimeTasiKomut.Dispose();
		
					}
				}
			}
			baglanti.Close();
		}

		public void kelimeIndexleri()
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			KelimeListele();
			OgrenilmisKelimeListele();

		}


		private void tileOgrenmeyeBasla_Click(object sender, EventArgs e)
		{
			OgrenilmisKelimeListele();
			
		}

		private void tileSinavaGit_Click(object sender, EventArgs e)
		{
			sinavEkrani sinavE = new sinavEkrani();
			sinavE.Show();
		}

		private void tileYeniKelimeEkle_Click(object sender, EventArgs e)
		{
			KelimeEkle();
		}

		private void listOgrenilmemisIng_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index;
			index = listOgrenilmemisIng.SelectedIndex;
			List<int> secilenKelimeIndexleri = new List<int>();
			secilenKelimeIndexleri.Add(index);
			SecilenKelimeler(secilenKelimeIndexleri);
		}

		private void txtBoxArama_TextChanged(object sender, EventArgs e)
		{

		
		}

		private void tabControlOgrenilmemis_Click(object sender, EventArgs e)
		{

		}

		private void tileAra_Click(object sender, EventArgs e)
		{
			KelimeKontrol();
			if(kontrol == true)
			{
				MetroFramework.MetroMessageBox.Show(this, "Kelime Bulunamadı" + Environment.NewLine + "Yeni Kelime Ekleyebilirsiniz.", "UYARI");
				tileYeniKelimeEkle.Visible = true;
			}
			else
			{
				MetroFramework.MetroMessageBox.Show(this, "Kelime Sözlükte Mevcuttur.","UYARI");
				tileYeniKelimeEkle.Visible = false;
			}
		}

		private void tileListeYenile_Click(object sender, EventArgs e)
		{
			KelimeListele();
			MetroFramework.MetroMessageBox.Show(this, "Kelime Listesi Güncellendi.", "UYARI");
		}
	}
}
