using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using EleWise.ELMA.Packaging.FileSystems;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class ManifestBuilder
{
	private readonly ElmaStoreComponentManifest _manifest;

	public ManifestBuilder(ElmaStoreComponentManifest manifest)
	{
		_manifest = manifest;
	}

	public void Create(string fileName)
	{
		SerializeByXmlToFile<ElmaStoreComponentManifest>(_manifest, fileName);
	}

	public static string SerializeByXml(Type t, object obj)
	{
		string result = null;
		MemoryStream ms = new MemoryStream();
		try
		{
			SerializeByXml(t, obj, ms, delegate
			{
				using StreamReader streamReader = new StreamReader(ms, Encoding.UTF8);
				result = streamReader.ReadToEnd();
			});
		}
		finally
		{
			if (ms != null)
			{
				((IDisposable)ms).Dispose();
			}
		}
		return result;
	}

	public static string SerializeByXml<T>(object obj)
	{
		return SerializeByXml(typeof(T), obj);
	}

	public static T DeserializeByXml<T>(string xml)
	{
		using MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
		return (T)DeserializeByXml(typeof(T), stream);
	}

	public static void SerializeByXmlToFile<T>(object obj, string fileName)
	{
		FS.CreateFile(fileName, delegate
		{
			using FileStream stream = File.Create(fileName);
			SerializeByXml(typeof(T), obj, stream, delegate
			{
			});
		});
	}

	public static T DeserializeByXmlFromFile<T>(string filename)
	{
		using FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
		return (T)DeserializeByXml(typeof(T), stream);
	}

	public static void ReadDataForDeserialization(object obj, SerializationInfo info)
	{
		if (obj == null)
		{
			return;
		}
		Type type = obj.GetType();
		if (type == null)
		{
			return;
		}
		SerializationInfoEnumerator enumerator = info.GetEnumerator();
		while (enumerator.MoveNext())
		{
			FieldInfo field = type.GetField(enumerator.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (field != null)
			{
				field.SetValue(obj, info.GetValue(enumerator.Name, field.FieldType));
			}
		}
	}

	public static void WriteDataForSerialization(object obj, SerializationInfo info)
	{
		if (obj == null)
		{
			return;
		}
		Type type = obj.GetType();
		if (type == null)
		{
			return;
		}
		FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if ((fieldInfo.Attributes & FieldAttributes.NotSerialized) != FieldAttributes.NotSerialized)
			{
				object value = fieldInfo.GetValue(obj);
				info.AddValue(fieldInfo.Name, value);
			}
		}
	}

	private static void SerializeByXml(Type type, object obj, Stream stream, Action<Stream> action)
	{
		using XmlTextWriter xmlTextWriter = new XmlTextWriter(stream, Encoding.UTF8);
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlTextWriter.Indentation = 2;
		xmlTextWriter.IndentChar = ' ';
		new XmlSerializer(type).Serialize(xmlTextWriter, obj);
		stream.Seek(0L, SeekOrigin.Begin);
		action(stream);
	}

	private static object DeserializeByXml(Type type, Stream stream)
	{
		using XmlTextReader xmlReader = new XmlTextReader(stream);
		return new XmlSerializer(type).Deserialize(xmlReader);
	}
}
