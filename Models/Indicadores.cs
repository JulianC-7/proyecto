using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoindicadores2.Models
{
    public class Indicadores
    {
        private int id;
        private string nombre;
        private string objetivo;
        private string alcance;
        private string formula;
        private string meta;
        private string codigo;
        private int fkidti;
        private int fkidum;
        private int fkids;
        private int fkidf;
        private string fkida;
        private string fkidl;
        private string fkidn;
        private string fkidp;


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public string Objetivo { get => objetivo; set => objetivo = value; }

        public string Alcance { get => alcance; set => alcance = value; }

        public string Formula { get => formula; set => formula = value; }

        public string Meta { get => meta; set => meta = value; }

        public string Codigo { get => codigo; set  => codigo = value; }
        public int fkIDTI { get => fkidti; set  => fkidti = value; }
        public int fkIDUM { get => fkidum; set => fkidum = value; }
        public int fkIDS { get => fkids; set => fkids = value; }
        public int fkIDF { get => fkidf; set => fkidf = value; }
        public string fkIDA { get => fkida; set => fkida = value; }
        public string fkIDL { get => fkidl; set => fkidl = value; }
        public string fkIDN { get => fkidn; set => fkidn = value; }
        public string fkIDP { get => fkidp; set => fkidp = value; }
        



        public Indicadores(int id, string nombre, string objetivo, string alcance, string formula, string meta, string codigo, int 
            fkidti, int fkidum, int fkids, int fkidf, string fkida, string fkidl, string fkidn, string fkidp)
        {
            this.id = id;
            this.nombre = nombre;
            this.objetivo = objetivo;
            this.alcance = alcance;
            this.formula = formula;
            this.meta = meta;
            this.codigo = codigo;
            this.fkidti = fkidti;
            this.fkidum = fkidum;
            this.fkids = fkids;
            this.fkidf = fkidf;
            this.fkida = fkida;
            this.fkidl = fkidl;
            this.fkidn = fkidn;
            this.fkidp = fkidp;

            
            
            

        }
        public Indicadores()
        {
            this.id = 0;
            this.nombre = "";
            this.objetivo = "";
            this.alcance = "";
            this.formula = "";
            this.meta = "";
            this.codigo = "";
            this.fkidti = 0;
            this.fkidum = 0;
            this.fkids = 0;
            this.fkidf = 0;
            this.fkida = "";
            this.fkidl = "";
            this.fkidn = "";
            this.fkidp = "";
        }


    }
}