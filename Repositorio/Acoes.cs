using System;
using System.Web;
using System.Linq;
using Doceria.Models;
using Doceria.Repositorio;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Doceria.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarDoce(Doces doces)
        {

            MySqlCommand cmd = new MySqlCommand("insert into tbl_doces values(@iddoce, @tipo," +
                "@fabricante, @peso, @estoque)", con.ConectarBd());
            cmd.Parameters.Add("@iddoce", MySqlDbType.VarChar).Value = doces.Doce_cd;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = doces.Doce_tipo;
            cmd.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = doces.Doce_fornec;
            cmd.Parameters.Add("@peso", MySqlDbType.VarChar).Value = doces.Doce_peso;
            cmd.Parameters.Add("@estoque", MySqlDbType.VarChar).Value = doces.Doce_est;
            cmd.ExecuteNonQuery();
            con.DesconectarBd();

        }

        public Doces ListarCodDoces(int cod)
        {
            var comando = String.Format("select * from tbl_doces where Doce_cd  = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            var DadosDoce = cmd.ExecuteReader();
            return ListCodDoces(DadosDoce).FirstOrDefault();
        }

        public List<Doces> ListCodDoces(MySqlDataReader dt)
        {
            var AltAl = new List<Doces>();
            while (dt.Read())
            {
                var AlTemp = new Doces()
                {
                    Doce_cd = int.Parse(dt["iddoce"].ToString()),
                    Doce_tipo = dt["tipo"].ToString(),
                    Doce_fornec = dt["fabricante"].ToString(),
                    Doce_peso = int.Parse(dt["peso"].ToString()),
                    Doce_est = int.Parse(dt["estoque"].ToString()),
                };
                AltAl.Add(AlTemp);
            }

            dt.Close();
            return AltAl;
        }

        public List<Doces> ListarDoces()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tbl_doces", con.ConectarBd());
            var DadosDoces = cmd.ExecuteReader();
            return ListarTodosDoces(DadosDoces);
        }

        public List<Doces> ListarTodosDoces(MySqlDataReader dt)
        {
            var TodosDoces = new List<Doces>();
            while (dt.Read())
            {
                var DocesTemp = new Doces()
                {
                    Doce_cd = int.Parse(dt["iddoce"].ToString()),
                    Doce_tipo = dt["tipo"].ToString(),
                    Doce_fornec = dt["fabricante"].ToString(),
                    Doce_peso = int.Parse(dt["peso"].ToString()),
                    Doce_est = int.Parse(dt["estoque"].ToString()),
                };
                TodosDoces.Add(DocesTemp);
            }
            dt.Close();
            return TodosDoces;
        }

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbl_fornecedor values(@idforn, @nome," +
                "@endereco, @telefone, @email)", con.ConectarBd());
            cmd.Parameters.Add("@idforn", MySqlDbType.VarChar).Value = fornecedor.Forn_cod;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = fornecedor.Forn_nome;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = fornecedor.Forn_endereco;
            cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = fornecedor.Forn_telefone;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = fornecedor.Forn_email;
            cmd.ExecuteNonQuery();
            con.DesconectarBd();
        }

        public Fornecedor ListarCodForn(int cod)
        {
            var comando = String.Format("select * from tbl_fornecedor where Forn_cod = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            var DadosForn = cmd.ExecuteReader();
            return ListCodForn(DadosForn).FirstOrDefault();
        }

        public List<Fornecedor> ListCodForn(MySqlDataReader dt)
        {
            var AltAl = new List<Fornecedor>();
            while (dt.Read())
            {
                var FornTemp = new Fornecedor()
                {
                    Forn_cod = int.Parse(dt["idforn"].ToString()),
                    Forn_nome = dt["nome"].ToString(),
                    Forn_endereco = dt["endereco"].ToString(),
                    Forn_telefone = dt["telefone"].ToString(),
                    Forn_email = dt["email"].ToString(),
                };
                AltAl.Add(FornTemp);
            }

            dt.Close();
            return AltAl;
        }

        public List<Fornecedor> ListarForn()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tbl_fornecedor ", con.ConectarBd());
            var DadosForn = cmd.ExecuteReader();
            return ListarTodosForn(DadosForn);
        }

        public List<Fornecedor> ListarTodosForn(MySqlDataReader dt)
        {
            var TodosForn = new List<Fornecedor>();
            while (dt.Read())
            {
                var FornTemp = new Fornecedor()
                {
                    Forn_cod = int.Parse(dt["idforn"].ToString()),
                    Forn_nome = dt["nome"].ToString(),
                    Forn_endereco = dt["endereco"].ToString(),
                    Forn_telefone = dt["telefone"].ToString(),
                    Forn_email = dt["email"].ToString(),
                };
                TodosForn.Add(FornTemp);
            }
            dt.Close();
            return TodosForn;
        }

    }
}