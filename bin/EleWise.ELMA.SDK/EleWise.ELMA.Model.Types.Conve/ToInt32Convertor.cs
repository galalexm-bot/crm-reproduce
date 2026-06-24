using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Convertors;

public class ToInt32Convertor : TypeConvertor
{
	internal static ToInt32Convertor cP6AqBojS1sr89uw5LXs;

	public override List<Guid> SourceTypeUids => new List<Guid>
	{
		Int16Descriptor.UID,
		Int32Descriptor.UID,
		Int64Descriptor.UID,
		BoolDescriptor.UID,
		EnumDescriptor.UID,
		DoubleDescriptor.UID,
		HtmlStringDescriptor.UID,
		TextDescriptor.UID,
		StringDescriptor.UID
	};

	public override List<Guid> TargetTypeUids => new List<Guid> { Int32Descriptor.UID };

	public override object DoConvert(object obj)
	{
		//Discarded unreachable code: IL_0080, IL_00b2, IL_00c9, IL_00d8
		int num = 3;
		int num2 = num;
		int? num3 = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return num3;
			case 3:
				num3 = 0;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 1;
				}
				break;
			default:
				try
				{
					num3 = (int?)Convert.ChangeType(obj, TypeCode.Int32);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				catch (Exception)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 2:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public ToInt32Convertor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SUNWDYojq1kg1kpJwGDe();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool u1juFJojiSY759ND6ObU()
	{
		return cP6AqBojS1sr89uw5LXs == null;
	}

	internal static ToInt32Convertor NCE3etojRyluFPP4W70N()
	{
		return cP6AqBojS1sr89uw5LXs;
	}

	internal static void SUNWDYojq1kg1kpJwGDe()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
