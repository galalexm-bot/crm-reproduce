using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace EleWise.ELMA.ServerInfoReference;

[Serializable]
[GeneratedCode("System.Xml", "4.8.3761.0")]
[XmlType(Namespace = "http://tempuri.org/")]
public enum StartErrorType
{
	Fatal,
	OlderVersion,
	OtherConnections,
	LastUpdateFault,
	ConfigurationScriptsRecompileRequired
}
