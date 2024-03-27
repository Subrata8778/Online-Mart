using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class MetodePembayaran
    {
        #region Fields
        private int id;
        private string nama;
        #endregion

        #region Constructors
        public MetodePembayaran(int id, string nama)
        {
            this.Id = id;
            this.Nama = nama;
        }

        public MetodePembayaran(string nama)
        {
            this.Nama = nama;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Methods
        public static List<MetodePembayaran> BacaData(string kriteria, string nilaiKriteria, Connection cdb)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from metode_pembayarans";
            }
            else
            {
                sql = "select * from metode_pembayarans where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            List<MetodePembayaran> listMetodePembayaran = new List<MetodePembayaran>();

            while (hasil.Read() == true)
            {
                MetodePembayaran k = new MetodePembayaran(hasil.GetInt32(0), hasil.GetValue(1).ToString());
                listMetodePembayaran.Add(k);
            }
            hasil.Dispose();
            hasil.Close();
            return listMetodePembayaran;
        }

        public static Boolean HapusData(int id,Connection cdb)
        {
            string sql = "delete from metode_pembayarans where id = " + id;
            int jumlahDataBerubah = Connection.JalankanPerintahDML(sql, cdb);
            if (jumlahDataBerubah == 0)
                return false;
            return true;
        }

        public static void TambahData(MetodePembayaran mp, Connection cdb)
        {
            string sql = "insert into metode_pembayarans (nama) values ('" + mp.Nama.Replace("'", "\\'") + "')";
            Connection.JalankanPerintahDML(sql, cdb);
        }

        public static void UbahData(MetodePembayaran mp, Connection cdb)
        {
            string sql = "update metode_pembayarans set nama = '" + mp.Nama.Replace("'", "\\'")
                + "' where id = " + mp.Id;
            Connection.JalankanPerintahDML(sql, cdb);
        }
        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
