using ERP.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
	public class Empleado
	{
		#region Properties

		public int Id { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Nombre { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Apellido { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		[Range(Restricciones.FloorDNI, Restricciones.CeilDNI, ErrorMessage = MensajesError.RangoMinMax)]
		public int DNI { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string NombreUsuario { get; set; }

		[DataType(DataType.EmailAddress)]
		[Required(ErrorMessage = MensajesError.Requerido)]
		public int Email { get; set; }

		[DataType(DataType.Date)]
		public DateTime FechaAlta { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public ObraSocial ObraSocial { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Legajo { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public bool EmpleadoActivo { get; set; }

		#endregion

		#region ORM

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int ImagenId { get; set; } // Foto

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int DireccionId { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int PosicionId { get; set; }

		public List<Telefono> Telefonos { get; set; }

		public List<Gasto> Gastos { get; set; }

		#endregion

		#region NavProperties

		//public Direccion Direccion { get; set; }

		#endregion
	}
}
