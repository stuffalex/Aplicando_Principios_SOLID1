using System;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDeDesconto
    {

        public decimal AplicaDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ?
                                            (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 :
                                            (decimal)tempoDeContaEmAnos / 100;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = precoProduto;
                    break;
                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_COMUM * precoProduto));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_ESPECIAL * precoProduto));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);
                    break;
                case StatusContaCliente.ClienteVIP:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return precoAposDesconto;
        }
    }
}