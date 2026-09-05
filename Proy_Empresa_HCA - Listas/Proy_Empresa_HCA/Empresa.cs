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
	/// Description of Empresa.
	/// </summary>
	public class Empresa
	{
		private string nombre;
		private string direccion;
		private long nit;
		private List<Administrativo> LAd;
		private List<Operario> LOp;
		private List<Cliente> Cli;
		private Garaje Ga;
		public Empresa(Administrativo a, Operario o, Cliente c)
		{
			nombre = "ABC";
			direccion = "calle bolivia";
			nit = 54321;
			int cant_ad = 2;
			LAd = new List<Administrativo>();
			for(int i=0;i<cant_ad;i++)
				LAd.Add(a);
			int cant_op = 3;
			LOp = new List<Operario>();;
			for(int i=0;i<cant_op;i++)
				LOp.Add(o);
			int cant_cli = 3;
			Cli = new List<Cliente>();
			for(int i=0;i<cant_cli;i++)
				Cli.Add(c);			
			Ga = new Garaje(new Vagoneta(new Rueda()),new Camion(new Rueda(),new Carga()));
		}

			public void Leer()
			{
			    Console.WriteLine("\n-- DATOS DE EMPRESA --\n");
			    Exceptiones E = new Exceptiones();
			   	E.ControlString("Nombre ");
			    E.ControlString("Direccion ");
			    E.NITEmpresa("nit ");
	
			    string respuesta;
			    int i;
			    i = 1;
			    do
			    {
			        Administrativo a = new Administrativo();
			        Console.WriteLine("\n------ ADMINISTRATIVO " + i + " -------");
			        i++;
			        a.llenarAd();
			        LAd.Add(a);
			        Console.Write("\n¿Desea agregar otro administrativo? (si/no): ");
			        respuesta = Console.ReadLine().ToLower();
			    } while (respuesta == "si");
			    i = 1;
			    do
			    {
			        Operario o = new Operario();
			        Console.WriteLine("\n------ OPERARIO " + i + " -------");
			        i++;
			        o.llenarOp();
			        LOp.Add(o);
			        Console.Write("\n¿Desea agregar otro operario? (si/no): ");
			        respuesta = Console.ReadLine().ToLower();
			
			    } while (respuesta == "si");
			    i = 1;
			    do
			    {
			        Cliente c = new Cliente();
			        Console.WriteLine("\n------ CLIENTE " + i + " -------");
			        i++;
			        c.Leer();
			        Cli.Add(c);
			        Console.Write("\n¿Desea agregar otro cliente? (si/no): ");
			        respuesta = Console.ReadLine().ToLower();
			    } while (respuesta == "si");
			    Ga.Leer();
			}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE EMPRESA--\n");
			Console.WriteLine("Nombre: "+nombre);
			Console.WriteLine("Dirección: "+direccion);
			Console.WriteLine("NIT Verificado......"+nit);
			Console.WriteLine("\nCantidad de administrativos: "+LAd.Count);
			int i=1;
			foreach (Administrativo ad in LAd){
				Console.WriteLine("\n----- ADMINISTRATIVO "+i+" -----");i++;
				ad.mostrarAd();
			}
			Console.WriteLine("\nCantidad de operarios: "+LOp.Count);
			i=1;
			foreach (Operario op in LOp){
				Console.WriteLine("\n----- OPERARIO "+i+" -----");i++;
				op.mostrarOp();
			}
			Console.WriteLine("\nCantidad de clientes: "+Cli.Count);
			i=1;
			foreach (Cliente cli in Cli){
				Console.WriteLine("\n----- CLIENTE "+i+" -----");i++;
				cli.Mostrar();
			}
			Ga.Mostrar();
		}
		public string Nombre{
		    get { return nombre; }
		    set{
		        if (string.IsNullOrWhiteSpace(value))
		            throw new Exception("Nombre vacío");
		        foreach (char c in value)
		        {
		            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
		                throw new Exception("Nombre no válido");
		        }
		
		        nombre = value;
		    }
		}
		public string Direccion{
		    get { return direccion; }
		    set{
		        if (string.IsNullOrWhiteSpace(value))
		            throw new Exception("Dirección vacía");
		        direccion = value;
		    }
		}
		public long Nit
		{
		    get { return nit; }
		    set{
		        if (value < 100000000 || value > 999999999999)
		            throw new Exception("NIT fuera del rango permitido");
		        nit = value;
		    }
		}
		public List<Administrativo>LADMINS{
			get{return LAd;}
			set{LAd = value;}
		}
		public List<Operario> LOPE{
			get{return LOp;}
			set{LOp = value;}
		}
		public List<Cliente> LCLI{
			get{return Cli;}
			set{Cli = value;}
		}
		public Garaje GARAJE{
			get{return Ga;}
			set{Ga = value;}
		}
		
		
	}
}