using System;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDeDesconto
    {
        private readonly ICalculaDescontoStatusFactory descontoStatusConta;
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        public GerenciadorDeDesconto(ICalculaDescontoStatusFactory _descontoStatusConta, ICalculaDescontoFidelidade _descontoFidelidade)
        {
            descontoFidelidade = _descontoFidelidade;
            descontoStatusConta = _descontoStatusConta;
        }

        public decimal AplicaDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            precoAposDesconto = descontoStatusConta.GetCalculoDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(preco);

            precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);

            return precoAposDesconto;
        }
    }
}