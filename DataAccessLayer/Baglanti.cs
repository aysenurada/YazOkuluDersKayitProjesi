using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-IDTQGS1;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}
