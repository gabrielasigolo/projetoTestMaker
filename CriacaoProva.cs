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

namespace ProjetoHelloWord
{
    public partial class CriacaoProva : Form
    {
        string pathName;
        public CriacaoProva()
        {
            InitializeComponent();
        }

        private void labelTema_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            
            pathName = @"C:\Users\andre\OneDrive\" + textBoxTitulo.Text + ".doc";
            if (radioButtonExcel.Checked)
            {
                pathName = @"C:\Users\andre\OneDrive\" + textBoxTitulo.Text + ".xls";
            }
               
            if (File.Exists(pathName) == true)
            {
                StreamWriter objArqProva = new StreamWriter(pathName, true);
                objArqProva.WriteLine(Convert.ToInt32(textBoxNum.Text) + " - " + richTextBoxEnunciado.Text);
                objArqProva.Close();

            }
            else
            {
                StreamWriter objArqProva = new StreamWriter(pathName, true);
                objArqProva.WriteLine("NOME: ");
                objArqProva.WriteLine("DATA: " + boxDataProva.Text);
                objArqProva.WriteLine("   Prova de " + comboBoxMat.Text + " - " + textBoxTitulo.Text);
                objArqProva.WriteLine("----------------------------------");
                objArqProva.WriteLine(Convert.ToInt32(textBoxNum.Text) + " - " + richTextBoxEnunciado.Text);
                objArqProva.Close();

            }




        }

        private void buttonProx_Click(object sender, EventArgs e)
        {
            textBoxNum.Clear();
            richTextBoxEnunciado.Clear();
        }

        private void radioButtonWord_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
