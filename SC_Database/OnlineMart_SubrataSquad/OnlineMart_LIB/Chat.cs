using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace OnlineMart_LIB
{
    public class Chat
    {
        private Pelanggan pelanggan;
        private Driver driver;
        private List<string> listChat;
        private List<string> listStatus;
        private string pengirim;

        public Chat(Pelanggan pelanggan, Driver driver)
        {
            this.Pelanggan = pelanggan;
            this.Driver = driver;
            this.ListChat = new List<string>();
            this.listStatus = new List<string>();
            this.Pengirim = "";
        }

        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public List<string> ListChat { get => listChat; set => listChat = value; }
        public List<string> ListStatus { get => listStatus; set => listStatus = value; }
        public string Pengirim { get => pengirim; set => pengirim = value; }

        public void BacaPesan()
        {
            string sql = "";
            sql = "select c.tanggal, concat(date_format( c.tanggal, '[%d/%m, %H:%i] ')" + " " + ", p.nama,' : ', c.pesan) as pesan" +
                       " from chats c " +
                       " inner join pelanggans p on c.pelanggan = p.id " +
                       " inner join drivers d on d.id = c.driver " +
                       " where c.pelanggan = " + Pelanggan.Id + " and c.driver = " + Driver.Id + " and c.pengirim = "+"'Pelanggan'"+
                       " union" +
                       " select c.tanggal, concat(date_format(c.tanggal, '[%d/%m, %H:%i] ')" + " " + ", d.nama,' : ', c.pesan) as pesan" +
                       " from chats c " +
                       " inner join pelanggans p on c.pelanggan = p.id " +
                       " inner join drivers d on d.id = c.driver " +
                       " where c.pelanggan = " + Pelanggan.Id + " and c.driver = " + Driver.Id + " and c.pengirim = " + "'Driver'" +
                       " order by tanggal";

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            while (hasil.Read())
            {
                ListChat.Add(hasil.GetString(1));
            }
        }
        public int TambahPesan(string chat, string pengirim, Connection cdb)
        {
            string sql = "";
            sql = "Insert into chats(tanggal, pelanggan,driver, pesan, pengirim) values('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," + Pelanggan.Id + "," + Driver.Id + ",'" + chat + "','"+ pengirim + "')";
            int hasil = Connection.JalankanPerintahDML(sql, cdb);
            return hasil;
        }
        public void UpdateData(string penerima,Connection cdb)
        {
            string sql = "Update chats set status = 'Seen' where pengirim = '"+ penerima + "' and driver = "+Driver.Id + " and pelanggan = "+ Pelanggan.Id;
            Connection.JalankanPerintahDML(sql, cdb);
        }
        public void BacaStatus(string pengirim)
        {
            string sql = "";
            sql = "select c.status " +
                       "from chats c " +
                       "inner join pelanggans p on c.pelanggan = p.id " +
                       "inner join drivers d on d.id = c.driver " +
                       " where c.pelanggan = " + Pelanggan.Id + " and c.driver = " + Driver.Id + " and c.pengirim = " + "'" + pengirim + "'";

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            while (hasil.Read())
            {
                ListStatus.Add(hasil.GetString(0));
            }
        }
    }
}
