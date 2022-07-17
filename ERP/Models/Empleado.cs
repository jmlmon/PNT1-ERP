namespace ERP.Models
{
	public class Empleado
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public int DNI { get; set; }
		public List<Telefono> Telefonos { get; set; }
		public Direccion Direccion { get; set; }
		public DateTime FechaAlta { get; set; }
		public string Email { get; set; }
		public ObraSocial ObraSocial { get; set; }
		public string Legajo { get; set; }
		public bool EmpleadoActivo { get; set; }
		public Posicion Posicion { get; set; }
		public Imagen Foto { get; set; }
	}
}
