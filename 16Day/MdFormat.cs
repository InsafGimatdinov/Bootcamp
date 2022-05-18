



struct MdFormat : IMyformatable
{
    public void Save(Model model)
    {
        File.WriteAllText("MdFormat.md","MdFormat");
    }
}