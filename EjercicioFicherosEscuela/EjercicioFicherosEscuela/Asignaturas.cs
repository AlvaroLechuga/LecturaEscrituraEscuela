using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFicherosEscuela
{
	class Asignaturas
	{
		private int id;
		private string nombre;
		private string departamento;
		private int horas;

		public Asignaturas()
		{
		}

		public Asignaturas(int id, string nombre, string departamento, int horas)
		{
			this.id = id;
			this.nombre = nombre;
			this.departamento = departamento;
			this.horas = horas;
		}

		public int Id { get => id; set => id = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Departamento { get => departamento; set => departamento = value; }
		public int Horas { get => horas; set => horas = value; }
	}
}
