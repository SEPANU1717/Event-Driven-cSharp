using System.Collections;
using BasicQueuingCashier.Class;

namespace BasicQueuingCashier.Forms;

public partial class CashierWindowQueueForm : Form
{
    private CashierClass cashierClass;
    public CashierWindowQueueForm()
    {
        InitializeComponent();
        cashierClass = new CashierClass();
        Autorefresh();
    }

    private void Autorefresh()
    {
        var timer = new System.Windows.Forms.Timer();
        timer.Interval = 1000;
        timer.Tick += timer1_tick;
        timer.Start();
    }
    
    private void timer1_tick(object sender, EventArgs e)
    {
        DisplayCashierQueue(CashierClass.CashierQueue);
    }
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        DisplayCashierQueue(CashierClass.CashierQueue);
    }

    public void DisplayCashierQueue(IEnumerable CashierList)
    {
        listCashierQueue.Items.Clear();
        foreach (Object obj in CashierList)
        {
            listCashierQueue.Items.Add(obj.ToString());
        }
    }

    private void btnnext_Click(object sender, EventArgs e)
    {
        cashierClass.DequeueFirstQueue();
        DisplayCashierQueue(CashierClass.CashierQueue);
    }
}