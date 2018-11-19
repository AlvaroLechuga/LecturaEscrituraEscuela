using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFicherosEscuela
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void btnLimpiarAlumno_Click(object sender, EventArgs e)
		{
			txtDNIAlumno.Text = "";
			txtNombreAlumno.Text = "";
			txtFechaNacimientoAlumno.Text = "";
			txtDireccionAlumno.Text = "";
			txtTelefonoAlumno.Text = "";
		}

		private void btnGuardarAlumno_Click(object sender, EventArgs e)
		{
			if(txtDNIAlumno.Text.Equals("") || txtNombreAlumno.Text.Equals("") || txtFechaNacimientoAlumno.Text.Equals("") || txtDireccionAlumno.Text.Equals("") || txtTelefonoAlumno.Text.Equals(""))
			{
				MessageBox.Show("No has completado algun campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int number1 = 0;
				bool canConvert = int.TryParse(txtTelefonoAlumno.Text, out number1);
				if (canConvert)
				{
					StreamWriter fichero;
					string alumno = txtDNIAlumno.Text + "|" + txtNombreAlumno.Text + "|" + txtFechaNacimientoAlumno.Text + "|" + txtDireccionAlumno.Text + "|" + txtTelefonoAlumno.Text;
					if (File.Exists("Alumnos.txt"))
					{
						try
						{
							fichero = File.AppendText("Alumnos.txt");
							fichero.WriteLine(alumno);
							fichero.Close();
						}
						catch (IOException ioe)
						{
							MessageBox.Show("No se ha podido escribir");
							MessageBox.Show("Error exacto: {0}", ioe.Message);
						}
					}
					else
					{
						try
						{
							fichero = File.CreateText("Alumnos.txt");
							fichero.WriteLine(alumno);
							fichero.Close();
						}
						catch (IOException ioe)
						{
							MessageBox.Show("No se ha podido escribir");
							MessageBox.Show("Error exacto: {0}", ioe.Message);
						}


					}

				}
				else
				{
					MessageBox.Show("Has introducido una letra en el telefono", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


			}
		}
				
	}
}
