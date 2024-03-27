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
    public partial class FormTambahHelpRobo : Form
    {
        public FormTambahHelpRobo()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBoxQuestion.Text != "" && textBoxAnswer.Text != "") && (textBoxAnswer.Text != null && textBoxQuestion.Text != null))
                {
                    ChatRobo.TambahData(textBoxQuestion.Text, textBoxAnswer.Text, FormLoading.cdb);
                    MessageBox.Show("Nice! the question and the answers added!","Robo");
                    textBoxQuestion.Clear();
                    textBoxAnswer.Clear();
                    textBoxQuestion.Focus();
                    FormListQuestionHelp frm = (FormListQuestionHelp)Owner;
                    frm.FormDaftarQuestionHelp_Load(sender,e);
                }
                else
                {
                    MessageBox.Show("Hmm? it's feel like you missing something? are you okay?","Robo");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!!ERROR!!!, Message error : "+ex.Message,"Robo");
            }
        }
    }
}
