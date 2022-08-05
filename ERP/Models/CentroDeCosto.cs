using ERP.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
	public class CentroDeCosto
	{
		#region Properties

		public int Id { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Nombre { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public float MontoMaximo{ get; set; }

		#endregion

		#region ORM

		public List<Gasto> Gastos { get; set; }

		#endregion

		#region navs

		//public List<Empleado> Empleados { get; set; } esto lo saca de Gasto, Gasto es la que tiene al Empleado

		#endregion
	}
}