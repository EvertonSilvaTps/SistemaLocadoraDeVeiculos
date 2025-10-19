using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public abstract class Veiculo    //  | Pilar > Abstração
    {

        // Propriedades do Veículo > todas as classes filhas passaram a ter eles
        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public string Cor {  get; set; }
        public string Placa { get; set; }



        // Toda classe filho deverá escrever este método
        public abstract void ExibirInformacoes();
    }
}
