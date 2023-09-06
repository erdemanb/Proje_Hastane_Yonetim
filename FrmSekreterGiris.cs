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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreterler where sekreterTC=@p1 and sekreterSifre = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTCsekreter.Text);
            komut.Parameters.AddWithValue("@p2", txtSekreterSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.TCnumara = mskTCsekreter.Text;
                frs.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı kimlik veya şifre!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
        }
    }
}
