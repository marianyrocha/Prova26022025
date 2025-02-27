public class Aluguel
{
    public Veiculo _veiculo;
    public DateOnly _dataInicio; 
    public DateOnly _dataFinal;
    public int _quantDias;
    public double _valorAluguel; 

    public Aluguel() 
    {
    }

    public Aluguel(Veiculo veiculo, DateOnly dataInicio, DateOnly dataFinal)
    {
        _veiculo = veiculo;
        int TotalDias = (_dataFinal.DayNumber - _dataInicio.DayNumber) + 1;
    }

    public double ValorTotalAluguel()
    {
        
        if (_dataInicio.DayNumber <= 0 || _dataInicio.Month <= 0 || _dataInicio.Year <= 0 || _dataFinal.DayNumber <= 0 || _dataFinal.Month <= 0 || _dataFinal.Year <= 0)
        {
            throw new Exception("Valor de cáculo inválido, revise as datas informadas");
        }

        _valorAluguel = _veiculo.CalcularValorAluguel(_quantDias);

        if (_valorAluguel < 0) {
        
        }


        return _valorAluguel;
    }
}
