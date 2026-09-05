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
	/// Description of Vagoneta.
	/// </summary>
	public class Vagoneta:Vehiculo
	{
		protected string tipo;
		public Vagoneta(Rueda r):base(r)
		{
			tipo = "4x4";
		}
		public void Leer(){
			Exceptiones E = new Exceptiones();
			
			Console.WriteLine("\n---DATOS DE VAGONETA---\n");
			base.Leer();
			E.ControlString("tipo ");
		}
		public void Mostrar(){
			Console.WriteLine("\n---MOSTRANDO DATOS DE VAGONETA---\n");
			base.Mostrar();
			Console.WriteLine("Tipo de vagoneta: "+tipo);
		}
	    public string Tipo_Vag
	    {
	        get{return tipo;}
	        set{
	            if (string.IsNullOrEmpty(value))
	                throw new ArgumentNullException("Tipo vacío");
	            foreach (char c in value)
	            {
	                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
	                    throw new Exception("Tipo no válido");
	            }
	            tipo = value;
	        }
	    }
}
}
