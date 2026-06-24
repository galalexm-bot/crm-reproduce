using System;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.DTO.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Types;

internal class EntityTypePublicApplicationProvider : TypePublicApplicationProvider
{
	private static EntityTypePublicApplicationProvider mDGKqOZn3pMX1tristT;

	public override bool? IsPublicApplicationDisplayEnabled(Guid typeUid, Guid subTypeUid)
	{
		if (!(subTypeUid == UserDTO.UID))
		{
			return null;
		}
		return true;
	}

	public override bool? IsPublicApplicationEditorEnabled(Guid typeUid, Guid subTypeUid)
	{
		if (!(subTypeUid == UserDTO.UID))
		{
			return null;
		}
		return true;
	}

	public EntityTypePublicApplicationProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool n7ipxAZilMBqIR4ZQEY()
	{
		return mDGKqOZn3pMX1tristT == null;
	}

	internal static EntityTypePublicApplicationProvider akOp8KZ7IWrK9LVb0H0()
	{
		return mDGKqOZn3pMX1tristT;
	}
}
