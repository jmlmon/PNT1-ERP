namespace ERP.Models
{
	public class Gasto
	{
		public string Descipcion { get; set; }
		public CentroDeCosto CentroDeCosto { get; set; }
		public Empleado Empleado { get; set; }
		public float Monto { get; set; }
		public DateTime Fecha { get; set; }
	}
}