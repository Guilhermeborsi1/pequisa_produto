using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Lib
{
    public class Class1
    {
        public string Chaveconexao = "Data Source=10.39.45.44;Initial Catalog=TI_Noite;User ID=Turma2022;Password=Turma2022@2022";

        public DataSet Listar_Produtos(string p_Nome_Produto)
        {

            DataSet DataSetProduto = new DataSet();
            SqlConnection Conexao = new SqlConnection(Chaveconexao);
            Conexao.Open();

            string wQuery = $"select * from Produto where Nome_Produto = '{p_Nome_Produto}'";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(DataSetProduto);

            foreach (DataRow linha in DataSetProduto.Tables[0].Rows)
            {
                Console.WriteLine(linha["Nome_Produto"]);
            }
            Conexao.Close();

            return DataSetProduto;
        }

        public DataSet Listar_Grupo(string p_Produto_grupo)
        {

            SqlConnection Conexao = new SqlConnection(Chaveconexao);
            DataSet DataSetProduto1 = new DataSet();
            Conexao.Open();
            string wQuery = "Select" +
                          $"      p.Nome_Produto as Produto_grupo,          " +
                          $"      g.Nome_Produto as Produto,                " +
                          $"  from Produto p,                               " +
                          $"      Produto g                                 " +
                          $"      where p.id_produto = g.id_produto_grupo   " +
                          $"      and g.Nome_produto = '{p_Produto_grupo}'  " +
                          $"      group by p.Nome_Produto,                  " +
                          $"                 g.Nome_Produto                 ";

            foreach (DataRow linha in DataSetProduto1.Tables[0].Rows)
            {
                Console.WriteLine(linha["Produto_grupo"]);
                Console.WriteLine(linha["Produto"]);
            }
            return DataSetProduto1;
        }




    }
}

