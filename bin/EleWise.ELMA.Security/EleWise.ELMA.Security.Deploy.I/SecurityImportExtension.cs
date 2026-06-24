using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Deploy.Import;

[Component]
public class SecurityImportExtension : ConfigImportExtension
{
	internal static SecurityImportExtension nrDlbUbuO9IApxFwVUm;

	public override void OnPreStartImport(PreStartImportParameters parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				xobIwWbLiKEbMveXVgM(this, parameters);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ytEcHObjHU5SbMShGlj(Locator.GetServiceNotNull<RunWithElevatedPrivilegiesService>(), true);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public SecurityImportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cbnqOqbHXnh8dXID7Vf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void xobIwWbLiKEbMveXVgM(object P_0, object P_1)
	{
		((ConfigImportExtension)P_0).OnPreStartImport((PreStartImportParameters)P_1);
	}

	internal static void ytEcHObjHU5SbMShGlj(object P_0, bool value)
	{
		((RunWithElevatedPrivilegiesService)P_0).Turned = value;
	}

	internal static bool Su1FWIbms66tjUSI7vD()
	{
		return nrDlbUbuO9IApxFwVUm == null;
	}

	internal static SecurityImportExtension VtnpJ8beMhuhKoAnKjJ()
	{
		return nrDlbUbuO9IApxFwVUm;
	}

	internal static void cbnqOqbHXnh8dXID7Vf()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
