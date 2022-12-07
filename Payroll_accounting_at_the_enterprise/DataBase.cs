using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Payroll_accounting_at_the_enterprise
{
    internal class DataBase
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-CB1C3LF\SQLEXPRESS;Initial Catalog=Payroll_accounting;Integrated Security=True");

        public void openConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Closed) // Если сейчас соединение закрыто, то мы его должны открыть
            {
                SqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open) // Если сейчас соединение открыто, то мы его должны закрыть
            {
                SqlConnection.Open();
            }
        }

        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }

    }
}
