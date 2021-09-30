using System;
using System.Web;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Doceria.Repositorio
{
    public class Conexao
    {
        MySqlConnection cn = new MySqlConnection("Server=localhost;DataBase=db_distridoce;user=rodrigo;pwd=12345678");
        public static string msg;

        public MySqlConnection ConectarBd()
        {
            try
            {
                cn.Open();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao conectar" + erro.Message;
            }
            return cn;
        }

        public MySqlConnection DesconectarBd()
        {
            try
            {
                cn.Close();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao desconectar" + erro.Message;
            }
            return cn;
        }
    }
}