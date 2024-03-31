
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.n1Tb = new System.Windows.Forms.TextBox();
            this.n2Tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saidaLb = new System.Windows.Forms.Label();
            this.seno = new System.Windows.Forms.Button();
            this.cosseno = new System.Windows.Forms.Button();
            this.tangente = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.raizQuadrada = new System.Windows.Forms.Button();
            this.porcentagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(170, 238);
            this.soma.Margin = new System.Windows.Forms.Padding(4);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(107, 45);
            this.soma.TabIndex = 1;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(331, 238);
            this.subtracao.Margin = new System.Windows.Forms.Padding(4);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(107, 45);
            this.subtracao.TabIndex = 2;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Location = new System.Drawing.Point(499, 238);
            this.multiplicacao.Margin = new System.Windows.Forms.Padding(4);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(107, 45);
            this.multiplicacao.TabIndex = 3;
            this.multiplicacao.Text = "*";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(646, 238);
            this.divisao.Margin = new System.Windows.Forms.Padding(4);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(107, 45);
            this.divisao.TabIndex = 4;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // n1Tb
            // 
            this.n1Tb.Location = new System.Drawing.Point(402, 97);
            this.n1Tb.Margin = new System.Windows.Forms.Padding(4);
            this.n1Tb.Name = "n1Tb";
            this.n1Tb.Size = new System.Drawing.Size(141, 41);
            this.n1Tb.TabIndex = 5;
            this.n1Tb.TextChanged += new System.EventHandler(this.n1Tb_TextChanged);
            // 
            // n2Tb
            // 
            this.n2Tb.Location = new System.Drawing.Point(402, 172);
            this.n2Tb.Margin = new System.Windows.Forms.Padding(4);
            this.n2Tb.Name = "n2Tb";
            this.n2Tb.Size = new System.Drawing.Size(141, 41);
            this.n2Tb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "N1°";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "N2°";
            // 
            // saidaLb
            // 
            this.saidaLb.AutoSize = true;
            this.saidaLb.Location = new System.Drawing.Point(386, 438);
            this.saidaLb.Name = "saidaLb";
            this.saidaLb.Size = new System.Drawing.Size(111, 34);
            this.saidaLb.TabIndex = 9;
            this.saidaLb.Text = "Saida:";
            this.saidaLb.Click += new System.EventHandler(this.label4_Click);
            // 
            // seno
            // 
            this.seno.Location = new System.Drawing.Point(197, 302);
            this.seno.Margin = new System.Windows.Forms.Padding(4);
            this.seno.Name = "seno";
            this.seno.Size = new System.Drawing.Size(107, 46);
            this.seno.TabIndex = 10;
            this.seno.Text = "sen";
            this.seno.UseVisualStyleBackColor = true;
            this.seno.Click += new System.EventHandler(this.seno_Click);
            // 
            // cosseno
            // 
            this.cosseno.Location = new System.Drawing.Point(349, 302);
            this.cosseno.Margin = new System.Windows.Forms.Padding(4);
            this.cosseno.Name = "cosseno";
            this.cosseno.Size = new System.Drawing.Size(107, 46);
            this.cosseno.TabIndex = 11;
            this.cosseno.Text = "cos";
            this.cosseno.UseVisualStyleBackColor = true;
            this.cosseno.Click += new System.EventHandler(this.cosseno_Click);
            // 
            // tangente
            // 
            this.tangente.Location = new System.Drawing.Point(478, 302);
            this.tangente.Margin = new System.Windows.Forms.Padding(4);
            this.tangente.Name = "tangente";
            this.tangente.Size = new System.Drawing.Size(107, 46);
            this.tangente.TabIndex = 12;
            this.tangente.Text = "tg";
            this.tangente.UseVisualStyleBackColor = true;
            this.tangente.Click += new System.EventHandler(this.tangente_Click);
            // 
            // potencia
            // 
            this.potencia.Location = new System.Drawing.Point(603, 302);
            this.potencia.Margin = new System.Windows.Forms.Padding(4);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(107, 46);
            this.potencia.TabIndex = 13;
            this.potencia.Text = "^";
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // raizQuadrada
            // 
            this.raizQuadrada.Location = new System.Drawing.Point(331, 373);
            this.raizQuadrada.Margin = new System.Windows.Forms.Padding(4);
            this.raizQuadrada.Name = "raizQuadrada";
            this.raizQuadrada.Size = new System.Drawing.Size(107, 46);
            this.raizQuadrada.TabIndex = 14;
            this.raizQuadrada.Text = "√";
            this.raizQuadrada.UseVisualStyleBackColor = true;
            this.raizQuadrada.Click += new System.EventHandler(this.button1_Click);
            // 
            // porcentagem
            // 
            this.porcentagem.Location = new System.Drawing.Point(470, 373);
            this.porcentagem.Margin = new System.Windows.Forms.Padding(4);
            this.porcentagem.Name = "porcentagem";
            this.porcentagem.Size = new System.Drawing.Size(107, 46);
            this.porcentagem.TabIndex = 15;
            this.porcentagem.Text = "%";
            this.porcentagem.UseVisualStyleBackColor = true;
            this.porcentagem.Click += new System.EventHandler(this.porcentagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 504);
            this.Controls.Add(this.porcentagem);
            this.Controls.Add(this.raizQuadrada);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.tangente);
            this.Controls.Add(this.cosseno);
            this.Controls.Add(this.seno);
            this.Controls.Add(this.saidaLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n2Tb);
            this.Controls.Add(this.n1Tb);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.TextBox n1Tb;
        private System.Windows.Forms.TextBox n2Tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label saidaLb;
        private System.Windows.Forms.Button seno;
        private System.Windows.Forms.Button cosseno;
        private System.Windows.Forms.Button tangente;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button raizQuadrada;
        private System.Windows.Forms.Button porcentagem;
    }
}

