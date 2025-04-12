using proyectoindicadores2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace proyectoindicadores2.Controllers
{
    public class ControlSeccion
    {
        Seccion objSeccion;
        public ControlSeccion(Seccion objSeccion)
        {
            this.objSeccion = objSeccion;
        }

        public string guardar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            string nom = objSeccion.Nombre;

            string comandoSQL = String.Format("INSERT INTO seccion(nombre) VALUES('{0}')", nom);
            string msg = "ok";
            objControlConexion.abrirBD();
            try
            {
                objControlConexion.ejecutarComandoSQL(comandoSQL);
                objControlConexion.cerrarBD();
            }
            catch (Exception objException)
            {
                msg = objException.Message;
            }
            return msg;
        }

        public Seccion consultar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            int id = objSeccion.Id;
            string comandoSQL = String.Format("SELECT * FROM seccion WHERE id='{0}'", id);
            string msg = "ok";
            objControlConexion.abrirBD();
            DataSet objDataSet = objControlConexion.ejecutarConsultaSql(comandoSQL);
            try
            {
                if (objDataSet.Tables[0].Rows.Count > 0)
                {
                    objSeccion.Nombre = objDataSet.Tables[0].Rows[0][1].ToString();
                    objControlConexion.cerrarBD();
                }
            }
            catch (Exception objException)
            {
                msg = objException.Message;
            }
            return this.objSeccion;
        }

        public string modificar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            int id = objSeccion.Id;
            string nom = objSeccion.Nombre;
            string comandoSQL = String.Format("UPDATE seccion SET nombre='{0}' WHERE id='{1}'", nom, id);
            string msg = "ok";
            objControlConexion.abrirBD();
            try
            {
                objControlConexion.ejecutarComandoSQL(comandoSQL);
                objControlConexion.cerrarBD();
            }
            catch (Exception objException)
            {
                msg = objException.Message;
            }
            return msg;
        }
        public string borrar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            int id = objSeccion.Id;
            string comandoSQL = String.Format("DELETE FROM seccion WHERE id='{0}'", id);
            string msg = "ok";
            objControlConexion.abrirBD();
            try
            {
                objControlConexion.ejecutarComandoSQL(comandoSQL);
                objControlConexion.cerrarBD();
            }
            catch (Exception objException)
            {
                msg = objException.Message;
            }
            return msg;
        }
    }
}