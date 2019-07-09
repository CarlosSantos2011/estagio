using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace LojaSys.AcessaDados
{
    public class Context
    {
        private SqlConnection conexao;

        private  SqlConnection CriarConexao()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
            return conexao;
        }
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        private SqlCommand CriarComando(CommandType cmdType,  string nomeProcedure )
        {
            conexao =  CriarConexao();
            conexao.Open();
            SqlCommand cmd = conexao.CreateCommand();
            cmd.CommandType = cmdType;
            cmd.CommandText = nomeProcedure;
            cmd.CommandTimeout = 7200;
            foreach(SqlParameter sqlParameter in sqlParameterCollection)
            {
                cmd.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
            }
            return cmd;
        }

        protected void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.AddWithValue(nomeParametro, valorParametro);
        }
        protected void LimparParametro()
        {
            sqlParameterCollection.Clear();
        }

        // Persiste (cria, deleta...)
        protected object ExecutarComando (CommandType cmdType, string nomeProcedure)
        {
            try
            {
                SqlCommand cmd = CriarComando(cmdType, nomeProcedure);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        // consulta
        protected DataTable ExecutaConsulta(CommandType cmdType, string nomeProcedure)
        {
            try
            {
                SqlCommand cmd = CriarComando(cmdType, nomeProcedure);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
