


struct Document
{
    IMyformatable format;

    Model model;

    public Document(IMyformatable f, string DocName, string AuthorFullName)
    {
        format = f;
        model = new Model()
        {
            Author = AuthorFullName,
            Title = DocName,
            Pages = new List<string>(),
        };
    }

    public void AddPage(string text)
    {
        model.Pages.Add(text);
    }

    public void SaveAs()
    {
        format.Save(model);
    }
}
