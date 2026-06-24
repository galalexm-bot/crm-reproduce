using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
public class EntitiesChapterManifest : ChapterManifest
{
	[XmlArray("Entities")]
	public List<EntityManifest> Entities { get; set; }

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
			xmlWriter.WriteStartElement("Entities");
			foreach (EntityManifest entity in Entities)
			{
				using XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(ManifestBuilder.SerializeByXml(entity.GetType(), entity)));
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

	public EntitiesChapterManifest()
	{
		Entities = new List<EntityManifest>();
	}
}
