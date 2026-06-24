using System;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Nullifier;

namespace EleWise.ELMA.Documents.Extensions;

[Serializable]
[Component]
[XmlRoot("UnitNullConfigDocument")]
public class UnitNullConfigDocument : UnitNullConfig
{
	[XmlElement("CheckDeleteVersionDocument")]
	public bool CheckDeleteVersionDocument { get; set; }

	[XmlElement("CheckDeleteActivVersionDocument")]
	public bool CheckDeleteActivVersionDocument { get; set; }

	[XmlElement("CheckDeleteDateVersionDocument")]
	public bool CheckDeleteDateVersionDocument { get; set; }

	[XmlElement("CheckExactDateVersionDocument")]
	public bool CheckExactDateVersionDocument { get; set; }

	[XmlElement("ExactDateVersionDocument")]
	public DateTime? ExactDateVersionDocument { get; set; }

	[XmlElement("CheckRelativeDateVersionDocument")]
	public bool CheckRelativeDateVersionDocument { get; set; }

	[XmlElement("CheckRelativeDateVersionDocumentYear")]
	public long? CheckRelativeDateVersionDocumentYear { get; set; }

	[XmlElement("CheckRelativeDateVersionDocumentMonth")]
	public long? CheckRelativeDateVersionDocumentMonth { get; set; }

	[XmlElement("CheckRelativeDateVersionDocumentDay")]
	public long? CheckRelativeDateVersionDocumentDay { get; set; }

	[XmlElement("DeleteHistoryVersionDocument")]
	public bool DeleteHistoryVersionDocument { get; set; }

	public UnitNullConfigDocument()
	{
		CheckDeleteVersionDocument = true;
		CheckDeleteActivVersionDocument = true;
		CheckDeleteDateVersionDocument = false;
	}
}
