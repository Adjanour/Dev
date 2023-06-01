using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HostelApp
{
    public class ConnectionStringParameters
    {
        public static  SqlConnection connStrx = new SqlConnection("Data source = KIRKPC\\SALEMSERVER; Initial catalog = dbHostelRoomAllocator ; Integrated security = True;");

        public static bool  OpenConnection()
        {
            
            try
            {
                if ( connStrx.State == System.Data.ConnectionState.Open | connStrx.State == System.Data.ConnectionState.Closed)
                {
                    connStrx.Close();
                    connStrx.Open();
                    return true;
                }
                
            }
            catch (SqlException )
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
