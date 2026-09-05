/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 24/4/2026
 * Hora: 08:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Proy_Empresa_HCA
{
	/// <summary>
	/// Description of Vehiculo.
	/// </summary>
	public class Vehiculo
	{
		protected string marca;
		protected string placa;
		protected int modelo;
		protected Motor Mo;
		protected List<Rueda> LRu;
		
		public Vehiculo(Rueda r)
		{
			marca = "Toyota";
			placa = "1234";
			modelo = 2026;
			Mo = new Motor();
			int cant_ru = 4;
			LRu = new List<Rueda>();
			for(int i=0;i<cant_ru;i++)
				LRu.Add(r);
		}

		public void Leer(){
			
		    Exceptiones E = new Exceptiones();
		
		    E.ControlString("Marca ");
		    E.ControlString("Placa ");
		    E.ControlModelo("modelo ");			
		    Mo.llenar();
			//Bucle para ingresar múltiples ruedas
			bool continuar = true;
			int i = 1;

			while(continuar)
			{
			    Rueda r = new Rueda();
			    r.llenar();
			    LRu.Add(r);
			
			    Console.Write("\n¿Desea agregar otra rueda? (s/n): ");
			    string respuesta = Console.ReadLine().ToLower();
			
			    if(respuesta != "s")
			        continuar = false;
			}
		}
		public void Mostrar(){
			Console.WriteLine("\nMarca: "+marca);
			Console.WriteLine("Placa: "+placa);
			Console.WriteLine("Modelo Verificado...."+modelo);
			Mo.mostrar();
			int i=1;
			foreach(Rueda r in LRu){
				Console.Write("\n-------- RUEDA "+i+"-----------");
				r.mostrar();
				i++;
			}
		}
		public string Marca{
		    get { return marca; }
		    set{
		        if (string.IsNullOrWhiteSpace(value))
		             throw new Exception("Marca vacía");
		
		            foreach (char c in value)
		            {
		                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
		                    throw new Exception("Marca no admite símbolos ni números");
		            }
		
		            marca = value;
		        }
		    }
			public string Placa{
			    get { return placa; }
			    set{
			        if (string.IsNullOrWhiteSpace(value))
			            throw new Exception("Placa vacía");
			        if (value.Length < 5 || value.Length > 10)
			            throw new Exception("Placa no válida");
			        placa = value;
			    }
			}
		public int Modelo_vehiculo{
		   	get { return modelo; }
		    set{
		    if (value < 1000 || value > 9999)
		       throw new Exception("Modelo debe ser de 4 dígitos");
		            modelo = value;
		        }
		    }

		public Motor MOTOR{
			get{return Mo;}
			set{Mo=value;}
		}
		public List<Rueda>LRUEDAS{
			get{return LRu ;}
			set{LRu= value;}
		}
	}
}
