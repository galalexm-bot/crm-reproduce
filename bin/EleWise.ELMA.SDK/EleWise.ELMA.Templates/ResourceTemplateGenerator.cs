using System;
using System.IO;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates;

public static class ResourceTemplateGenerator
{
	public static void GenerateTemplate<T>(string resourceName, string fileName, Func<string, string> conversions = null)
	{
		string directoryName = Path.GetDirectoryName(fileName);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		using FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
		GenerateTemplate<T>(resourceName, stream, conversions);
	}

	public static void GenerateTemplate<T>(string resourceName, Stream stream, Func<string, string> conversions = null)
	{
		using StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.Write(GenerateTemplate<T>(resourceName, conversions));
	}

	public static string GenerateTemplate<T>(string resourceName, Func<string, string> conversions = null)
	{
		using Stream stream = typeof(T).Assembly.GetManifestResourceStream(typeof(T).Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146503193) + resourceName);
		using StreamReader streamReader = new StreamReader(stream);
		string text = streamReader.ReadToEnd();
		return (conversions != null) ? conversions(text) : text;
	}
}
