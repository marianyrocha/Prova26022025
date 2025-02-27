public class Carros: Veiculo
{
    public int _portasQuant;
    public double _tamanhoBagageiro;

    public override double CalcularValorAluguel(int quantDias)
    {
        if (quantDias > 7)
        {
            return _valorDiaria - (_valorDiaria * 10) / 100;
        }
        else
        {
            return _valorDiaria * quantDias; 
        }
    }
}