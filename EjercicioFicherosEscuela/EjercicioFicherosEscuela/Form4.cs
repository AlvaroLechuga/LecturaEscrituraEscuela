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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void btnLimpiarAsignatura_Click(object sender, EventArgs e)
		{
			txtIdAsignatura.Text = "";
			txtNombreAsignatura.Text = "";
			txtHorasAsignatura.Text = "";
			txtDepartamentoAsignatura.SelectedIndex = 0;
		}

		private void btnGuardarAsignatura_Click(object sender, EventArgs e)
		{
			if(txtIdAsignatura.Text.Equals("") || txtNombreAsignatura.Text.Equals("") || txtHorasAsignatura.Text.Equals("") || txtDepartamentoAsignatura.SelectedIndex == 0)
			{
				MessageBox.Show("No has completado algun campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int number1 = 0;
				int number2 = 0;

				bool canConvert = int.TryParse(txtIdAsignatura.Text, out number1);
				bool canConvert2 = int.TryParse(txtHorasAsignatura.Text, out number2);

				if(canConvert && canConvert2)
				{
					StreamWriter fichero;
					string asignatura = txtIdAsignatura.Text + "|" + txtNombreAsignatura.Text + "|" + txtDepartamentoAsignatura.SelectedItem.ToString() + "|" + txtHorasAsignatura.Text;

					if (File.Exists("Asignaturas.txt"))
					{
						try
						{
							fichero = File.AppendText("Asignaturas.txt");
							fichero.WriteLine(asignatura);
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
							fichero = File.CreateText("Asignaturas.txt");
							fichero.WriteLine(asignatura);
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
					MessageBox.Show("Has introducido una letra en el numero de horas o el ID de la asiganatura", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
