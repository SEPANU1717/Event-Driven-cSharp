namespace QueuingForm;

public partial class QueuingForm : Form
{
    private CashierClass cashier;
    private CashierWindowQueueForm window;
    public QueuingForm()
    {
        InitializeComponent();
        cashier = new CashierClass();
        btnCashier.Click += btnCashier_Click;
        lblQueue.Text = "P - 10000";
    }
    private void btnCashier_Click(object sender, EventArgs e)
    {
        lblQueue.Text = cashier.CahsierGeneratedNumber("P - ");
        CashierClass.getNumberInQueue = lblQueue.Text;
        CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        
        window = new CashierWindowQueueForm();
        window.ShowDialog();
    }
}