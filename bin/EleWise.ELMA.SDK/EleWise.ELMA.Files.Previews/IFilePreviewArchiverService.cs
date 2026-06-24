namespace EleWise.ELMA.Files.Previews;

public interface IFilePreviewArchiverService
{
	string GetArchive(BinaryFile file);

	void ClearArchive(BinaryFile file);
}
