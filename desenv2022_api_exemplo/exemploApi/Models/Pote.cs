using System.Collections.Generic;

namespace exemploApi.Models
{
	public class Pote
	{
        protected Pote()
        {

        }
		public int IdPote { get; set; }
		public string Descricao { get; set; }

		List<Paises> ListaPaises { get; set; }
	}
}