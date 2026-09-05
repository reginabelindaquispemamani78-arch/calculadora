/*
 * Created by SharpDevelop.
 * User: RYZEN 5
 * Date: 19/6/2026
 * Time: 08:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proy_Empresa_HCA
{
	/// <summary>
	/// Description of Exception.
	/// </summary>
	public class Exceptiones
	{
		public Exceptiones()
		{
		}
		public void ControlString(string atributo){
			string cadena =" ";
			bool sw = false;
			do{
				try {
					Console.Write("Ingrese "+atributo+": ");
					cadena = Console.ReadLine();
					Cadena1(cadena);
					sw =false;
					
				} 
				catch (Exception e) {
					Console.WriteLine("--->Error!:...."+e.Message);
					sw=true;
				}
				
			}while (sw);
		}
		private void Cadena1(string Cadena){
			if (string.IsNullOrEmpty(Cadena)) 
				throw  new ArgumentNullException();
				foreach(char c in Cadena)
					if (!char.IsLetter(c)&& !char.IsWhiteSpace(c)) {
						throw new Exception("cadena no valida..");
					
				}
			}
		public void CONTROLARENTERO( string entero,int ci)
		{
		    bool sw = false;
		    do
		    {
		        try{
		            Console.Write("Ingrese "+ entero + ":");
		            ci = int.Parse(Console.ReadLine());
		            ExpCI(ci);
		            sw = false;
		        }
		        catch (Exception e)
		        {
		            Console.WriteLine("--->Error!: " + e.Message);
		            sw = true;
		        }
		
		    } while (sw);
		}
		public void Controltelefono(string cel){
			int telefono = 0;
			bool sw = false;
		    do
		    {
		        try{
		            Console.Write("Ingrese "+cel+":");
		            telefono = int.Parse(Console.ReadLine());
		            ExpCelular(telefono);
		            sw = false;
		        }
		        catch (Exception e)
		        {
		            Console.WriteLine("Error: " + e.Message);
		            sw = true;
		        }
		    } while (sw);
		}
		public void ControlEdad(string ED){
			short edad = 0;
			bool sw = false;
			do
		    {
		        try{
					Console.Write("Ingrese" +ED+ ":");
		            edad = short.Parse(Console.ReadLine());
		            LimEdad(edad);
		            sw = false;
		        }
		        catch (Exception e){
		            Console.WriteLine("Error: " + e.Message);
		            sw = true;
		        }
		    } while (sw);
		}
			public void ControlGenero(string G)
			{
			    char genero = ' ';
			    bool sw = false;
			    do
			    {
			        try
			        {
			            Console.Write("Ingrese "+G+":");
			            genero = char.Parse(Console.ReadLine());
			            Genero1(genero);
			            sw = false;
			        }
			        catch (Exception e){
			            Console.WriteLine("--->Error!:...." + e.Message);
			            sw = true;
			        }
			    } while (sw);
			}
			public void ControlModelo(string mode){
				
				int modelo = 0 ;
				bool sw = false;
				do
			    {
			        try{
			            Console.Write("Ingrese "+mode+":");
			            modelo = int.Parse(Console.ReadLine());
			            LimModelo(modelo);
			            sw = false;
			        }
			        catch (Exception e){
			            Console.WriteLine("Error: " + e.Message);
			            sw = true;
			        }
			    } while (sw);
			}
			public void LimNroR(string num){
				int nro_rueda = 0;
				bool sw = false;
				do{
					try {
						Console.Write("Ingrese "+num+":");
						nro_rueda=int.Parse(Console.ReadLine());
						LimNro_ruedas(nro_rueda);
						sw=false;
					} catch (Exception e) {
						Console.WriteLine("\nError: "+e.Message);
						sw = true;
					}
				}while (sw);
			}
			
			public void limModeloRU(string Ru){
				int modelo = 0;
				bool sw = false;
				do{
					try {
							Console.Write("Ingrese "+Ru+":");
							modelo=int.Parse(Console.ReadLine());
							LimModelo(modelo);
							sw = false;
							
					} catch (Exception e) {
						Console.WriteLine("\n Error. "+e.Message);
						sw = true;
					}
					}while (sw);
				}
			public void LimModeloMo(string mo){
				int modelo = 0;
				bool sw = false;
				do{
					try {
							Console.Write("Ingrese "+mo+":");
							modelo=int.Parse(Console.ReadLine());
							limModelo(modelo);
							sw = false;
						
					} catch (Exception e) {
						Console.WriteLine("\nERROR: "+e.Message);
						sw = true;
						
					}
				}while(sw);
			}
			public void LimPeso(string pes){
				double peso = 0;
				bool sw = false;
				do{
					try {
							Console.Write("Ingrese "+pes+":");
							peso=double.Parse(Console.ReadLine());
							limPeso(peso);
							sw = false	;
						
					} catch (Exception e) {
						Console.WriteLine("\nERROR: "+e.Message);
						sw = true;
					}
				}while (sw);
			}
			public void LimCapa(string capaci){
				int capacidad = 0;
				bool sw = false;
				
				do{
					try {
							Console.Write("Ingrese Capacidad: ");
							capacidad = int.Parse(Console.ReadLine());
							LimCapa(capacidad);
							sw = false;
						
					} catch (Exception e) {
						Console.WriteLine("\nERROR: "+e.Message);
						sw = true;
					}
				}while (sw);
			}
			public void NITEmpresa(string NIT){
				long nit = 0;
				bool sw = false;	
			    do
			    {
			        try
			        {
			            Console.Write("Ingrese "+NIT+":");
			            nit = long.Parse(Console.ReadLine());
			            LimEmpre(nit);
			            sw = false;
			        }
			        catch (Exception e)
			        {
			            Console.WriteLine("\nERROR: " + e.Message);
			            sw = true;
			        }
			    } while (sw);
			}
			public void LimSuel(string SUL){
				double sueldo = 0;
				bool sw = false;
				do{
					try {
							Console.Write("ingrese "+SUL+":");
							sueldo=double.Parse(Console.ReadLine());
							LimSueldo(sueldo);
							sw = false;
					} catch (Exception e) {
						Console.WriteLine("\nERROR: "+e.Message);
						sw = true;
					}
				}while (sw);
			}
			public void LimAntigu(string lim){
				int antiguedad = 0;
				bool sw = false;
		        do{
		        	try {
						Console.Write("ingrese "+lim+":");
		        		antiguedad=int.Parse(Console.ReadLine());	
		        		LimAntig(antiguedad);
		        		sw = false;
		        	} catch (Exception e) {
						Console.WriteLine("\nERROR: "+e.Message);
						sw = true;
		        	}
		        }while (sw);
			}
			public void NumCLI(string CLI){
				int nro_cliente = 0;
				bool sw = false;
				do{
					try {
							Console.Write("Ingrese "+":");
							nro_cliente = int.Parse(Console.ReadLine());
							NroClien(nro_cliente);
							sw = false;
					} catch (Exception e) {
						Console.WriteLine("\nERROR: "+e.Message);
						sw = true;
					}
				}while (sw);
			}
			public void TamCami(string ta){
				double tam = 0;
				bool sw = false;
				do{
					try {
							Console.Write("Ingrese "+ta+":");
							tam = double.Parse(Console.ReadLine());
							TamaCam(tam);
							sw = false;
						
					} catch (Exception e) {
						Console.WriteLine("\nERROR: "+e.Message);
						sw = true;
					}
				}while (sw);
			}
		private void Genero1(char genero){
			 if (genero != 'M' && genero != 'F' && genero != 'm' && genero != 'f'){
			        throw new Exception("Género no válido...");
			    }
			}
		private void ExpCI(int ci){
		    if (ci < 1000000 || ci > 9999999)
		        throw new Exception("CI no válido...");
		    
		}
		private void ExpCelular(int cel){
		    if (cel < 60000000 || cel > 79999999)
		        throw new Exception("Número de celular no válido...");
		}
		private void LimEdad(short edad){
		    if (edad < 18 || edad > 65)
		        throw new Exception("La edad debe estar entre 18 y 65 años...");
		}
		private void LimModelo(int modelo){
		    if (modelo < 1000 || modelo > 9999)
		        throw new Exception("modelo no esta dentro del rango...");
		}
		private void LimNro_ruedas(int nro_rueda){
		    if (nro_rueda < 1 || nro_rueda > 4)
		        throw new Exception("El número de ruedas debe estar entre 1 y 4.");
		}
		private void LimModeloRu(int modelo){
		    if (modelo < 100|| modelo > 999)
		        throw new Exception("El modelo debe tener 4 dígitos.");
		}
		private void limModelo(int modelo){
		    if (modelo < 1998 || modelo > 2026)
		        throw new Exception("Modelo no encontrado. Debe estar entre 1998 y 2026.");
		}
		private void limPeso(double peso){
		    if (peso < 300 || peso > 1500)
		        throw new Exception("El peso debe estar entre 300 y 1500 kg.");
		}
		private void LimCapa(int capacidad){
		    if (capacidad < 1 || capacidad > 50) {
		        throw new Exception("La capacidad debe estar entre 1 y 50.");
		    }
		}
		private void LimEmpre(long nit){
			 if (nit < 100000000 || nit > 999999999999)
			     throw new Exception("NIT fuera del rango permitido (100000000 - 999999999999).");
			}
		private void LimSueldo(double sueldo){
		    if (sueldo < 3000 || sueldo > 10000)
		        throw new Exception("El sueldo debe estar entre 3000 y 10000.");
		}
		private void LimAntig(int antiguedad){
		    if (antiguedad < 2 || antiguedad > 50){
		        throw new Exception("La antigüedad debe estar entre 2 y 50 años.");
		    }
		}
		private void NroClien(int nro_cliente){
		    if (nro_cliente < 1 || nro_cliente > 9999){
		        throw new Exception("El número de cliente debe estar entre 1 y 9999.");
		    }
		}
		private void TamaCam(double tam){
			if (tam < 4.00 || tam > 25.00) {
				throw new Exception("\nTamaño no registrado. Debe estar entre 4.00 y 25.00 metros....");
			}
		}
	}
}	