using System.Xml.Serialization;

namespace EleWise.ELMA.WebCompiler;

public class WebCompileDiagnostic
{
	[XmlIgnore]
	public bool IsError { get; set; }

	[XmlIgnore]
	public string Id { get; set; }

	public string Message { get; set; }

	public WebCompileDiagnosticPosition Position { get; set; }

	public override string ToString()
	{
		return Message;
	}
}
