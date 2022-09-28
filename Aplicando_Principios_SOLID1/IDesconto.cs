namespace Aplicando_Principios_SOLID1
{
    public interface IDesconto
    {
        public virtual decimal Calcular(decimal valor, int tipo, int anos)
        {
            return valor;
        }
    }
}
