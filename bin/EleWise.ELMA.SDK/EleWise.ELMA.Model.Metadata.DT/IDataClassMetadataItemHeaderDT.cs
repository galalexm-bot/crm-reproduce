using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.DTO.Models;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

public interface IDataClassMetadataItemHeaderDTOManager : IConfigurationService
{
	DataClassMetadataItemHeaderDTO Load(long id);

	DataClassMetadataItemHeaderDTO LoadOrNull(long id);

	DataClassMetadataItemHeaderDTO LoadOrNull(Guid uid);

	IEnumerable<DataClassMetadataItemHeaderDTO> FindAll();
}
