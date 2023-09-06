using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void linkLblUyelik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where hastaTC = @p1 and hastaSifre = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTChasta.Text);
            komut.Parameters.AddWithValue("@p2", txtSifreHasta.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = mskTChasta.Text;
                fr.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı kimlik veya şifre!","Kayıt Bulunamadı.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            bgl.baglanti().Close();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
