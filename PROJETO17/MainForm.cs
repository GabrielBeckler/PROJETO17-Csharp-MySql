using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJETO17
{
    public partial class frmCadastro : Form
    {
        private MySqlConnection sqlcon = null;

        private string strcon =
            "server=localhost;uid=root;password=123456;database=bdclientes2026";

        private int idSelecionado = -1;

        public frmCadastro()
        {
            InitializeComponent();

            txtnome.Enabled = false;
            txtemail.Enabled = false;
            txtfone.Enabled = false;
            txtpesquisar.Enabled = false;

            // Carrega os clientes ao abrir o formulário
            btnconsultartodos_Click(null, null);
        }

        // BOTÃO ADICIONAR
 
        private void btnadd_Click(object sender, EventArgs e)
        {
            LimparCampos();

            idSelecionado = -1;

            txtnome.Enabled = true;
            txtemail.Enabled = true;
            txtfone.Enabled = true;
            txtpesquisar.Enabled = true;

            txtnome.Focus();
        }

        // TEXTBOX NOME
        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            // Não precisa fazer nada aqui.
            // O evento pode permanecer vazio.
        }
        
        // BOTÃO EXCLUIR / LIMPAR
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado == -1)
            {
                LimparCampos();

                MessageBox.Show(
                    "Nenhum cliente selecionado.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Deseja realmente excluir este cliente?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
                return;

            string strsql =
                "DELETE FROM tbcliente WHERE codigo = @codigo";

            using (MySqlConnection conexao = new MySqlConnection(strcon))
            {
                try
                {
                    conexao.Open();

                    using (MySqlCommand comando =
                           new MySqlCommand(strsql, conexao))
                    {
                        comando.Parameters.AddWithValue(
                            "@codigo",
                            idSelecionado
                        );

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Cliente excluído com sucesso!",
                        "Confirmação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LimparCampos();

                    idSelecionado = -1;

                    DesabilitarCampos();

                    btnconsultartodos_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao excluir cliente: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        
        // BOTÃO SALVAR
        
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            // Validação
            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {
                MessageBox.Show(
                    "Digite o nome do cliente.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtnome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show(
                    "Digite o e-mail do cliente.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtemail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtfone.Text))
            {
                MessageBox.Show(
                    "Digite o telefone do cliente.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtfone.Focus();
                return;
            }

            string strsql =
                "INSERT INTO tbcliente (nome, email, telefone) " +
                "VALUES (@nome, @email, @telefone)";

            using (MySqlConnection conexao =
                   new MySqlConnection(strcon))
            {
                try
                {
                    conexao.Open();

                    using (MySqlCommand comando =
                           new MySqlCommand(strsql, conexao))
                    {
                        comando.Parameters.AddWithValue(
                            "@nome",
                            txtnome.Text
                        );

                        comando.Parameters.AddWithValue(
                            "@email",
                            txtemail.Text
                        );

                        comando.Parameters.AddWithValue(
                            "@telefone",
                            txtfone.Text
                        );

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Cliente cadastrado com sucesso!",
                        "Confirmação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LimparCampos();

                    idSelecionado = -1;

                    DesabilitarCampos();

                    btnconsultartodos_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao cadastrar cliente: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        
        // BOTÃO ALTERAR
        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == -1)
            {
                MessageBox.Show(
                    "Selecione um cliente para alterar.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {
                MessageBox.Show(
                    "Digite o nome do cliente.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtnome.Focus();
                return;
            }

            string strsql =
                "UPDATE tbcliente SET " +
                "nome = @nome, " +
                "email = @email, " +
                "telefone = @telefone " +
                "WHERE codigo = @codigo";

            using (MySqlConnection conexao =
                   new MySqlConnection(strcon))
            {
                try
                {
                    conexao.Open();

                    using (MySqlCommand comando =
                           new MySqlCommand(strsql, conexao))
                    {
                        comando.Parameters.AddWithValue(
                            "@nome",
                            txtnome.Text
                        );

                        comando.Parameters.AddWithValue(
                            "@email",
                            txtemail.Text
                        );

                        comando.Parameters.AddWithValue(
                            "@telefone",
                            txtfone.Text
                        );

                        comando.Parameters.AddWithValue(
                            "@codigo",
                            idSelecionado
                        );

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Cliente alterado com sucesso!",
                        "Confirmação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LimparCampos();

                    idSelecionado = -1;

                    DesabilitarCampos();

                    btnconsultartodos_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao alterar cliente: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        
        // SELECIONAR CLIENTE NO DATAGRIDVIEW
        
        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow linha =
                    dataGridView1.Rows[e.RowIndex];

                idSelecionado =
                    Convert.ToInt32(linha.Cells["codigo"].Value);

                txtnome.Text =
                    linha.Cells["nome"].Value.ToString();

                txtemail.Text =
                    linha.Cells["email"].Value.ToString();

                txtfone.Text =
                    linha.Cells["telefone"].Value.ToString();

                txtnome.Enabled = true;
                txtemail.Enabled = true;
                txtfone.Enabled = true;
                txtpesquisar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao selecionar cliente: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // CONSULTAR TODOS
        
        private void btnconsultartodos_Click(
            object sender,
            EventArgs e)
        {
            string strsql =
                "SELECT codigo, nome, email, telefone " +
                "FROM tbcliente " +
                "ORDER BY codigo";

            using (MySqlConnection conexao =
                   new MySqlConnection(strcon))
            {
                try
                {
                    conexao.Open();

                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(strsql, conexao))
                    {
                        DataTable tabela = new DataTable();

                        adaptador.Fill(tabela);

                        dataGridView1.DataSource = tabela;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao carregar os clientes: " +
                        ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        
        // LIMPAR CAMPOS
        
        private void LimparCampos()
        {
            txtnome.Clear();
            txtemail.Clear();
            txtfone.Clear();
            txtpesquisar.Clear();
        }

        
        // DESABILITAR CAMPOS
        
        private void DesabilitarCampos()
        {
            txtnome.Enabled = false;
            txtemail.Enabled = false;
            txtfone.Enabled = false;
            txtpesquisar.Enabled = false;
        }
    }
}