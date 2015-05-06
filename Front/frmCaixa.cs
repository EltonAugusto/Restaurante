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
    public partial class frmCaixa : Form
    {
        int trace = 0;

        public frmCaixa()
        {
            InitializeComponent();
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            trace = 1; // iniciou o procedimento
        }

        private void frmCaixa_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var repository = new PedidoRepository();
          var pedido = new Pedido();
            if (e.KeyValue.Equals(13))// Enter
            {
                pedido = repository.BuscarPedidoEmAbertoPorComanda(textBox1.Text);
                label1.Text = (pedido.ValorRefeicao + pedido.Produtos.Sum(p => p.Valor)).ToString();
                trace = 2;
            }

            repository = null;
            pedido = null;
            GC.Collect();
        }
    }
}
