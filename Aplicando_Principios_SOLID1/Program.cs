using System;

namespace Aplicando_Principios_SOLID1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculaDescontoFidelidade descFide = new CalculoDescontoFidelidade();
            ICalculaDescontoStatusFactory descConta = new CalculaDescontoStatusFactory();

            GerenciadorDeDesconto gerDesc = new GerenciadorDeDesconto(descConta, descFide);

            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

            var resultado = gerDesc.AplicaDesconto(1000, StatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {resultado}");

            var resultado1 = gerDesc.AplicaDesconto(1000, StatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Cliente tipo 3 o valor do desconto é de : {resultado1}");

            var resultado2 = gerDesc.AplicaDesconto(1000, StatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Cliente tipo 4 o valor do desconto é de : {resultado2}\n");

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%)\n");
            var resultado3 = gerDesc.AplicaDesconto(1000, StatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {resultado3}");

            var resultado4 = gerDesc.AplicaDesconto(1000, StatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Para Cliente tipo 3 o valor do desconto é de : {resultado4}");

            var resultado5 = gerDesc.AplicaDesconto(1000, StatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Para Cliente tipo 4 o valor do desconto é de : {resultado5}");

            Console.ReadLine();
        }
    }
}
