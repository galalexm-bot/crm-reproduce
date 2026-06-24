using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[DataContract]
public sealed class ItemRuntimeModel
{
	internal static ItemRuntimeModel Ro47Y9b33KnhUK8PTWRx;

	[DataMember]
	public Guid HeaderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderUid_003Ek__BackingField;
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
					_003CHeaderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Guid ItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CItemUid_003Ek__BackingField;
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
					_003CItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ItemRuntimeModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		J6I1Ryb3DLlSnOuQnHdm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DEit1Lb3pJO53QXx6Bjg()
	{
		return Ro47Y9b33KnhUK8PTWRx == null;
	}

	internal static ItemRuntimeModel G27P5Ub3aVQDMkseT41R()
	{
		return Ro47Y9b33KnhUK8PTWRx;
	}

	internal static void J6I1Ryb3DLlSnOuQnHdm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
