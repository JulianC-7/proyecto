using proyectoindicadores2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace proyectoindicadores2.Controllers
{
    public class ControlIndicadores
    {

        Indicadores objIndicadores;
        public ControlIndicadores(Indicadores objIndicadores)
        {
            this.objIndicadores = objIndicadores;
        }

        public string guardar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            string cod = objIndicadores.Codigo;
            string nom = objIndicadores.Nombre;
            string obj = objIndicadores.Objetivo;
            string alc = objIndicadores.Alcance;
            string form = objIndicadores.Formula;
            int fkidti = objIndicadores.fkIDTI;
            int fkidum = objIndicadores.fkIDUM;
            string met = objIndicadores.Meta;
            int fkids = objIndicadores.fkIDS;
            int fkidf = objIndicadores.fkIDF;
            string fkida = objIndicadores.fkIDA;
            string fkidl = objIndicadores.fkIDL;
            string fkidn = objIndicadores.fkIDN;
            string fkidp = objIndicadores.fkIDP;

            string comandoSQL = String.Format("INSERT INTO indicador (codigo, nombre, objetivo, alcance, formula, fkidtipoindicador, fkidunidadmedicion, meta, fkidsentido, fkidfrecuencia, fkidarticulo, fkidliteral, fkidnumeral, fkidparagrafo) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", cod, nom, obj, alc, form, fkidti, fkidum, met, fkids, fkidf, fkida, fkidl, fkidn, fkidp);
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

        public Indicadores consultar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            int id = objIndicadores.Id;
            string comandoSQL = String.Format("SELECT * FROM indicador WHERE id='{0}'", id);
            string msg = "ok";
            objControlConexion.abrirBD();
            DataSet objDataSet = objControlConexion.ejecutarConsultaSql(comandoSQL);
            try
            {
                if (objDataSet.Tables[0].Rows.Count > 0)
                {
                    objIndicadores.Codigo = objDataSet.Tables[0].Rows[0][1].ToString();
                    objIndicadores.Nombre = objDataSet.Tables[0].Rows[0][2].ToString();
                    objIndicadores.Objetivo = objDataSet.Tables[0].Rows[0][3].ToString();
                    objIndicadores.Alcance = objDataSet.Tables[0].Rows[0][4].ToString();
                    objIndicadores.Formula = objDataSet.Tables[0].Rows[0][5].ToString();
                    objIndicadores.Meta = objDataSet.Tables[0].Rows[0][8].ToString();
                    objIndicadores.fkIDTI = Convert.ToInt32(objDataSet.Tables[0].Rows[0][6].ToString());
                    objIndicadores.fkIDUM = Convert.ToInt32(objDataSet.Tables[0].Rows[0][7].ToString());
                    objIndicadores.fkIDS = Convert.ToInt32(objDataSet.Tables[0].Rows[0][9].ToString());
                    objIndicadores.fkIDF = Convert.ToInt32(objDataSet.Tables[0].Rows[0][10].ToString());
                    objIndicadores.fkIDA = objDataSet.Tables[0].Rows[0][11].ToString();
                    objIndicadores.fkIDL = objDataSet.Tables[0].Rows[0][12].ToString();
                    objIndicadores.fkIDN = objDataSet.Tables[0].Rows[0][13].ToString();
                    objIndicadores.fkIDP = objDataSet.Tables[0].Rows[0][14].ToString();

                    objControlConexion.cerrarBD(); 
                }
            }
            catch (Exception objException)
            {
                msg = objException.Message;
            }
            return this.objIndicadores;
        }

        public string modificar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            int id = objIndicadores.Id;
            string nom = objIndicadores.Nombre;
            string alc = objIndicadores.Alcance;
            string obj = objIndicadores.Objetivo;
            string form = objIndicadores.Formula;
            string met = objIndicadores.Meta;
            string cod = objIndicadores.Codigo;
            int fkidti = objIndicadores.fkIDTI;
            int fkidum = objIndicadores.fkIDUM;
            int fkids = objIndicadores.fkIDS;
            int fkidf = objIndicadores.fkIDF;
            string fkida = objIndicadores.fkIDA;
            string fkidl = objIndicadores.fkIDL;
            string fkidn = objIndicadores.fkIDN;
            string fkidp = objIndicadores.fkIDP;
            string comandoSQL = String.Format("UPDATE indicador SET (nombre), (codigo), (objetivo), (alcance), (formula), (meta), (fkidtipoindicador), (fkidunidaddemedicion), (fkidsentido), (fkidfrecuencia), (fkidarticulo), (fkidliteral), (fkidnumeral), (fkidparagrafo) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}') WHERE id='{14}')", nom, cod, obj, alc, form, met, fkidti, fkidum, fkids, fkidf, fkida, fkidl, fkidn, fkidp, id );
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
            int id = objIndicadores.Id;
            string comandoSQL = String.Format("DELETE FROM indicador WHERE id='{0}'", id);
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