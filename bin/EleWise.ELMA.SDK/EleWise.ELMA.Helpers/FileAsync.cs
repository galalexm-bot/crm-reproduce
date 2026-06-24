using System.IO;

namespace EleWise.ELMA.Helpers;

public static class FileAsync
{
	private static FileAsync Oi45LshYpPSpGeMNAyJp;

	public static FileStream OpenRead(string path)
	{
		return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192, useAsync: true);
	}

	public static FileStream OpenWrite(string path)
	{
		return new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 8192, useAsync: true);
	}

	internal static bool qt0RtChYaucpE7MYOv45()
	{
		return Oi45LshYpPSpGeMNAyJp == null;
	}

	internal static FileAsync N4N0QMhYDB2Ksy1wnPXj()
	{
		return Oi45LshYpPSpGeMNAyJp;
	}
}
