using ERP.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
	public class Gerencia
	{
		#region Properties

		public int Id { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Nombre { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public bool EsGerenciaGeneral { get; set; }

		#endregion

		#region ORM

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int DireccionId { get; set; } //- Direccion(Gerencia)

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int ResponsableId { get; set; } //- Responsable(Posicion)
		
		public List<Posicion> Posiciones { get; set; }
		
		public List<Gerencia> Gerencias { get; set; } //Las subgerencias

		[Required(ErrorMessage = MensajesError.Requerido)]
		public int EmpresaId { get; set; } //esto era más que nada por el caso de que haya más de una empresa

		#endregion
	}
}
