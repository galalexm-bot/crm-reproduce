namespace EleWise.ELMA.Documents.Models;

public class AddDocumentVersionResult
{
	public IDocumentVersion NewDocumentVersion { get; set; }

	public bool IsWebDocument { get; set; }
}
