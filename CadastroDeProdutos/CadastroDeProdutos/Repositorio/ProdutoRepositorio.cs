using CadastroDeProdutos.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace CadastroDeProdutos.Repositorio
{
    public class ProdutoRepositorio(IConfiguration configuration)
    {
        // Declara um campo privado somente leitura para armazenar a string de conexão com o MySQL.
        private readonly string _conexaoMySQL = configuration.GetConnectionString("ConexaoMySQL");

        public void AdicionarUsuario(Produto usuario)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                var cmd = conexao.CreateCommand();
                // Cria um novo comando SQL para inserir dados na tabela 'cliente'
                cmd.CommandText = "INSERT INTO usuario (Nome,Email,Senha) VALUES (@nome, @email, @senha)";

                // Adiciona um parâmetro para o email, definindo seu tipo e valor
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = usuario.Nome;
                // Adiciona um parâmetro para o email, definindo seu tipo e valor
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = usuario.Email;
                // Adiciona um parâmetro para o senha, definindo seu tipo e valor
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Senha;

                // Executa o comando SQL de inserção e retorna o número de linhas afetadas
                cmd.ExecuteNonQuery();
                // Fecha explicitamente a conexão com o banco de dados 
                conexao.Close();

            }
        }
    }
}
