namespace Orchard.ContentManagement.FieldStorage;

public static class FieldStorageExtension
{
	public static T Get<T>(this IFieldStorage storage)
	{
		return storage.Get<T>(null);
	}

	public static void Set<T>(this IFieldStorage storage, T value)
	{
		storage.Set(null, value);
	}
}
