using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        await ApiFetch();
    }

    static async Task ApiFetch()
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                // Read from .env file
                string baseUrl = GetEnvironmentVariableFromDotEnv("API_BASE_URL") ?? "";
                string url = baseUrl;
                
                HttpResponseMessage response = await client.GetAsync(url);
                
                if (!response.IsSuccessStatusCode)
                    throw new Exception($"HTTP error! Status: {response.StatusCode}");

                string json = await response.Content.ReadAsStringAsync();
                JsonDocument doc = JsonDocument.Parse(json);
                
                Console.WriteLine("First Post Title: " + doc.RootElement[0].GetProperty("title").GetString());
                
                doc.Dispose();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
    
    // Code to pull straight from .env file
    static string GetEnvironmentVariableFromDotEnv(string variableName)
    {
        try
        {
            // Look for .env file in the current directory
            string envFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Task 3/.env");
            
            if (File.Exists(envFilePath))
            {
                string[] lines = File.ReadAllLines(envFilePath);
                
                foreach (string line in lines)
                {
                    if (line.StartsWith(variableName + "="))
                    {
                        return line.Substring(variableName.Length + 1);
                    }
                }
            }
        }
        catch
        {
            // If there's any error reading the file, just return null
        }
        
        return null;
    }
}