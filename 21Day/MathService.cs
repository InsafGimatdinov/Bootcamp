public struct MathService
{
    public static int Sum(params int[] args)
    {
        int len = args.Length;
        int s = 0;
        foreach (int e in args)
        {
            s += e;
        }
        return s;
    }
    
}