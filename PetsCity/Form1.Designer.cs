namespace PetsCity
{
    partial class Form1
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
            this.lblNomePet = new System.Windows.Forms.Label();
            this.lblPrecoServico = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblIdadeAnimal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.txtIdadeAnimal = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPrecoServico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.Location = new System.Drawing.Point(30, 20);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(54, 13);
            this.lblNomePet.TabIndex = 0;
            this.lblNomePet.Text = "Nome Pet";
            // 
            // lblPrecoServico
            // 
            this.lblPrecoServico.AutoSize = true;
            this.lblPrecoServico.Location = new System.Drawing.Point(26, 58);
            this.lblPrecoServico.Name = "lblPrecoServico";
            this.lblPrecoServico.Size = new System.Drawing.Size(74, 13);
            this.lblPrecoServico.TabIndex = 1;
            this.lblPrecoServico.Text = "Preço Serviço";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(26, 101);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblIdadeAnimal
            // 
            this.lblIdadeAnimal.AutoSize = true;
            this.lblIdadeAnimal.Location = new System.Drawing.Point(26, 137);
            this.lblIdadeAnimal.Name = "lblIdadeAnimal";
            this.lblIdadeAnimal.Size = new System.Drawing.Size(68, 13);
            this.lblIdadeAnimal.TabIndex = 3;
            this.lblIdadeAnimal.Text = "Idade Animal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(29, 384);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 5;
            this.btnCalculo.Text = "Calculo";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Location = new System.Drawing.Point(30, 291);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(53, 13);
            this.lblValorFinal.TabIndex = 9;
            this.lblValorFinal.Text = "ValorFinal";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(36, 326);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(43, 13);
            this.lblParcela.TabIndex = 8;
            this.lblParcela.Text = "Parcela";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(30, 262);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(53, 13);
            this.lblDesconto.TabIndex = 7;
            this.lblDesconto.Text = "Desconto";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(36, 224);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(159, 20);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(146, 20);
            this.txtNomePet.TabIndex = 11;
            // 
            // txtIdadeAnimal
            // 
            this.txtIdadeAnimal.Location = new System.Drawing.Point(159, 137);
            this.txtIdadeAnimal.Name = "txtIdadeAnimal";
            this.txtIdadeAnimal.Size = new System.Drawing.Size(146, 20);
            this.txtIdadeAnimal.TabIndex = 13;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(159, 101);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(146, 20);
            this.txtQuantidade.TabIndex = 16;
            // 
            // txtPrecoServico
            // 
            this.txtPrecoServico.Location = new System.Drawing.Point(159, 58);
            this.txtPrecoServico.Name = "txtPrecoServico";
            this.txtPrecoServico.Size = new System.Drawing.Size(146, 20);
            this.txtPrecoServico.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrecoServico);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtIdadeAnimal);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIdadeAnimal);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPrecoServico);
            this.Controls.Add(this.lblNomePet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePet;
        private System.Windows.Forms.Label lblPrecoServico;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblIdadeAnimal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.TextBox txtIdadeAnimal;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPrecoServico;
    }
}

