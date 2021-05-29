
namespace ProjetoHelloWord
{
    partial class CriacaoProva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriacaoProva));
            this.labelCriacaoProva = new System.Windows.Forms.Label();
            this.labelAlternativas = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.labelTema = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.comboBoxMat = new System.Windows.Forms.ComboBox();
            this.richTextBoxEnunciado = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonProx = new System.Windows.Forms.Button();
            this.boxDataProva = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonWord = new System.Windows.Forms.RadioButton();
            this.radioButtonExcel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCriacaoProva
            // 
            this.labelCriacaoProva.AutoSize = true;
            this.labelCriacaoProva.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCriacaoProva.Location = new System.Drawing.Point(24, 27);
            this.labelCriacaoProva.Name = "labelCriacaoProva";
            this.labelCriacaoProva.Size = new System.Drawing.Size(342, 32);
            this.labelCriacaoProva.TabIndex = 0;
            this.labelCriacaoProva.Text = "Crie sua prova agora mesmo";
            // 
            // labelAlternativas
            // 
            this.labelAlternativas.AutoSize = true;
            this.labelAlternativas.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelAlternativas.Location = new System.Drawing.Point(32, 148);
            this.labelAlternativas.Name = "labelAlternativas";
            this.labelAlternativas.Size = new System.Drawing.Size(113, 18);
            this.labelAlternativas.TabIndex = 3;
            this.labelAlternativas.Text = "Nº da questão";
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelMateria.Location = new System.Drawing.Point(32, 113);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(66, 18);
            this.labelMateria.TabIndex = 2;
            this.labelMateria.Text = "Matéria";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelData.Location = new System.Drawing.Point(32, 185);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(112, 18);
            this.labelData.TabIndex = 5;
            this.labelData.Text = "Data da prova";
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelEnunciado.Location = new System.Drawing.Point(32, 229);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(84, 18);
            this.labelEnunciado.TabIndex = 4;
            this.labelEnunciado.Text = "Enunciado";
            // 
            // labelTema
            // 
            this.labelTema.AutoSize = true;
            this.labelTema.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTema.Location = new System.Drawing.Point(27, 77);
            this.labelTema.Name = "labelTema";
            this.labelTema.Size = new System.Drawing.Size(120, 18);
            this.labelTema.TabIndex = 1;
            this.labelTema.Text = "Título da prova";
            this.labelTema.Click += new System.EventHandler(this.labelTema_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(162, 78);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(208, 20);
            this.textBoxTitulo.TabIndex = 6;
            // 
            // comboBoxMat
            // 
            this.comboBoxMat.FormattingEnabled = true;
            this.comboBoxMat.Items.AddRange(new object[] {
            "Matemática",
            "Português",
            "Inglês",
            "Ciências",
            "Biologia",
            "Literatura",
            "História",
            "Geografia",
            "Química",
            "Sociologia",
            "Filosofia",
            "Espanhol"});
            this.comboBoxMat.Location = new System.Drawing.Point(162, 114);
            this.comboBoxMat.Name = "comboBoxMat";
            this.comboBoxMat.Size = new System.Drawing.Size(184, 21);
            this.comboBoxMat.TabIndex = 7;
            this.comboBoxMat.Text = "Selecione uma matéria...";
            // 
            // richTextBoxEnunciado
            // 
            this.richTextBoxEnunciado.Location = new System.Drawing.Point(122, 230);
            this.richTextBoxEnunciado.Name = "richTextBoxEnunciado";
            this.richTextBoxEnunciado.Size = new System.Drawing.Size(514, 105);
            this.richTextBoxEnunciado.TabIndex = 10;
            this.richTextBoxEnunciado.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoHelloWord.Properties.Resources.prova;
            this.pictureBox1.Location = new System.Drawing.Point(511, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(451, 420);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(114, 49);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonProx
            // 
            this.buttonProx.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProx.Location = new System.Drawing.Point(588, 420);
            this.buttonProx.Name = "buttonProx";
            this.buttonProx.Size = new System.Drawing.Size(119, 49);
            this.buttonProx.TabIndex = 13;
            this.buttonProx.Text = "Próxima questão";
            this.buttonProx.UseVisualStyleBackColor = true;
            this.buttonProx.Click += new System.EventHandler(this.buttonProx_Click);
            // 
            // boxDataProva
            // 
            this.boxDataProva.Location = new System.Drawing.Point(162, 186);
            this.boxDataProva.Mask = "00/00/0000";
            this.boxDataProva.Name = "boxDataProva";
            this.boxDataProva.Size = new System.Drawing.Size(100, 20);
            this.boxDataProva.TabIndex = 14;
            this.boxDataProva.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(162, 149);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(81, 20);
            this.textBoxNum.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Formato do arquivo";
            // 
            // radioButtonWord
            // 
            this.radioButtonWord.AutoSize = true;
            this.radioButtonWord.Checked = true;
            this.radioButtonWord.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.radioButtonWord.Location = new System.Drawing.Point(201, 365);
            this.radioButtonWord.Name = "radioButtonWord";
            this.radioButtonWord.Size = new System.Drawing.Size(61, 22);
            this.radioButtonWord.TabIndex = 17;
            this.radioButtonWord.TabStop = true;
            this.radioButtonWord.Text = "Word";
            this.radioButtonWord.UseVisualStyleBackColor = true;
            this.radioButtonWord.CheckedChanged += new System.EventHandler(this.radioButtonWord_CheckedChanged);
            // 
            // radioButtonExcel
            // 
            this.radioButtonExcel.AutoSize = true;
            this.radioButtonExcel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.radioButtonExcel.Location = new System.Drawing.Point(201, 401);
            this.radioButtonExcel.Name = "radioButtonExcel";
            this.radioButtonExcel.Size = new System.Drawing.Size(59, 22);
            this.radioButtonExcel.TabIndex = 18;
            this.radioButtonExcel.Text = "Excel";
            this.radioButtonExcel.UseVisualStyleBackColor = true;
            // 
            // CriacaoProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(733, 501);
            this.Controls.Add(this.radioButtonExcel);
            this.Controls.Add(this.radioButtonWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.boxDataProva);
            this.Controls.Add(this.buttonProx);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCriacaoProva);
            this.Controls.Add(this.richTextBoxEnunciado);
            this.Controls.Add(this.labelTema);
            this.Controls.Add(this.labelAlternativas);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.comboBoxMat);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriacaoProva";
            this.Text = "CriacaoProva";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCriacaoProva;
        private System.Windows.Forms.Label labelAlternativas;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelEnunciado;
        private System.Windows.Forms.Label labelTema;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.ComboBox comboBoxMat;
        private System.Windows.Forms.RichTextBox richTextBoxEnunciado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonProx;
        private System.Windows.Forms.MaskedTextBox boxDataProva;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonWord;
        private System.Windows.Forms.RadioButton radioButtonExcel;
    }
}