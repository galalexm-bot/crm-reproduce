using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Documents.DTO.Managers;

public interface IDocumentDTOManager : IConfigurationService
{
	bool IsDocumentExists(long id);

	string GetDoсumentName(long id);

	string GetCurrentVersionFileId(long documentId);
}
