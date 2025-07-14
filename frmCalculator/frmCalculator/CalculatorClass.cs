namespace frmCalculator;

public delegate T Formula<T>(T arg1, T arg2);
public delegate double CalculateEvent( double arg1, double arg2);

public class CalculatorClass
{
    Formula<double> formula;
    public CalculateEvent calculate;
    public event CalculateEvent eventCalculate
    {
        add
        {
            Console.WriteLine("Event added");
            calculate += value;
        }
        remove
        {
            Console.WriteLine("Event removed");
            calculate += value;
        }
    }


    public double GetSum(double arg1, double arg2) => arg1 + arg2;
    public double GetDifference(double arg1, double arg2) => arg1 - arg2;
    public double GetProduct(double arg1, double arg2) => arg1 * arg2;
    public double GetQuotient(double arg1, double arg2) => arg1 / arg2;

}
