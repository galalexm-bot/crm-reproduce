using System;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

[Serializable]
public class SimpleTemplateModel
{
	public string Name { get; set; }

	public string Path { get; set; }

	public string FileId { get; set; }

	public long DocumentId { get; set; }

	public string CreationDate { get; set; }

	public string CreationUser { get; set; }

	public DocumentTemplateType TemplateType { get; set; }

	public long TemplateId { get; set; }
}
