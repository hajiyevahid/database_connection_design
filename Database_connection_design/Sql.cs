namespace Database_connection_design
{
    public class Sql : DBconnection_string
    {
        public override void Open()
        {
            System.Console.WriteLine("Sql connection is opened !");

        }
        public override void Close()
        {
            System.Console.WriteLine("Sql connection is closed !");

        }
    }

}
