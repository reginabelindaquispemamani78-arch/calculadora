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
	/// Description of Operario.
	/// </summary>
	public class Operario:Empleado
	{
		protected string turno;
		public Operario():base()
		{	turno="noche";
		}
		public void llenarOp(){
			Exceptiones E =new Exceptiones();
			
			Console.WriteLine("\n---DATOS DE OPERARIO---");

			E.ControlString("turno ");
			base.llenarEm();
			
		}
		public void mostrarOp(){
			Console.WriteLine("\n---MOSTRANDO DATOS DE OPERARIO---");
			base.mostrarEm();
			Console.WriteLine("turno: "+turno);
		}
		public string Turno
		{
		    get { return turno; }
		    set{
	            if (string.IsNullOrWhiteSpace(value))
	                throw new Exception("Turno vacía");
	            foreach (char c in value){
	                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
	                    throw new Exception("Turno no admite símbolos ni números");
	            }
	            turno = value;
		    }
		}
}
}
