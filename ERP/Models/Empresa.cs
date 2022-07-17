namespace ERP.Models
{
	public class Empresa
	{
		public string Nombre { get; set; }
		public string Rubro { get; set; }
		public Imagen Logo{ get; set; }
		public Direccion Direccion { get; set; }
		public Telefono TelefonoContacto { get; set; }
		public string EmailContacto { get; set; }
		public List<Gerencia> Gerencias { get; set; }
	}
}