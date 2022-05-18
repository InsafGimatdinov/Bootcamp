



struct JsonFormat : IMyformatable
{
    public void Save(Model model)
    {
        File.WriteAllText("JsonFormat.json", 
        Newtonsoft
            .Json
            .JsonConvert
            .SerializeObject(model)
        );
    }
}
