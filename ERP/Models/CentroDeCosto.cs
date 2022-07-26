namespace ERP.Models
{
	public class CentroDeCosto
	{
		#region Properties

		public string Nombre { get; set; }
		public float MontoMaximo{ get; set; }

		#endregion

		#region NavProperties

		public List<Gasto> Gastos { get; set; }

		#endregion
	}
}
