using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.FullTextSearch.Enum;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Model;

public class FilterListItem
{
	private List<object> values;

	internal static FilterListItem I7ALiPGRBB7Hyc4H46Vr;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
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

	public List<string> Values => (from s in values
		where s != null
		select s.ToString()).Distinct().ToList();

	public object[] Array => values.ToArray();

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
				case 0:
					return;
				case 1:
					_003CItemType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
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

	public FilterListItem(string field, List<object> values, FilterListItemType itemType, FullTextFieldType type)
	{
		SingletonReader.JJCZtPuTvSt();
		this.values = new List<object>();
		base._002Ector();
		Field = field;
		this.values = values;
		ItemType = itemType;
		Type = type;
	}

	internal static bool aWI98FGRW324GrSU5q6L()
	{
		return I7ALiPGRBB7Hyc4H46Vr == null;
	}

	internal static FilterListItem KROqIJGRoNgbE6VdD2vs()
	{
		return I7ALiPGRBB7Hyc4H46Vr;
	}
}
