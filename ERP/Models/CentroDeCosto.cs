namespace ERP.Models
{
	public class CentroDeCosto
	{
		public string Nombre { get; set; }
		public float MontoMaximo{ get; set; }
		public List<Gasto> Gastos { get; set; }
	}
}
