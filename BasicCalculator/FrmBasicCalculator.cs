using static CalculatorPrivateAssembly.BasicCalculator;
namespace BasicCalculator;
public partial class FrmBasicCalculator : Form
{
    public FrmBasicCalculator()
    {
        InitializeComponent();
        cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
    }

    private void btnCompute_Click(object sender, EventArgs e)
    {
        if (float.TryParse(txtNum1.Text, out float num1) && float.TryParse(txtNum2.Text, out float num2))
        {
            try
            {
                string selectedOperator = cbOperator.SelectedItem?.ToString()?? String.Empty;
                if (string.IsNullOrWhiteSpace(selectedOperator))
                {
                    throw new Exception("Invalid operator.");
                }
                var operators = selectedOperator switch
                {
                    "+" => Addition(num1, num2),
                    "-" => Subtraction(num1, num2),
                    "*" => Multiplication(num1, num2),
                    "/" => Division(num1, num2),
                    _ => throw new InvalidOperationException("Invalid operator selected.")
                };
                
                lblTotal.Text = operators.ToString();
            }catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
    }