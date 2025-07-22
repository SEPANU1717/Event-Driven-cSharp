namespace BasicThreading.ThreadPriority;

public partial class frmTrackThread : Form
{
    public frmTrackThread()
    {
        InitializeComponent();
    }

    private void Threads()
    {
        var threads = new[]
        {
            new Thread(MyThreadClass.Thread1) { Name = "Thread A", Priority = System.Threading.ThreadPriority.Highest },
            new Thread(MyThreadClass.Thread2) { Name = "Thread B", Priority = System.Threading.ThreadPriority.Normal },
            new Thread(MyThreadClass.Thread1) { Name = "Thread C", Priority = System.Threading.ThreadPriority.AboveNormal },
            new Thread(MyThreadClass.Thread2) { Name = "Thread D", Priority = System.Threading.ThreadPriority.BelowNormal }
        };
        
        foreach (var thread in threads)thread.Start();
        foreach (var thread in threads)thread.Join();
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Threads Start");
        Threads();
        lblThreads.Text = "End of Thread";
        Console.WriteLine("End of Thread");
    }
}