namespace ERP.Models
{
	public class Telefono
	{
		public string Numero { get; set; } // string ya que es un número sobre el que no se realizan operaciones
		public TipoTelefono TipoTelefono { get; set; } // Enum
	}
}