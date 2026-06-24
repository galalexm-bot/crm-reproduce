using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Documents.Types;

[Serializable]
[XmlRoot("DocumentTemplatesList")]
public class DocumentTemplatesList
{
	public List<DocumentTemplate> Items { get; set; }

	public int SelectedTemplate { get; set; }

	public DocumentTemplate NewTemplate { get; set; }

	public DocumentTemplatesList()
	{
		Items = new List<DocumentTemplate>();
	}
}
