using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class GiftRedeem
    {
        #region Fields
        private int id;
        private DateTime waktu;
        private int poinRedeem;
        private Gift gift;
        private Order order;
        #endregion

        #region Constructors
        public GiftRedeem(int id, DateTime waktu, int poinRedeem, Gift gift, Order order)
        {
            this.Id = id;
            this.Waktu = waktu;
            this.PoinRedeem = poinRedeem;
            this.Gift = gift;
            this.Order = order;
        }

        public GiftRedeem(int poinRedeem, Gift gift, Order order)
        {
            this.Waktu = waktu;
            this.PoinRedeem = poinRedeem;
            this.Gift = gift;
            this.Order = order;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public DateTime Waktu { get => waktu; set => waktu = value; }
        public int PoinRedeem { get => poinRedeem; set => poinRedeem = value; }
        public Gift Gift { get => gift; set => gift = value; }
        public Order Order { get => order; set => order = value; }
        #endregion

        #region Methods
        public static List<GiftRedeem> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select gr.id, gr.waktu, gr.poin_redeem, g.id, g.nama, g.jumlah_poin, o.id, o.tanggal_waktu, o.alamat_tujuan, +" +
                    "o.ongkos_kirim, o.total_bayar, o.cara_bayar, o.cabangs_id, o.drivers_id, o.pelanggans_id, o.promo_id, " +
                    "o.status, o.metode_pembayaran_id, o.status_kirims from gift_redeems as gr inner join gifts as g on " +
                    "gr.orders_id = g.id inner join orders as o on gr.orders_id = o.id";
            }
            else
            {
                sql = "select gr.id, gr.waktu, gr.poin_redeem, g.id, g.nama, g.jumlah_poin, o.id, o.tanggal_waktu, o.alamat_tujuan, +" +
                    "o.ongkos_kirim, o.total_bayar, o.cara_bayar, o.cabangs_id, o.drivers_id, o.pelanggans_id, o.promo_id, " +
                    "o.status, o.metode_pembayaran_id, o.status_kirims from gift_redeems as gr inner join gifts as g on " +
                    "gr.orders_id = g.id inner join orders as o on gr.orders_id = o.id " +
                    "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);

            List<GiftRedeem> listGiftRedeem = new List<GiftRedeem>();
            while (hasil.Read() == true)
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18), hasil.GetString(19), (byte[])hasil.GetValue(20));
                Cabang cabang = new Cabang(hasil.GetInt32(12), hasil.GetString(13), hasil.GetString(14), pegawai);
                Driver driver = new Driver(hasil.GetInt32(21), hasil.GetString(22), hasil.GetString(23), hasil.GetString(24), hasil.GetString(25), (byte[])hasil.GetValue(26));
                Pelanggan pelanggan = new Pelanggan(hasil.GetInt32(27), hasil.GetString(28), hasil.GetString(29), hasil.GetString(30), hasil.GetString(31), hasil.GetFloat(32), hasil.GetInt32(33), (byte[])hasil.GetValue(34));
                Promo promo = new Promo(hasil.GetInt32(35), hasil.GetString(36), hasil.GetString(37), hasil.GetInt32(38), hasil.GetInt32(39), hasil.GetFloat(40));
                Gift g = new Gift(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5));
                MetodePembayaran mp = new MetodePembayaran(hasil.GetString(42));
                Order order = new Order(hasil.GetInt32(6), hasil.GetDateTime(7), hasil.GetString(8), hasil.GetFloat(9), hasil.GetFloat(10), hasil.GetString(11), cabang, driver, pelanggan, promo, hasil.GetString(41), mp, hasil.GetString(43));
                GiftRedeem gr = new GiftRedeem(hasil.GetInt32(0), hasil.GetDateTime(1), hasil.GetInt32(2), g, order);
                listGiftRedeem.Add(gr);
            }
            return listGiftRedeem;
        }

        public static void TambahData(GiftRedeem gr, Connection cdb)
        {
            string sql = "insert into gift_redeems (waktu, poin_redeem, gifts_id, orders_id) " +
                "values (now(), " + gr.PoinRedeem + ", '" + gr.Gift.Id + "', '" + gr.Order.Id + "')";
            Connection.JalankanPerintahDML(sql, cdb);
        }
        public static void KurangiPoin(int poin, Pelanggan p,Connection cdb)
        {
            int poinSekarang = p.Poin - poin;
            string sql = "update pelanggans set poin = " + poinSekarang + " where id = " + p.Id;
            Connection.JalankanPerintahDML(sql, cdb);
        }
        #endregion
    }
}