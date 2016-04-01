/*
    File: DataAccess.cs
    Name: Steven Johnston, Matthew Warren
    Assingment: Final project milestone one
    Date: 3/18/2016
*/
using System.Data.SqlClient;

namespace Prestige_YoYo
{

    class DataAccess
    {
        SqlConnection con;
        /// <summary>
        /// Creates a connection to the database
        /// </summary>
        /// <param name="server"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="databaseName"></param>
        public DataAccess(string server,string userName, string password, string databaseName)
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=" + server + "; Database=" + databaseName + "; User ID=" + userName + "; Password=" + password + ";";
            con.Open();
        }
        /// <summary>
        /// Inserts a product log. using stored procedure
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string InsertLog(string data)
        {
            string message = "";
            string[] logData = data.Split(',');

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddLog";

                //Used to return success/errors from database
                SqlParameter returnParam = new SqlParameter("@returnMessage",System.Data.SqlDbType.VarChar,1024);
                returnParam.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.Add(new SqlParameter("@factoryName",logData[0]));
                cmd.Parameters.Add(new SqlParameter("@serial", logData[1]));
                cmd.Parameters.Add(new SqlParameter("@lineName", logData[2]));
                cmd.Parameters.Add(new SqlParameter("@machineName", logData[3]));
                cmd.Parameters.Add(new SqlParameter("@reason", logData[4]));
                cmd.Parameters.Add(new SqlParameter("@dateTime", logData[5]));
                cmd.Parameters.Add(returnParam);

                cmd.ExecuteNonQuery();

                message = (string)returnParam.Value;
            }
            return message;
        }  
    }
}
