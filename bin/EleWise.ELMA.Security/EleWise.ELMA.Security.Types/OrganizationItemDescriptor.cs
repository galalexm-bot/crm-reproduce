using System;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Types;

public class OrganizationItemDescriptor : EntitySubTypeDescriptor<IOrganizationItem>
{
	internal static OrganizationItemDescriptor L460YcZ6DOKdOl0oNar;

	public override Type SettingsType => QJnbGIZZdQHOKfNMlae(typeof(OrganizationItemSettings).TypeHandle);

	protected override Guid EntityUid => InterfaceActivator.UID<IOrganizationItem>();

	public OrganizationItemDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type QJnbGIZZdQHOKfNMlae(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool JjVqWnZlZuama6R9viw()
	{
		return L460YcZ6DOKdOl0oNar == null;
	}

	internal static OrganizationItemDescriptor lu4j8qZNnPEEFbdHfkK()
	{
		return L460YcZ6DOKdOl0oNar;
	}
}
