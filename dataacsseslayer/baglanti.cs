using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dataacsseslayer
{
    internal class baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dbkatpersonel;Integrated Security=True");
    }
}
