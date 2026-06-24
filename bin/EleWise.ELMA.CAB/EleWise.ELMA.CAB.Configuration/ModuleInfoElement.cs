using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EleWise.ELMA.CAB.Configuration.Xsd;

[Serializable]
[GeneratedCode("xsd", "2.0.50727.26")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/pag/cab-profile")]
public class ModuleInfoElement
{
	private string assemblyFileField;

	private RoleElement[] rolesField;

	private string updateLocationField;

	[XmlArrayItem("Role", IsNullable = false)]
	public RoleElement[] Roles
	{
		get
		{
			return rolesField;
		}
		set
		{
			rolesField = value;
		}
	}

	[XmlAttribute]
	public string AssemblyFile
	{
		get
		{
			return assemblyFileField;
		}
		set
		{
			assemblyFileField = value;
		}
	}

	[XmlAttribute(DataType = "anyURI")]
	public string UpdateLocation
	{
		get
		{
			return updateLocationField;
		}
		set
		{
			updateLocationField = value;
		}
	}
}
