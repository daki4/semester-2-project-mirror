namespace PrinterApplication.Storage;
internal static class ListExtensions
{
    /// <summary>
    /// Limits the list to the specified number of items. Removes the first elements that were added to the list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <param name="limit"></param>
    internal static void Limit<T>(this List<T> list, int limit)
    {
        if (list.Count > limit)
        {
            list.RemoveRange(0, list.Count - limit);
        }
    }
}
