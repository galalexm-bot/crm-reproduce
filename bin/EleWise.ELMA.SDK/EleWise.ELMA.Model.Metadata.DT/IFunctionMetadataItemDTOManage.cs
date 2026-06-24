using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.DTO.Models;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

public interface IFunctionMetadataItemDTOManager : IConfigurationService
{
	FunctionMetadataItemDTO Load(long id);

	FunctionMetadataItemDTO LoadOrNull(long id);

	FunctionMetadataItemDTO LoadOrNull(Guid uid);
}
