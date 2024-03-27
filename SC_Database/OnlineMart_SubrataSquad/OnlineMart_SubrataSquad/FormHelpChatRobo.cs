using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_SubrataSquad
{
    public partial class FormHelpChatRobo : Form
    {
        public List<ChatRobo> listChatRobo = new List<ChatRobo>();
        public FormHelpChatRobo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text!="")
            {
                listChatRobo = ChatRobo.BacaChat(textBox1.Text, FormLoading.cdb);
            }
            else
            {
                listChatRobo = ChatRobo.BacaChat("", FormLoading.cdb);
            }
            FormatDataGrid();
        }

        private void FormHelpChatRobo_Load(object sender, EventArgs e)
        {
            pictureBoxTyping.Visible = false;
            listChatRobo = ChatRobo.BacaChat("",FormLoading.cdb);
            FormatDataGrid();
        }
        private void BalasChat(string pertanyaan)
        {
            //Menampilkan jawaban Robo sesuai pertanyaan yang dipilih
            foreach (ChatRobo cb in listChatRobo)
            {
                if (cb.Pertanyaan == pertanyaan)
                {
                    circularButtonFeedback.Text = cb.Jawaban;
                }
            }
        }

        public void FormatDataGrid()
        {
            dataGridViewPertanyaan.DataSource = null;
            dataGridViewPertanyaan.Columns.Clear();

            //Atur Tabel
            dataGridViewPertanyaan.Columns.Add("Question", "");

            //Atur Ukuran Cell
            dataGridViewPertanyaan.Columns["Question"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Batasi Aktivitas User
            dataGridViewPertanyaan.AllowUserToAddRows = false;
            dataGridViewPertanyaan.ReadOnly = true;

            //Desain data Grid
            dataGridViewPertanyaan.BorderStyle = BorderStyle.None;
            dataGridViewPertanyaan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewPertanyaan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPertanyaan.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewPertanyaan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewPertanyaan.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewPertanyaan.EnableHeadersVisualStyles = false;
            dataGridViewPertanyaan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPertanyaan.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewPertanyaan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewPertanyaan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPertanyaan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPertanyaan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPertanyaan.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewPertanyaan.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewPertanyaan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPertanyaan.RowHeadersVisible = false;
            TampilDataGrid();
        }
        public void TampilDataGrid()
        {
            dataGridViewPertanyaan.Rows.Clear();

            if (listChatRobo.Count > 0)
            {
                foreach (ChatRobo cb in listChatRobo)
                {
                    dataGridViewPertanyaan.Rows.Add(cb.Pertanyaan);
                }
            }
            else
            {
                dataGridViewPertanyaan.DataSource = null;
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            pictureBoxTyping.Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            pictureBoxTyping.Visible = true;
        }

        private void dataGridViewPertanyaan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string question = dataGridViewPertanyaan.CurrentRow.Cells["Question"].Value.ToString();
            foreach (ChatRobo i in listChatRobo)
            {
                if (e.ColumnIndex == dataGridViewPertanyaan.Columns["Question"].Index && e.RowIndex >= 0)
                {
                    circularButtonChat.Text = question;
                    if (i.Pertanyaan == question)
                    {
                        circularButtonFeedback.Text = i.Jawaban;
                    }

                }
            }
        }
    }
}
