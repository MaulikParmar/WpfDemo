using System;

namespace ListboxDemo
{
    public class ConnectionStringConfiguration
    {
        public static String DbName
        {
            get { return "MyTestDb"; }
        }

        public static string Username
        {
            get { return "sa"; }
        }

        public static string Password
        {
            get { return "map@123"; }
        }

        public static string Server
        {
            get { return @"MAULIK-PC\MPSQL"; }
        }

        public static string ConnectionString
        {
            get { return $"Data Source={Server};Initial Catalog={DbName};Integrated Security=SSPI;User ID = {Username}; Password = {Password}; "; }
        }

    }
}
