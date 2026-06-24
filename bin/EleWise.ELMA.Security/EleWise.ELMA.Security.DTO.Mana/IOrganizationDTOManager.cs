using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Security.DTO.Models;

namespace EleWise.ELMA.Security.DTO.Managers;

public interface IOrganizationDTOManager : IConfigurationService
{
	int CurrentVersion { get; }

	OrganizationModelDTO LoadOrNull();

	OrganizationModelDTO LoadOrNull(int id);

	OrganizationModelDTO LoadPublishedOrNull();

	void Save(OrganizationModelDTO organizationModel);

	int Publish(OrganizationModelDTO organizationModel);

	int Publish(OrganizationModelDTO organizationModel, out OrganizationModelPublishWarning warning);

	int Validate(OrganizationModelDTO organizationModel);

	int Validate(OrganizationModelDTO organizationModel, out OrganizationModelPublishWarning warning);

	ICollection<OrganizationVersionDTO> FindAllVersions();
}
