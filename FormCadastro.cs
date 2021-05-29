using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoHelloWord
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoTestMakerDataSet.Cadastros' table. You can move, or remove it, as needed.
            this.cadastrosTableAdapter.Fill(this.bancoTestMakerDataSet.Cadastros);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            try
            { // Abrir a conexão 
                string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\OneDrive\Área de Trabalho\Prog em Banco de Dados\ProjetoHelloWord\bancoTestMaker.mdf;Integrated Security=True";
                SqlConnection objConexao = new SqlConnection(strConexao);
                objConexao.Open();

                // Verificar se o usuario já existe 
                string cmdCount = "select count(*) from Cadastros where Email= '" +textBoxEmail.Text+ "' ";
                SqlCommand objCommand = new SqlCommand(cmdCount, objConexao);
                int num = (int)objCommand.ExecuteScalar();
                if(num > 1){
                    MessageBox.Show("Usuário já cadastrado, faça o login!");
                } else
                {
                    // Fazer o cadastro 
                    string scriptInserir = "insert into Cadastros(Nome, Email, Senha, Telefone) values ('" +textBoxNome.Text+ "' , '" +textBoxEmail.Text+ "', '" +textBoxSenha.Text+ "', '" +Telefone.Text+ "') ";
                    SqlCommand objComando = new SqlCommand(scriptInserir, objConexao);
                    objComando.ExecuteNonQuery(); // alterar - inserir - excluir (altera a estrutura do banco)
                    
                    MessageBox.Show("Cadastrado");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ");
            }
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\OneDrive\Área de Trabalho\Prog em Banco de Dados\ProjetoHelloWord\bancoTestMaker.mdf;Integrated Security=True";
            SqlConnection objConexao = new SqlConnection(strConexao);

            DataSet objDS = new DataSet();

            string comando = "select Nome, Email from Cadastros where Email = '" +textBoxFiltro.Text+ "'";
            SqlDataAdapter objData = new SqlDataAdapter(comando, objConexao);
            objData.Fill(objDS);

           
            dataGridViewConsulta.DataSource = objDS.Tables[0]; // conectar o data grid view com o DataSet 
           
        }

        

        private void dataGridViewConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = dataGridViewConsulta.CurrentCell.Value.ToString();
            
        }

        private void buttonCadLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin;
            formLogin = new FormLogin();

            formLogin.Show();
        }
    }
}
