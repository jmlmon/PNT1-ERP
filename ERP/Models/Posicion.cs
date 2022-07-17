namespace ERP.Models
{

	public class Posicion
	{
		public string Nombre { get; set; }
		public string Descipcion { get; set; }
		public float sueldo { get; set; }
		public Empleado Empleado { get; set; } // será una lista?
		public Empleado Responsable { get; set; } 
		public Gerencia Gerencia { get; set; }
	}
}