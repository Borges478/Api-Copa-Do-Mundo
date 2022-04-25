using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{


	public class PotePaisMapping : IEntityTypeConfiguration<PotePais>
	{
		public void Configure(EntityTypeBuilder<PotePais> builder)
		{
			builder.HasKey(c => c.IdPote);

			builder.Property(c => c.IDPais)
				.IsRequired();

			builder.HasOne(p => p.Pote)
				.WithMany()
				.HasForeignKey(p => p.IdPote);


			


			builder.ToTable(name: "PotePais", schema: "CopaDoMundo");
		}
	}
}

