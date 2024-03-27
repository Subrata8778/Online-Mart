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
    public partial class FormListQuestionHelp : Form
    {
        public FormListQuestionHelp()
        {
            InitializeComponent();
        }
        List<ChatRobo> listHelp = new List<ChatRobo>();
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormDaftarQuestionHelp_Load(object sender, EventArgs e)
        {
            listHelp = ChatRobo.BacaChat("",FormLoading.cdb);
            FormatDataGrid();
        }
        public void FormatDataGrid()
        {
            dataGridViewHelpChatRobo.DataSource = null;
            dataGridViewHelpChatRobo.Columns.Clear();

            //Atur Tabel
            dataGridViewHelpChatRobo.Columns.Add("Id", "Id");
            dataGridViewHelpChatRobo.Columns.Add("Question", "Question");
            dataGridViewHelpChatRobo.Columns.Add("Answer", "Answer");

            //Atur Ukuran Cell
            dataGridViewHelpChatRobo.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHelpChatRobo.Columns["Question"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHelpChatRobo.Columns["Answer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Batasi Aktivitas User
            dataGridViewHelpChatRobo.AllowUserToAddRows = false;
            dataGridViewHelpChatRobo.ReadOnly = true;

            //Desain Data Grid
            dataGridViewHelpChatRobo.BorderStyle = BorderStyle.None;
            dataGridViewHelpChatRobo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewHelpChatRobo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewHelpChatRobo.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewHelpChatRobo.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewHelpChatRobo.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewHelpChatRobo.EnableHeadersVisualStyles = false;
            dataGridViewHelpChatRobo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewHelpChatRobo.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewHelpChatRobo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewHelpChatRobo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewHelpChatRobo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewHelpChatRobo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            TampilDataGrid();
        }
        public void TampilDataGrid()
        {
            dataGridViewHelpChatRobo.Rows.Clear();

            if (listHelp.Count > 0)
            {
                foreach (ChatRobo cr in listHelp)
                {
                    dataGridViewHelpChatRobo.Rows.Add(cr.IdChat, cr.Pertanyaan, cr.Jawaban);
                }
            }
            else
            {
                dataGridViewHelpChatRobo.DataSource = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormTambahHelpRobo frm = new FormTambahHelpRobo();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
