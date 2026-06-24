using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.UI.DTO.Models;

namespace EleWise.ELMA.UI.DTO.Managers;

public interface IFormMetadataItemGroupDTOManager : IConfigurationService
{
	FormMetadataItemGroupDTO LoadRootGroup(Guid metadataType);

	IEnumerable<FormMetadataItemGroupDTO> GetChildGroups(Guid metadataType, long? parentGroupId);

	IEnumerable<FormMetadataItemGroupDTO> GetNestedChildGroups(Guid metadataType, long? parentGroupId);

	FormMetadataItemGroupDTO Save(FormMetadataItemGroupDTO group);

	void Delete(long groupId);
}
