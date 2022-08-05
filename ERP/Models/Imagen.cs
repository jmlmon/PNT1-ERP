using ERP.Helpers;

namespace ERP.Models
{
	public class Imagen
	{
		#region Props
		public int Id { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Nombre { get; set; }

		[Required(ErrorMessage = MensajesError.Requerido)]
		public string Path { get; set; }
		#endregion

		#region ORM
		public int EmpresaId { get; set; } // no es required porque la imagen puede ser de un perfil de usuario
	}
}
