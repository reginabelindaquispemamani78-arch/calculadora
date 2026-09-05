/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 24/4/2026
 * Hora: 08:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Proy_Empresa_HCA
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente:Persona
	{
		protected int nro_cliente;
		
		public Cliente():base()
		{
			nro_cliente = 1;
		}

		public void Leer(){
			Exceptiones E = new Exceptiones();
			Console.WriteLine("\n--DATOS DE CLIENTE--\n");
			E.NumCLI("nro_cliente ");
			base.Leer();

		}
		public void Mostrar(){
			Console.WriteLine("\n--MOSTRANDO DATOS DE CLIENTE--\n");
			base.Mostrar();
			Console.WriteLine("Número de cliente: "+nro_cliente);
		}
		public int NroCli{
		    get { return nro_cliente; }
		    set{
		        if (value < 1 || value > 9999)
		            throw new Exception("El número de cliente debe estar entre 1 y 9999");
		        nro_cliente = value;
		    }
		}
	}
}
