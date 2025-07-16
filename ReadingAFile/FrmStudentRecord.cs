namespace TextFile;

public partial class FrmStudentRecord : Form
{
    FrmRegistration registration = new();
    FrmFileName frmFileName = new();
    public FrmStudentRecord()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Hide();
        registration.ShowDialog();
        
        
    }

    private void button2_Click(object sender, EventArgs e)
    {
        frmFileName.ShowDialog();
        
        var fileName = FrmFileName.SetFileName ?? String.Empty;
        var path = Path.Combine(@"C:\Users\emsii\Downloads", fileName);

        if (File.Exists(path))
        {
            
            using StreamReader reader = new(path);
            string? line;
            listView1.Items.Clear();
            while ((line = reader.ReadLine()) != null)
            {
                listView1.Items.Add(line);
            }
            
        }
        else
        {
            MessageBox.Show(this, "File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void button3_Click(object sender, EventArgs e)
    {
        MessageBox.Show(this, "Sucessfully Uploaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        listView1.Items.Clear();
    }
}