using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security;

internal interface IInternalSecurityService : ILicensedUnit, IWorkplaceLicenseInfoOwner, IConcurrentLicenseInfoOwner
{
	void CheckUserToAuthenticate([NotNull] EleWise.ELMA.Security.Models.IUser user, Func<bool> isAlreadyLoggedFunc, Func<int, bool> isCurrentPrivilegeFunc, Func<int> otherUsersCountFunc);

	bool CanCreateNewUser();
}
