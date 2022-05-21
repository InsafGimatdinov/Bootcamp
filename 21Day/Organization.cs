public class Organization
{
    public Worker Manager;
    public string Name {get; set;}

    public override string ToString()
    {
        return $"{Name} {Manager}";
    }
}