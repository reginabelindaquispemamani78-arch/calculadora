/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 22/5/2026
 * Time: 09:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Proy_Empresa_HCA
{
	/// <summary>
	/// Description of ListaEmpresas.
	/// </summary>
	public class ListaEmpresas
	{
		private List<Empresa> LEm;
		public ListaEmpresas()
		{
			LEm = new List<Empresa>();
			int cant_em = 2;
			Empresa e = new Empresa(new Administrativo(),new Operario(), new Cliente());
			for (int i=0;i<cant_em;i++)
				LEm.Add(e);							
		}
		public void Leer(){
			Console.WriteLine("\n---- DATOS DE LA LISTA DE EMPRESAS ----\n");
			string respuesta;
			int i = 1;
			Empresa e = new Empresa(new Administrativo(),new Operario(), new Cliente());
			do{
				Console.WriteLine("\n------ EMPRESA "+i+"-------"); i++;
				e.Leer();
				LEm.Add(e);
				Console.Write("\n¿Desea agregar otra empresa a la lista?(si/no): ");
				respuesta = Console.ReadLine().ToLower();
			}while(respuesta=="si");
		}
		public void Mostrar(){
			Console.WriteLine("\n---- MOSTRANDO DATOS DE LA LISTA DE EMPRESAS ----\n");
			int i=1;
			foreach(Empresa em in LEm){
				Console.WriteLine("\n------ EMPRESA "+i+"-------"); i++;
				em.Mostrar();
			}
		}
		//a)Buscar al camion modelo "x" modifvcar tipo de ambiente de su carga 
			//1raF
			public void modificarAmbiente(){
				Console.Write("\nIngrese modelo de camion a buscar: ");
				int x = int.Parse(Console.ReadLine());
				bool sw=false;
				int i = 1;
				foreach (Empresa em in LEm) {
					int j = 1;
					foreach (Camion Ca in em.GARAJE.LCAMIONES) {
						if (Ca.Modelo_vehiculo.Equals(x)) {
							Console.WriteLine("\n============EMPRESA "+i+" ===========");
							Console.WriteLine("\n-----------CAMION "+j+ "---------------");
							Console.WriteLine("\nTipo de ambiente actual de la carga: "+Ca.CARGA.Tipo_ambiente);
							Console.WriteLine("\nIngrese tipo de ambiente nuevo: ");
							Ca.CARGA.Tipo_ambiente = Console.ReadLine();
							Ca.CARGA.mostrar();
							sw = true;
						}
						j++;
					}
					i++;
				}
				if (!sw) {
					Console.WriteLine("\nNo se encuentra camion modelo "+x);
				}
			}
		
	}
}
