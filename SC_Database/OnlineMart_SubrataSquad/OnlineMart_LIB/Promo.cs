using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Promo
    {
        #region Fields
        private int id;
        private string tipe;
        private string nama;
        private int diskon;
        private int diskon_max;
        private float min_belanja;
        #endregion

        #region Construtors
        public Promo(int id, string tipe, string nama, int diskon, int diskon_max, float min_belanja)
        {
            this.Id = id;
            this.Tipe = tipe;
            this.Nama = nama;
            this.Diskon = diskon;
            this.Diskon_max = diskon_max;
            this.Min_belanja = min_belanja;
        }

        public Promo(string tipe, string nama, int diskon, int diskon_max, float min_belanja)
        {
            this.Tipe = tipe;
            this.Nama = nama;
            this.Diskon = diskon;
            this.Diskon_max = diskon_max;
            this.Min_belanja = min_belanja;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Tipe { get => tipe; set => tipe = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Diskon { get => diskon; set => diskon = value; }
        public int Diskon_max { get => diskon_max; set => diskon_max = value; }
        public float Min_belanja { get => min_belanja; set => min_belanja = value; }
        #endregion

        #region Methods
        public static List<Promo> BacaData(string kriteria, string nilaiKriteria, Connection cdb)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from promos";
            }
            else
            {
                sql = "select * from promos where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);

            List<Promo> listPromo = new List<Promo>();
            while (hasil.Read() == true)
            {
                Promo k = new Promo(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetInt32(3), hasil.GetInt32(4), hasil.GetFloat(5));
                listPromo.Add(k);
            }
            hasil.Dispose();
            hasil.Close();
            return listPromo;
        }
        public static void TambahData(Promo p, Connection cdb)
        {
            string sql = "insert into promos (id, tipe, nama, diskon, diskon_max, minimal_belanja) values ('" + p.Id + "','" + p.Tipe.Replace("'", "\\'") + "','" + p.Nama.Replace("'", "\\'") + "','" + p.Diskon + "','" + p.Diskon_max + "','" + p.Min_belanja + "')";
            Connection.JalankanPerintahDML(sql, cdb);
        }
        public static void UbahData(Promo p, Connection cdb)
        {
            string sql = "update promos set Tipe = '" + p.Tipe + "', nama = '" + p.Nama + "', diskon = '" + p.Diskon + "', diskon_max = '" + p.Diskon_max + "', minimal_belanja = '" + p.Min_belanja + "' where id = '" + p.Id + "'";
            Connection.JalankanPerintahDML(sql, cdb);
        }


        public static Boolean HapusData(string id, Connection cdb)
        {
            string perintah = "delete from promos where id='" + id + "'";
            int jumlahDataBerubah = Connection.JalankanPerintahDML(perintah, cdb);
            if (jumlahDataBerubah == 0)
                return false;
            return true;
        }
        public static int HitungDiskon(Promo promo, float totalHarga, List<Keranjang> listKeranjang)
        {
            int diskon = 0;

            if (totalHarga >= promo.Min_belanja)
            {
                if (promo.Tipe == "Ongkir")
                {
                    diskon = (int)totalHarga * promo.Diskon / 100;
                    if (diskon > promo.Diskon_max)
                    {
                        diskon = promo.Diskon_max;
                    }
                }
                else
                {
                    int subtotal = 0;
                    foreach (Keranjang keranjang in listKeranjang)
                    {
                        if (promo.Tipe == keranjang.Barang.Kategori.Nama)
                        {
                            subtotal += int.Parse(keranjang.Barang.Harga) * keranjang.Jumlah;
                        }
                    }
                    diskon = subtotal * promo.Diskon / 100;
                    if (diskon > promo.Diskon_max)
                    {
                        diskon = promo.Diskon_max;
                    }
                }
            }
            return diskon;
        }
        #endregion
    }
}
