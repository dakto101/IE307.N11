using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace IE307.N11.Services
{
    public class DatabaseService
    {
        public DatabaseService()
        {

        }

        public static void DBTest()
        {
            try
            {
                string cs = @"server=192.168.1.252;uid=root;pwd=null;database=authme";

                MySqlConnection con = new MySqlConnection(cs);
                con.Open();
            }
            catch (Exception e)
            {
                App.Current.MainPage.DisplayAlert("Info", "Error: " + e.Message, "OK");
            }
            finally
            {
                App.Current.MainPage.DisplayAlert("Info", "Success", "OK");
            }
        }
    }
}
