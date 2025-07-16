namespace OpenTextFile;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public void DisplayToList()
    {
        openFileDialog1.InitialDirectory = @"C:\Users\emsii\Downloads";
        openFileDialog1.Title = "Browse Text File";
        openFileDialog1.DefaultExt = "txt";
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        openFileDialog1.ShowDialog();
        
        var path = openFileDialog1.FileName;
        using (var streamReader = new StreamReader(path))
        {
            string _getText = string.Empty;
            while ((_getText = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(_getText);
                lvShowText.Items.Add(_getText);
            }
        }
    }
    
    private void btnOpen_Click(object sender, EventArgs e)
    {
        DisplayToList();
    }
}