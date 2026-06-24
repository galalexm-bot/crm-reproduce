using System;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Services.API;

internal abstract class DefaultApplicationValidator : IPublicApplicationAuthValidator
{
	private static DefaultApplicationValidator e5T3q0UMO3qqeWxfpZc;

	public virtual string AppToken => PublicApplicationService.DefaultApplications.First((PublicApplicationService.DefaultSystemApplication a) => lQt660U4GZqHqAADrq2(a) == AppUid).DefaultToken;

	protected abstract Guid AppUid { get; }

	public virtual bool Validate(IUser user)
	{
		return true;
	}

	protected DefaultApplicationValidator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PqJfemUIeSrS8jvIhqO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rLNpkCUsgfJc9MTEOGd()
	{
		return e5T3q0UMO3qqeWxfpZc == null;
	}

	internal static DefaultApplicationValidator Y7sGF5UYEviKB3aEsiC()
	{
		return e5T3q0UMO3qqeWxfpZc;
	}

	internal static void PqJfemUIeSrS8jvIhqO()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static Guid lQt660U4GZqHqAADrq2(object P_0)
	{
		return ((PublicApplicationService.DefaultSystemApplication)P_0).Uid;
	}
}
