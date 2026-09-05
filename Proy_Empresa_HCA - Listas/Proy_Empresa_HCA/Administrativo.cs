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
	/// Description of Administrativo.
	/// </summary>
	public class Administrativo:Empleado
	{
		protected string tipo_adm;
		public Administrativo():base()
		{	tipo_adm="interno";
		}
		public void llenarAd(){
			Console.WriteLine("\n---DATOS DE ADMINISTRATIVO---");
			Exceptiones E = new Exceptiones();
			E.ControlString("tipo_admi ");
			base.llenarEm();
		}
		public void mostrarAd(){
			Console.WriteLine("\n---MOSTRANDO DATOS DE ADMINISTRATIVO---");
			base.mostrarEm();
			Console.WriteLine("Tipo de administrativo: "+tipo_adm);
		}
		public string Tipo_adm{
		    get { return tipo_adm; }
		    set{
		        if (string.IsNullOrWhiteSpace(value))
		            throw new Exception("Tipo de administrativo vacío");
		        foreach (char c in value)
		        {
		            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
		                throw new Exception("Tipo de administrativo  no válido");
		        }
		        tipo_adm = value;
		    }
		}
	}
}
