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
	public partial class Form7 : Form
	{
		Asignaturas[] asignaturas = new Asignaturas[100];

		public Form7()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int pos = cbIdAsignatura.Items.IndexOf(cbIdAsignatura.SelectedItem);
			txtNombreAsignatura.Text = asignaturas[pos].Nombre;
			txtDepartamentoAsignatura.Text = asignaturas[pos].Departamento;
			txtHorasAsignatura.Text = Convert.ToString(asignaturas[pos].Horas);
			
		}

		private void Form7_Load(object sender, EventArgs e)
		{
			StreamReader fichero;
			string linea = "";
			int con = 0;
			string[] temporal;			fichero = File.OpenText("Asignaturas.txt");

			while ((linea = fichero.ReadLine()) != null)
			{
				temporal = linea.Split('|');

				if (!linea.Equals(""))
				{
					asignaturas[con] = new Asignaturas();
					asignaturas[con].Id = Convert.ToInt32(temporal[0]);
					asignaturas[con].Nombre = temporal[1];
					asignaturas[con].Departamento = temporal[2];
					asignaturas[con].Horas = Convert.ToInt32(temporal[3]);

					cbIdAsignatura.Items.Add(asignaturas[con].Id);
					con++;
				}
			}
		}
	}
}
