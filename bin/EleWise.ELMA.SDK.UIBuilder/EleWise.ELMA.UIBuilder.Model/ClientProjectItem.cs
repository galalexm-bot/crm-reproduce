using System;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Scripts.DTO.Models;

namespace EleWise.ELMA.UIBuilder.Model;

[Serializable]
[Component]
public class ClientProjectItem : ProjectItem
{
	[XmlIgnore]
	public override string FileName => $"{base.Name}.{FileExtension}";

	[XmlIgnore]
	public override string ClassName => base.Name.Replace("." + FileExtension, "").ToTranslitIdent();

	public string FileExtension { get; set; }
}
