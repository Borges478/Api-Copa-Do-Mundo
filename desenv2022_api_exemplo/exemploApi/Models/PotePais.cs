namespace exemploApi.Models
{
	public class PotePais
	{
        protected PotePais()
        {

        }
		public int IdPote { get; set; }
		public int IDPais { get; set; }

        public Pote Pote { get; set; }
    }
}