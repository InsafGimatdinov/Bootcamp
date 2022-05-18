

Document doc = new Document(new JsonFormat(), "война и мир", "А. С. Пушкин");
doc.AddPage("line 1");
doc.AddPage("line 2");
doc.AddPage("line 3");
doc.SaveAs();