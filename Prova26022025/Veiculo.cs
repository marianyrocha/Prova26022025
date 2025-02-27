public class Veiculo
{
    public int _id;
    public string _descricao;
    public string _marca;
    public string _anoFabricacao;
    public double _valorDiaria;

    public virtual double CalcularValorAluguel(int quantDias)
    {
        return _valorDiaria * quantDias;
    }
}