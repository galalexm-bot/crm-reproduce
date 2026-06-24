using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging;

public class FilesAttributes
{
	public const string FileName = "Files_Attributes.xml";

	[XmlArrayItem("File")]
	public List<FileAttributes> Files { get; set; }

	public FilesAttributes()
	{
		Files = new List<FileAttributes>();
	}
}
