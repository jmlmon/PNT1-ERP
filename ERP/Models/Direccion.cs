using ERP.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
	public class Direccion
	{
		#region props

		public int Id { get; set; }

		public int? Piso { get; set; }
		public string? Departamento { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int NroCalle { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string NombreCalle { get; set; }

		public string? CodPostal { get; set; }

		public string? Ciudad { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Localidad { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Provincia { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Pais { get; set; }

		public long? Latitud { get; set; }

		public long? Longitud { get; set; }

		#endregion
	}
}