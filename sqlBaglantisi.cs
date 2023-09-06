using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(""); //Buraya veritabanı adresi girilmeli!
            baglan.Open();
            return baglan;
        }
        // sqlBaglantisi sınıfın adı, baglanti metodun adı, baglan SqlConnection sınıfından türettiğim ve benim adresimi tutan nesnemin adı, Open bir metod, return de geriye dönen değeri tutan kısım.
    }
}
