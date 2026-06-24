namespace EleWise.ELMA.Documents.Models;

internal class ValidateFolderResult
{
	public IFolder Folder { get; set; }

	public string[] Messages { get; set; }
}
