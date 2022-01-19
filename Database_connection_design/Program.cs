using System;

namespace Database_connection_design
{

    class Program
    {
       
        static void Main(string[] args)
        {
            var sql = new Sql();
            sql.Open();
            sql.Close();
            var oracle = new Oracle();
            oracle.Open();
            oracle.Close();
            
        }
    }
}
