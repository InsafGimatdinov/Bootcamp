public struct CopyService
{
    public static Worker CopyWorker(Worker w)
    {
        Worker t = new Worker();
        t.Id = w.Id;
        t.Age = w.Age;
        t.FullName = w.FullName;
        return t;
    }

    public static Organization CopyOrganization(Organization o)
    {
        Organization t = new Organization();
        t.Name = o.Name;
        t.Manager = CopyWorker(o.Manager);
        return t;
    }
}