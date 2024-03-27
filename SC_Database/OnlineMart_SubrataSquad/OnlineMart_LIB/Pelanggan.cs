using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Pelanggan
    {
        #region Fields
        private int id;
        private string nama;
        private string email;
        private string password;
        private string telepon;
        private float saldo;
        private int poin;
        private byte[] images;
        #endregion

        #region Constructors
        public Pelanggan(int id, string nama, string email, string password, string telepon, float saldo, int poin, byte[] images)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Password = password;
            this.Telepon = telepon;
            this.Saldo = saldo;
            this.Poin = poin;
            this.Images = images;
        }
        public Pelanggan(string nama, string email, string password, string telepon, float saldo, int poin, byte[] images)
        {
            this.Nama = nama;
            this.Email = email;
            this.Password = password;
            this.Telepon = telepon;
            this.Saldo = saldo;
            this.Poin = poin;
            this.Images = images;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama 
        { 
            get => nama;
            set
            {
                if(value != null && value != "")
                {
                    nama = value;
                }
                else
                {
                    throw new ArgumentException("Please input your name.");
                }
            } 
        }
        public string Email 
        { 
            get => email;
            set
            {
                if (value != null && value != "")
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Please input your email.");
                }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Length >=8)
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentException("Password must be at least 8 char.");
                }
            }
        }
        public string Telepon { get => telepon; set => telepon = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public int Poin { get => poin; set => poin = value; }
        public byte[] Images { get => images; set => images = value; }
        #endregion

        #region Methods
        public static List<Pelanggan> BacaData(string kriteria, string nilaiKriteria, Connection cdb)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from pelanggans";
            }
            else
            {
                sql = "select * from pelanggans where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);

            List<Pelanggan> listPelanggan = new List<Pelanggan>();
            while (hasil.Read() == true)
            {
                Pelanggan k = new Pelanggan(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(), hasil.GetFloat(5), hasil.GetInt32(6), (byte[])hasil.GetValue(7));
                listPelanggan.Add(k);
            }
            hasil.Dispose();
            hasil.Close();
            return listPelanggan;
        }
        public static Pelanggan AmbilData(string username, string password, Connection cdb)
        {
            string sql = "select id, nama, email, password, telepon, saldo, poin, image from pelanggans where Email = '" +
                         username + "' AND Password = SHA2('" + password + "', 512)";
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            Pelanggan pel = null;
            while (hasil.Read() == true)
            {
                pel = new Pelanggan(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3),
                    hasil.GetString(4), hasil.GetFloat(5), hasil.GetInt32(6), (byte[])hasil.GetValue(7));
            }
            hasil.Dispose();
            hasil.Close();
            return pel;
        }
        public static bool CekLogin(string username, string password, Connection cdb)
        {
            Pelanggan pel = AmbilData(username, password, cdb);
            if (pel !=null)
            {
                return true;
            }
            return false;
        }
        public static void TambahData(Pelanggan pel, Connection cdb)
        {
            string sql = "insert into pelanggans (Nama, Email, Password, Telepon, Saldo, Poin) " +
                "values ('" + pel.Nama + "', '" + pel.Email + "', SHA2('" + pel.password + "', 512), '" + pel.Telepon +
                "', '" + pel.saldo + "', '" + pel.Poin + "', @image)";
            Connection.JalankanPerintahDML(sql, pel.Images, cdb);
        }
        public static void UbahData(Pelanggan p, Connection cdb)
        {
            string sql = "update pelanggans set nama = '" + p.Nama + "', email = '" + p.Email + "', password = SHA2('" + p.password + "', 512), telepon = '" + p.Telepon + "', saldo = '" + p.Saldo + "', poin = '" + p.Poin + "', Image = @image where id = '" + p.Id + "'";
            Connection.JalankanPerintahDML(sql, p.Images, cdb);
        }
        public static Boolean HapusData(string id, Connection cdb)
        {
            string perintah = "delete from pelanggans where id='" + id + "'";
            int jumlahDataBerubah = Connection.JalankanPerintahDML(perintah, cdb);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            return true;
        }
        public static void UpdateSaldo(float nominal, int id, Connection cdb)
        {
            string sql = "update pelanggans set saldo = saldo + " + nominal + " where id = " + id;
            Connection.JalankanPerintahDML(sql,cdb);
        }

        public static void TambahPoin(float totalHarga, Pelanggan p, Connection cdb)
        {
            p.Poin += (int)totalHarga / 10000;
            string sql = "update pelanggans set poin = " + p.Poin + " where id = " + p.Id;
            Connection.JalankanPerintahDML(sql, cdb);
        }
        public static void kurangiSaldo(float nominal, int id, Connection cdb)
        {
            string sql = "update pelanggans set saldo = saldo - " + nominal + " where id = " + id;
            Connection.JalankanPerintahDML(sql, cdb);
        }
        public static Pelanggan AmbilPelangganById(int id, Connection cdb)
        {
            string sql = "select * from pelanggans where id  like " + id;
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            Pelanggan pel = null;
            if (hasil.Read() == true)
            {
               pel = new Pelanggan(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(), hasil.GetFloat(5), hasil.GetInt32(6), (byte[])hasil.GetValue(7));
            }
            hasil.Dispose();
            hasil.Close();
            return pel;
        }
        public static Pelanggan AmbilPelangganByUsername(string username, Connection cdb)
        {
            string sql = "select * from pelanggans where email = '" + username + "'";
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            Pelanggan pelanggan = null;
            if (hasil.Read() == true)
            {
                pelanggan = new Pelanggan(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(), hasil.GetFloat(5), hasil.GetInt32(6), (byte[])hasil.GetValue(7));
            }
            hasil.Dispose();
            hasil.Close();
            return pelanggan;
        }
        public static bool CheckId(string username, Connection cdb)
        {
            Pelanggan pel = AmbilPelangganByUsername(username, cdb);
            if (pel !=null)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
