using System.Xml.Serialization;

namespace EleWise.ELMA.WebCompiler;

public class WebCompileDiagnosticPosition
{
	[XmlIgnore]
	public string FilePath { get; set; }

	public int Character { get; set; }

	public int Line { get; set; }
}
