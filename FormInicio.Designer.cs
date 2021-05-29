
namespace ProjetoHelloWord
{
    partial class FormInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.buttonCriar = new System.Windows.Forms.Button();
            this.labelProva = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomePrograma = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCriar
            // 
            this.buttonCriar.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCriar.Location = new System.Drawing.Point(262, 203);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(198, 55);
            this.buttonCriar.TabIndex = 3;
            this.buttonCriar.Text = "&Cadastre-se";
            this.buttonCriar.UseVisualStyleBackColor = false;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // labelProva
            // 
            this.labelProva.AutoSize = true;
            this.labelProva.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProva.Location = new System.Drawing.Point(25, 29);
            this.labelProva.Name = "labelProva";
            this.labelProva.Size = new System.Drawing.Size(500, 27);
            this.labelProva.TabIndex = 4;
            this.labelProva.Text = "Monte sua prova da forma mais prática possível!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoHelloWord.Properties.Resources.imgProva1;
            this.pictureBox1.Location = new System.Drawing.Point(519, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // nomePrograma
            // 
            this.nomePrograma.AutoSize = true;
            this.nomePrograma.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePrograma.ForeColor = System.Drawing.Color.Black;
            this.nomePrograma.Location = new System.Drawing.Point(128, 104);
            this.nomePrograma.Name = "nomePrograma";
            this.nomePrograma.Size = new System.Drawing.Size(316, 64);
            this.nomePrograma.TabIndex = 6;
            this.nomePrograma.Text = "TestMaker";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogin.Location = new System.Drawing.Point(40, 203);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(198, 55);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "&Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(756, 347);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.nomePrograma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelProva);
            this.Controls.Add(this.buttonCriar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicio";
            this.Text = "TestMaker";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Label labelProva;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nomePrograma;
        private System.Windows.Forms.Button buttonLogin;
    }
}

