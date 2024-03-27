using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace OnlineMart_LIB
{
    public class Barang
    {
        #region Fields
        private int id;
        private string nama;
        private string harga;
        private Kategori kategori;
        private byte[] images;
        #endregion

        #region Constructors
        public Barang(int id, string nama, string harga, Kategori kategori, byte[] images)
        {
            this.Id = id;
            this.Nama = nama;
            this.Harga = harga;
            this.Kategori = kategori;
            this.Images = images;
        }

        public Barang(string nama, string harga, Kategori kategori, byte[] images)
        {
            this.Nama = nama;
            this.Harga = harga;
            this.Kategori = kategori;
            this.Images = images;
        }

        public Barang()
        {
            this.Nama = "";
            this.Harga = "";
            this.Kategori = null;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Harga { get => harga; set => harga = value; }
        public Kategori Kategori { get => kategori; set => kategori = value; }
        public byte[] Images { get => images; set => images = value; }
        #endregion

        #region Methods
        public static List<Barang> BacaData(string kriteria, string nilaiKriteria, Connection cdb)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select B.id, B.Nama, B.Harga, B.Image, K.id, K.Nama as Nama from barangs B inner join kategoris K on B.kategoris_id = K.id";
            }
            else
            {
                sql = "select B.id, B.Nama, B.Harga, B.Image, K.id, K.Nama as Nama from barangs B inner join kategoris K on B.kategoris_id = K.id where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            List<Barang> listBarang = new List<Barang>();

            while (hasil.Read() == true)
            {
                Kategori k = new Kategori(hasil.GetInt32(4), hasil.GetString(5));
                if (hasil.GetValue(3) != null)
                {
                    Barang b = new Barang(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), k, (byte[])hasil.GetValue(3));
                    listBarang.Add(b);
                }
                else
                {
                    Barang b = new Barang(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), k, null);
                    listBarang.Add(b);
                }
            }
            hasil.Dispose();
            hasil.Close();
            return listBarang;
        }

        public static List<Barang> BacaBarangTerlaris(List<int> listId, Connection cdb)
        {
            string sql = "select B.id, B.Nama, B.Harga, B.Image, K.id, K.Nama as Nama from barangs B inner join kategoris K on B.kategoris_id = K.id";

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            List<Barang> listBarang = new List<Barang>();

            while (hasil.Read() == true)
            {
                Kategori k = new Kategori(hasil.GetInt32(4), hasil.GetString(5));
                if (hasil.GetValue(3) != null)
                {
                    Barang b = new Barang(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), k, (byte[])hasil.GetValue(3));
                    for (int i = 0; i <= 3; i++)
                    {
                        if (b.Id == listId[i])
                        {
                            listBarang.Add(b);
                        }
                    }
                }
                else
                {
                    Barang b = new Barang(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), k, null);
                    for (int i = 0; i <= 3; i++)
                    {
                        if (b.Id == listId[i])
                        {
                            listBarang.Add(b);
                        }
                    }
                    listBarang.Add(b);
                }
            }
            hasil.Dispose();
            hasil.Close();
            return listBarang;
        }


        public static void TambahData(Barang b, Connection cdb)
        {
            string sql = "insert into barangs (Nama, Harga, Kategoris_Id, Image)" +
                  " values ('" + b.Nama + "', '" + b.Harga + "', '" + b.Kategori.Id + "', @image)";

            Connection.JalankanPerintahDML(sql, b.Images, cdb);
        }

        //public static Barang AmbilDataByKode(string kode)
        //{
        //    string sql = "select * from barangs where Id = '" + kode + "'";
        //    MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
        //    if (hasil.Read() == true)
        //    {
        //        Kategori k = new Kategori(hasil.GetInt32(3), hasil.GetString(4));
        //        Barang b = new Barang(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), k);
        //        return b;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        public static void UbahData(Barang b, Connection cdb)
        {
            string sql = "update barangs set Nama = '" + b.Nama + "', Harga = '" + b.Harga +
                "', kategoris_id = " + b.Kategori.Id + ", Image = @image where id = " + b.Id;

            Connection.JalankanPerintahDML(sql, b.images, cdb);
        }

        public static Boolean HapusData(string id, Connection cdb)
        {
            string perintah = "delete from barangs where id = '" + id + "'";
            int jumlahDataBerubah = Connection.JalankanPerintahDML(perintah, cdb);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
