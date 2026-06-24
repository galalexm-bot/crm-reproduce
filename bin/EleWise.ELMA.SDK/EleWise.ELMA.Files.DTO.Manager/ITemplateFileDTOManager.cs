using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files.DTO.Models;

namespace EleWise.ELMA.Files.DTO.Managers;

public interface ITemplateFileDTOManager : IConfigurationService
{
	string SaveTemplate(BinaryFileDTO binaryFile);

	BinaryFileDTO LoadTemplate(string id);

	BinaryFileDTO CreateFromTemplate(string id);

	BinaryFileDTO LoadSystemTemplate(string name);

	string GetTemplateFileServerPath(string id);
}
