using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 3000)]
public class RelativeDateTimeConverter : IConvertTypeWrapper
{
	internal static RelativeDateTimeConverter sDiHZJbhGM73NNxqlypD;

	public Type OriginalType => BY7gIHbhQpjhjDuLqo1X(typeof(DateTimeRange).TypeHandle);

	public Type ConvertType => typeof(RelativeDateTime);

	public bool RelativeConvertNeeded(Type type)
	{
		return type.IsAssignableFrom(BY7gIHbhQpjhjDuLqo1X(typeof(DateTimeRange).TypeHandle));
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_00b1, IL_00c0
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				RelativeDateTime relativeDateTime = new RelativeDateTime();
				uvhAnXbhCLnBffOxkZa3(relativeDateTime, new DateTimeRange
				{
					From = ((DateTimeRange)obj).From,
					To = ((DateTimeRange)obj).To
				});
				S1cdVsbhvVvuF2UUrDcV(relativeDateTime, false);
				IcArkibh8Phgli3RXbKt(relativeDateTime, null);
				relativeDateTime.RelativeTo = null;
				return relativeDateTime;
			}
			default:
				return obj;
			case 1:
				if (!RelativeConvertNeeded(obj.GetType()))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public RelativeDateTimeConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BWQWZsbhZEp0YjfaGn1L();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type BY7gIHbhQpjhjDuLqo1X(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool JNv3lEbhEc9FuRZ0Fs5K()
	{
		return sDiHZJbhGM73NNxqlypD == null;
	}

	internal static RelativeDateTimeConverter KmOpAXbhfVSof7d5PkV2()
	{
		return sDiHZJbhGM73NNxqlypD;
	}

	internal static void uvhAnXbhCLnBffOxkZa3(object P_0, DateTimeRange value)
	{
		((RelativeDateTime)P_0).DateTimeRange = value;
	}

	internal static void S1cdVsbhvVvuF2UUrDcV(object P_0, bool value)
	{
		((RelativeDateTime)P_0).IsRelative = value;
	}

	internal static void IcArkibh8Phgli3RXbKt(object P_0, object P_1)
	{
		((RelativeDateTime)P_0).RelativeFrom = (string)P_1;
	}

	internal static void BWQWZsbhZEp0YjfaGn1L()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
