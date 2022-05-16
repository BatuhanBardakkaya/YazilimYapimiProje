using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Temel6SigmaQuizSorularınınBelirlenmeAlgoritması
{
    class sqlBaglantisi
    {
        public static SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-D3S9ESL2;Initial Catalog=birleştirmeDeneme2;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
