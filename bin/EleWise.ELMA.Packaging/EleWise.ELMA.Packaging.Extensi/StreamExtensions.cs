using System.IO;

namespace EleWise.ELMA.Packaging.Extensions;

internal static class StreamExtensions
{
	public static byte[] ReadAllBytes(this Stream stream)
	{
		if (stream is MemoryStream memoryStream)
		{
			return memoryStream.ToArray();
		}
		MemoryStream memoryStream2;
		using (memoryStream2 = new MemoryStream())
		{
			stream.CopyTo(memoryStream2);
			return memoryStream2.ToArray();
		}
	}
}
