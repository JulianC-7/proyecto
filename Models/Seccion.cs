using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoindicadores2.Models
{
    public class Seccion
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Seccion(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Seccion()
        {
            this.id = 0;
            this.nombre = "";
        }
    }
}