using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace OnlineMart_LIB
{
    public class Connection
    {
        #region Fields
        private MySqlConnection conDB;
        #endregion

        #region Constructor
        public Connection()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingsSection = userSettings.Sections["OnlineMart_SubrataSquad.Db"] as ClientSettingsSection;

            string DbServer = settingsSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingsSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingsSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername + ";password=" + DbPassword + ";SSL Mode=None";
            ConDB = new MySqlConnection();
            ConDB.ConnectionString = strCon;
            Connect();
        }
        #endregion

        #region Properties
        public MySqlConnection ConDB { get => conDB; private set => conDB = value; }
        #endregion

        #region Methods
        public void Connect()
        {
            if (ConDB.State == System.Data.ConnectionState.Open)
            {
                ConDB.Close();
            }
            ConDB.Open();
        }
        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Connection k = new Connection();
            MySqlCommand c = new MySqlCommand(sql, k.ConDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }
        public static MySqlDataReader JalankanPerintahQuery(string sql, Connection cdb)
        {
            MySqlCommand c = new MySqlCommand(sql, cdb.ConDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }
        //public static int JalankanPerintahDML(string sql)
        //{
        //    Connection k = new Connection();
        //    MySqlCommand c = new MySqlCommand(sql, k.ConDB);
        //    int hasil = 0;
        //    hasil = c.ExecuteNonQuery();
        //    return hasil;
        //}
        public static int JalankanPerintahDML(string sql, Connection cdb)
        {
            MySqlCommand c = new MySqlCommand(sql, cdb.ConDB);
            int hasil = 0;
            hasil = c.ExecuteNonQuery();
            return hasil;
        }
        public static int JalankanPerintahDML(string sql, byte[] img, Connection cdb)
        {
            MySqlCommand c = new MySqlCommand(sql, cdb.ConDB);
            c.Parameters.AddWithValue("@image", img);
            int hasil = 0;
            hasil = c.ExecuteNonQuery();
            return hasil;
        }
        #endregion
    }
}
