using EleWise.ELMA.Documents.Metadata;

namespace EleWise.ELMA.Documents.Models;

internal class InitDocumentResult
{
	public IDocumentMetadataProfile Profile { get; set; }

	public DocumentMetadata Metadata { get; set; }

	public IDocumentVersion Version { get; set; }

	public string[] Messages { get; set; }
}
