namespace therucapi;

public class HttpHandler : IHttpHandler
{
    public async Task<IEnumerable<T>?> GetObjects<T>(string url)
    {
        var client = new HttpClient();
        var result = await client.GetFromJsonAsync<IEnumerable<T>>(requestUri: url);
        return result;
    }
}