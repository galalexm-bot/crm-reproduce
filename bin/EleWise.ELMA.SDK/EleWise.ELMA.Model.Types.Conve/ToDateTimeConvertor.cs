using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Convertors;

public class ToDateTimeConvertor : TypeConvertor
{
	private static ToDateTimeConvertor QdfsROo5Uh126OhEUuDQ;

	public override List<Guid> SourceTypeUids => new List<Guid>
	{
		DateTimeDescriptor.UID,
		HtmlStringDescriptor.UID,
		TextDescriptor.UID,
		StringDescriptor.UID
	};

	public override List<Guid> TargetTypeUids => new List<Guid> { DateTimeDescriptor.UID };

	public override object DoConvert(object obj)
	{
		//Discarded unreachable code: IL_0080, IL_00b2, IL_00c9, IL_00d8
		int num = 1;
		int num2 = num;
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dateTime = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return dateTime;
			case 3:
				try
				{
					dateTime = (DateTime?)HejwOIo5zSYo0R8ngGpp(obj, TypeCode.DateTime);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			default:
				if (obj != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	public ToDateTimeConvertor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		l2m5bjojFgQjHIAKp3r2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object HejwOIo5zSYo0R8ngGpp(object P_0, TypeCode P_1)
	{
		return Convert.ChangeType(P_0, P_1);
	}

	internal static bool HTutxbo5sHobEoAMN4xA()
	{
		return QdfsROo5Uh126OhEUuDQ == null;
	}

	internal static ToDateTimeConvertor o1rRlEo5cAd2nb1QMgjb()
	{
		return QdfsROo5Uh126OhEUuDQ;
	}

	internal static void l2m5bjojFgQjHIAKp3r2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
