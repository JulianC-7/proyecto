using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoindicadores2.Models
{
    public class RepresenVisualPorIndicador
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public RepresenVisualPorIndicador(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public RepresenVisualPorIndicador()
        {
            this.id = 0;
            this.nombre = "";
        }
    }
}