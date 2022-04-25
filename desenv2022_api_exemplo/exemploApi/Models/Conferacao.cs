using System.Collections.Generic;

namespace exemploApi.Models
{
	public class Confederacao
	{
        protected Confederacao()
        {

        }
		public int IDConfederacao { get; set; }
		public string Nome { get; set; }
		public string Sigla { get; set; }

		public List<Paises> listPaises { get; set; }
	}
}
