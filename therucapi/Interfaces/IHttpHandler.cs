namespace therucapi;

public interface IHttpHandler
{
    Task<IEnumerable<T>?> GetObjects<T>(string url);
}