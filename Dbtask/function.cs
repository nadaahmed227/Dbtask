using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbtask
{
    internal class function
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda; 
        private string Constr; 
        public functions()
        {

            Constr = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\bahgat\\source\\repos\\Dbtask\\Dbtask\\EmpDb.mdf;Integrated Security=True;Connect Timeout=30"
            Constr = new SqlConnection(Constr); 

        }
    } 

}
