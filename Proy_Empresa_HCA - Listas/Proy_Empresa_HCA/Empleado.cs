/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 24/4/2026
 * Hora: 08:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_HCA
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado:Persona
	{
		protected double sueldo;
		protected int antiguedad;
		public Empleado():base()
		{	sueldo=2000;
			antiguedad=5;
		}

		protected void llenarEm(){
			Console.WriteLine("\n-- DATOS DE EMPLEADO --\n");
			Exceptiones E = new Exceptiones();
			E.LimSuel("sueldo ");
			E.LimAntigu("Antiguedad ");
			base.Leer();
		}
		protected void mostrarEm(){
			base.Mostrar();
			Console.WriteLine("sueldo verificado... "+sueldo);
			Console.WriteLine("antiguedad verificado..."+antiguedad);
		}	
		public double Sueldo{
		    get { return sueldo; }
		    set
		    {
		        if (value < 3000 || value > 10000)
		            throw new Exception("El sueldo debe estar entre 3000 y 10000");
		
		        sueldo = value;
		    }
		}
		public int Antiguedad{
		    get { return antiguedad; }
		    set{
		        if (value < 2 || value > 50)
		            throw new Exception("La antigüedad debe estar entre 2 y 50 años");
		        antiguedad = value;
		    }
		}
	}
}
