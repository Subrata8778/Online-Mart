using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class ChatRobo
    {
        #region Fields
        private int idChat;
        private string pertanyaan;
        private string jawaban;
        #endregion

        #region Constructors
        public ChatRobo(int idChat, string pertanyaan, string jawaban)
        {
            this.IdChat = idChat;
            this.Pertanyaan = pertanyaan;
            this.Jawaban = jawaban;
        }
        #endregion

        #region Properties
        public int IdChat { get => idChat; set => idChat = value; }
        public string Pertanyaan { get => pertanyaan; set => pertanyaan = value; }
        public string Jawaban { get => jawaban; set => jawaban = value; }
        #endregion

        #region Methods
        //Baca Jawaban-Jawaban Robo dari Database
        public static List<ChatRobo> BacaChat(string question, Connection cdb)
        {
            string sql = "";
            sql = "select * from chat_robos where pertanyaan like '%"+question+"%'";

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql, cdb);
            List<ChatRobo> listChatRobo = new List<ChatRobo>();

            while (hasil.Read())
            {
                ChatRobo cb = new ChatRobo(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2));

                listChatRobo.Add(cb);
            }
            hasil.Dispose();
            hasil.Close();
            return listChatRobo;
        }
        public static void TambahData(string question, string answer, Connection cdb)
        {
            string sql = "insert into chat_robos(pertanyaan, jawaban) values('" + question + "','" + answer + "')";
            Connection.JalankanPerintahDML(sql, cdb);
        }
        #endregion
    }
}
