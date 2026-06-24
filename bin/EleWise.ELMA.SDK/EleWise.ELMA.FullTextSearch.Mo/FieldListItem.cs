using System.Runtime.CompilerServices;
using EleWise.ELMA.FullTextSearch.Enum;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Model;

public class FieldListItem
{
	private static FieldListItem gb058tGRYCuLlJ9cKRO7;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
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

	public string Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
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

	public FilterListItemType ItemType
	{
		[CompilerGenerated]
		get
		{
			return _003CItemType_003Ek__BackingField;
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
					_003CItemType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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

	public FieldListItem(string field, string value)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lGBX47GRsKg0OCG8IXrE();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Field = field;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num = 0;
				}
				break;
			default:
				Value = value;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	public FieldListItem(string field, string value, FilterListItemType itemType)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(field, value);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			ItemType = itemType;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num = 1;
			}
		}
	}

	internal static void lGBX47GRsKg0OCG8IXrE()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rUavdCGRLlo0DMUZYaQu()
	{
		return gb058tGRYCuLlJ9cKRO7 == null;
	}

	internal static FieldListItem wVLg7jGRUQEErdUUXmQT()
	{
		return gb058tGRYCuLlJ9cKRO7;
	}
}
