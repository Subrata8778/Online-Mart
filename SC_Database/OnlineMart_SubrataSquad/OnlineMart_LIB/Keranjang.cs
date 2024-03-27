using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Keranjang
    {
        #region Fields
        private Pelanggan pelanggan;
        private Barang barang;
        private Cabang cabang;
        private int jumlah;
        #endregion

        #region Constructors
        public Keranjang(Pelanggan pelanggan, Barang barang, Cabang cabang, int jumlah)
        {
            this.Pelanggan = pelanggan;
            this.Barang = barang;
            this.Cabang = cabang;
            this.Jumlah = jumlah;
        }
        public Keranjang()
        {
            this.Pelanggan = null;
            this.Barang = null;
            this.Cabang = null;
            this.Jumlah = 0;
        }
        #endregion

        #region Properties
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        public Barang Barang { get => barang; set => barang = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        #endregion

        #region Methods
        public static List<Keranjang> BacaData(int penggunaId)
        {
            string sql = "select p.id, p.nama, p.email, p.password, p.telepon, p.saldo, p.poin, p.image, " +
                " cb.stok, " + "b.id, b.nama, b.harga, b.image, " +
                " ka.id,ka.nama, " + "c.id,c.nama,c.alamat, " +
                " pe.id,pe.nama,pe.email,pe.password,pe.telepon,pe.image,k.jumlah" +
                " from keranjangs k inner join pelanggans p on k.pelanggans_id = p.id " +
                " inner join cabangs_barangs cb on k.cabangs_id = cb.cabangs_id AND k.barangs_id = cb.barangs_id" +
                " inner join cabangs c on c.id = cb.cabangs_id" +
                " inner join pegawais pe on pe.id = c.pegawais_id" +
                " inner join barangs b on b.id = cb.barangs_id" +
                " inner join kategoris ka on ka.id = b.kategoris_id" +
                " where p.id = " + penggunaId;

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            List<Keranjang> listKeranjang = new List<Keranjang>();

            while (hasil.Read() == true)
            {
                Pelanggan p = new Pelanggan(int.Parse(hasil.GetValue(0).ToString()), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), float.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()), (byte[])hasil.GetValue(7));
                Kategori k = new Kategori(int.Parse(hasil.GetValue(13).ToString()), hasil.GetString(14));
                Barang b = new Barang(int.Parse(hasil.GetValue(9).ToString()), hasil.GetString(10), hasil.GetString(11), k, (byte[])hasil.GetValue(12));
                Pegawai pe = new Pegawai(int.Parse(hasil.GetValue(18).ToString()), hasil.GetString(19), hasil.GetString(20), hasil.GetString(22), (byte[])hasil.GetValue(23));
                Cabang c = new Cabang(int.Parse(hasil.GetValue(15).ToString()), hasil.GetString(16), hasil.GetString(17), pe);

                Keranjang keranjang = new Keranjang(p, b, c, int.Parse(hasil.GetValue(24).ToString()));

                listKeranjang.Add(keranjang);
            }
            return listKeranjang;
        }

        public static void TambahData(Keranjang k, Connection cdb)
        {
            string sql = "insert into keranjangs values (" +
                k.Pelanggan.Id + ", " + k.Cabang.Id + ", " + k.Barang.Id + ", " + k.Jumlah + ")";

            Connection.JalankanPerintahDML(sql, cdb);
        }

        public static Boolean HapusKeranjang(Keranjang k, Connection cdb)
        {
            string perintah = "delete from keranjangs where pelanggans_id = " + k.Pelanggan.Id +
                " AND cabangs_id = " + k.Cabang.Id + " AND barangs_id = " + k.Barang.Id;
            int jumlahDataBerubah = Connection.JalankanPerintahDML(perintah, cdb);
            if (jumlahDataBerubah == 0)
                return false;
            return true;
        }
        public static void UpdateJumlahBeli(int jumlah, int barangId, int cabangId, Connection cdb)
        {
            string peritah = "update keranjangs set jumlah = '" + jumlah + "' where barangs_id = '" + barangId + "' AND cabangs_id = '" + cabangId + "'";

            Connection.JalankanPerintahDML(peritah, cdb);
        }

        public static void KurangiStok(Keranjang k, Connection cdb)
        {
            string sql = "update cabangs_barangs set Stok = Stok - " + k.Jumlah + " where barangs_id = " +
                k.Barang.Id + " and cabangs_id = " + k.Cabang.Id;
            Connection.JalankanPerintahDML(sql, cdb);
        }
        #endregion
    }
}
