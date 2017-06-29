using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.DAL
{
    internal sealed class ConnectionManager
    {

        public static SqlConnection GetConnection() // bu methodu static yapmamın nedeni ConnectionManagerden yeni bir insitance oluşturmadan direk sınıftan ulaşabilmemi sağladığı için
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;                                                                              
            SqlConnection connection = new SqlConnection(connectionString);

            connection.StateChange += new System.Data.StateChangeEventHandler(Util.Logger.LogConnectionStateChange);
            connection.Open();
            return connection;
        }


      
    }
}
