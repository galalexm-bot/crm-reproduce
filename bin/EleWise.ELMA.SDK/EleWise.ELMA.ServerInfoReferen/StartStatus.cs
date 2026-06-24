using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace EleWise.ELMA.ServerInfoReference;

[Serializable]
[XmlType(Namespace = "http://tempuri.org/")]
[GeneratedCode("System.Xml", "4.8.3761.0")]
public enum StartStatus
{
	Running,
	Started,
	NotActivated,
	NotStarted,
	PrerequisitesCheckFault,
	BackupNeeded
}
