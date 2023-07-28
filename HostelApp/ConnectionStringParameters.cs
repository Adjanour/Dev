using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace HostelApp
{
    public class ConnectionStringParameters
    {
        public static SqlConnection connStrx = new SqlConnection("Data Source=KIRKPC\\SALEMSERVER;Initial Catalog=dbHostelRoomAllocator;Integrated Security = True ; TrustServerCertificate=True");


        public static bool OpenConnection()
        {

            try
            {
                if (connStrx.State == System.Data.ConnectionState.Open || connStrx.State == System.Data.ConnectionState.Closed)
                {
                    connStrx.Open();
                    return true;
                }

            }
            catch (SqlException)
            {
                return false;
            }
            return true;

        }
        public static bool CloseConnection()
        {
            try
            {
                connStrx.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}