/*
 * Created by SharpDevelop.
 * User: Usuário
 * Date: 17/06/2026
 * Time: 11:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace PROJETO17
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmCadastro : Form
	{
		public frmCadastro()
		{
			InitializeComponent();
			txtnome.Enabled=false;
			txtemail.Enabled=false;
			txtfone.Enablend=false;
		}
		
		void limpar()
		{
			sqlcon.Close();
			txtname.Clear();
			txtemail.Clear();
			txtfone.Clear;
			txtpesquisar.Clear();
		}
		
		void CarregarDados()
		{
			String strsql = "SELECT codigo, nome, email, telefone FROM tbclient";
			MySqlConnection conexao = new MySqlConnection(strcon);
			try{
				conexao.Open();
				MySqlDataAdapter adaptador = new MySqlDataAdapter(strsql, conexao);
				DataTable tabela = new DataTable();
				adaptador.Fill(tabela);
				dataGridView1.DataSource = tabela;
			}
			catch (Exception ex)
			{
				MessageBpox.Show("Erro ao carregar os clientes " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}
		
	}
}
