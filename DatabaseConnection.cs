using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public static class DatabaseConnection
    {
        // Define the connection string here
        public static  string connectionString = @"Data Source=.;Initial Catalog=TaptagCaisse;Integrated Security=True;";


        // Method to get the connection string
        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}
