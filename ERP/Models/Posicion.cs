using ERP.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{

	public class Posicion
	{
		#region Properties

		public int Id { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Nombre { get; set; }

		public string? Descipcion { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		// la data Annotation para settear el SalarioMinimo como valor mínimo
		public float sueldo { get; set; }

		#endregion

		# region ORM

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int ResponsableId { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int GerenciaId { get; set; }

		public List<Empleado> Empleados { get; set; }
		#endregion

		#region NavProperties


		
		

		#endregion
	}
}