using System.Globalization;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

public class ServerLocalizationService : DTOManager, IServerLocalizationService, IConfigurationService
{
	internal static ServerLocalizationService H4aS4AGELOuJHpwwQhY9;

	public virtual string GetDefaultCultureName()
	{
		return (string)GibsWQGEc3hjpQ6iqIXR(SR.GetDefaultCulture());
	}

	public ServerLocalizationService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mS4p4KGEzEZ93YEpQIR9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object GibsWQGEc3hjpQ6iqIXR(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static void mS4p4KGEzEZ93YEpQIR9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool U06ICdGEU4mPS1bsUc1r()
	{
		return H4aS4AGELOuJHpwwQhY9 == null;
	}

	internal static ServerLocalizationService kZeQXOGEsBMLkbdhy3Rt()
	{
		return H4aS4AGELOuJHpwwQhY9;
	}
}
