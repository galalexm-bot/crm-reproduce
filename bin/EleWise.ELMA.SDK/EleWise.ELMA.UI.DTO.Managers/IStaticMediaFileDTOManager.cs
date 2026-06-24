using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.UI.DTO.Managers;

public interface IStaticMediaFileDTOManager : IConfigurationService
{
	string GetWebRoot();

	IEnumerable<FileEntryDTO> GetFiles(string webPath);

	IEnumerable<DirectoryEntryDTO> GetDirectories(string webPath);

	byte[] GetFiles(FileEntryDTO[] fileEnties);
}
