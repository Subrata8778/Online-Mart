using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class RiwayatIsiSaldo
    {
        #region Fields
        private int id;
        private DateTime waktu;
        private int isiSaldo;
        private Pelanggan pelanggan;
        #endregion

        #region Constructors
        public RiwayatIsiSaldo(int id, DateTime waktu, int isiSaldo, Pelanggan pelanggan)
        {
            this.Id = id;
            this.Waktu = waktu;
            this.IsiSaldo = isiSaldo;
            this.Pelanggan = pelanggan;
        }
        public RiwayatIsiSaldo(DateTime waktu, int isiSaldo, Pelanggan pelanggan)
        {
            this.Waktu = waktu;
            this.IsiSaldo = isiSaldo;
            this.Pelanggan = pelanggan;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public DateTime Waktu { get => waktu; set => waktu = value; }
        public int IsiSaldo { get => isiSaldo; set => isiSaldo = value; }
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        #endregion

        #region Methods
        public static List<RiwayatIsiSaldo> BacaData(string kriteria, string nilaiKriteria, Connection cdb)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select ris.id, ris.waktu, ris.isi_saldo, p.id, p.nama, p.email, p.password, p.telepon, p.saldo,p.poin, p.image from riwayat_isi_saldos ris inner join pelanggans p on ris.pelanggans_id = p.id";
            }
            else
            {
                sql = "select ris.id, ris.waktu, ris.isi_saldo, p.id, p.nama, p.email, p.password, p.telepon, p.saldo,p.poin, p.image from riwayat_isi_saldos ris inner join pelanggans p on ris.pelanggans_id = p.id where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);

            List<RiwayatIsiSaldo> listRiwayatIsiSaldo = new List<RiwayatIsiSaldo>();
            while (hasil.Read() == true)
            {
                Pelanggan p = new Pelanggan(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7), hasil.GetFloat(8), hasil.GetInt32(9), (byte[])hasil.GetValue(10));
                RiwayatIsiSaldo k = new RiwayatIsiSaldo(hasil.GetInt32(0), hasil.GetDateTime(1), hasil.GetInt32(2), p);
                listRiwayatIsiSaldo.Add(k);
            }
            hasil.Dispose();
            hasil.Close();
            return listRiwayatIsiSaldo;
        }

        public static List<RiwayatIsiSaldo> BacaData(string tahun, int bulan,Connection cdb)
        {
            string sql = "select ris.id, ris.waktu, ris.isi_saldo, p.id, p.nama, p.email, p.password, p.telepon, p.saldo,p.poin, p.image from riwayat_isi_saldos ris inner join pelanggans p on ris.pelanggans_id = p.id where year(ris.waktu) like '%" + tahun + "%' ";

            if (bulan != 0)
            {
                sql += " AND month(ris.waktu) like " + bulan;
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);

            List<RiwayatIsiSaldo> listRiwayatIsiSaldo = new List<RiwayatIsiSaldo>();
            while (hasil.Read() == true)
            {
                Pelanggan p = new Pelanggan(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7), hasil.GetInt32(8), hasil.GetInt32(9), (byte[])hasil.GetValue(10));
                RiwayatIsiSaldo k = new RiwayatIsiSaldo(hasil.GetInt32(0), hasil.GetDateTime(1), hasil.GetInt32(2), p);
                listRiwayatIsiSaldo.Add(k);
            }
            hasil.Dispose();
            hasil.Close();
            return listRiwayatIsiSaldo;
        }

        public static void TambahData(RiwayatIsiSaldo r, Connection cdb)
        {
            string sql = "insert into riwayat_isi_saldos (waktu, isi_saldo, pelanggans_id)" +
                " values ('" + r.Waktu.ToString("yyyy-MM-dd HH-mm-ss") + "', '" + r.IsiSaldo + "', '" + r.Pelanggan.Id + "')";

            Connection.JalankanPerintahDML(sql, cdb);
        }
        #endregion
    }
}
