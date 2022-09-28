namespace Aplicando_Principios_SOLID1
{
    public class DescontoPorTempo
    {
        public decimal Calcular(int anos)
        {
            decimal desc = (anos > 5) ? (decimal)5 / 100 : (decimal)anos / 100;
            return desc;
        }
    }

}
