using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Pegawai
    {
        #region Fields
        private int id;
        private string nama;
        private string email;
        private string password;
        private string telepon;
        private byte[] images;
        #endregion

        #region Constructors
        public Pegawai(int id, string nama, string email, string password, string telepon, byte[] images)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Password = password;
            this.Telepon = telepon;
            this.Images = images;
        }

        public Pegawai(int id, string nama, string email, string telepon, byte[] images)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Telepon = telepon;
            this.Images = images;
        }

        public Pegawai(string nama, string email, string password, string telepon, byte[] images)
        {
            this.Nama = nama;
            this.Email = email;
            this.Password = password;
            this.Telepon = telepon;
            this.Images = images;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Telepon { get => telepon; set => telepon = value; }
        public byte[] Images { get => images; set => images = value; }
        #endregion

        #region Methods
        public static List<Pegawai> BacaData(string kriteria, string nilaiKriteria, Connection cdb)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from pegawais";
            }
            else
            {
                sql = "select * from pegawais where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            List<Pegawai> listPegawai = new List<Pegawai>();

            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(), (byte[])hasil.GetValue(5));
                listPegawai.Add(p);
            }
            hasil.Dispose();
            hasil.Close();
            return listPegawai;
        }


        public static Pegawai AmbilData(string username, string password, Connection cdb)
        {
            string sql = "select id, nama, email, password, telepon, image from pegawais where Email = '" +
                         username + "' AND Password = SHA2('" + password + "', 512)";
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql,cdb);
            Pegawai p = null;
            while (hasil.Read() == true)
            {
                p = new Pegawai(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3),
                    hasil.GetString(4), (byte[])hasil.GetValue(5));
            }
            hasil.Dispose();
            hasil.Close();
            return p;
        }

        public static bool CekLogin(string username, string password, Connection cdb)
        {
            Pegawai p = AmbilData(username, password, cdb);
            while (p != null)
                return true;
            return false;
        }
        public static void TambahData(Pegawai p,Connection cdb)
        {
            string sql = "insert into pegawais (Nama, Email, Password, Telepon, image) " +
                "values ('" + p.Nama + "', '" + p.Email + "', SHA2('" + p.Password + "', 512), '" + p.Telepon + "', @image)";
            Connection.JalankanPerintahDML(sql, p.Images, cdb);
        }
        public static void UbahData(Pegawai p, Connection cdb)
        {
            string sql = "update pegawais set nama = '" + p.Nama + "', email = '" + p.Email + "', password = SHA2('" + p.Password + "', 512), telepon = '" + p.Telepon + "' where id = '" + p.Id + "'";
            Connection.JalankanPerintahDML(sql, p.Images, cdb);
        }
        public static Boolean HapusData(string id, Connection cdb)
        {
            string perintah = "delete from pegawais where id='" + id + "'";
            int jumlahDataBerubah = Connection.JalankanPerintahDML(perintah, cdb);
            if (jumlahDataBerubah == 0)
                return false;
            return true;
        }
        #endregion
    }
}
