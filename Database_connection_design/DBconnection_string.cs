using System;

namespace Database_connection_design
{
    public abstract class DBconnection_string
    {
       public string connection_String { get; set; } = "this is a connection string :) ";
       public TimeSpan time_out { get; set; }
       

        public DBconnection_string()
        {
            if (string.IsNullOrEmpty(connection_String.ToString()))
            {
                throw new Exception("Please supply a valid connection string !");
            }
        }

       
        public abstract void Open();

        public abstract void Close();

    }




}
