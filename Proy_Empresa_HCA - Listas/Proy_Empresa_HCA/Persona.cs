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
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		protected string nombre;
		protected string apellido;
		protected int ci;
		protected short edad;
		protected char genero;
		protected string nacionalidad;
		protected int telefono;
		
		public Persona()
		{
			nombre = "Rosa";
			apellido = "Campos";
			ci = 12345;
			edad = 20;
			genero = 'F';
			nacionalidad = "Bolivia";
			telefono = 7777777;
		}
		public void Leer(){
			Exceptiones E = new Exceptiones();
			
			//Console.Write("Nombre");
			E.ControlString("nombre");
			E.ControlString("apellido");
			E.CONTROLARENTERO("ci",ci);
			E.ControlEdad("edad");
			E.ControlString("nacionalidad");
			E.Controltelefono("telfono ");
			E.ControlGenero("genero ");
		}
		public void Mostrar(){
			Console.WriteLine("Nombre: "+nombre);
			Console.WriteLine("Apellido: "+apellido);
			Console.WriteLine("Cedula de Identidad verificado.. "+ci);
			Console.WriteLine("Edad Verificado... "+edad);
			Console.WriteLine("Género: "+genero);
			Console.WriteLine("Nacionalidad: "+nacionalidad);
			Console.WriteLine("\nCelular verifcado...."+telefono);
		}
		//PROPIEDADES...-----resolver los set--validar--
	    public string Nombre
	    {
	        get { return nombre; }
	        set{
	            if (string.IsNullOrWhiteSpace(value))
	                throw new Exception("Nombre vacío");
	            foreach (char c in value){
	                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
	                    throw new Exception("Nombre no admite símbolos ni números");
	            }
	            nombre = value;
	        }
	    }
	    public string Apellido
	    {
	        get { return apellido; }
	        set{
	            if (string.IsNullOrWhiteSpace(value))
	                throw new Exception("Apellido vacío");
	            foreach (char c in value){
	                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
	                    throw new Exception("Apellido no admite símbolos ni números");
	            }
	
	            apellido = value;
	        }
	    }
	
	    public int Ci
	    {
	        get { return ci; }
	        set{
	            if (value < 1000000 || value > 99999999)
	                throw new Exception("CI no válido");
	            ci = value;
	        }
	    }
	    public short Edad
	    {
	        get { return edad; }
	        set{
	            if (value < 18 || value > 65)
	                throw new Exception("Edad debe estar entre 18 y 65");
	            edad = value;
	        }
	    }
	
	    public char Genero
	    {
	        get { return genero; }
	        set{
	            if (value != 'M' && value != 'F' && value != 'm' && value != 'f')
	                throw new Exception("Género no válido");
	            genero = char.ToUpper(value);
	        }
	    }
	
	    public string Nacionalidad
	    {
	        get { return nacionalidad; }
	        set{
	            if (string.IsNullOrWhiteSpace(value))
	                throw new Exception("Nacionalidad vacía");
	            foreach (char c in value){
	                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
	                    throw new Exception("Nacionalidad no admite símbolos ni números");
	            }
	            nacionalidad = value;
	        }
	    }
	
	    public int Telefono
	    {
	        get { return telefono; }
	        set{
	            if (value < 60000000 || value > 79999999)
	                throw new Exception("Teléfono no válido");
	            telefono = value;
	        }
	    }
	}
}
