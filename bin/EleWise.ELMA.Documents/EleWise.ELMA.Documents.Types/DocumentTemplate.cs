using System;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Documents.Types;

[Serializable]
public class DocumentTemplate
{
	public string Name { get; set; }

	public bool DocumentUsed { get; set; }

	public long? DocumentId { get; set; }

	public string TemplateFileId { get; set; }

	public BinaryFile File { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2b660715-d111-4cc6-acfd-965661719fba")]
	public IDocument Document { get; set; }
}
