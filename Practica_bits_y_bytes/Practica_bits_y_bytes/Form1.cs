using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_bits_y_bytes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnprocesar_Click(object sender, EventArgs e)
		{
			Int32 NumEn = Convert.ToInt32(txtentrada.Text);
			string SenLvlCardinal = Convert.ToString(NumEn, 2);
			lbltest.Text = Convert.ToString(SenLvlCardinal);
			txtsensores2.Text = Convert.ToString(Sensor2(NumEn));
			txtsensores1.Text = Convert.ToString(Sensor1(NumEn));
			Nivel(NumEn);
			Direccion(NumEn);
			txtreadDate.Text=Convert.ToString(FechaRead(NumEn));
			
		}

		/// <summary>
		/// Regresa un 1 o 0 si el 7mo bit esta en 1 o 0 respectivamente
		/// </summary>
		/// <param name="numS1"></param>
		/// <returns></returns>
		int Sensor1(Int32 numS1)
		{
			return (numS1 & 64) >> 6;
		}

		/// <summary>
		/// Regresa un 1 o 0 si el 8vo bit esta en 1 o 0 respectivamente
		/// </summary>
		/// <param name="numS2"></param>
		/// <returns></returns>
		int Sensor2(Int32 numS2)
		{
			return (numS2 & 128) >> 7;
		}

		/// <summary>
		/// Segun el valor de los 4 y 5, desde 0 a 3, se regresara un numero igual e imprimira
		/// el estado de un contenedor
		/// </summary>
		/// <param name="numN"></param>
		/// <returns></returns>
		int Nivel(int numN)
		{
			int ambos = (byte)(numN >> 4);
			if (ambos == 2)
			{
				txtnivel.Text = "LLeno";
				return 2;
			}
			else if (ambos == 0)
			{
				txtnivel.Text = "Vacio";
				return ambos;
			}
			else if (ambos == 3)
			{
				txtnivel.Text = "LLenando";
				return ambos;
			}
			else
			{
				txtnivel.Text = "Nivel Medio";
				return 1;
			}
		}

		/// <summary>
		/// Devuelve valor de acuerdo a la direccion en el numero enviado e imprimira la 
		/// direccion cardinal de este
		/// </summary>
		/// <param name="numD"></param>
		void Direccion(Int32 numD)
		{
			byte cardinal = (byte)(numD >> 1);
			cardinal = (byte)(numD & 7);
			switch (cardinal)
			{
				case 0:
					txtdireccion.Text = "N";
					//return 0;
					break;
				case 1:
					txtdireccion.Text = "NE";
					//return 1;
					break;
				case 2:
					txtdireccion.Text = "E";
					//return 2;
					break;
				case 3:
					txtdireccion.Text = "SE";
					//return 3;
					break;
				case 4:
					txtdireccion.Text = "S";
					//return 4;
					break;
				case 5:
					txtdireccion.Text = "SO";
					//return 5;
					break;
				case 6:
					txtdireccion.Text = "O";
					//return 6;
					break;
				case 7:
					txtdireccion.Text = "NO";
					//return 7;
					break;
			}
						
		}

		void FechaDate(byte fechadia, byte fechames, byte fechayear)
		{
			byte Dia = fechadia;
			byte Mes = fechames;
			byte Year = fechayear;
			txtreadDate.Text = Dia.ToString() + "/" + Mes.ToString() + "/" + Year.ToString();
		}

		/// <summary>
		/// Devuelve la fecha en el numero ingresado de acuedo al 2do y 3er byte del mismo
		/// </summary>
		/// <param name="date"></param>
		/// <returns></returns>
		string FechaRead(Int32 date)
		{
			int Day = (date & 31);
			int Mnt = (date >> 5);
			int Month = (Mnt & 15);
			int Yr = (date >> 9);
			int Year = (Yr & 127);
			Year += 1900;
			string Fecha = Convert.ToString(Year) + "/" + Convert.ToString(Month) + "/" + Convert.ToString(Day);
			return Fecha;
		}

		/// <summary>
		/// Convierte la fecha de btndateChange a decimal para mostrarla como numero entero
		/// </summary>
		/// <param name="y"></param>
		/// <param name="m"></param>
		/// <param name="d"></param>
		void ChangeDate(int y, int m, int d)
		{
			Int32 Chg = 0;
			y -= 1900;
			Chg = (y << 9) + (m << 5) + (d);
			txtChangedDate.Text = Chg.ToString();
		}
		
		/// <summary>
		/// Toma la fecha del DateTimePicker y la convierte a base 2 en 2 bytes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btndateChange_Click(object sender, EventArgs e)
		{
			DateTime dtf = dateTimePicker1.Value;
			string year = dtf.Year.ToString();
			string month = dtf.Month.ToString();
			string day = dtf.Day.ToString();
			int Y = Convert.ToInt32(year);
			int M = Convert.ToInt32(month);
			int D = Convert.ToInt32(day);
			ChangeDate(Y, M, D);
		}
	}
}
