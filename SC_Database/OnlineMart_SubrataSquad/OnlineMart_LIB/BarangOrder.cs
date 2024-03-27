using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class BarangOrder
    {
        #region Fields
        private Barang barang;
        private Order order;
        private int jumlah;
        private string harga;
        #endregion

        #region Constructors
        public BarangOrder(Barang barang, Order order, int jumlah, string harga)
        {
            this.Barang = barang;
            this.Order = order;
            this.Jumlah = jumlah;
            this.Harga = harga;
        }
        #endregion

        #region Properties
        public Barang Barang { get => barang; set => barang = value; }
        public Order Order { get => order; set => order = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public string Harga { get => harga; set => harga = value; }
        #endregion

        #region Methods
        public static List<BarangOrder> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select o.id, o.tanggal_waktu, o.alamat_tujuan,o.ongkos_kirim, o.total_bayar,o.cara_bayar," +
                    " c.id,c.nama,c.alamat," +
                    " p.id, p.nama,p.email,p.password,p.telepon,p.image," +
                    " d.id,d.nama,d.email,d.password,d.telepon,d.image," +
                    " pe.id,pe.nama,pe.email,pe.password,pe.telepon,pe.saldo,pe.poin,pe.image," +
                    " pr.id,pr.tipe,pr.nama,pr.diskon,pr.diskon_max,pr.minimal_belanja," +
                    " o.status,mp.nama,o.status_kirim," +
                    " b.id, b.nama, b.harga, b.kategoris_id, b.image," +
                    " k.nama," +
                    " bo.jumlah, bo.harga" +
                    " from orders o inner join cabangs c on o.cabangs_id = c.id" +
                    " inner join pegawais p on c.pegawais_id = p.id" +
                    " inner join drivers d on o.drivers_id = d.id" +
                    " inner join promos pr on o.promo_id = pr.id" +
                    " inner join pelanggans pe on o.pelanggans_id = pe.id" +
                    " inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id" +
                    " inner join barangs_orders bo on bo.orders_id = o.id" +
                    " inner join barangs b on bo.barangs_id = b.id" +
                    " inner join kategoris k on b.kategoris_id = k.id";
            }
            else
            {
                sql = "select o.id, o.tanggal_waktu, o.alamat_tujuan, o.ongkos_kirim, o.total_bayar, o.cara_bayar," +
                    " c.id, c.nama, c.alamat," +
                    " p.id, p.nama, p.email, p.password, p.telepon,p.image," +
                    " d.id, d.nama, d.email, d.password, d.telepon,d.image," +
                    " pe.id, pe.nama, pe.email, pe.password, pe.telepon, pe.saldo, pe.poin,pe.image," +
                    " pr.id, pr.tipe, pr.nama, pr.diskon, pr.diskon_max, pr.minimal_belanja," +
                    " o.status, mp.nama, o.status_kirim," +
                    " b.id, b.nama, b.harga, b.kategoris_id, b.image," +
                    " k.nama," +
                    " bo.jumlah, bo.harga" +
                    " from orders o inner join cabangs c on o.cabangs_id = c.id" +
                    " inner join pegawais p on c.pegawais_id = p.id" +
                    " inner join drivers d on o.drivers_id = d.id" +
                    " inner join promos pr on o.promo_id = pr.id" +
                    " inner join pelanggans pe on o.pelanggans_id = pe.id" +
                    " inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id" +
                    " inner join barangs_orders bo on bo.orders_id = o.id" +
                    " inner join barangs b on bo.barangs_id = b.id" +
                    " inner join kategoris k on b.kategoris_id = k.id" +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            List<BarangOrder> listBarangOrder = new List<BarangOrder>();

            while (hasil.Read() == true)
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(9), hasil.GetString(10), hasil.GetString(11), hasil.GetString(12), hasil.GetString(13), (byte[])hasil.GetValue(14));
                Cabang cabang = new Cabang(hasil.GetInt32(6), hasil.GetString(7), hasil.GetString(8), pegawai);
                Driver driver = new Driver(hasil.GetInt32(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18), hasil.GetString(19), (byte[])hasil.GetValue(20));
                Pelanggan pelanggan = new Pelanggan(hasil.GetInt32(21), hasil.GetString(22), hasil.GetString(23), hasil.GetString(24), hasil.GetString(25), hasil.GetFloat(26), hasil.GetInt32(27), (byte[])hasil.GetValue(28));
                Promo promo = new Promo(hasil.GetInt32(29), hasil.GetString(30), hasil.GetString(31), hasil.GetInt32(32), hasil.GetInt32(33), hasil.GetFloat(34));
                MetodePembayaran mp = new MetodePembayaran(hasil.GetString(36));
                Order o = new Order(hasil.GetInt32(0), DateTime.Parse(hasil.GetValue(1).ToString()), hasil.GetValue(2).ToString(), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetValue(5).ToString(), cabang, driver, pelanggan, promo, hasil.GetString(35), mp, hasil.GetString(37));
                Kategori k = new Kategori(hasil.GetInt32(41), hasil.GetString(43));
                Barang b = new Barang(hasil.GetInt32(38), hasil.GetString(39), hasil.GetString(40), k, (byte[])hasil.GetValue(42));
                BarangOrder bo = new BarangOrder(b, o, hasil.GetInt32(44), hasil.GetString(45));
                listBarangOrder.Add(bo);
            }
            return listBarangOrder;
        }

        public static List<int> BacaIdBarangTerlaris(Connection cdb)
        {
            string sql = "Select distinct barangs_id, sum(jumlah) as jumlah from barangs_orders group by barangs_id order by jumlah DESC";
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            List<int> listBarangPopuler = new List<int>();

            while (hasil.Read() == true)
            {
                listBarangPopuler.Add(hasil.GetInt32(0));
            }
            hasil.Dispose();
            hasil.Close();
            return listBarangPopuler;
        }

        public static void TambahData(BarangOrder bo,Connection cdb)
        {
            string sql = "insert into barangs_orders (barangs_id, orders_id, jumlah, harga)"
                + " values ('" + bo.Barang.Id + "', '" + bo.Order.Id + "', '" + bo.Jumlah + "', '" + bo.Harga + "')";

            Connection.JalankanPerintahDML(sql, cdb);
        }
        #endregion
    }
}
