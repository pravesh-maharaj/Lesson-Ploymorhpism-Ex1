using System;

namespace Polymorphyism
{
 public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void ConnectionClose()
        {
            System.Console.WriteLine("Close connection to SQL Server");
        }

        public override void ConnectionOpen()
        {
            System.Console.WriteLine("Open connection to SQL Server");
        }
    }
}