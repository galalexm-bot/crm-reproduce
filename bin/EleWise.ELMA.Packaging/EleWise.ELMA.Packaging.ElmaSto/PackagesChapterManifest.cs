using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
public class PackagesChapterManifest : ChapterManifest
{
	[XmlArray("Package")]
	public List<PackageManifest> Packages { get; set; }

	public override string ToXml()
	{
		using StringWriter stringWriter = new StringWriter();
		using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
		{
			Encoding = Encoding.UTF8,
			CloseOutput = true,
			Indent = true,
			ConformanceLevel = ConformanceLevel.Fragment
		}))
		{
			xmlWriter.WriteStartElement("Packages");
			foreach (PackageManifest package in Packages)
			{
				using XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(ManifestBuilder.SerializeByXml(package.GetType(), package)));
				xmlTextReader.Read();
				xmlTextReader.Read();
				while (!xmlTextReader.EOF)
				{
					xmlWriter.WriteNode(xmlTextReader, defattr: false);
				}
			}
			xmlWriter.WriteEndElement();
		}
		return stringWriter.ToString();
	}

	public PackagesChapterManifest()
	{
		Packages = new List<PackageManifest>();
	}
}
