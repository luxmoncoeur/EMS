using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.CRUD
{
    class connection
    {
        static string dbPath = @"C:\DBLOCAL\EMS1.accdb";
        public static string conString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";

        public static OleDbConnection mysqldb()
        {
            return new OleDbConnection(conString);
        }
        public static OleDbConnection con = mysqldb();
    }
}
