using ERP.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
	public class Gasto
	{
		#region Properties

		public int Id { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Descipcion { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public float Monto { get; set; }

		public DateTime Fecha { get; set; }

		#endregion

		#region ORM

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int CentroDeCostoId { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int EmpleadoId { get; set; }

		#endregion
	}
}