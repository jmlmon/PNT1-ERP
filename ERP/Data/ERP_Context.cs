using ERP.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP.Data
{
	public class ERP_Context : DbContext
	{

		public ERP_Context(DbContextOptions options) : base(options)
		{

		}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);

		//	/*Relaciones N-N, por medio de Fluent API ?
		//	 * Definiciones de nombres de tablas
		//	 * Comportamientoes especificos para el manejo de entidades
		//	 *
		//	 *  --> Videos Cortos >> EF.01.Agregando EntityFramework - ORM >> minuto 8
		//	 */
		//}		

		public DbSet<CentroDeCosto> CentroDeCostos { get; set; }
		public DbSet<Direccion> Direcciones { get; set; }
		public DbSet<Empleado> Empleados { get; set; }
		public DbSet<Empresa> Empresas { get; set; }
		public DbSet<Gasto> Gastos { get; set; }
		public DbSet<Gerencia> Gerencias { get; set; }
		public DbSet<Imagen> Imagenes { get; set; }
		public DbSet<Posicion> Posiciones { get; set; }
		public DbSet<Telefono> Telefonos { get; set; }

	}
}
