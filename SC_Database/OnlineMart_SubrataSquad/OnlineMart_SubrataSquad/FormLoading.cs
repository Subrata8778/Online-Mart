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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }
        public static Connection cdb;

        #region No Tick Constrols
        //Optimized Controls(No Tick)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            try
            {
                panelLoading.Width += 3;
                if (panelLoading.Width >= 533)
                {
                    this.Hide();
                    timerLoading.Stop();
                    cdb = new Connection();
                    FormLogin frm = new FormLogin();
                    frm.Owner = this.Owner;
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed, failure message : " + ex.Message);
                Application.Exit();
            }
        }
    }
}
