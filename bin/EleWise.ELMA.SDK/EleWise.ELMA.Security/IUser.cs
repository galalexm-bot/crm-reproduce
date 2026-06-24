using System;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Security;

public interface IUser : IIdentified
{
	string UserName { get; }

	string FullName { get; }

	string EMail { get; }

	string Lang { get; set; }

	bool IsSystemLocal { get; set; }

	Guid AuthProviderGuid { get; }
}
