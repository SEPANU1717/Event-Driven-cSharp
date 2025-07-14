using System;
using System.Collections.Generic;

namespace QueuingForm;

public class CashierClass
{
    private int x;
    public static string getNumberInQueue = "";
    public static Queue<string> CashierQueue;

    public CashierClass()
    {
        x = 10000;
        CashierQueue = new Queue<string>();
    }

    public string CahsierGeneratedNumber(string CashierNumber)
    {
        x++;
        CashierNumber = CashierNumber + x.ToString();
        return CashierNumber;
    }
}