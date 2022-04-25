using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{
	
	
		public class GrupoMapping : IEntityTypeConfiguration<Grupo>
	{
		public void Configure(EntityTypeBuilder<Grupo> builder)
		{
			builder.HasKey(c => c.IdGrupo);

			builder.Property(c => c.Nome)
				.HasMaxLength(200)
				.IsRequired();
			



			builder.ToTable(name: "Grupo", schema: "CopaDoMundo");
		}
	}
}


