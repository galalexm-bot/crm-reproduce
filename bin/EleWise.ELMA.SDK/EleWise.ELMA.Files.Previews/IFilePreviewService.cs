using System.IO;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Files.Previews;

[DeveloperApi(DeveloperApiType.Service)]
public interface IFilePreviewService
{
	string PreviewDir { get; }

	void AddPreviewWork(BinaryFile file, long priority);

	void GeneratePreview(BinaryFile file);

	void GeneratePreview(BinaryFile file, string fileEncryptPassword, string password = null);

	bool TryExtractFile(BinaryFile file, string path, Stream outputStream, string fileEncryptPassword, string password = null);

	void ClearPreview(BinaryFile file);

	string GetPreviewPath(BinaryFile file);

	string GetTextPreviewPath(BinaryFile file);

	long GetTextPreviewSize(BinaryFile file);

	bool HasPreview(BinaryFile file);

	bool HasPreview(BinaryFile file, long priority);

	PreviewWorkStatus GetPreviewWorkStatus(BinaryFile file);

	bool IsSupportPreview(BinaryFile file);

	IFilePreviewCreator GetPreviewCreator(BinaryFile file);

	string GetPreviewText(BinaryFile file);

	bool CheckPassword(BinaryFile file, string password);

	bool CheckPassword(BinaryFile file, string fileEncryptPassword, string password);
}
