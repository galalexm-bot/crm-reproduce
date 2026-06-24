using System;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Documents.DTO.Managers;

public interface ISearchUsesElementsOrganizationDTOManager : IConfigurationService
{
	long FindDocument(Guid metadataType, long elementOrgstructurId);
}
