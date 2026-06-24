using System;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Documents.DTO.Managers;

public class SearchUsesElementsOrganizationDTOManager : DTOManager, ISearchUsesElementsOrganizationDTOManager, IConfigurationService
{
	public virtual long FindDocument(Guid metadataType, long elementOrgstructurId)
	{
		Guid typeUid = new Guid("e502f586-afd4-4f55-bedb-f71028ffd302");
		return DocumentMetadataHeadManager.Instance.findUse(metadataType, elementOrgstructurId, typeUid);
	}
}
