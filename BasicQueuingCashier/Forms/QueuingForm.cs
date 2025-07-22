using BasicQueuingCashier.Class;

namespace BasicQueuingCashier.Forms;

public partial class QueuingForm : Form
{
    private CashierClass cashier;
    public QueuingForm()
    {
        InitializeComponent();
        cashier = new CashierClass();
    }

    private void btnCashier_Click(object sender, EventArgs e)
    {
        lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
        CashierClass.getNumberInQueue = lblQueue.Text;
        CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        
        CashierWindowQueueForm cashierWindowQueueForm = new CashierWindowQueueForm();
        cashierWindowQueueForm.Show();
    }

    private void label2_Click(object sender, EventArgs e)
    {
        
    }
}