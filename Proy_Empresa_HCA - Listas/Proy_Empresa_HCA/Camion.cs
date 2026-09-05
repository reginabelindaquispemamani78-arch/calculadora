/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 24/4/2026
 * Hora: 08:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_HCA
{
	/// <summary>
	/// Description of Camion.
	/// </summary>
	public class Camion:Vehiculo
	{
		protected double tam;
		private Carga Ca;
		
		public Camion(Rueda r, Carga c):base(r)
		{
			tam = 12.5;
			Ca = c;
		}
		public void Leer(){
			Console.WriteLine("\n---DATOS DE CAMION---\n");
			Exceptiones E = new Exceptiones();
			E.TamCami("tamaño ");
			base.Leer();


			Ca.llenar();
		}
		public void Mostrar(){
			Console.WriteLine("\n---MOSTRANDO DATOS DE CAMION---\n");
			base.Mostrar();
			Console.WriteLine("Tamaño del camion: "+tam);
			Ca.mostrar();
		}
		public double Tamaño{
		    get { return tam; }
		    set{
		        if (value < 4.00 || value > 25.00)
		            throw new Exception("El tamaño debe estar entre 4.00 y 25.00 metros");
		        tam = value;
		    }
		}
		public Carga CARGA{
			get{return Ca;}
			set{Ca=value;}
		}
		
	}
}
