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
	/// Description of Motor.
	/// </summary>
	public class Motor
	{
		private int modelo;
		private double peso;
		private string marca;
		private string potencia;
		public Motor()
		{   modelo=2018;
			peso=1616;
			marca="Lim";
			potencia="1234";	
		}

		public void llenar(){
			Exceptiones E = new Exceptiones();
			E.LimModeloMo("modelo ");
			E.LimPeso("peso ");
			E.ControlString("Marca ");
			E.ControlString("potencia ");
		}
		public void mostrar(){
			Console.WriteLine("modelo: "+modelo);
			Console.WriteLine("peso: "+peso);
			Console.WriteLine("marca: "+marca);
			Console.WriteLine("potencia: "+potencia);
		}
			
		public int Modelo_Mo
		{
		    get { return modelo; }
		    set{
		        if (value < 1998 || value > 2026)
		            throw new Exception("Modelo no encontrado");
		        modelo = value;
		    }
		}
		public double Peso_Mo{
		    get { return peso; }
		    set
		    {
		        if (value < 300 || value > 1500)
		            throw new Exception("El peso debe estar entre 300 y 1500 kg");
		        peso = value;
		    }
		}
		
		public string Marca_Mo{
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
		
		public string Potencia_Mo{
		    get { return potencia; }
		    set{
		        if (string.IsNullOrWhiteSpace(value))
		            throw new Exception("Potencia vacía");
		
		        potencia = value;
		    }
		}
	}
}
