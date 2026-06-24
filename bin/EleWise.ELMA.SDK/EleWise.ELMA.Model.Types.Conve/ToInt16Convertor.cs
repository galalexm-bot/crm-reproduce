using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Convertors;

public class ToInt16Convertor : TypeConvertor
{
	internal static ToInt16Convertor upDgABojKj6cfM7gjBI4;

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

	public override List<Guid> TargetTypeUids => new List<Guid> { Int16Descriptor.UID };

	public override object DoConvert(object obj)
	{
		//Discarded unreachable code: IL_005d, IL_008f, IL_00a6
		int num = 2;
		int num2 = num;
		short? num3 = default(short?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return num3;
			default:
				try
				{
					num3 = (short?)kug88OojkhJrDgoPgJ51(obj, TypeCode.Int16);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				num3 = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ToInt16Convertor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		G5JYwSojnhehCRsVrJ7p();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object kug88OojkhJrDgoPgJ51(object P_0, TypeCode P_1)
	{
		return Convert.ChangeType(P_0, P_1);
	}

	internal static bool lcwdsyojXV3c77IRggtx()
	{
		return upDgABojKj6cfM7gjBI4 == null;
	}

	internal static ToInt16Convertor DogpQFojT37mv4C8xxtC()
	{
		return upDgABojKj6cfM7gjBI4;
	}

	internal static void G5JYwSojnhehCRsVrJ7p()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
