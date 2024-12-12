using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp12
{
    internal class sqlbağlantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-U1IT6GI8;Initial Catalog=OgrenciIsleri;Integrated Security=True;");
            baglan.Open();
            return baglan;    
        }
    }
}
