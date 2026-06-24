using System;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Documents.Models;

[Serializable]
[Obsolete("Больше не используется", true)]
[XmlRoot("PreviewSettings")]
public class PreviewSettings : DocumentStorageSettingsBase
{
	[XmlElement("PreviewSettings")]
	[DisplayName(typeof(__Resources_PreviewSettings), "P_HideSelector_DisplayName")]
	public bool HideSelector { get; set; }
}
