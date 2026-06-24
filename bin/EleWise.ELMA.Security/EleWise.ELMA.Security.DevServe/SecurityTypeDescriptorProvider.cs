using System;
using System.Collections.Generic;
using EleWise.ELMA.DevServer.TypeDescriptors;
using EleWise.ELMA.Security.Types;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.DevServer;

internal sealed class SecurityTypeDescriptorProvider : ITypeDescriptorProvider
{
	private static SecurityTypeDescriptorProvider j2YG8s3vT3uCibjBmBl;

	public IEnumerable<Type> GetTypeDescriptors()
	{
		return new Type[4]
		{
			typeof(EntityUserDescriptor),
			typeof(OrganizationDiagramTypeDescriptor),
			typeof(OrganizationSubDiagramTypeDescriptor),
			typeof(OrganizationItemDescriptor)
		};
	}

	public SecurityTypeDescriptorProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nfSrDK3oS0CPtlxjC4B();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void nfSrDK3oS0CPtlxjC4B()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool eRKN0j3CN7lunH3bWxe()
	{
		return j2YG8s3vT3uCibjBmBl == null;
	}

	internal static SecurityTypeDescriptorProvider gA1e883Uve90Z3Rc3Lj()
	{
		return j2YG8s3vT3uCibjBmBl;
	}
}
