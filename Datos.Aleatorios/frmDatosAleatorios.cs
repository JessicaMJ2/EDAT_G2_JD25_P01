using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos.Aleatorios
{
    public partial class frmDatosAleatorios : Form
    {

        List<Empleado> empleados = new List<Empleado>();

        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        private void btnGenerarDatos_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Empleado empleado = new Empleado();


            empleado.Numero = rnd.Next(1000, 9999);
            empleado.Nombre = "Empleado" + empleado.Numero;
            empleado.FechaNacimiento = new DateTime(rnd.Next(1970, 2005), rnd.Next(1, 13), rnd.Next(1, 28));
            empleado.Sexo = (rnd.Next(0, 2) == 0) ? "Masculino" : "Femenino";
            empleado.Grupo = (char)('A' + rnd.Next(1, 5));
            empleado.Sueldo = Math.Round(rnd.NextDouble() * 10000, 2);
            empleado.SeguroMedico = (rnd.Next(2) == 0);

            empleados.Add(empleado);

            MostrarEmpleado(empleado);
        }

        private void MostrarEmpleado(Empleado empleado)
        {

            intNumero.Text = empleado.Numero.ToString();
            strNombre.Text = empleado.Nombre;
            dtmFechaNacimiento.Value = empleado.FechaNacimiento;
            strSexoM.Checked = empleado.Sexo == "Masculino";
            strSexoF.Checked = empleado.Sexo == "Femenino";
            chrGrupo.Text = empleado.Grupo.ToString();
            dblSueldo.Text = empleado.Sueldo.ToString("F2");
            blnSeguroMedico.Checked = empleado.SeguroMedico;

        }

        private void Numero_Click(object sender, EventArgs e)
        {

        }
    }
}
