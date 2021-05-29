
namespace ProjetoHelloWord
{
    partial class FormCadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoTestMakerDataSet = new ProjetoHelloWord.bancoTestMakerDataSet();
            this.cadastrosTableAdapter = new ProjetoHelloWord.bancoTestMakerDataSetTableAdapters.CadastrosTableAdapter();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCadLogin = new System.Windows.Forms.Button();
            this.groupBoxCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoTestMakerDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(518, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Faça agora seu cadastro no TestMaker! ";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(94, 132);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(165, 21);
            this.textBoxSenha.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(94, 81);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(245, 21);
            this.textBoxEmail.TabIndex = 1;
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCadastro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCadastro.FlatAppearance.BorderSize = 3;
            this.buttonCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastro.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastro.Location = new System.Drawing.Point(30, 385);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(145, 43);
            this.buttonCadastro.TabIndex = 4;
            this.buttonCadastro.Text = "Cadastre-se";
            this.buttonCadastro.UseVisualStyleBackColor = false;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonCadastro_Click);
            // 
            // Telefone
            // 
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(96, 186);
            this.Telefone.Mask = "(99) 0000-00000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(130, 22);
            this.Telefone.TabIndex = 3;
            this.Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.White;
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(94, 34);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(257, 21);
            this.textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefone";
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.BackColor = System.Drawing.Color.Coral;
            this.groupBoxCadastro.Controls.Add(this.label6);
            this.groupBoxCadastro.Controls.Add(this.label1);
            this.groupBoxCadastro.Controls.Add(this.label4);
            this.groupBoxCadastro.Controls.Add(this.textBoxNome);
            this.groupBoxCadastro.Controls.Add(this.label3);
            this.groupBoxCadastro.Controls.Add(this.textBoxEmail);
            this.groupBoxCadastro.Controls.Add(this.label2);
            this.groupBoxCadastro.Controls.Add(this.textBoxSenha);
            this.groupBoxCadastro.Controls.Add(this.Telefone);
            this.groupBoxCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCadastro.Location = new System.Drawing.Point(30, 85);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(382, 270);
            this.groupBoxCadastro.TabIndex = 18;
            this.groupBoxCadastro.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "8 dígitos no máximo";
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.BackColor = System.Drawing.SystemColors.Control;
            this.buttonConsulta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConsulta.FlatAppearance.BorderSize = 3;
            this.buttonConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsulta.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsulta.Location = new System.Drawing.Point(109, 386);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(145, 43);
            this.buttonConsulta.TabIndex = 19;
            this.buttonConsulta.Text = "Consultar";
            this.buttonConsulta.UseVisualStyleBackColor = false;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.AutoGenerateColumns = false;
            this.dataGridViewConsulta.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridViewConsulta.DataSource = this.cadastrosBindingSource;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(28, 96);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.Size = new System.Drawing.Size(321, 266);
            this.dataGridViewConsulta.TabIndex = 20;
            this.dataGridViewConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsulta_CellClick);
            this.dataGridViewConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsulta_CellContentClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // cadastrosBindingSource
            // 
            this.cadastrosBindingSource.DataMember = "Cadastros";
            this.cadastrosBindingSource.DataSource = this.bancoTestMakerDataSet;
            // 
            // bancoTestMakerDataSet
            // 
            this.bancoTestMakerDataSet.DataSetName = "bancoTestMakerDataSet";
            this.bancoTestMakerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastrosTableAdapter
            // 
            this.cadastrosTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFiltro.Location = new System.Drawing.Point(28, 52);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(321, 25);
            this.textBoxFiltro.TabIndex = 21;
            this.textBoxFiltro.Text = "Digite seu email aqui...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Veja se você já tem uma conta no TestMaker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonConsulta);
            this.groupBox1.Controls.Add(this.textBoxFiltro);
            this.groupBox1.Controls.Add(this.dataGridViewConsulta);
            this.groupBox1.Location = new System.Drawing.Point(580, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 451);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // buttonCadLogin
            // 
            this.buttonCadLogin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCadLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCadLogin.FlatAppearance.BorderSize = 3;
            this.buttonCadLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadLogin.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadLogin.Location = new System.Drawing.Point(224, 385);
            this.buttonCadLogin.Name = "buttonCadLogin";
            this.buttonCadLogin.Size = new System.Drawing.Size(145, 43);
            this.buttonCadLogin.TabIndex = 24;
            this.buttonCadLogin.Text = "Fazer login";
            this.buttonCadLogin.UseVisualStyleBackColor = false;
            this.buttonCadLogin.Click += new System.EventHandler(this.buttonCadLogin_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(997, 535);
            this.Controls.Add(this.buttonCadLogin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCadastro);
            this.Controls.Add(this.buttonCadastro);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoTestMakerDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonConsulta;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private bancoTestMakerDataSet bancoTestMakerDataSet;
        private System.Windows.Forms.BindingSource cadastrosBindingSource;
        private bancoTestMakerDataSetTableAdapters.CadastrosTableAdapter cadastrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCadLogin;
    }
}