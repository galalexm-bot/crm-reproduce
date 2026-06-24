using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 3000)]
public class RelativeDateTimeDateTimeConverter : IConvertTypeWrapper
{
	private static RelativeDateTimeDateTimeConverter Yute93bhw7J2V5xfbC5j;

	public Type OriginalType => RrxVa2bhHYk8sQpX7kgs(typeof(RelativeDateTime).TypeHandle);

	public Type ConvertType => typeof(DateTime);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_0042, IL_0067, IL_0076
		int num = 3;
		DateTimeRange dateTimeRange = default(DateTimeRange);
		DateTime? from = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				DateTime dateTime;
				switch (num2)
				{
				case 6:
					dateTime = DateTime.MinValue;
					goto IL_00ef;
				case 3:
					if (!RelativeConvertNeeded(obj.GetType()))
					{
						num2 = 2;
						continue;
					}
					goto default;
				default:
					dateTimeRange = fQL8D6bhAhQnPFnDGAFr((RelativeDateTime)obj);
					num2 = 4;
					continue;
				case 4:
					break;
				case 5:
					if (from.HasValue)
					{
						from = dateTimeRange.From;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 6;
					}
					continue;
				case 1:
					dateTime = from.Value;
					goto IL_00ef;
				case 2:
					{
						return obj;
					}
					IL_00ef:
					return dateTime;
				}
				break;
			}
			from = dateTimeRange.From;
			num = 5;
		}
	}

	public RelativeDateTimeDateTimeConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type RrxVa2bhHYk8sQpX7kgs(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static DateTimeRange fQL8D6bhAhQnPFnDGAFr(object P_0)
	{
		return ((RelativeDateTime)P_0).DateTimeRange;
	}

	internal static bool VH1T50bh4yRlJRnirthQ()
	{
		return Yute93bhw7J2V5xfbC5j == null;
	}

	internal static RelativeDateTimeDateTimeConverter hPAyombh6sLO1W2Ol20O()
	{
		return Yute93bhw7J2V5xfbC5j;
	}
}
