namespace ERP.Models
{
	public class Usuario
	{
		public int Id { get; set; } // para usar con IdentityFrameworks
		public string Nombre { get; set; }
		public int Email { get; set; }
		public DateTime FechaAlta { get; set; }
		//public string Password { get; set; } // para usar con IdentityFrameworks
	}
}
