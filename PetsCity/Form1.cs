using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetsCity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio negocio = new Negocio();

                negocio.NomePet = txtNomePet.Text;
                negocio.PrecoServ = Convert.ToDouble(txtPrecoServico.Text);
                negocio.Quantidade = int.Parse(txtQuantidade.Text);
                negocio.IdadeAnimal = int.Parse(txtIdadeAnimal.Text);

                double desconto = negocio.CalcularDesconto();
                double valorFinal = negocio.CalcularValorFinal();
                double parcela = negocio.CalcularParcela();
                bool brinde = negocio.ValidarBrinde();

                lblNome.Text = $"{negocio.NomePet.ToUpper()}";
                lblDesconto.Text = $"{desconto:N2}";
                lblValorFinal.Text = $"{valorFinal:N2}";
                lblParcela.Text = $"3x de R${parcela:N2}";

                txtNomePet.Clear();
                txtPrecoServico.Clear();
                txtQuantidade.Clear();
                txtIdadeAnimal .Clear();

                if (brinde)
                {
                    lblStatus.Text = "PARABÉNS! você ganhou um Brinde";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Compra padrão realizada com sucesso!";
                    lblStatus.ForeColor = Color.Red;
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Preencha os campos corretamente",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
            }
        }
    }
}
