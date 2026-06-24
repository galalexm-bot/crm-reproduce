using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.API.Models;

[Serializable]
[DataContract(Name = "SubordinateUsers")]
public class SubordinateUsersResponse
{
	internal static SubordinateUsersResponse waYPf63j2fJRq3B3FuH;

	[DataMember]
	public long[] Ids
	{
		[CompilerGenerated]
		get
		{
			return _003CIds_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CIds_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public SubordinateUsersResponse()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool iZwSC33HTUl15InJw4g()
	{
		return waYPf63j2fJRq3B3FuH == null;
	}

	internal static SubordinateUsersResponse pjbOZN3ayGwk9v4d5Cj()
	{
		return waYPf63j2fJRq3B3FuH;
	}
}
