/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 24/4/2026
 * Hora: 08:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Proy_Empresa_HCA
{
	/// <summary>
	/// Description of Garaje.
	/// </summary>
	public class Garaje
	{
		private int capacidad;
		private string horario;
		private List<Vagoneta> LVag;
		private List<Camion> LCam;
		
		public Garaje(Vagoneta v, Camion c)
		{
			capacidad = 15;
			horario = "8:00 a 20:00";
			int cant_vag = 1;
			LVag = new List<Vagoneta>();
			for(int i=0;i<cant_vag;i++)
				LVag.Add(v); 
			int cant_cam = 1;
			LCam = new List<Camion>();
			for(int j=0;j<cant_cam;j++)
				LCam.Add(c); 
		}

		public void Leer(){
			Console.WriteLine("\n-- DATOS DEL GARAJE--\n");
			Exceptiones E = new Exceptiones();
			E.LimCapa("capacidad ");
			E.ControlString("Horario ");
			
			Vagoneta v = new Vagoneta(new Rueda());
			Camion c = new Camion(new Rueda(),new Carga());
			string respuesta;
			int i = 1;
			do{
				Console.WriteLine("\n------ VAGONETA "+i+"-------"); i++;
				v.Leer();
				LVag.Add(v);
				Console.Write("\n¿Desea agregar otra vagoneta?(si/no): ");
				respuesta = Console.ReadLine().ToLower();
			}while(respuesta=="si");
			i = 1;
			do{
				Console.WriteLine("\n------ CAMION "+i+"-------"); i++;
				c.Leer();
				LCam.Add(c);
				Console.Write("\n¿Desea agregar otro camión?(si/no): ");
				respuesta = Console.ReadLine().ToLower();
			}while(respuesta=="si");
		}
		public void Mostrar(){
			Console.WriteLine("\n--DATOS DE GARAJE--\n");
			Console.WriteLine("Capacidad verificado"+capacidad);
			Console.WriteLine("Horario: "+horario);
			Console.WriteLine("\nCantidad de vagonetas: "+LVag.Count);
			int i = 1;
			foreach(var vag in LVag){
				Console.WriteLine("\n----- VAGONETA "+i+" -----");i++;
				vag.Mostrar();
			}
			Console.WriteLine("\ncantidad de Camiones: "+LCam.Count);
			i = 1;
			foreach(var cam in LCam){
				Console.WriteLine("\n----- CAMION "+i+" -----");i++;
				cam.Mostrar();
			}
		}
		public int Capacidad
		{
		    get { return capacidad; }
		    set
		    {
		        if (value < 1 || value > 50)
		            throw new Exception("La capacidad debe estar entre 1 y 50");
		
		        capacidad = value;
		    }
		}
		public string Horario
		{
		    get { return horario; }
		    set{
		        if (string.IsNullOrWhiteSpace(value))
		            throw new Exception("Horario vacío");
		        horario = value;
		    }
		}
		public List<Vagoneta> LVAGONETAS{
			get{return LVag;}
			set{LVag = value;}
		}
		public List<Camion> LCAMIONES{
			get{return LCam;}
			set{LCam = value;}
		}
	}
}
