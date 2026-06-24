using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Security.DTO.Models;

namespace EleWise.ELMA.Security.DTO.Managers;

public interface IUserGroupDTOManager : IConfigurationService
{
	UserGroupDTO Save(UserGroupDTO group);

	UserGroupDTO Load(long id);

	UserGroupDTO LoadOrNull(long id);

	UserGroupDTO Load(Guid uid);

	UserGroupDTO LoadOrNull(Guid uid);

	ICollection<UserGroupDTO> FindAll();

	void Delete(long id);
}
