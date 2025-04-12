using proyectoindicadores2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoindicadores2.Controllers
{

    public class ControlRolUsuario
    {
        RolUsuario objRolUsuario;

        public ControlRolUsuario(RolUsuario objRolUsuario)
        {
            this.objRolUsuario = objRolUsuario;
        }
        public string guardar()
        {
            string baseDeDatos = "bd_indicadores_1330.mdf";
            ControlConexion objControlConexion = new ControlConexion(baseDeDatos);
            string fkemail = objRolUsuario.FkEmail;
            int fkidrol = objRolUsuario.FkIdRol;
            string comandoSQL = String.Format("INSERT INTO rol_usuario(fkemail,fkidrol) VALUES('{0}','{1}')", fkemail, fkidrol);
            string msg = "ok";
            try
            {
                objControlConexion.abrirBD();
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