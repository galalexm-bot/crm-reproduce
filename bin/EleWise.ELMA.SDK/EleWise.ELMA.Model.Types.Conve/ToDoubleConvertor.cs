using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Convertors;

public class ToDoubleConvertor : TypeConvertor
{
	internal static ToDoubleConvertor lFAQLtojQTIk7S6Egole;

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

	public override List<Guid> TargetTypeUids => new List<Guid> { DoubleDescriptor.UID };

	public override object DoConvert(object obj)
	{
		//Discarded unreachable code: IL_0078, IL_00aa, IL_00c1, IL_00d0
		int num = 2;
		int num2 = num;
		double? num3 = default(double?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					num3 = (double?)xQaUdooj8fnoSa3Ar587(obj, TypeCode.Double);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto default;
			default:
				return num3;
			case 1:
				if (obj != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			}
		}
	}

	public ToDoubleConvertor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		J1kDXQojZYs8ZsAETf3v();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object xQaUdooj8fnoSa3Ar587(object P_0, TypeCode P_1)
	{
		return Convert.ChangeType(P_0, P_1);
	}

	internal static bool i9Qp0kojCxvlyMGnxf68()
	{
		return lFAQLtojQTIk7S6Egole == null;
	}

	internal static ToDoubleConvertor HbT0gPojvE25am1YV78w()
	{
		return lFAQLtojQTIk7S6Egole;
	}

	internal static void J1kDXQojZYs8ZsAETf3v()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
