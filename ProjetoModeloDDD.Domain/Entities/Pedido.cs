using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Pedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PedidoId { get; set; }
        public string Comanda { get; set; }
        public double ValorRefeicao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataFechamento { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public bool Ativo { 
            get { return this.DataFechamento!= null? true: false ;}
        }

        public Pedido()
        {
            this.Produtos = new Collection<Produto>();
        }

    }
}
