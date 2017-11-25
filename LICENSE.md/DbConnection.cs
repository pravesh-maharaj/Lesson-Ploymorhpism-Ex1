using System;

namespace Polymorphyism
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }

        //constructor
        public DbConnection(string connectionString)
        {
            if(connectionString == null || connectionString=="")
            {
                throw new InvalidOperationException("Connection cannot be null or blank");
            }
            else{
                ConnectionString = connectionString;
            }
        }
        //method for db connection time-out
        //abstract methods
        public abstract void ConnectionOpen();
        public abstract void ConnectionClose();

    }
}
