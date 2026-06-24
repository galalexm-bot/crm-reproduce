using System;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.UI.DTO.Managers;

public interface IFormMetadataItemHeaderDTOManager : IConfigurationService
{
	long GetPublishingVersionNumber(long headerId);

	void Delete(long headerId);

	bool ValidateName(long headerId, Guid metadataType, string name, out string errorMessage);

	bool ValidateDisplayName(long headerId, Guid metadataType, string displayName, out string errorMessage);

	string GetDisplayName(Guid uid);
}
