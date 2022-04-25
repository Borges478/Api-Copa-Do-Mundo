using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{

	public class ParticipantesGrupoMapping : IEntityTypeConfiguration<ParticipantesGrupo>
	{
		public void Configure(EntityTypeBuilder<ParticipantesGrupo> builder)
		{
			builder.HasKey(c => c.IdGrupo);

			builder.Property(c => c.IDPais)
				.IsRequired();




			builder.ToTable(name: "ParticipantesGrupo", schema: "CopaDoMundo");
		}
	}
}
