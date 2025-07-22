namespace BasicThreading.ThreadPriority;

public class MyThreadClass
{
    public static void Thread1()
    {
        for(var loopCount = 0 ; loopCount < 3; loopCount++)
        {
            var thread = Thread.CurrentThread;
            Thread.Sleep(500);
            Console.WriteLine($"Name of thread: {thread.Name} Process = {loopCount}");
        }
        Console.WriteLine();
    }
    
    public static void Thread2()
    {
        for(var loopCount = 0; loopCount < 6; loopCount++)
        {
            var thread = Thread.CurrentThread;
            Thread.Sleep(1500);
            Console.WriteLine($"Name of thread: {thread.Name} Process = {loopCount}");
        }
    }
}