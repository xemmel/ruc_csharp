
public static class AndersAnd
{
    public static int GetCrazyLength(this string s, string ff) //Extension Method
    {
        return 17;
    }

    public static int GetCrazyLength<T>(this IEnumerable<T> collection)
    {
        return collection.Count() + 17;
    }

    
}