namespace Database_connection_design
{
    public class Oracle : DBconnection_string
    {
        public override void Open()
        {
            System.Console.WriteLine("Oracle connection is opened !");
        }


        public override void Close()
        {
            System.Console.WriteLine("Oracle connection is closed !");

        }


    }
}
