using System.IO;

namespace Orchard.FileSystems.Media;

public static class StorageProviderExtensions
{
	public static void WriteAllText(this IStorageProvider storageProvider, string path, string contents)
	{
		if (storageProvider.FileExists(path))
		{
			storageProvider.DeleteFile(path);
		}
		using Stream stream = storageProvider.CreateFile(path).OpenWrite();
		using StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.Write(contents);
	}

	public static string ReadAllText(this IStorageProvider storageProvider, string path)
	{
		if (!storageProvider.FileExists(path))
		{
			return string.Empty;
		}
		using Stream stream = storageProvider.GetFile(path).OpenRead();
		using StreamReader streamReader = new StreamReader(stream);
		return streamReader.ReadToEnd();
	}
}
