using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging;

[XmlRoot("settings")]
public class PackagingSettings
{
	private static class SettingsNames
	{
		public const string Repository = "repository";

		public const string Edition = "edition";
	}

	[XmlIgnore]
	public string Root { get; set; }

	[XmlElement("repository")]
	public string Repository { get; set; }

	[XmlElement("localRepository")]
	[DefaultValue("Packages")]
	public string LocalRepository { get; set; }

	[XmlElement("edition")]
	public ElmaEdition Edition { get; set; }

	[XmlElement("startMenuGroup")]
	public string StartMenuGroup { get; set; }

	public PackagingSettings()
	{
		Edition = ElmaEdition.Express;
	}

	public static PackagingSettings Load(string fileName)
	{
		return Load<PackagingSettings>(fileName);
	}

	public static T Load<T>(string fileName) where T : PackagingSettings
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		T val;
		using (FileStream stream = File.OpenRead(fileName))
		{
			val = (T)xmlSerializer.Deserialize(stream);
		}
		val.Root = Path.GetDirectoryName(Path.GetDirectoryName(fileName));
		if (string.IsNullOrEmpty(val.LocalRepository))
		{
			val.LocalRepository = Path.Combine(val.Root, "Packages");
		}
		return val;
	}

	public static PackagingSettings LoadFromDirectory(string path)
	{
		return LoadFromDirectory<PackagingSettings>(path);
	}

	public static T LoadFromDirectory<T>(string path) where T : PackagingSettings
	{
		return Load<T>(Path.Combine(path, Path.ChangeExtension(Path.GetFileName(typeof(PackagingInitializer).Assembly.Location), ".config")));
	}
}
