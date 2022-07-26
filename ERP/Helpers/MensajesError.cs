namespace ERP.Helpers
{
	public class MensajesError
	{
		public const string Requerido = "El campo {0} es obligatorio.";
		public const string RangoMinMax = "El campo {0} debe estar comprendido entre {1} y {2}.";
		public const string StrMaxMin = "El campo {0}, debe tener un mínimo de {2} caracteres y un máximo de {1}.";
		public const string StrMax = "El campo {0}, debe tener un máximo de {1} caracteres.";
		public const string StrMin = "El campo {0}, debe tener un mínimo de {1} caracteres.";
		public const string NoValido = "El campo {0} no es válido. Verifique que esté bien escrito.";
		public const string PassMissmatch = "Las contraseñas ingresadas no coinciden.";
	}
}