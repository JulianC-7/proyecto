﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoindicadores2.Models
{
    public class RepresenVisual
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public RepresenVisual(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public RepresenVisual()
        {
            this.id = 0;
            this.nombre = "";
        }
    }
}