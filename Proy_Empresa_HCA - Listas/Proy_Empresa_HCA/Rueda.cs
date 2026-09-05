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
	/// Description of Rueda.
	/// </summary>
	public class Rueda
	{
		private string marca;
		private int nro_rueda;
		private int modelo;
		public Rueda()
		{	marca="Logan";
			nro_rueda=6;
			modelo=233;
		}

		public void llenar(){
			Exceptiones E = new Exceptiones();
			E.ControlString("Marca ");
			E.LimNroR("nro_rueda ");
			E.limModeloRU("modelo ");

		}
		public void mostrar(){
			Console.WriteLine("\nmarca: "+marca);
			Console.WriteLine("nro_rueda verificado... "+nro_rueda);
			Console.WriteLine("modelo verficado.... "+modelo);
		}			
	    public string Marca
	    {
	        get { return marca; }
	        set{
	            if (string.IsNullOrWhiteSpace(value))
	                throw new Exception("Marca vacía");
	            foreach (char c in value)
	            {
	                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
	                    throw new Exception("Marca no válida");
	            }
	            marca = value;
	        }
	    }
	    public int NroRu
	    {
	        get { return nro_rueda; }
	        set{
	            if (value < 1 || value > 4)
	                throw new Exception("Número de rueda debe estar entre 1 y 4");
	            nro_rueda = value;
	        }
	    }
	    public int Modelo_Ru
	    {
	        get { return modelo; }
	        set{
	            if (value < 100 || value > 999)
					throw new Exception("El modelo debe estar entre 100 y 999");
	
	            modelo = value;
	        }
	    }
	}
}
