namespace exemploApi.Models
{
	public class Paises
	{
        protected Paises()
        {

        }

		public int IDPais { get; set; }
		public string Nome { get; set; }
		public bool Sede { get; set; }
		public int RankingFifa { get; set; }
		public int IDConfederacao { get; set; }

        public Confederacao Confederacao { get; set; }

    } 
}
