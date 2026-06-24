using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface ICustomActivityFolderDTOManager : IConfigurationService
{
	CustomActivityFolderDTO LoadOrNull(Guid uid);

	CustomActivityFolderDTO LoadOrNull(long id);

	CustomActivityFolderDTO LoadRootFolder(long updateCustomActivity = 0L, bool? published = null);

	IEnumerable<CustomActivityFolderDTO> GetChildFolders(long parentFolderId);

	CustomActivityFolderDTO Save(CustomActivityFolderDTO folder);

	void Delete(long groupId);
}
