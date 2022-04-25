using System.Collections.Generic;

namespace exemploApi.Models
{
	public class Grupo
	{
        protected Grupo()
        {

        }
		public int IdGrupo { get; set; }
		public string Nome { get; set; }

		List<Paises> ListaPaises { get; set; }
		
	}
}