using System;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Models;

[Serializable]
[XmlRoot("DragAndDropSettings")]
public class DragAndDropSettings : DocumentStorageSettingsBase
{
	[XmlElement("DocumentType")]
	[DisplayName(typeof(__Resources_DragAndDropSettings), "P_DocumentType_DisplayName")]
	public Guid DocumentType { get; set; }

	[XmlElement("UseCustomTemplate")]
	[DisplayName(typeof(__Resources_DragAndDropSettings), "P_UseCustomTemplate_DisplayName")]
	public bool UseCustomTemplate { get; set; }

	[XmlElement("TemplateName")]
	[DisplayName(typeof(__Resources_DragAndDropSettings), "P_TemplateName_DisplayName")]
	public string TemplateName { get; set; }

	[DisplayName(typeof(__Resources_DragAndDropSettings), "P_DoubleNameAction_DisplayName")]
	public DoubleNameActionType DoubleNameAction { get; set; }

	public DragAndDropSettings()
	{
		DocumentType = InterfaceActivator.UID<IFile>();
		DoubleNameAction = DoubleNameActionType.UseFileName;
	}

	public EntityMetadata GetDocumentMetadata()
	{
		if (DocumentType == Guid.Empty)
		{
			return null;
		}
		return (EntityMetadata)MetadataLoader.LoadMetadata(DocumentType);
	}
}
