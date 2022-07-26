namespace ERP.Models
{
	public class Gerencia
	{
		#region Properties

		public string Nombre { get; set; }
		public bool EsGerenciaGeneral { get; set; }

		#endregion

		#region NavProperties

		public Gerencia Direccion { get; set; } //- Direccion(Gerencia)
		public Posicion Responsable { get; set; } //- Responsable(Posicion)
		public List<Posicion> Posiciones { get; set; }
		public List<Gerencia> Gerencias { get; set; }
		public Empresa Empresa { get; set; }

		#endregion
	}
}
