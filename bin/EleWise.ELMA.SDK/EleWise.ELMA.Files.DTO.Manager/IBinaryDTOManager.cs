using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files.DTO.Models;

namespace EleWise.ELMA.Files.DTO.Managers;

public interface IBinaryDTOManager : IConfigurationService
{
	string SaveFile(BinaryFileDTO binaryFile);

	BinaryFileDTO LoadFile(string id);

	BinaryFileDTO CopyFile(BinaryFileDTO sourceBinaryFile);
}
