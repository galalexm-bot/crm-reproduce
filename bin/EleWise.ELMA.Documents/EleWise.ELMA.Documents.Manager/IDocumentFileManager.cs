using EleWise.ELMA.Files;

namespace EleWise.ELMA.Documents.Managers;

public interface IDocumentFileManager
{
	BinaryFile GetFileByDocumentId(long documentId);
}
