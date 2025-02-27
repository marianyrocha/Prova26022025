public class Motos: Veiculo
{
    public int _celindradas;
    public int _partidaEletrica;
    public double _peso;
    public double _capTanque;


    public override double CalcularValorAluguel(int quantDias)
    {
        if (quantDias > 5)
        {
            _valorDiaria = _valorDiaria - (_valorDiaria * 15) / 100;
        }

        return _valorDiaria;
    }
}