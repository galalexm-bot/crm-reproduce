using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Common;

[Serializable]
[DataContract]
public class FetchOptionsSortDescriptor
{
	private static FetchOptionsSortDescriptor kpOU6uhku7mbVdZcQqNk;

	[DataMember]
	public string SortExpression
	{
		[CompilerGenerated]
		get
		{
			return _003CSortExpression_003Ek__BackingField;
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
					_003CSortExpression_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
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

	[DataMember]
	public ListSortDirection SortDirection
	{
		[CompilerGenerated]
		get
		{
			return _003CSortDirection_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CSortDirection_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FetchOptionsSortDescriptor(string sortExpression, ListSortDirection sortDirection)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Rr5gkJhkSELZJX8blCdQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				SortDirection = sortDirection;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				SortExpression = sortExpression;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void Rr5gkJhkSELZJX8blCdQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool IU5MYIhkIgMVsugjqH57()
	{
		return kpOU6uhku7mbVdZcQqNk == null;
	}

	internal static FetchOptionsSortDescriptor SPJYI3hkVBdV3aLQEa58()
	{
		return kpOU6uhku7mbVdZcQqNk;
	}
}
