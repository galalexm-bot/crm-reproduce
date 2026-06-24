using System.IO;
using System.Xml.Serialization;
using EleWise.ELMA.Packaging.FileSystems;

namespace EleWise.ELMA.Packaging;

public class ElmaComponentSettings
{
	public const string DefaultSettingsFileName = "ComponentSettings.config";

	public virtual void InitByDefault()
	{
	}

	public virtual void Save(string fileName)
	{
		XmlSerializer serializer = new XmlSerializer(GetType());
		string tempFileName = fileName + ".bak";
		FS.CreateFile(tempFileName, delegate
		{
			using FileStream stream = File.Create(tempFileName);
			serializer.Serialize(stream, this);
		});
		FS.CreateFile(fileName, delegate
		{
			File.Move(tempFileName, fileName);
		});
	}

	public static T Load<T>(string fileName) where T : ElmaComponentSettings
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		using FileStream stream = File.OpenRead(fileName);
		return (T)xmlSerializer.Deserialize(stream);
	}
}
