using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using EleWise.ELMA.Logging;
using Orchard.Environment.Descriptor.Models;
using Orchard.FileSystems.AppData;
using Orchard.Localization;

namespace Orchard.Environment.Descriptor;

public class ShellDescriptorCache : IShellDescriptorCache
{
	private readonly IAppDataFolder _appDataFolder;

	private const string DescriptorCacheFileName = "cache.dat";

	private static readonly object _synLock = new object();

	public ILogger Logger { get; set; }

	public Localizer T { get; set; }

	public bool Disabled { get; set; }

	public ShellDescriptorCache(IAppDataFolder appDataFolder)
	{
		_appDataFolder = appDataFolder;
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	public ShellDescriptor Fetch(string name)
	{
		if (Disabled)
		{
			return null;
		}
		lock (_synLock)
		{
			VerifyCacheFile();
			string xml = _appDataFolder.ReadFile("cache.dat");
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			XmlNode documentElement = xmlDocument.DocumentElement;
			if (documentElement != null)
			{
				foreach (XmlNode childNode in documentElement.ChildNodes)
				{
					if (string.Equals(childNode.Name, name, StringComparison.OrdinalIgnoreCase))
					{
						return GetShellDecriptorForCacheText(childNode.InnerText);
					}
				}
			}
			return null;
		}
	}

	public void Store(string name, ShellDescriptor descriptor)
	{
		if (Disabled)
		{
			return;
		}
		lock (_synLock)
		{
			VerifyCacheFile();
			string xml = _appDataFolder.ReadFile("cache.dat");
			bool flag = false;
			StringWriter stringWriter = new StringWriter();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			XmlNode documentElement = xmlDocument.DocumentElement;
			if (documentElement != null)
			{
				foreach (XmlNode childNode in documentElement.ChildNodes)
				{
					if (string.Equals(childNode.Name, name, StringComparison.OrdinalIgnoreCase))
					{
						childNode.InnerText = GetCacheTextForShellDescriptor(descriptor);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					XmlElement xmlElement = xmlDocument.CreateElement(name);
					xmlElement.InnerText = GetCacheTextForShellDescriptor(descriptor);
					documentElement.AppendChild(xmlElement);
				}
			}
			xmlDocument.Save(stringWriter);
			_appDataFolder.CreateFile("cache.dat", stringWriter.ToString());
		}
	}

	private static string GetCacheTextForShellDescriptor(ShellDescriptor descriptor)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(descriptor.SerialNumber + "|");
		foreach (ShellFeature feature in descriptor.Features)
		{
			stringBuilder.Append(feature.Name + ";");
		}
		return stringBuilder.ToString();
	}

	private static ShellDescriptor GetShellDecriptorForCacheText(string p)
	{
		string[] array = p.Trim().Split(new string[1] { "|" }, StringSplitOptions.None);
		ShellDescriptor shellDescriptor = new ShellDescriptor
		{
			SerialNumber = Convert.ToInt32(array[0])
		};
		string[] source = array[1].Split(new string[1] { ";" }, StringSplitOptions.RemoveEmptyEntries);
		shellDescriptor.Features = source.Select((string feature) => new ShellFeature
		{
			Name = feature
		}).ToList();
		return shellDescriptor;
	}

	private void VerifyCacheFile()
	{
		if (!_appDataFolder.FileExists("cache.dat"))
		{
			StringWriter stringWriter = new StringWriter();
			using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
			{
				xmlWriter.WriteStartDocument();
				xmlWriter.WriteStartElement("Tenants");
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndDocument();
			}
			_appDataFolder.CreateFile("cache.dat", stringWriter.ToString());
		}
	}
}
