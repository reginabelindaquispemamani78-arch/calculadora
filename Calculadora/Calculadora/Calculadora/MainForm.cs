/*
 * Creado por SharpDevelop.
 * Usuario: Lab 3
 * Fecha: 21/08/2026
 * Hora: 9:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculadora
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private double num1, num2,res;
		private string operador;
		
		
		
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
	    double Factorial(double n)
	    {
	        double resultado = 1;
	
	        for (int i = 1; i <= n; i++){
	            resultado = resultado * i;
	        }
	        return resultado;
	    }   
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			txtPantalla.Text = txtPantalla.Text +"1";			
		}
		
		void Button22Click(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtPantalla.Text);

		    res = Math.Sqrt(num1);
		
		    txtPantalla.Text = res.ToString();
				}
		
		
		
		void Btn2Click(object sender, EventArgs e)
		{
			txtPantalla.Text = txtPantalla.Text +"2";			
		}
		
		void Btn3Click(object sender, EventArgs e)
		{
			txtPantalla.Text = txtPantalla.Text +"3";			
		}
		
		void Btn4Click(object sender, EventArgs e)
		{
			txtPantalla.Text = txtPantalla.Text +"4";			
		}
		
		void Btn5Click(object sender, EventArgs e)
		{
			txtPantalla.Text = txtPantalla.Text +"5";			
		}
		void Btn6Click(object sender, EventArgs e)
		{
			txtPantalla.Text = txtPantalla.Text +"6";			
		}
		
		void Btn7Click(object sender, EventArgs e)
		{
			txtPantalla.Text = txtPantalla.Text +"7";
		}
		
		void Btn8Click(object sender, EventArgs e)
		{
			txtPantalla.Text = txtPantalla.Text +"8";
		}
		
		void Btn9Click(object sender, EventArgs e)
		{
			txtPantalla.Text = txtPantalla.Text +"9";			
		}
		
		void BtnComaClick(object sender, EventArgs e)
		{
			if (txtPantalla.Text =="") {
				txtPantalla.Text="0";
			}
			else if (!txtPantalla.Text.Contains(",")) {
				txtPantalla.Text = txtPantalla.Text+",";
			}

		}
		
		void Btn0Click(object sender, EventArgs e)
		{
			txtPantalla.Text = txtPantalla.Text +"0";			
		}
		
		void BtnCAClick(object sender, EventArgs e)
		{
			if(txtPantalla.Text.Length.Equals(1))
				txtPantalla.Clear();
			else
				txtPantalla.Text= txtPantalla.Text.Substring(0,txtPantalla.Text.Length-1);
		}
		
		void BtnCClick(object sender, EventArgs e)
		{
			txtPantalla.Clear();
		}
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtPantalla.Text);
			operador = "+";
			txtPantalla.Clear();
		}
		
		void BtnIgualClick(object sender, EventArgs e)
		{
			num2 = Convert.ToDouble(txtPantalla.Text);
			switch(operador){
				case "+":
					res= num1 + num2;
					txtPantalla.Text= res.ToString();
					break;
				case "-":
					res= num1 - num2;
					txtPantalla.Text= res.ToString();
					break;
				case "x":
					res= num1 * num2;
					txtPantalla.Text= res.ToString();
					break;
				case "÷":
					res= num1 / num2;
					txtPantalla.Text= res.ToString();
					break;
				case "^":
					
					res = Math.Pow(num1, num2);
			        txtPantalla.Text = res.ToString();
			        break;					
			} 
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtPantalla.Text);
			operador = "-";
			txtPantalla.Clear();
		}
		
		void BtnMultiClick(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtPantalla.Text);
			operador = "x";
			txtPantalla.Clear();
		}
		
		void BtnDivClick(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtPantalla.Text);
			operador = "÷";
			txtPantalla.Clear();
		}
		
		void BtnPotenciaClick(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtPantalla.Text);
			operador = "^";
			txtPantalla.Clear();
		}
		
		void BtnFacClick(object sender, EventArgs e){
	
			num1 = Convert.ToDouble(txtPantalla.Text);
			res = Factorial(num1);
			
			txtPantalla.Text = res.ToString();
		}
		
		void BtnPorcentajeClick(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtPantalla.Text);
    		res = num1 / 100;
    		txtPantalla.Text = res.ToString();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}

