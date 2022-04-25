namespace exemploApi.Models
{
	public class ParticipantesGrupo
	{
        protected ParticipantesGrupo()
        {

        }
		public int IdGrupo { get; set; }
		public int IDPais { get; set; }

        public Grupo Grupo { get; set; }
        public Paises Paises { get; set; }

    }
}