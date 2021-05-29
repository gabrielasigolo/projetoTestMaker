using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHelloWord
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

      

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

      

       

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            FormLogin objFormLogin;
            objFormLogin = new FormLogin(); // método que cria o objeto -- metódo construtor

            objFormLogin.Show(); // Show é uma ação que exibe o objeto
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            FormCadastro objFormCad;
            objFormCad = new FormCadastro();

            objFormCad.Show(); 
        }
    }
}
