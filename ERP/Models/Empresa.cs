using ERP.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
	public class Empresa
	{
		#region Properties

		public int Id { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Nombre { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Rubro { get; set; }

		[DataType(DataType.EmailAddress)]
		[Required(ErrorMessage = MensajesError.Requerido)]
		public string EmailContacto { get; set; }

		#endregion

		#region ORM

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int DireccionId { get; set; }

		public List<Gerencia> Gerencias { get; set; }

		public List<Imagen> Imagenes { get; set; }
		
		public List<Telefono> Telefonos { get; set; }

		#endregion
	}
}