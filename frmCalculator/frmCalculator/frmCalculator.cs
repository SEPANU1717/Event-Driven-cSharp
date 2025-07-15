namespace frmCalculator;

public partial class frmCalculator : Form
{
    private CalculatorClass cal;
    public frmCalculator()
    {
        InitializeComponent();
        cal = new CalculatorClass();
        cbOperator.Items.AddRange(new object[] {"+", "-", "*", "/"});
    }

    private void btnEqual_Click(object sender, EventArgs e)
    {
        var num1 = double.Parse(txtBoxInput1.Text);
        var num2 = double.Parse(txtBoxInput2.Text);
        var op = cbOperator.SelectedItem.ToString();
        double result = 0;
        try
        {
            switch (op)
            {
                case "+":
                    cal.eventCalculate += (cal.GetSum);
                    result = cal.GetSum(num1, num2);
                    cal.eventCalculate -= (cal.GetSum);
                    break;
                case "-":
                    cal.eventCalculate += (cal.GetDifference);
                    result = cal.GetDifference(num1, num2);
                    cal.eventCalculate -= (cal.GetDifference);
                    break;
                case "*":
                    cal.eventCalculate += (cal.GetProduct);
                    result = cal.GetProduct(num1, num2);
                    cal.eventCalculate -= (cal.GetProduct);
                    break;
                case "/":
                    cal.eventCalculate += (cal.GetQuotient);
                    result = cal.GetQuotient(num1, num2);
                    cal.eventCalculate -= (cal.GetQuotient);
                    break;
            }
            lblDisplayTotal.Text = result.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        
    }
}