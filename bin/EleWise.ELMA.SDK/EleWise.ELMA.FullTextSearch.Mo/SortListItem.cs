using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.FullTextSearch.Enum;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Model;

public class SortListItem
{
	internal static SortListItem jV4yk7GRuSSZQh3b1M92;

	public string Field
	{
		[CompilerGenerated]
		get
		{
			return _003CField_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CField_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
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

	public ListSortDirection Direction
	{
		[CompilerGenerated]
		get
		{
			return _003CDirection_003Ek__BackingField;
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
					_003CDirection_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FullTextFieldType Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
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

	public SortListItem(string field, FullTextFieldType type)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		pTgdWMGRS6ME1DOBFbQ2();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				Type = type;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				Field = field;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public SortListItem(string field, FullTextFieldType type, ListSortDirection direction)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pTgdWMGRS6ME1DOBFbQ2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				Type = type;
				num = 2;
				break;
			case 2:
				return;
			case 1:
				Direction = direction;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num = 3;
				}
				break;
			default:
				Field = field;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void pTgdWMGRS6ME1DOBFbQ2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool wiNttVGRIggm25neq4oQ()
	{
		return jV4yk7GRuSSZQh3b1M92 == null;
	}

	internal static SortListItem ifYBacGRVtu8n6d4sdNB()
	{
		return jV4yk7GRuSSZQh3b1M92;
	}
}
