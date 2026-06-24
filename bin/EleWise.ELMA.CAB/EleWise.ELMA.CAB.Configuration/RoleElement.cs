using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EleWise.ELMA.CAB.Configuration.Xsd;

[Serializable]
[GeneratedCode("xsd", "2.0.50727.26")]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/pag/cab-profile")]
[DebuggerStepThrough]
public class RoleElement
{
	private string allowField;

	[XmlAttribute]
	public string Allow
	{
		get
		{
			return allowField;
		}
		set
		{
			allowField = value;
		}
	}
}
