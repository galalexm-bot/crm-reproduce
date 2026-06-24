using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 3000)]
public class DateTimeRelativeDateTimeConverter : IConvertTypeWrapper
{
	private static DateTimeRelativeDateTimeConverter VJxyHWbhuyUUhDVxlWd4;

	public Type OriginalType => typeof(DateTime);

	public Type ConvertType => hW60HVbhSpU8sw3tvVc9(typeof(RelativeDateTime).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_0097, IL_00a6
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!RelativeConvertNeeded(obj.GetType()))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
			{
				RelativeDateTime relativeDateTime = new RelativeDateTime();
				kgbDaGbhiW4xdsX1t7EO(relativeDateTime, new DateTimeRange
				{
					From = (DateTime)obj
				});
				mX42fmbhR2Aj7v8Vdlw0(relativeDateTime, false);
				yvJQ54bhqxtfb1sBoBy7(relativeDateTime, null);
				hmQkEbbhKh5cdg6v7f7w(relativeDateTime, null);
				return relativeDateTime;
			}
			default:
				return obj;
			}
		}
	}

	public DateTimeRelativeDateTimeConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Qhg6CVbhXJDamscMZjWU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type hW60HVbhSpU8sw3tvVc9(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void kgbDaGbhiW4xdsX1t7EO(object P_0, DateTimeRange value)
	{
		((RelativeDateTime)P_0).DateTimeRange = value;
	}

	internal static void mX42fmbhR2Aj7v8Vdlw0(object P_0, bool value)
	{
		((RelativeDateTime)P_0).IsRelative = value;
	}

	internal static void yvJQ54bhqxtfb1sBoBy7(object P_0, object P_1)
	{
		((RelativeDateTime)P_0).RelativeFrom = (string)P_1;
	}

	internal static void hmQkEbbhKh5cdg6v7f7w(object P_0, object P_1)
	{
		((RelativeDateTime)P_0).RelativeTo = (string)P_1;
	}

	internal static bool SVsGYwbhIVq5XdFhNqge()
	{
		return VJxyHWbhuyUUhDVxlWd4 == null;
	}

	internal static DateTimeRelativeDateTimeConverter jldYlRbhVvTJEqpOf8lb()
	{
		return VJxyHWbhuyUUhDVxlWd4;
	}

	internal static void Qhg6CVbhXJDamscMZjWU()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
