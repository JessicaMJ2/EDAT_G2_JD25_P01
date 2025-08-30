using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Aleatorios
{
    internal class Empleado
    {
        private int _intNumero;
        private string _strNombre;
        private DateTime _dtmFechaNacimiento;
        private string _strSexo;
        private char _chrGrupo;
        private double _dblSueldo;
        private bool _blnSeguroMedico;

        public int Numero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        } 

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }

        public string Sexo
        {
            get { return _strSexo; }
            set { _strSexo = value; }
        }

        public char Grupo
        {
            get { return _chrGrupo; }
            set { _chrGrupo = value; }
        }

        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }

        public bool SeguroMedico
        {
            get { return _blnSeguroMedico; }
            set { _blnSeguroMedico = value;}
        }

        public Empleado() { }

        public Empleado(int numero, string nombre, DateTime fechaNacimiento,
                        string sexo, char grupo, double sueldo, bool seguroMedico)
        {
            _intNumero = numero;
            _strNombre = nombre;
            _dtmFechaNacimiento = fechaNacimiento;
            _strSexo = sexo;
            _chrGrupo = grupo;
            _dblSueldo = sueldo;
            _blnSeguroMedico = seguroMedico;
        }

        public override string ToString()
        {
            return "Número: " + Numero + "\n" +
                   "Nombre: " + Nombre + "\n" +
                   "Fecha Nacimiento: " + FechaNacimiento.ToLongDateString() + "\n" +
                   "Sexo: " + Sexo + "\n" +
                   "Grupo: " + Grupo + "\n" +
                   "Sueldo: " + Sueldo.ToString("C") + "\n" +
                   "Seguro Médico: " + (SeguroMedico ? "Sí" : "No");
        }
    }
}
