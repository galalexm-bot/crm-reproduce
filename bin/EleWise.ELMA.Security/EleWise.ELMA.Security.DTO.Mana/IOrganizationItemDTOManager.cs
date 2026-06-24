using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Security.DTO.Models;

namespace EleWise.ELMA.Security.DTO.Managers;

public interface IOrganizationItemDTOManager : IConfigurationService
{
	OrganizationItemDTO LoadRoot();

	OrganizationItemDTO LoadOrNull(Guid uid);

	OrganizationItemDTO LoadOrNull(long id);

	List<UserDTO> UsersToOrganizationItem(long id);
}
