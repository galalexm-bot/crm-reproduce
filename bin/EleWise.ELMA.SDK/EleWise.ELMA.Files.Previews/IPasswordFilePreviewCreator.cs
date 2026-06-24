namespace EleWise.ELMA.Files.Previews;

public interface IPasswordFilePreviewCreator : IFilePreviewCreator
{
	bool CheckPassword(BinaryFile file, string password);

	void Create(string path, BinaryFile file, string password);
}
