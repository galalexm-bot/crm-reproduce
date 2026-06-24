using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Deploy;

[Component]
public class SecurityDeployHelper : ISecurityDeployHelperExtension
{
	private static SecurityDeployHelper egGJN73JQsl4aVdNUfM;

	public IUser LoadUserOrNull(long userId)
	{
		return UserManager.Instance.LoadOrNull(userId);
	}

	public SecurityDeployHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YjRXX63hd9EiP8w5mnj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool S9PGRa3KM1c9Bs4EI8j()
	{
		return egGJN73JQsl4aVdNUfM == null;
	}

	internal static SecurityDeployHelper XlDJLQ3tc0ayBx6MwnY()
	{
		return egGJN73JQsl4aVdNUfM;
	}

	internal static void YjRXX63hd9EiP8w5mnj()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
