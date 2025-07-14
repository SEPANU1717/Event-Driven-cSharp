namespace frmBasicThread;

public partial class frmBasicThread : Form
{
    public frmBasicThread()
    {
        InitializeComponent();
        
    }


    private void button1_Click(object sender, EventArgs e)
    {
        var threadA = new Thread(MyThreadClass.Thread1) { Name = "Thread A" };
        var threadB = new Thread(MyThreadClass.Thread1) { Name = "Thread B" };

        foreach (var s in new[] { threadA, threadB }) s.Start();
        foreach (var s in new[] { threadA, threadB }) s.Join();
        
        
        
        //For TP
        /*var threadA = new Thread(MyThreadClass.Thread1) { Name = "Thread A", Priority = ThreadPriority.Highest };
        var threadC = new Thread(MyThreadClass.Thread1) { Name = "Thread C", Priority = ThreadPriority.AboveNormal };
        var threadB = new Thread(MyThreadClass.Thread2) { Name = "Thread B", Priority = ThreadPriority.Normal };
        var threadD = new Thread(MyThreadClass.Thread2) { Name = "Thread D", Priority = ThreadPriority.BelowNormal };
        
        
        foreach(var t in new[] { threadA, threadB, threadC, threadD }) t.Start();
        foreach(var t in new[] { threadA, threadB, threadC, threadD }) t.Join();*/
        
        
        Console.WriteLine("End of threads");
        label1.Text = "End of thread";

        }
    }
