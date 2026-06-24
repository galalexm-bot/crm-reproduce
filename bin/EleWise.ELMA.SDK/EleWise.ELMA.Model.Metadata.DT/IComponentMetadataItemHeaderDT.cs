using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.DTO.Models;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

public interface IComponentMetadataItemHeaderDTOManager : IConfigurationService
{
	ComponentMetadataItemHeaderDTO Load(long id);

	ComponentMetadataItemHeaderDTO LoadOrNull(long id);

	ComponentMetadataItemHeaderDTO LoadOrNull(Guid uid);

	IEnumerable<ComponentMetadataItemHeaderDTO> FindAll();
}
