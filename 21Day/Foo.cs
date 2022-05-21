public class Foo
{
    static int a = 0;
    public static void Start()
    {
        new Thread(() =>
        {
            while (true)
            {
                File.AppendAllText($"data {a}", $"data {a++}.txt");
                Thread.Sleep(500);
            }
        })      
        .Start();
    }   
}