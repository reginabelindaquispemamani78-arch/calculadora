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
	/// Description of Carga.
	/// </summary>
	public class Carga
	{
		private string tipo_carga;
		private string tipo_ambiente;
		public Carga()
		{	
		 	tipo_carga="liviano";
		 	tipo_ambiente="frio";
		}
		public void llenar(){
			Console.WriteLine("\n---DATOS DE CARGA---");
			Exceptiones E = new Exceptiones();
			E.ControlString("Tipo_Carga");
			E.ControlString("Tipo_ambiente");
		}
		public void mostrar(){  
			Console.WriteLine("\n---MOSTRANDO DATOS DE CARGA---");			
			Console.WriteLine("\ntipo_carga: "+tipo_carga);
			Console.WriteLine("tipo_ambiente: "+tipo_ambiente);
		}
		public string Tipo_carga{
		    get { return tipo_carga; }
		    set{
		        if (string.IsNullOrWhiteSpace(value))
		            throw new Exception("Tipo de carga vacío");
		        foreach (char c in value){
		            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
		                throw new Exception("Tipo de carga no válido");
		        }
		
		        tipo_carga = value;
		    }
		}
		
		public string Tipo_ambiente{
		    get { return tipo_ambiente; }
		    set{
		        if (string.IsNullOrWhiteSpace(value))
		            throw new Exception("Tipo de ambiente vacío");
		        foreach (char c in value)
		        {
		            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
		                throw new Exception("Tipo de ambiente no válido");
		        }
		
		        tipo_ambiente = value;
		    }
		}
	}
}
