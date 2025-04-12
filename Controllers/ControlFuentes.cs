using proyectoindicadores2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace proyectoindicadores2.Controllers
{
    public class ControlFuentes
    {
        Fuentes  objFuentes;
        public ControlFuentes(Fuentes objFuentes)
        {
            this.objFuentes = objFuentes;
        }

        public string guardar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            string nom = objFuentes.Nombre;
            
            string comandoSQL = String.Format("INSERT INTO fuente(nombre) VALUES('{0}')", nom);
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

        public Fuentes consultar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            int id = objFuentes.Id;
            string comandoSQL = String.Format("SELECT * FROM fuente WHERE id='{0}'", id);
            string msg = "ok";
            objControlConexion.abrirBD();
            DataSet objDataSet = objControlConexion.ejecutarConsultaSql(comandoSQL);
            try
            {
                if (objDataSet.Tables[0].Rows.Count > 0)
                {
                    objFuentes.Nombre = objDataSet.Tables[0].Rows[0][1].ToString();
                    objControlConexion.cerrarBD();
                }
            }
            catch (Exception objException)
            {
                msg = objException.Message;
            }
            return this.objFuentes;
        }

        public string modificar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            int id = objFuentes.Id;
            string nom = objFuentes.Nombre;
            string comandoSQL = String.Format("UPDATE fuente SET nombre='{0}' WHERE id='{1}'", nom, id);
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
            int id = objFuentes.Id;
            string comandoSQL = String.Format("DELETE FROM fuente WHERE id='{0}'", id);
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