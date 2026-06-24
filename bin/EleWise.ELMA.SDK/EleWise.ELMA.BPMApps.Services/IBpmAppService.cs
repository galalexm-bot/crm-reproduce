using System;
using System.Collections.Generic;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.Deploy.Export;

namespace EleWise.ELMA.BPMApps.Services;

public interface IBpmAppService
{
	IEnumerable<BPMAppDTO> LoadAll();

	BPMAppDTO Save(BPMAppDTO bpmApp, byte[] helpFileContent, byte[] additionalFilesContent);

	BPMAppDTO Save(BPMAppDTO bpmApp);

	void Delete(long id);

	void LoadFiles(long id, out byte[] helpFileContent, out byte[] additionalFilesContent);

	ConfigExportSettings GetAppExportSettings(Guid uid, Guid settingsFilename);

	FilesLoadToCacheResult PutBpmAppFilesToCache(FilesLoadToCacheInput input);
}
