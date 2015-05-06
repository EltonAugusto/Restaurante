

using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class PedidoConfiguration : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfiguration()
        {
            HasKey(c => c.PedidoId);
            Property(c => c.DataFechamento);
            Property(c => c.DataCadastro).IsRequired();

            Property(c => c.Comanda)
                .IsRequired()
                .HasMaxLength(3);

            Property(c => c.ValorRefeicao)
                .IsRequired();

            HasMany(x => x.Produtos).WithMany();

        }
    }
}
