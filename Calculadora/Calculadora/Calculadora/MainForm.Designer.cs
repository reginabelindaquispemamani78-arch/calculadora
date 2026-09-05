/*
 * Creado por SharpDevelop.
 * Usuario: Lab 3
 * Fecha: 21/08/2026
 * Hora: 9:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace calculadora
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtPantalla = new System.Windows.Forms.TextBox();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btnComa = new System.Windows.Forms.Button();
			this.btnIgual = new System.Windows.Forms.Button();
			this.btnCA = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnRaiz = new System.Windows.Forms.Button();
			this.btnFac = new System.Windows.Forms.Button();
			this.btnMulti = new System.Windows.Forms.Button();
			this.btnPotencia = new System.Windows.Forms.Button();
			this.btnPorcentaje = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPantalla
			// 
			this.txtPantalla.Location = new System.Drawing.Point(37, 23);
			this.txtPantalla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPantalla.Multiline = true;
			this.txtPantalla.Name = "txtPantalla";
			this.txtPantalla.Size = new System.Drawing.Size(406, 122);
			this.txtPantalla.TabIndex = 0;
			this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtPantalla.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.Color.Red;
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btn1.Location = new System.Drawing.Point(40, 166);
			this.btn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(68, 58);
			this.btn1.TabIndex = 1;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btn8
			// 
			this.btn8.BackColor = System.Drawing.Color.Red;
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btn8.Location = new System.Drawing.Point(116, 302);
			this.btn8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(68, 58);
			this.btn8.TabIndex = 4;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = false;
			this.btn8.Click += new System.EventHandler(this.Btn8Click);
			// 
			// btn7
			// 
			this.btn7.BackColor = System.Drawing.Color.Red;
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btn7.Location = new System.Drawing.Point(40, 302);
			this.btn7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(68, 58);
			this.btn7.TabIndex = 5;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = false;
			this.btn7.Click += new System.EventHandler(this.Btn7Click);
			// 
			// btn5
			// 
			this.btn5.BackColor = System.Drawing.Color.Red;
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btn5.Location = new System.Drawing.Point(116, 234);
			this.btn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(68, 58);
			this.btn5.TabIndex = 6;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = false;
			this.btn5.Click += new System.EventHandler(this.Btn5Click);
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.Color.Red;
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btn4.Location = new System.Drawing.Point(40, 234);
			this.btn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(68, 58);
			this.btn4.TabIndex = 7;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = false;
			this.btn4.Click += new System.EventHandler(this.Btn4Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.Color.Red;
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btn2.Location = new System.Drawing.Point(116, 166);
			this.btn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(68, 58);
			this.btn2.TabIndex = 8;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn9
			// 
			this.btn9.BackColor = System.Drawing.Color.Red;
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btn9.Location = new System.Drawing.Point(192, 302);
			this.btn9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(68, 58);
			this.btn9.TabIndex = 10;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = false;
			this.btn9.Click += new System.EventHandler(this.Btn9Click);
			// 
			// btn6
			// 
			this.btn6.BackColor = System.Drawing.Color.Red;
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btn6.Location = new System.Drawing.Point(192, 234);
			this.btn6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(68, 58);
			this.btn6.TabIndex = 11;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = false;
			this.btn6.Click += new System.EventHandler(this.Btn6Click);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.Color.Red;
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btn3.Location = new System.Drawing.Point(192, 166);
			this.btn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(68, 58);
			this.btn3.TabIndex = 12;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.Btn3Click);
			// 
			// btn0
			// 
			this.btn0.BackColor = System.Drawing.Color.Red;
			this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btn0.Location = new System.Drawing.Point(40, 370);
			this.btn0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(144, 58);
			this.btn0.TabIndex = 13;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = false;
			this.btn0.Click += new System.EventHandler(this.Btn0Click);
			// 
			// btnComa
			// 
			this.btnComa.BackColor = System.Drawing.Color.Red;
			this.btnComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnComa.Location = new System.Drawing.Point(192, 370);
			this.btnComa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnComa.Name = "btnComa";
			this.btnComa.Size = new System.Drawing.Size(68, 58);
			this.btnComa.TabIndex = 14;
			this.btnComa.Text = ",";
			this.btnComa.UseVisualStyleBackColor = false;
			this.btnComa.Click += new System.EventHandler(this.BtnComaClick);
			// 
			// btnIgual
			// 
			this.btnIgual.BackColor = System.Drawing.Color.Red;
			this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIgual.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnIgual.Location = new System.Drawing.Point(40, 437);
			this.btnIgual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnIgual.Name = "btnIgual";
			this.btnIgual.Size = new System.Drawing.Size(220, 58);
			this.btnIgual.TabIndex = 15;
			this.btnIgual.Text = "=";
			this.btnIgual.UseVisualStyleBackColor = false;
			this.btnIgual.Click += new System.EventHandler(this.BtnIgualClick);
			// 
			// btnCA
			// 
			this.btnCA.BackColor = System.Drawing.Color.Red;
			this.btnCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCA.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnCA.Location = new System.Drawing.Point(283, 167);
			this.btnCA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCA.Name = "btnCA";
			this.btnCA.Size = new System.Drawing.Size(84, 58);
			this.btnCA.TabIndex = 16;
			this.btnCA.Text = "CA";
			this.btnCA.UseVisualStyleBackColor = false;
			this.btnCA.Click += new System.EventHandler(this.BtnCAClick);
			// 
			// btnC
			// 
			this.btnC.BackColor = System.Drawing.Color.Red;
			this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnC.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnC.Location = new System.Drawing.Point(375, 167);
			this.btnC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(68, 58);
			this.btnC.TabIndex = 17;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = false;
			this.btnC.Click += new System.EventHandler(this.BtnCClick);
			// 
			// btnSuma
			// 
			this.btnSuma.BackColor = System.Drawing.Color.Red;
			this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuma.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnSuma.Location = new System.Drawing.Point(299, 234);
			this.btnSuma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(68, 58);
			this.btnSuma.TabIndex = 19;
			this.btnSuma.Text = "+";
			this.btnSuma.UseVisualStyleBackColor = false;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnDiv
			// 
			this.btnDiv.BackColor = System.Drawing.Color.Red;
			this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiv.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnDiv.Location = new System.Drawing.Point(375, 302);
			this.btnDiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(68, 58);
			this.btnDiv.TabIndex = 20;
			this.btnDiv.Text = "÷";
			this.btnDiv.UseVisualStyleBackColor = false;
			this.btnDiv.Click += new System.EventHandler(this.BtnDivClick);
			// 
			// btnResta
			// 
			this.btnResta.BackColor = System.Drawing.Color.Red;
			this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResta.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnResta.Location = new System.Drawing.Point(375, 234);
			this.btnResta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(68, 58);
			this.btnResta.TabIndex = 21;
			this.btnResta.Text = "-";
			this.btnResta.UseVisualStyleBackColor = false;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnRaiz
			// 
			this.btnRaiz.BackColor = System.Drawing.Color.Red;
			this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRaiz.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnRaiz.Location = new System.Drawing.Point(299, 370);
			this.btnRaiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRaiz.Name = "btnRaiz";
			this.btnRaiz.Size = new System.Drawing.Size(68, 58);
			this.btnRaiz.TabIndex = 22;
			this.btnRaiz.Text = "√x";
			this.btnRaiz.UseVisualStyleBackColor = false;
			this.btnRaiz.Click += new System.EventHandler(this.Button22Click);
			// 
			// btnFac
			// 
			this.btnFac.BackColor = System.Drawing.Color.Red;
			this.btnFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFac.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnFac.Location = new System.Drawing.Point(375, 370);
			this.btnFac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnFac.Name = "btnFac";
			this.btnFac.Size = new System.Drawing.Size(68, 58);
			this.btnFac.TabIndex = 23;
			this.btnFac.Text = "x!";
			this.btnFac.UseVisualStyleBackColor = false;
			this.btnFac.Click += new System.EventHandler(this.BtnFacClick);
			// 
			// btnMulti
			// 
			this.btnMulti.BackColor = System.Drawing.Color.Red;
			this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMulti.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnMulti.Location = new System.Drawing.Point(299, 302);
			this.btnMulti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnMulti.Name = "btnMulti";
			this.btnMulti.Size = new System.Drawing.Size(68, 58);
			this.btnMulti.TabIndex = 24;
			this.btnMulti.Text = "x";
			this.btnMulti.UseVisualStyleBackColor = false;
			this.btnMulti.Click += new System.EventHandler(this.BtnMultiClick);
			// 
			// btnPotencia
			// 
			this.btnPotencia.BackColor = System.Drawing.Color.Red;
			this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPotencia.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnPotencia.Location = new System.Drawing.Point(299, 437);
			this.btnPotencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnPotencia.Name = "btnPotencia";
			this.btnPotencia.Size = new System.Drawing.Size(68, 58);
			this.btnPotencia.TabIndex = 25;
			this.btnPotencia.Text = "^";
			this.btnPotencia.UseVisualStyleBackColor = false;
			this.btnPotencia.Click += new System.EventHandler(this.BtnPotenciaClick);
			// 
			// btnPorcentaje
			// 
			this.btnPorcentaje.BackColor = System.Drawing.Color.Red;
			this.btnPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPorcentaje.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnPorcentaje.Location = new System.Drawing.Point(375, 437);
			this.btnPorcentaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnPorcentaje.Name = "btnPorcentaje";
			this.btnPorcentaje.Size = new System.Drawing.Size(68, 58);
			this.btnPorcentaje.TabIndex = 26;
			this.btnPorcentaje.Text = "%";
			this.btnPorcentaje.UseVisualStyleBackColor = false;
			this.btnPorcentaje.Click += new System.EventHandler(this.BtnPorcentajeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(491, 522);
			this.Controls.Add(this.btnPorcentaje);
			this.Controls.Add(this.btnPotencia);
			this.Controls.Add(this.btnMulti);
			this.Controls.Add(this.btnFac);
			this.Controls.Add(this.btnRaiz);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnCA);
			this.Controls.Add(this.btnIgual);
			this.Controls.Add(this.btnComa);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.txtPantalla);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "calculadora";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnPorcentaje;
		private System.Windows.Forms.Button btnPotencia;
		private System.Windows.Forms.Button btnMulti;
		private System.Windows.Forms.Button btnFac;
		private System.Windows.Forms.Button btnRaiz;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnDiv;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnCA;
		private System.Windows.Forms.Button btnIgual;
		private System.Windows.Forms.Button btnComa;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.TextBox txtPantalla;
	}
}
