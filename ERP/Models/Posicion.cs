namespace ERP.Models
{

	public class Posicion
	{
		#region Properties

		public string Nombre { get; set; }
		public string Descipcion { get; set; }
		public float sueldo { get; set; }


		#endregion

		#region NavProperties

		public List<Empleado> Empleados { get; set; } // será una lista?
		public Empleado Responsable { get; set; }
		public Gerencia Gerencia { get; set; }

		#endregion
	}
}