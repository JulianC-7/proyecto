using proyectoindicadores2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace proyectoindicadores2.Controllers
{
    public class ControlRepresenVisual
    {

        RepresenVisual objRepresenVisual;
        public ControlRepresenVisual(RepresenVisual objRepresenVisual)
        {
            this.objRepresenVisual = objRepresenVisual;
        }

        public string guardar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            string nom = objRepresenVisual.Nombre;

            string comandoSQL = String.Format("INSERT INTO represenvisual(nombre) VALUES('{0}')", nom);
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

        public RepresenVisual consultar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            int id = objRepresenVisual.Id;
            string comandoSQL = String.Format("SELECT * FROM represenvisual WHERE id='{0}'", id);
            string msg = "ok";
            objControlConexion.abrirBD();
            DataSet objDataSet = objControlConexion.ejecutarConsultaSql(comandoSQL);
            try
            {
                if (objDataSet.Tables[0].Rows.Count > 0)
                {
                    objRepresenVisual.Nombre = objDataSet.Tables[0].Rows[0][1].ToString();
                    objControlConexion.cerrarBD();
                }
            }
            catch (Exception objException)
            {
                msg = objException.Message;
            }
            return this.objRepresenVisual;
        }

        public string modificar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            int id = objRepresenVisual.Id;
            string nom = objRepresenVisual.Nombre;
            string comandoSQL = String.Format("UPDATE represenvisual SET nombre='{0}' WHERE id='{1}'", nom, id);
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
            int id = objRepresenVisual.Id;
            string comandoSQL = String.Format("DELETE FROM represenvisual WHERE id='{0}'", id);
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