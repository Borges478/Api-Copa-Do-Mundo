using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{
	
	
		public class PaisesMapping : IEntityTypeConfiguration<Paises>
		{
			public void Configure(EntityTypeBuilder<Paises> builder)
			{
				builder.HasKey(c => c.IDPais);

			builder.Property(c => c.Nome)
				.HasMaxLength(200)
				.IsRequired();
			builder.Property(c => c.Sede)
				.IsRequired();
			builder.Property(c => c.RankingFifa)
				.IsRequired();

			builder.HasOne(c => c.Confederacao)
				   .WithMany(p => p.listPaises)
				   .HasForeignKey(c => c.IDConfederacao);

			builder.ToTable(name: "Paises", schema: "CopaDoMundo");
			}
		}
	}

