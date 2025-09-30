using System.Text.Json;

public class Pet
{
    public long id { get; set; }
    public string name { get; set; }
    public string status { get; set; }
    public Category category { get; set; }
    public List<string> photoUrls { get; set; }
    public List<Tag> tags { get; set; }
}

public class Category
{
    public long id { get; set; }
    public string name { get; set; }
}

public class Tag
{
    public long id { get; set; }
    public string name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            string[] urls =
            {
                //rest api endpoints
                "https://petstore.swagger.io/v2/pet/findByStatus?status=available",
                "https://petstore.swagger.io/v2/pet/findByStatus?status=pending",
                "https://petstore.swagger.io/v2/pet/findByStatus?status=sold"
            };
            var start = DateTime.Now;

            foreach (string url in urls)
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                //responseBody should contain our result in json format
                string responseBody = response.Content.ReadAsStringAsync().Result;

                var pets = JsonSerializer.Deserialize<List<Pet>>(responseBody);
                System.Console.WriteLine($"{url} returned {pets?.Count} pets");

                if (pets != null && pets.Count > 0)
                {
                    var pet = pets[0];
                    System.Console.WriteLine($"Example Id: {pet.id}, Category: {pet.category?.name}, Tags: {string.Join(", ", pet.tags?.ConvertAll(t => t.name) ?? new List<string>())}");
                }
            }
            var end = DateTime.Now;
            System.Console.WriteLine($"Duration (blocking): {(end - start).TotalSeconds:F2} seconds");
        }
    }
}