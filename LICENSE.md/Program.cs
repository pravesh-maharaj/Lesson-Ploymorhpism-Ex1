using System;

namespace Polymorphyism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson: Excersise 1 Polymorphyism");
            var sqlConnection = new SqlConnection("//localhard...");
            sqlConnection.ConnectionOpen();
            sqlConnection.ConnectionClose();

            System.Console.WriteLine("================");
            var oracleConnection = new OracleConnection(null);
            sqlConnection.ConnectionOpen();
            sqlConnection.ConnectionClose();

        }
    }
}
