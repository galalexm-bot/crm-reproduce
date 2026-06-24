using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.DTO.Models;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

public interface IFunctionMetadataItemHeaderDTOManager : IConfigurationService
{
	FunctionMetadataItemHeaderDTO Load(long id);

	FunctionMetadataItemHeaderDTO LoadOrNull(long id);

	FunctionMetadataItemHeaderDTO LoadOrNull(Guid uid);

	IEnumerable<FunctionMetadataItemHeaderDTO> FindAll();
}
