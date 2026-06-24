using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EleWise.ELMA.CAB.Configuration.Xsd;

[Serializable]
[DesignerCategory("code")]
[XmlRoot("SolutionProfile", Namespace = "http://schemas.microsoft.com/pag/cab-profile", IsNullable = false)]
[DebuggerStepThrough]
[GeneratedCode("xsd", "2.0.50727.26")]
[XmlType(Namespace = "http://schemas.microsoft.com/pag/cab-profile")]
public class SolutionProfileElement
{
	private ModuleInfoElement[] modulesField;

	[XmlArrayItem("ModuleInfo", IsNullable = false)]
	public ModuleInfoElement[] Modules
	{
		get
		{
			return modulesField;
		}
		set
		{
			modulesField = value;
		}
	}

	public SolutionProfileElement()
	{
		modulesField = new ModuleInfoElement[0];
	}
}
