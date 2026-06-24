using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

[Component(Order = 50)]
public class UserGroupEntityUserTypeSelector : BaseEntityUserTypeSelector
{
	public const string PREFIX = "UserGroup";

	internal static UserGroupEntityUserTypeSelector M7dh5Bz7Ai8piRlgJkP;

	public override Type EntityType => InterfaceActivator.TypeOf<IUserGroup>();

	public override string Prefix => (string)MsrdyQzNs5bZa598ifc(0xCDF201B ^ 0xCDF5D03);

	public override string DisplayName => (string)qH89EHzZiO2HViQ0s5O(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74C28149 ^ 0x74C392B5));

	public override List<EleWise.ELMA.Security.Models.IUser> ExtractUsers(string value)
	{
		long objectId = BaseEntityUserTypeSelector.GetObjectId(GetFullPrefix(), value);
		return (from u in UserGroupManager.Instance.GetUsersByGroup(objectId)
			select ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)_003C_003Ec.riEmCUpoVb3xBVA1Ls0n()).Load(u)).ToList();
	}

	public UserGroupEntityUserTypeSelector()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SVjMn3zxggBLoyoWZLq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object MsrdyQzNs5bZa598ifc(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool VQDoaAz62teUPtZJeLh()
	{
		return M7dh5Bz7Ai8piRlgJkP == null;
	}

	internal static UserGroupEntityUserTypeSelector Ne7KiazlkaYbH4xPjrZ()
	{
		return M7dh5Bz7Ai8piRlgJkP;
	}

	internal static object qH89EHzZiO2HViQ0s5O(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void SVjMn3zxggBLoyoWZLq()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
