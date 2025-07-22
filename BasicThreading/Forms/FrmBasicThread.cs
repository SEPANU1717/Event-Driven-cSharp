namespace BasicThreading;

public partial class FrmBasicThread : Form
{
    public FrmBasicThread()
    {
        InitializeComponent();
    }

    private void ThreadAnB()
    {
        var threads = new[]
        {
            new Thread(MyThreadClass.Thread1){Name = "Thread A"},
            new Thread(MyThreadClass.Thread1){Name = "Thread B"}
        };
        
        foreach (var thread in threads)thread.Start();
        foreach (var thread in threads)thread.Join();

    }

    private void btnRun_Click(object sender, EventArgs e)
    {
        ThreadAnB();
        lblThread.Text = "End of threads";
        Console.WriteLine("End of threads");
    }
}