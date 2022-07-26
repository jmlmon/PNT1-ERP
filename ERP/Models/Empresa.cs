using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
	public class Empresa
	{
		#region Properties

		public string Nombre { get; set; }
		public string Rubro { get; set; }
		[DataType(DataType.EmailAddress)]
		public string EmailContacto { get; set; }

		#endregion

		#region NavProperties

		public List<Gerencia> Gerencias { get; set; } // es necesaria la relación?
		public Imagen Logo { get; set; }
		public Direccion Direccion { get; set; }
		public Telefono TelefonoContacto { get; set; }

		#endregion
	}
}