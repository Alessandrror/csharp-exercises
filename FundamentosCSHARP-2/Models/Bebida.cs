using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP_2.Models
{
    public class Bebida
    {
        // public permite que sea accesible
        // private lo vuelve inaccesible a menos que sea la misma clase
        // protected permite ser accesido por la misma clase y las clases heredadas de la misma
        // sí no se colocan el get; y set; por defecto será accesible porque se considerará de tipo internal
        private string Nombre { get; set; }

        public int Cantidad { get; set; }

        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public void Beberse(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;
        }
    }
}

