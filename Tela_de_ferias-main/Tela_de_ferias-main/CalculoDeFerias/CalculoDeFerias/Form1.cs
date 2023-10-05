using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CalculoDeFerias
{
    public partial class Form1 : Form
    {

        // Conexão com o banco de dados
        private SqlConnection conexao = new SqlConnection("Server=DESKTOP-30FVRF9\\SQLGOMES;Database=ferias;Trusted_Connection=True;");


        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se a conexão já está aberta
                if (conexao.State != ConnectionState.Open)
                {
                    // Abre a conexão com o banco de dados
                    conexao.Open();
                }

                // Prepara a instrução SQL de inserção
                string query = "INSERT INTO TabelaFerias (NomeFuncionario, DataInicio, DataTermino, StatusVencido) VALUES (@NomeFuncionario, @DataInicio, @DataTermino, @StatusVencido)";
                SqlCommand cmd = new SqlCommand(query, conexao);

                // Define os parâmetros
                cmd.Parameters.AddWithValue("@NomeFuncionario", txtFuncionario.Text);
                cmd.Parameters.AddWithValue("@DataInicio", dateTimeInicio.Value);
                cmd.Parameters.AddWithValue("@DataTermino", dateTimeTermino.Value);
                cmd.Parameters.AddWithValue("@StatusVencido", radioBtnVencido.Checked);

                // Executa a inserção
                cmd.ExecuteNonQuery();

                // Atualiza a DataGridView
                AtualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar no banco de dados: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão com o banco de dados se ela estiver aberta
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private void btnExculir_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se a conexão já está aberta
                if (conexao.State != ConnectionState.Open)
                {
                    // Abre a conexão com o banco de dados
                    conexao.Open();
                }

                // Prepara a instrução SQL de exclusão
                string query = "DELETE FROM TabelaFerias WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conexao);

                // Define os parâmetros
                cmd.Parameters.AddWithValue("@ID", dataTabela.SelectedCells[0].Value);

                // Executa a exclusão
                cmd.ExecuteNonQuery();

                // Atualiza a DataGridView
                AtualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir do banco de dados: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão com o banco de dados se ela estiver aberta
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private void btnLimapr_Click(object sender, EventArgs e)
        {
            txtFuncionario.Clear();
            txtSalarioHora.Clear();
            dateTimeInicio.ResetText();
            dateTimeTermino.ResetText();
            lblResultado.Text = "";
            radioBtnVencido.Checked = false;
        }

        private void AtualizarDataGridView()
        {
            try
            {
                // Verifica se a conexão já está aberta
                if (conexao.State != ConnectionState.Open)
                {
                    // Abre a conexão com o banco de dados
                    conexao.Open();
                }

                // Prepara a consulta SQL para selecionar os dados da tabela TabelaFerias
                string query = "SELECT ID, NomeFuncionario, DataInicio, DataTermino, StatusVencido FROM TabelaFerias";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexao);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Define a fonte de dados da DataGridView
                dataTabela.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do banco de dados: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão com o banco de dados se ela estiver aberta
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtém a data de início e de término das férias a partir dos controles de data
            DateTime inicioDate = dateTimeInicio.Value;
            DateTime fimDate = dateTimeTermino.Value;

            // Calcula o número de dias de férias
            int dias = (int)(fimDate - inicioDate).TotalDays + 1;

            // Verifica se o número de dias é maior que 30 (considerando 30 dias como período mínimo de férias)
            if (dias > 30)
            {
                // Obtém o salário por hora do TextBox, substituindo vírgula por ponto se necessário
                double salario = double.Parse(txtSalarioHora.Text.Replace(",", "."));

                // Verifica se a opção de abono está selecionada
                if (radioAbono.Checked)
                {
                    // Calcula o valor do abono com base nos dias excedentes além dos 30 dias
                    double abono = salario * (dias - 30) / 30;

                    // Exibe o resultado na Label lblResultado
                    lblResultado.Text = $"O valor do seu abono é R$ {abono.ToString("F2").Replace(",", ".")}";
                }
                // Verifica se a opção de 13º salário está selecionada
                else if (radio13.Checked)
                {
                    // Calcula o valor do 13º salário proporcional com base nos dias excedentes além dos 30 dias
                    double decimoTerceiro = salario / 12 * (dias - 30);

                    // Exibe o resultado na Label lblResultado
                    lblResultado.Text = $"O valor do seu 13º salário é R$ {decimoTerceiro.ToString("F2").Replace(",", ".")}";
                }
            }
            else
            {
                // Caso o número de dias seja menor ou igual a 30, exibe a mensagem com a quantidade de dias de férias
                lblResultado.Text = $"Você tem {dias} dias de férias.";
            }
        }
    }
}



