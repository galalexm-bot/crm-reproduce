using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.DTO.Models;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

public interface IMetadataItemGroupDTOManager : IConfigurationService
{
	MetadataItemGroupDTO LoadRootGroup();

	IEnumerable<MetadataItemGroupDTO> GetChildGroups(long parentGroupId);

	IEnumerable<MetadataItemGroupDTO> GetNestedChildGroups(long parentGroupId);

	MetadataItemGroupDTO Save(MetadataItemGroupDTO group);

	void Delete(long groupId);
}
