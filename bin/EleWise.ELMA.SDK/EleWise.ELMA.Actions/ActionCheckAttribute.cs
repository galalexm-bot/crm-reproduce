using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Actions;

[Serializable]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class ActionCheckAttribute : ActionImplAttribute
{
	private static ActionCheckAttribute wxItXXfwLFGQjcTo82Sq;

	public ActionCheckAttribute(string actionTypeUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		a4EfRWfwcYA7dfKYtOSq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Apply(actionTypeUid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ActionCheckAttribute(string actionTypeUid, string auditObjectUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		a4EfRWfwcYA7dfKYtOSq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Apply(actionTypeUid, auditObjectUid);
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num = 1;
			}
		}
	}

	internal static void a4EfRWfwcYA7dfKYtOSq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool kDSMrkfwU5f6yV7iqeqN()
	{
		return wxItXXfwLFGQjcTo82Sq == null;
	}

	internal static ActionCheckAttribute CZvBd3fwsGBXL4UG8d4F()
	{
		return wxItXXfwLFGQjcTo82Sq;
	}
}
