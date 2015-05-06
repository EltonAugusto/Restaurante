using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            var frmprincipal = this;
            if (e.KeyValue.Equals(66)) // Letra "B" abrir a balança
            {
                frmBalanca frm = new frmBalanca();
                frm.Show();
                frmprincipal.Hide();
            }
            if (e.KeyValue.Equals(67))  // Letra "C" abrir a balança
            {
                frmCaixa frm = new frmCaixa();
                frm.Show();
                frmprincipal.Hide();
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

    }
}
