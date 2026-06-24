using System.Xml.Serialization;

namespace Microsoft.Xml.Serialization.GeneratedAssembly;

public abstract class XmlSerializer1 : XmlSerializer
{
	protected override XmlSerializationReader CreateReader()
	{
		return new XmlSerializationReaderApplicationStartCache();
	}

	protected override XmlSerializationWriter CreateWriter()
	{
		return new XmlSerializationWriterApplicationStartCache();
	}
}
