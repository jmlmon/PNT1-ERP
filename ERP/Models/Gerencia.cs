namespace ERP.Models
{
//- Nombre
//- EsGerenciaGeneral
//- Direccion(Gerencia)
//- Responsable(Posicion)
//- Posiciones
//- Gerencias
//- Empresa
	public class Gerencia
	{
		public string Nombre { get; set; }
		public bool EsGerenciaGeneral { get; set; }
		public Gerencia Direccion { get; set; }
		public Posicion Responsable { get; set; }
		public List<Posicion> Posiciones { get; set; }
		public List<Gerencia> Gerencias { get; set; }
		public Empresa Empresa { get; set; }
	}
}
