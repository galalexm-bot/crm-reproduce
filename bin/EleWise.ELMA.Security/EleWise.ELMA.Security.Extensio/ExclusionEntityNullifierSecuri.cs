using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Extensions;

[Component]
internal class ExclusionEntityNullifierSecurity : IExclusionEntityNullifier
{
	private static ExclusionEntityNullifierSecurity pm5Cvb8ZlsKh0GryGdq;

	public List<Guid> SetExclusion()
	{
		return new List<Guid>
		{
			InterfaceActivator.UID<IUserPublicKeyToken>(),
			InterfaceActivator.UID<IUserGroup>(),
			InterfaceActivator.UID<IOrganizationItem>(),
			InterfaceActivator.UID<IPersonalGroup>(),
			InterfaceActivator.UID<IUserCertificate>(),
			InterfaceActivator.UID<IOrganizationModel>(),
			InterfaceActivator.UID<IUser>(),
			InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(),
			InterfaceActivator.UID<IAssignedRoleStereotype>()
		};
	}

	public ExclusionEntityNullifierSecurity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bpQiSa8uq5BnroIDjDW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void bpQiSa8uq5BnroIDjDW()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool ekGxos8xDcsWJDD4HXy()
	{
		return pm5Cvb8ZlsKh0GryGdq == null;
	}

	internal static ExclusionEntityNullifierSecurity OBpYc48BdLTArRI8NiZ()
	{
		return pm5Cvb8ZlsKh0GryGdq;
	}
}
