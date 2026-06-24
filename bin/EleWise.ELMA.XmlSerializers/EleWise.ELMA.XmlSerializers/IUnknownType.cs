using System.Collections.Generic;
using System.Xml;

namespace EleWise.ELMA.XmlSerializers;

public interface IUnknownType
{
	List<KeyValuePair<string, string>> Attributes { get; set; }

	List<XmlNode> Nodes { get; set; }
}
