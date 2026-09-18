using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsCity
{
    internal class Negocio
    {
        public string NomePet {  get; set; }
        public double PrecoServ { get; set; }
        public int Quantidade {  get; set; }
        public int IdadeAnimal {  get; set; }

        public double CalcularDesconto()
        {
            double valorTotal = PrecoServ * Quantidade;

            if(Quantidade > 3)
            {
                return valorTotal * 0.20;
            }

            return 0.0;
        }
        public double CalcularValorFinal()
        {
            double valorBruto = PrecoServ * Quantidade;
            double desconto = CalcularDesconto();
            return valorBruto - desconto;
        }
        public double CalcularParcela()
        {
            return CalcularValorFinal() / 3;
        }
        public bool ValidarBrinde()
        {
            return (IdadeAnimal >= 18 && Quantidade >= 5 || CalcularValorFinal() > 100);
        }

    }
}
