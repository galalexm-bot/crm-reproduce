using System.Collections.Generic;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.BPMApps.DTO.Managers;

public interface IBPMAppDTOManager : IConfigurationService
{
	IEnumerable<BPMAppDTO> LoadAll();

	BPMAppDTO Save(BPMAppDTO bpmApp, byte[] helpFileContent, byte[] additionalFilesContent);

	BPMAppDTO Save(BPMAppDTO bpmApp);

	void Delete(long id);

	void LoadFiles(long id, out byte[] helpFileContent, out byte[] additionalFilesContent);
}
