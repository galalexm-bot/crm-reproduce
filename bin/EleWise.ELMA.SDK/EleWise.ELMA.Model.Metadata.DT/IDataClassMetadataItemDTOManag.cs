using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.DTO.Models;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

public interface IDataClassMetadataItemDTOManager : IConfigurationService
{
	DataClassMetadataItemDTO Load(long id);

	DataClassMetadataItemDTO LoadOrNull(long id);

	DataClassMetadataItemDTO LoadOrNull(Guid uid);
}
