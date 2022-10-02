using System;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDeDesconto
    {
        ICalculaDescontoFidelidade descontoFidelidade;
        public GerenciadorDeDesconto(ICalculaDescontoFidelidade _descontoFidelidade)
        {
            descontoFidelidade = _descontoFidelidade;
        }

        public decimal AplicaDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = new ClienteNaoRegistrado().AplicarDescontoStatusConta(preco);
                    break;
                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = new ClienteComum().AplicarDescontoStatusConta(preco);
                    precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = new ClienteEspecial().AplicarDescontoStatusConta(preco);
                    precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteVIP:
                    precoAposDesconto = new ClienteVip().AplicarDescontoStatusConta(preco);
                    precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return precoAposDesconto;
        }
    }
}