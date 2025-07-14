using System.Collections;

namespace QueuingForm;

public partial class CashierWindowQueueForm : Form
{
    private System.Windows.Forms.Timer timer;
    private Serving serving;
    

    public CashierWindowQueueForm()
    {
        serving = new Serving();
        InitializeComponent();
        timer = new System.Windows.Forms.Timer();
        timer.Interval = 1000; 
        timer.Tick += Timer_Tick;
        timer.Start();
    }
    private void Timer_Tick(object sender, EventArgs e)
    {
        DisplayCashierQueue(CashierClass.CashierQueue);
    }
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        DisplayCashierQueue(CashierClass.CashierQueue);
        
    }

    private void DisplayCashierQueue(IEnumerable CashierList)
    {
        listCashierQueue.Items.Clear();
        foreach (var obj in CashierList)
        {
            listCashierQueue.Items.Add(obj.ToString());
        }
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        if (CashierClass.CashierQueue.Count > 0)
        {
            var next = CashierClass.CashierQueue.Peek();
            serving.SetServingText(next);
            CashierClass.CashierQueue.Dequeue();
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        else
        {
            serving.SetServingText("No customers in queue");
        }
        serving.ShowDialog();
        }
    

    private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}