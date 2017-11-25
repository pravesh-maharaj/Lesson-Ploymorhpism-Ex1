namespace Polymorphyism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void ConnectionClose()
        {
            System.Console.WriteLine("Close connection to Oracle db");
        }

        public override void ConnectionOpen()
        {
            System.Console.WriteLine("Open connection to Oracle db");
        }
    }
}
