namespace Shared;

public class CalcHistoryService
{
    public string EquationString { get; set; }

    public List<string> EquationList { get; set; } = new();

    public void AddEquationToList(double a, double b, double result, string symbol, TimeSpan time)
    {
        EquationString = $"{a} {symbol} {b} = {result} | {time}";
        EquationList.Add(EquationString);
    }
    public List<string> GetAllEquations()
    {
        return EquationList;
    }
}