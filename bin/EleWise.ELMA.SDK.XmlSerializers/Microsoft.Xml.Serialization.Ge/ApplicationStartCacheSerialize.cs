using System.Xml;
using System.Xml.Serialization;

namespace Microsoft.Xml.Serialization.GeneratedAssembly;

public sealed class ApplicationStartCacheSerializer : XmlSerializer1
{
	public override bool CanDeserialize(XmlReader xmlReader)
	{
		return xmlReader.IsStartElement("ApplicationStartCache", "");
	}

	protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
	{
		((XmlSerializationWriterApplicationStartCache)writer).Write5_ApplicationStartCache(objectToSerialize);
	}

	protected override object Deserialize(XmlSerializationReader reader)
	{
		return ((XmlSerializationReaderApplicationStartCache)reader).Read6_ApplicationStartCache();
	}
}
