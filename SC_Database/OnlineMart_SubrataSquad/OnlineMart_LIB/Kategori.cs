using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Kategori
    {
        #region Fields
        private int id;
        private string nama;
        #endregion

        #region Constructors
        public Kategori(int id, string nama)
        {
            this.Id = id;
            this.Nama = nama;
        }

        public Kategori(string nama)
        {
            this.Nama = nama;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Methods
        public static List<Kategori> BacaData(string kriteria, string nilaiKriteria,Connection cdb)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from kategoris";
            }
            else
            {
                sql = "select * from kategoris where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            List<Kategori> listKategori = new List<Kategori>();

            while (hasil.Read() == true)
            {
                Kategori k = new Kategori(hasil.GetInt32(0), hasil.GetValue(1).ToString());
                listKategori.Add(k);
            }
            hasil.Dispose();
            hasil.Close();
            return listKategori;
        }

        public static Boolean HapusData(string code, Connection cdb)
        {
            string sql = "delete from kategoris where id='" + code + "'";
            int jumlahDataBerubah = Connection.JalankanPerintahDML(sql, cdb);
            if (jumlahDataBerubah == 0)
                return false;
            return true;
        }

        public static void TambahData(Kategori k, Connection cdb)
        {
            string sql = "insert into kategoris (nama) values ('" + k.Nama.Replace("'", "\\'") + "')";
            Connection.JalankanPerintahDML(sql, cdb);
        }

        public static void UbahData(Kategori k, Connection cdb)
        {
            string sql = "update kategoris set nama = '" + k.Nama.Replace("'", "\\'")
                + "' where id = " + k.Id;
            Connection.JalankanPerintahDML(sql, cdb);
        }
        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
