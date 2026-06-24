using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Types;

[Component]
internal class SecurityPlatformTypeDescriptorProvider : PlatformTypeDescriptorProvider
{
	internal static SecurityPlatformTypeDescriptorProvider P1rLIHZMG95hWx9M2Y7;

	public override IEnumerable<ITypeDescriptor> GetTypeDescriptors()
	{
		return new ITypeDescriptor[1] { CreateEntityDescriptor<EleWise.ELMA.Security.Models.IUser>() };
	}

	public SecurityPlatformTypeDescriptorProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Y4nnTmZI0Shpk8XAPyu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void Y4nnTmZI0Shpk8XAPyu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool lLXqofZsIKbbaaVXWPJ()
	{
		return P1rLIHZMG95hWx9M2Y7 == null;
	}

	internal static SecurityPlatformTypeDescriptorProvider ivIgykZYuHWDCguol3T()
	{
		return P1rLIHZMG95hWx9M2Y7;
	}
}
