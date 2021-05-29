using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ProjetoHelloWord
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

       

       

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void CriaçãoProvaImpressa_Load(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                CriacaoProva objCriacaoProva;
                //Conectar
                string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\OneDrive\Área de Trabalho\Prog em Banco de Dados\ProjetoHelloWord\bancoTestMaker.mdf;Integrated Security=True";
                SqlConnection objcon = new SqlConnection(strCon);
                objcon.Open();



                //Comando
                string cmdSql = "select count(*) from Cadastros where Nome= '" + textBoxNome.Text + "' ";
                SqlCommand objcomando = new SqlCommand(cmdSql, objcon);
                int numreg = (int)objcomando.ExecuteScalar();
                if (numreg > 0)
                {
                    MessageBox.Show("Usuário cadastrado");
                    objCriacaoProva = new CriacaoProva();

                    objCriacaoProva.Show();
                } 
                /*Exemplo para abrir um outro formulário
                 * {
                    FormMenu objmenu = FormMenu();
                    objmenu.Show();
                }*/
                else
                    MessageBox.Show("Aluno não existe");



                objcon.Close();



            }
            catch (Exception)
            {
                MessageBox.Show("Erro durante a execução");

            }
        }
    }
}
