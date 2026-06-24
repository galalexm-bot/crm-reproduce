using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;

namespace EleWise.ELMA.Runtime.Managers;

public abstract class NHManagerBase
{
	internal static NHManagerBase lmIK41WJv8XDtP5fxAMo;

	[NotNull]
	protected ISession Session => (ISession)n1IAdYWJuuAwGnjgQoQY(SessionProvider, GetDbName());

	[NotNull]
	public ISessionProvider SessionProvider
	{
		[CompilerGenerated]
		protected get
		{
			return _003CSessionProvider_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected string GetDbName()
	{
		return string.Empty;
	}

	protected NHManagerBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HyyndPWJIeiPLVreAWJD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object n1IAdYWJuuAwGnjgQoQY(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static bool oMXn3lWJ86dKpsKFGNpy()
	{
		return lmIK41WJv8XDtP5fxAMo == null;
	}

	internal static NHManagerBase PLrAGiWJZLBwCyFJ9E6N()
	{
		return lmIK41WJv8XDtP5fxAMo;
	}

	internal static void HyyndPWJIeiPLVreAWJD()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
