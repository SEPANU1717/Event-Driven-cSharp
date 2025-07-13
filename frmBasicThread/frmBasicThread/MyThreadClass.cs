namespace frmBasicThread;

public class MyThreadClass
{
    public static void Thread1()
    {

        for (var loopCount = 0; loopCount < 3; loopCount++)
        {
            
            Thread.Sleep(500);
            Thread thread = Thread.CurrentThread;
            Console.WriteLine($"Name of thread: {thread.Name} {loopCount}");
        }
    }

    public static void Thread2()
    {
        for (var loopCount = 0; loopCount < 6; loopCount++)
        {
            Thread.Sleep(1500);
            Thread thread = Thread.CurrentThread;
            Console.WriteLine($"Name of thread: {thread.Name} {loopCount}");
            

        }
    }
}

