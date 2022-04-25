using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{
	
	
		public class ConfederaçõesMapping : IEntityTypeConfiguration<Confederacao>
	{
		public void Configure(EntityTypeBuilder<Confederacao> builder)
		{
			builder.HasKey(c => c.IDConfederacao);

			builder.Property(c => c.Nome)
				.HasMaxLength(200)
				.IsRequired();
			builder.Property(c => c.Sigla)
				.HasMaxLength(8)
				.IsRequired();
			



			builder.ToTable(name: "Confederacao", schema: "CopaDoMundo");
		}
	}
}

