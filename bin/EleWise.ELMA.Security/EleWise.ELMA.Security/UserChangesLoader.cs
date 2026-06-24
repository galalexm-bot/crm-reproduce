using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

[Component]
public class UserChangesLoader : EntityChangesLoader
{
	private static UserChangesLoader yxhYbLNPE1oAF0oKbE4;

	public override bool IsTypeSupported(Guid typeUid)
	{
		int num = 1;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				classMetadata = TN2lKkNUKx2vlMKBqGM(typeUid, true, true) as ClassMetadata;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (InterfaceActivator.LoadMetadata<EleWise.ELMA.Security.Models.IUser>() != classMetadata)
				{
					num2 = 3;
					continue;
				}
				return true;
			case 3:
				return mDv0RmNo8OVinOnSI8s(InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(), classMetadata, true);
			}
			if (classMetadata == null)
			{
				return false;
			}
			num2 = 2;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
			{
				num2 = 2;
			}
		}
	}

	public UserChangesLoader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object TN2lKkNUKx2vlMKBqGM(Guid P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static bool mDv0RmNo8OVinOnSI8s(Guid P_0, object P_1, bool P_2)
	{
		return MetadataLoader.IsBaseClass(P_0, (ClassMetadata)P_1, P_2);
	}

	internal static bool Gd0FyqNvXTvj04NLxwN()
	{
		return yxhYbLNPE1oAF0oKbE4 == null;
	}

	internal static UserChangesLoader U6yp2sNCmBuGb2c0oTc()
	{
		return yxhYbLNPE1oAF0oKbE4;
	}
}
