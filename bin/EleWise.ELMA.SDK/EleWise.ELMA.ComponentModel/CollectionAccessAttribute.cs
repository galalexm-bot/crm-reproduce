using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Method)]
public sealed class CollectionAccessAttribute : Attribute
{
	internal static CollectionAccessAttribute KobbdBfC2GgBVieuMpyM;

	public CollectionAccessType CollectionAccessType
	{
		[CompilerGenerated]
		get
		{
			return _003CCollectionAccessType_003Ek__BackingField;
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
					_003CCollectionAccessType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
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

	public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bT9JJcfC1MJioJsOrhTP();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				CollectionAccessType = collectionAccessType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void bT9JJcfC1MJioJsOrhTP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xRkmWYfCe6wecOFF1sTj()
	{
		return KobbdBfC2GgBVieuMpyM == null;
	}

	internal static CollectionAccessAttribute Vl4XXZfCP4rXEfRXIc0x()
	{
		return KobbdBfC2GgBVieuMpyM;
	}
}
