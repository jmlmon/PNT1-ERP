namespace ERP.Models
{
	public class Gasto
	{
		#region Properties

		public string Descipcion { get; set; }
		public float Monto { get; set; }
		public DateTime Fecha { get; set; }

		#endregion

		#region NavProperties

		public CentroDeCosto CentroDeCosto { get; set; }
		public Empleado Empleado { get; set; }

		#endregion
	}
}