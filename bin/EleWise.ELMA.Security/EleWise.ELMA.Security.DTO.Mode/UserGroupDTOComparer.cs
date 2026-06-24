using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.DTO.Models;

public class UserGroupDTOComparer : IEqualityComparer<UserGroupDTO>
{
	internal static UserGroupDTOComparer I9v6oduDldWRuxysl00;

	public bool Equals(UserGroupDTO x, UserGroupDTO y)
	{
		int num = 3;
		int num2 = num;
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (x == y)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
					{
						num2 = 2;
					}
					break;
				}
				if (x != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
				if (y == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					guid = nEB2wmuYPCKjgCVlmif(x);
					num2 = 4;
				}
				break;
			case 4:
				return guid.Equals(nEB2wmuYPCKjgCVlmif(y));
			default:
				return false;
			case 2:
				return true;
			}
		}
	}

	public int GetHashCode(UserGroupDTO obj)
	{
		int num = 1;
		int num2 = num;
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				return guid.GetHashCode();
			case 1:
				guid = nEB2wmuYPCKjgCVlmif(obj);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public UserGroupDTOComparer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid nEB2wmuYPCKjgCVlmif(object P_0)
	{
		return ((UserGroupDTO)P_0).Uid;
	}

	internal static bool Hb9b4HuM5GfPi4X8geK()
	{
		return I9v6oduDldWRuxysl00 == null;
	}

	internal static UserGroupDTOComparer mfSoltuskD1Dj1Z8nfk()
	{
		return I9v6oduDldWRuxysl00;
	}
}
