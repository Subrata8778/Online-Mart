using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Cabang
    {
        #region Fields
        private int id;
        private string nama;
        private string alamat;
        private Pegawai pegawai;
        #endregion

        #region Constructors
        public Cabang(int id, string nama, string alamat, Pegawai pegawai)
        {
            this.Id = id;
            this.Nama = nama;
            this.Alamat = alamat;
            this.Pegawai = pegawai;
        }

        public Cabang(string nama, string alamat, Pegawai pegawai)
        {
            this.Nama = nama;
            this.Alamat = alamat;
            this.Pegawai = pegawai;
        }
        public Cabang()
        {
            Nama = "";
            Alamat = "";
            Pegawai = null;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        #endregion

        #region Methods
        public static List<Cabang> BacaData(string kriteria, string nilaiKriteria, Connection cdb)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select c.ID, c.nama, c.alamat, p.id as id, p.nama as nama, p.email as email," +
                    " p.password as password, p.telepon as telepon, p.image as image" +
                    " from cabangs c inner join pegawais " +
                    "p on c.pegawais_id = p.ID";
            }
            else
            {
                sql = "select c.ID, c.nama, c.alamat, p.id as id, p.nama as nama, p.email as email," +
                    " p.password as password, p.telepon as telepon, p.image as image" +
                    " from cabangs c inner join pegawais " +
                    "p on c.pegawais_id = p.ID where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            List<Cabang> listCabang = new List<Cabang>();

            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetInt32(3), hasil.GetValue(4).ToString(), hasil.GetValue(5).ToString(),
                    hasil.GetValue(6).ToString(), hasil.GetValue(7).ToString(), (byte[])hasil.GetValue(8));
                Cabang c = new Cabang(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), p);
                listCabang.Add(c);
            }
            hasil.Dispose();
            hasil.Close();
            return listCabang;
        }

        public static Boolean HapusData(string kode, Connection cdb)
        {
            string sql = "delete from cabangs where id = '" + kode + "'";

            int jumlahDitambah = Connection.JalankanPerintahDML(sql, cdb);
            if (jumlahDitambah == 0)
                return false;
            return true;
        }

        public static Boolean UbahData(Cabang c, Connection cdb)
        {
            string sql = "update cabangs set nama = '" + c.Nama + "', alamat = '" + c.Alamat + "'" +
                " where id = " + c.Id;

            int jumlahDitambah = Connection.JalankanPerintahDML(sql, cdb);
            if (jumlahDitambah == 0)
                return false;
            return true;
        }

        public static void TambahData(Cabang c, Connection cdb)
        {
            string sql = "insert into cabangs (nama, alamat, pegawais_id)"
                + " values ('" + c.Nama + "', '" + c.Alamat + "', '" + c.Pegawai.Id + "')";

            Connection.JalankanPerintahDML(sql, cdb);
        }
        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
