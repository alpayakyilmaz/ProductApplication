using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.DAL
{
    internal sealed class ProductDAL
    {
        public static int GetProductCount()
        {
            int value = 0;
            string sql = "SELECT COUNT(*) FROM Production.Product WHERE ListPrice > 0";

            // using içerisinde kullandığım işlemleri süslü parantez dışına çıkar çıkmaz imha eder connection sınıfını kapat dememize gerek kalmaz
            using (SqlConnection conn = ConnectionManager.GetConnection())
            {
                using(SqlCommand command = new SqlCommand(sql,conn))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    value = (int)command.ExecuteScalar();

                }
            }

            return value;

        }

        public static BL.ProductSummaryStatistic GetProductSummary()
        {
            object[] summaryStats = new Object[4];

            string sql = "SELECT Count(*), MIN(ListPrice),MAX(ListPrice),AVG(ListPrice) FROM Production.Product WHERE ListPrice > 0";
            using(SqlCommand command = new SqlCommand(sql,ConnectionManager.GetConnection()))
            {
                command.CommandType = System.Data.CommandType.Text;
                using(SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleRow))
                {
                    reader.Read();
                    reader.GetValues(summaryStats);

                }
            }

            BL.ProductSummaryStatistic pss = new BL.ProductSummaryStatistic("all products",(int)summaryStats[0]
                                                                            ,(decimal)summaryStats[1],
                                                                            (decimal)summaryStats[2],
                                                                            (decimal)summaryStats[3]);

            return pss;
        }

    }
}
