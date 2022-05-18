



struct TxtFormat : IMyformatable
{
    public void Save(Model model) => File.WriteAllText("TxtFormat.txt","TxtFormat");
}
