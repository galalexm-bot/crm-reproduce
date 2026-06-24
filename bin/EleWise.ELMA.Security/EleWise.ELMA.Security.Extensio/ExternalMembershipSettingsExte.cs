using System;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Settings;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Security.Extensions;

public static class ExternalMembershipSettingsExtension
{
	internal static ExternalMembershipSettingsExtension zCoKnG8mgF73KZ9rLJ3;

	public static IExternalMembershipModule Module(this IExternalMembershipModuleSettings settings)
	{
		return (IExternalMembershipModule)dvpC8t8H5g4HJwtIK2Q(Locator.GetServiceNotNull<IExternalMembershipManager>(), hi8Ial8jFYrVF9oQt4p(settings));
	}

	internal static Guid hi8Ial8jFYrVF9oQt4p(object P_0)
	{
		return ((IExternalMembershipModuleSettings)P_0).ModuleUid;
	}

	internal static object dvpC8t8H5g4HJwtIK2Q(object P_0, Guid moduleUid)
	{
		return ((IExternalMembershipManager)P_0).GetModule(moduleUid);
	}

	internal static bool BDNEHj8eAf7L6ZFNqTe()
	{
		return zCoKnG8mgF73KZ9rLJ3 == null;
	}

	internal static ExternalMembershipSettingsExtension wDItgn8L8ShIbbYktU5()
	{
		return zCoKnG8mgF73KZ9rLJ3;
	}
}
