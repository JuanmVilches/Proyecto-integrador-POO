using Proyecto_integrador_club_deportivo;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_integrador_club_deportivo
{
    internal class Socio : Alumno
    {
        private DateTime vencimiento;

        public Socio(int identificador, int documento, string nombre, string apellido, DateTime vencimiento, bool apto_fisico, string actividad)
            : base(identificador, documento, nombre, apellido, true, apto_fisico, actividad) // esSocio = true
        {
            this.vencimiento = vencimiento;
        }

        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }

        public override void pagar()
        {
            base.pagar();
        }

        public override bool obtenerEstadoPago()
        {
            return this.vencimiento < DateTime.Today;
        }
    }
}