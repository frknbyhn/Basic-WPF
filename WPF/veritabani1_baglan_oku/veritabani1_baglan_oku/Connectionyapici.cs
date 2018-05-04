using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient ;
namespace veritabani1_baglan_oku
{
    class Connectionyapici
    {
        public SqlConnection baglantiyagec()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\okul11a.mdf;Integrated Security=True;User Instance=True";
            return baglanti;
        }
    }
}
