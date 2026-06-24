using System.ServiceModel.Channels;
using System.Xml;

namespace EleWise.ELMA.Web.Service.JsonBehavior;

internal sealed class RawBodyWriter : BodyWriter
{
	private readonly byte[] content;

	private readonly int offset;

	private readonly int length;

	public RawBodyWriter(byte[] content, int offset, int length)
		: base(isBuffered: true)
	{
		this.content = content;
		this.offset = offset;
		this.length = length;
	}

	protected override void OnWriteBodyContents(XmlDictionaryWriter writer)
	{
		writer.WriteStartElement("Binary");
		writer.WriteBase64(content, offset, length);
		writer.WriteEndElement();
	}
}
