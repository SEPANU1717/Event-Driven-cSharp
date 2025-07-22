namespace BasicQueuingCashier.Class;

public class CashierClass
{
    private int x;
    public static string getNumberInQueue;
    public static Queue<string> CashierQueue;

    static CashierClass() => CashierQueue = new Queue<string>();
    public CashierClass() => x = 10000;
    public bool DequeueFirstQueue() => CashierQueue.Count > 0 && (CashierQueue.Dequeue() != null);
    
    
    public string CashierGeneratedNumber(string CashierNumber)
    {
        x++;
        CashierNumber += x.ToString();
        return CashierNumber;
    }
}