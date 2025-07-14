namespace QueuingForm;

public partial class Serving : Form
{
    public Serving()
    {
        InitializeComponent();
        UpdateServingLabel();
    }

    private void lblServing_Click(object sender, EventArgs e)
    {
        if (CashierClass.CashierQueue.Count > 0)
            CashierClass.CashierQueue.Dequeue(); 
        UpdateServingLabel();
    }
    public void SetServingText(string text)
    {
        lblServing.Text = text;
    }

    private void UpdateServingLabel()
    {
        if (CashierClass.CashierQueue.Count > 0) 
            lblServing.Text = CashierClass.CashierQueue.Peek();
    }
}