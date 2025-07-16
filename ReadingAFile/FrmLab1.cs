namespace TextFile;

public partial class FrmLab1 : Form
{
    FrmFileName frmFileName = new();
    
    public FrmLab1()
    {
        InitializeComponent();
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        Hide();
        frmFileName.ShowDialog();
        
        var getInput = txtInput.Text;
        var docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        using StreamWriter outputFile = new(Path.Combine(docPath, FrmFileName.SetFileName ?? string.Empty));
        outputFile.WriteLine(getInput);
        Console.WriteLine(getInput);
    }
}