namespace BasicThreading;

public class MyThreadClass
{
    public static void Thread1()
    {
        for (var loopCount = 0; loopCount < 6; loopCount++)
        {
            var thread = Thread.CurrentThread;
            Console.WriteLine($"Name of thread: {thread.Name} = {loopCount}");
            Thread.Sleep(1500);
        }
    }
}