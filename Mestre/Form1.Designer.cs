namespace Mestre
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.picAmarelo = new System.Windows.Forms.PictureBox();
            this.picAzul = new System.Windows.Forms.PictureBox();
            this.picVerde = new System.Windows.Forms.PictureBox();
            this.picVermelho = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.tmrPassarCores = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFacil = new System.Windows.Forms.RadioButton();
            this.rdDificil = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAmarelo
            // 
            this.picAmarelo.Enabled = false;
            this.picAmarelo.Image = global::Mestre.Properties.Resources.amarelo;
            this.picAmarelo.Location = new System.Drawing.Point(73, 33);
            this.picAmarelo.Name = "picAmarelo";
            this.picAmarelo.Size = new System.Drawing.Size(261, 224);
            this.picAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmarelo.TabIndex = 0;
            this.picAmarelo.TabStop = false;
            this.picAmarelo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAmarelo_MouseDown);
            this.picAmarelo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picAmarelo_MouseUp);
            // 
            // picAzul
            // 
            this.picAzul.Enabled = false;
            this.picAzul.Image = global::Mestre.Properties.Resources.azul;
            this.picAzul.Location = new System.Drawing.Point(330, 33);
            this.picAzul.Name = "picAzul";
            this.picAzul.Size = new System.Drawing.Size(261, 224);
            this.picAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAzul.TabIndex = 1;
            this.picAzul.TabStop = false;
            this.picAzul.Click += new System.EventHandler(this.picAzul_Click);
            this.picAzul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAzul_MouseDown);
            this.picAzul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picAzul_MouseUp);
            // 
            // picVerde
            // 
            this.picVerde.Enabled = false;
            this.picVerde.Image = global::Mestre.Properties.Resources.verde;
            this.picVerde.Location = new System.Drawing.Point(73, 257);
            this.picVerde.Name = "picVerde";
            this.picVerde.Size = new System.Drawing.Size(261, 224);
            this.picVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerde.TabIndex = 2;
            this.picVerde.TabStop = false;
            this.picVerde.Click += new System.EventHandler(this.picVerde_Click);
            this.picVerde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picVerde_MouseDown);
            this.picVerde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picVerde_MouseUp);
            // 
            // picVermelho
            // 
            this.picVermelho.Enabled = false;
            this.picVermelho.Image = global::Mestre.Properties.Resources.vermelho;
            this.picVermelho.Location = new System.Drawing.Point(330, 257);
            this.picVermelho.Name = "picVermelho";
            this.picVermelho.Size = new System.Drawing.Size(261, 224);
            this.picVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVermelho.TabIndex = 3;
            this.picVermelho.TabStop = false;
            this.picVermelho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picVermelho_MouseDown);
            this.picVermelho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picVermelho_MouseUp);
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(249, 231);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(169, 60);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "Começar!";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // tmrPassarCores
            // 
            this.tmrPassarCores.Interval = 500;
            this.tmrPassarCores.Tick += new System.EventHandler(this.tmrPassarCores_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDificil);
            this.groupBox1.Controls.Add(this.rdFacil);
            this.groupBox1.Location = new System.Drawing.Point(597, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dificuldade";
            // 
            // rdFacil
            // 
            this.rdFacil.AutoSize = true;
            this.rdFacil.Checked = true;
            this.rdFacil.Location = new System.Drawing.Point(24, 46);
            this.rdFacil.Name = "rdFacil";
            this.rdFacil.Size = new System.Drawing.Size(54, 21);
            this.rdFacil.TabIndex = 0;
            this.rdFacil.TabStop = true;
            this.rdFacil.Text = "facil";
            this.rdFacil.UseVisualStyleBackColor = true;
            // 
            // rdDificil
            // 
            this.rdDificil.AutoSize = true;
            this.rdDificil.Location = new System.Drawing.Point(24, 91);
            this.rdDificil.Name = "rdDificil";
            this.rdDificil.Size = new System.Drawing.Size(60, 21);
            this.rdDificil.TabIndex = 1;
            this.rdDificil.Text = "dificil";
            this.rdDificil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.picVermelho);
            this.Controls.Add(this.picVerde);
            this.Controls.Add(this.picAzul);
            this.Controls.Add(this.picAmarelo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAmarelo;
        private System.Windows.Forms.PictureBox picAzul;
        private System.Windows.Forms.PictureBox picVerde;
        private System.Windows.Forms.PictureBox picVermelho;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Timer tmrPassarCores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDificil;
        private System.Windows.Forms.RadioButton rdFacil;
    }
}

