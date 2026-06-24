namespace EleWise.ELMA.Documents.Web.Models;

internal sealed class FolderTreePackage
{
	public long FolderId { get; }

	public int Package { get; }

	public long Depth { get; }

	public FolderTreePackage(long folderId, int package, long depth)
	{
		FolderId = folderId;
		Package = package;
		Depth = depth;
	}
}
