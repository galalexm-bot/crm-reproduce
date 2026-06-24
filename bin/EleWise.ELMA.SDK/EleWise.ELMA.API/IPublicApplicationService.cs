using System;
using System.Collections.Generic;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.API;

[DeveloperApi(DeveloperApiType.Service)]
public interface IPublicApplicationService
{
	IEnumerable<IPublicApplication> Applications { get; }

	bool CreateApplication(IPublicApplication application);

	bool RemoveApplication(Guid applicationUid);

	bool IsActive(Guid applicationUid);

	bool Activate(Guid applicationUid);

	bool DeActivate(Guid applicationUid);

	IPublicApplicationToken CreateToken(Guid applicationUid, DateTime expire);

	bool IsTokenValid(string applicationToken, out IPublicApplicationToken token);

	bool HasUserAccess(string applicationToken, IUser user);

	bool UpdateToken(string applicationToken, DateTime expire);

	bool RemoveToken(string applicationToken);
}
