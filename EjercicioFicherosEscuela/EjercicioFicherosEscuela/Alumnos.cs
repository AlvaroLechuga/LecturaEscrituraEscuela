using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFicherosEscuela
{
	class Alumnos
	{
		private string dni;
		private string nombre;
		private string fecha;
		private string direccion;

		public Alumnos()
		{
		}

		public Alumnos(string dni, string nombre, string fecha, string direccion, int telefono)
		{
			this.dni = dni;
			this.nombre = nombre;
			this.fecha = fecha;
			this.direccion = direccion;
			this.Telefono = telefono;
		}

		public string Dni { get => dni; set => dni = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Fecha { get => fecha; set => fecha = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public int Telefono { get; set; }
	}
}
