using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 3000)]
public class DateTimeNullRelativeDateTimeConverter : IConvertTypeWrapper
{
	internal static DateTimeNullRelativeDateTimeConverter PHsImmbhTg1lDCtdrIxX;

	public Type OriginalType => Gc6ZScbhOMt9OwOLIjVS(typeof(DateTime?).TypeHandle);

	public Type ConvertType => Gc6ZScbhOMt9OwOLIjVS(typeof(RelativeDateTime).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				RelativeDateTime obj2 = new RelativeDateTime
				{
					DateTimeRange = new DateTimeRange
					{
						From = (DateTime)obj
					}
				};
				vXxMPWbh2ZSmZYdjs8VV(obj2, false);
				tR5oZebheBtcqtNIWLhZ(obj2, null);
				GRpacRbhPMqrF987c0Zt(obj2, null);
				return obj2;
			}
			case 1:
				if (!RelativeConvertNeeded(obj.GetType()))
				{
					return obj;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DateTimeNullRelativeDateTimeConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BOpsoSbh1g9Fiq7k3NWK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type Gc6ZScbhOMt9OwOLIjVS(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void vXxMPWbh2ZSmZYdjs8VV(object P_0, bool value)
	{
		((RelativeDateTime)P_0).IsRelative = value;
	}

	internal static void tR5oZebheBtcqtNIWLhZ(object P_0, object P_1)
	{
		((RelativeDateTime)P_0).RelativeFrom = (string)P_1;
	}

	internal static void GRpacRbhPMqrF987c0Zt(object P_0, object P_1)
	{
		((RelativeDateTime)P_0).RelativeTo = (string)P_1;
	}

	internal static bool zj1SydbhkDtL53B256c6()
	{
		return PHsImmbhTg1lDCtdrIxX == null;
	}

	internal static DateTimeNullRelativeDateTimeConverter hnMFvGbhnZUX7td5R3tk()
	{
		return PHsImmbhTg1lDCtdrIxX;
	}

	internal static void BOpsoSbh1g9Fiq7k3NWK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
