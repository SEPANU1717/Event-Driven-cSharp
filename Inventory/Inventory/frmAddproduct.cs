using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddproduct : Form
    {
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;
        private BindingSource showProductList;
        private MyException myException;

        public frmAddproduct()
        {
            showProductList = new BindingSource();
            myException = new MyException();
            InitializeComponent();
        }

        private void frmAddproduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory =
            {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personel Care",
                "Other"
            };

            foreach (var productCategory in ListOfProductCategory)
            {
                cbCategory.Items.Add(productCategory);
            }
        }

        public string Product_Name(string name)
{
    try
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new MyException.StringFormatException("Product name cannot be empty.");

        if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            throw new MyException.StringFormatException("Product name must contain only letters.");
        return name;
    }
    catch (MyException.StringFormatException e)
    {
        MessageBox.Show(e.Message, "Invalid Product Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
        throw;
    }
    finally
    {
        
    }
}

        public int Quantity(string qty)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(qty))
                    throw new MyException.NumberFormatException("Quantity cannot be empty.");
                if (Regex.IsMatch(qty, @"^[a-zA-Z]+$"))
                    throw new MyException.StringFormatException("Quantity must be a number.");
                if (!Regex.IsMatch(qty, @"^\d+$"))
                    throw new MyException.NumberFormatException("Quantity must be a positive integer.");
                return Convert.ToInt32(qty);
            }
            catch(MyException.StringFormatException e)
            {
                MessageBox.Show(e.Message, "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (MyException.NumberFormatException e)
            {
                MessageBox.Show(e.Message, "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
            finally
            {
                
            }
            
        }

        public double SellingPrice(string price)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(price))
                    throw new MyException.CurrencyFormatException("Price cannot be empty.");
                if (Regex.IsMatch(price, @"^[a-zA-Z]+$"))
                    throw new MyException.StringFormatException("Price must be a number.");
                if (!Regex.IsMatch(price, @"^(\d*\.)?\d+$"))
                    throw new MyException.CurrencyFormatException("Price must be a valid number.");
                return Convert.ToDouble(price);
            }
            catch (MyException.StringFormatException e)
            {
                MessageBox.Show(e.Message, "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (MyException.CurrencyFormatException e)
            {
                MessageBox.Show(e.Message, "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTxtDescription.Text;
            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text); 
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, 
                _ExpDate, _SellPrice, _Quantity, _Description));
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;
        }
    }
}