public class Caminhoes: Veiculo
{
    public int _quantEixos;
    public double _capCarga;
    public string _tipoCaroceria;
    public double _comprimento;
    public double _altura;

    public override double CalcularValorAluguel(int capCarga)
    {
        _capCarga = capCarga; 

        if (capCarga > 10000)
        {
            _valorDiaria = _valorDiaria + (_valorDiaria * 20) / 100;
        }

        return _valorDiaria;
    }

}