using System;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.API.Models;

public interface IPublicClientSession
{
	Guid AuthToken { get; }

	IPublicApplicationToken ClientToken { get; }

	IPublicApplication Application { get; }

	string SessionToken { get; }

	IUser AuthUser { get; }

	DateTime LastAccess { get; }

	byte[] LastChangesPackage { get; set; }
}
