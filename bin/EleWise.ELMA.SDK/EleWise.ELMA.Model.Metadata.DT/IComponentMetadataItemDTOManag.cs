using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.DTO.Models;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

public interface IComponentMetadataItemDTOManager : IConfigurationService
{
	ComponentMetadataItemDTO Load(long id);

	ComponentMetadataItemDTO LoadOrNull(long id);

	ComponentMetadataItemDTO LoadOrNull(Guid uid);
}
