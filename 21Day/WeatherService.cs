public struct WeatherService
{
    public static string GetCountyList(int id)
    {
        string url = $"https://www.meteoservice.ru/?ysclid=l3gbv0eaa4 {id}";
        string path = $"Country_id_{id}.json";
        if (!File.Exists(path))
        {
            HttpClient hc = new HttpClient();
            string tjson = hc.GetStringAsync(url).Result;
            File.WriteAllText(path, tjson);
        }
        return File.ReadAllText(path);
    }
}