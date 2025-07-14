namespace frmCalculator;

public partial class frmCalculator : Form
{
    private CalculatorClass cal;
    public frmCalculator()
    {
        InitializeComponent();
        cal = new CalculatorClass();
        string [] operators = { "+", "-", "*", "/"};
        foreach(var operaor in operators)
            cbOperator.Items.Add(operaor);
    }

    private void btnEqual_Click(object sender, EventArgs e)
    {
        double num1 = double.Parse(txtBoxInput1.Text);
        double num2 = double.Parse(txtBoxInput2.Text);
        string op = cbOperator.SelectedItem.ToString();
        double result = 0;
        try
        {
            switch (op)
            {
                case "+":
                    cal.eventCalculate += new CalculateEvent(cal.GetSum);
                    result = cal.GetSum(num1, num2);
                    cal.eventCalculate -= new CalculateEvent(cal.GetSum);
                    break;
                case "-":
                    cal.eventCalculate += new CalculateEvent(cal.GetDifference);
                    result = cal.GetDifference(num1, num2);
                    cal.eventCalculate -= new CalculateEvent(cal.GetDifference);
                    break;
                case "*":
                    cal.eventCalculate += new CalculateEvent(cal.GetProduct);
                    result = cal.GetProduct(num1, num2);
                    cal.eventCalculate -= new CalculateEvent(cal.GetProduct);
                    break;
                case "/":
                    cal.eventCalculate += new CalculateEvent(cal.GetQuotient);
                    result = cal.GetQuotient(num1, num2);
                    cal.eventCalculate -= new CalculateEvent(cal.GetQuotient);
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