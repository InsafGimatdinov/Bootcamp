public class Worker
{
    public int Id {get; set; }
    public int Age {get; set; }
    public string  FullName {get; set; }

    public override string ToString()
    {
        return $"{Id, 3} {Age, 5} {FullName}";
    }
}