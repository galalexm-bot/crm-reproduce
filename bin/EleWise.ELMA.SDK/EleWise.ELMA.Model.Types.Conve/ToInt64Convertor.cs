using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Convertors;

public class ToInt64Convertor : TypeConvertor
{
	internal static ToInt64Convertor ywoTesoju66IZKJh18AL;

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

	public override List<Guid> TargetTypeUids => new List<Guid> { Int64Descriptor.UID };

	public override object DoConvert(object obj)
	{
		//Discarded unreachable code: IL_0076, IL_00a8, IL_00bf, IL_00ce
		int num = 1;
		int num2 = num;
		long? num3 = default(long?);
		while (true)
		{
			switch (num2)
			{
			default:
				if (obj != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 3:
				try
				{
					num3 = (long?)Convert.ChangeType(obj, TypeCode.Int64);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				break;
			case 1:
				num3 = 0L;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			}
			break;
		}
		return num3;
	}

	public ToInt64Convertor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SxxAIiojI7g8uXYjDVnd()
	{
		return ywoTesoju66IZKJh18AL == null;
	}

	internal static ToInt64Convertor QS9uIHojVTZ0Ve2X2l5S()
	{
		return ywoTesoju66IZKJh18AL;
	}
}
