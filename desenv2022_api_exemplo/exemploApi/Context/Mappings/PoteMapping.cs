using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{

		public class PoteMapping : IEntityTypeConfiguration<Pote>
	{
		public void Configure(EntityTypeBuilder<Pote> builder)
		{
			builder.HasKey(c => c.IdPote);

			builder.Property(c => c.Descricao)
				.HasMaxLength(200)
				.IsRequired();




			builder.ToTable(name: "Pote", schema: "CopaDoMundo");
		}
	}
}

      

