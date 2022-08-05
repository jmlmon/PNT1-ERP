using ERP.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
	public class Telefono
	{
		#region props

		public int Id { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Numero { get; set; } // string ya que es un número sobre el que no se realizan operaciones

		// NavProp
		[Required(ErrorMessage = MensajesError.Requerido)]
		public int TipoTelefonoID { get; set; } // Enum

		public int EmpleadoId { get; set; } // no es required porque puede ser de una persona o de una empresa
		public int EmpresaId { get; set; }

		#endregion
	}
}