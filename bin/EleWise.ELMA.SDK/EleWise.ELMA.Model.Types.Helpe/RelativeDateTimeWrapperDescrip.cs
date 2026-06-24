using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 2000)]
public class RelativeDateTimeWrapperDescriptor : ITypeWrapperDescriptor
{
	internal static RelativeDateTimeWrapperDescriptor jxYRjEbb5POJBYifcjx0;

	public Type OriginalType => zUOB0ybbLy5eZLZnh8kA(typeof(RelativeDateTime).TypeHandle);

	public Type WrapperType => zUOB0ybbLy5eZLZnh8kA(typeof(RelativeDateTimeWrapper).TypeHandle);

	public bool TestType(Type type)
	{
		return false;
	}

	public object CreateWrapper(object obj)
	{
		return new RelativeDateTimeWrapper((RelativeDateTime)obj);
	}

	public object GetObject(object wrapper)
	{
		int num = 2;
		int num2 = num;
		DateTimeRangeWrapper dateTimeRangeWrapper = default(DateTimeRangeWrapper);
		DateTimeRange dateTimeRange = default(DateTimeRange);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (dateTimeRangeWrapper != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				}
				RelativeDateTime relativeDateTime = new RelativeDateTime();
				QuDYDPbbzjJejuZB6oI3(relativeDateTime, volvD3bbcHKcvrOFeIMG((RelativeDateTimeWrapper)wrapper));
				yP1HSZbhBwtYAq4w0RwF(relativeDateTime, (uBsH7EbhFQypJMJCI4aS((RelativeDateTimeWrapper)wrapper) != null) ? new DateTimeRange(((DateTimeWrapper)T8Tt5EbbUZxxpqj64orO(uBsH7EbhFQypJMJCI4aS((RelativeDateTimeWrapper)wrapper))).Value, ((DateTimeRangeWrapper)uBsH7EbhFQypJMJCI4aS((RelativeDateTimeWrapper)wrapper)).To.Value) : new DateTimeRange(null, null));
				relativeDateTime.RelativeFrom = (string)oOgVC6bhW93aW5Fbrqg1((RelativeDateTimeWrapper)wrapper);
				GX9TMEbhbcvYMrPQImTy(relativeDateTime, AJbJqEbhoarvo6KbeFLe((RelativeDateTimeWrapper)wrapper));
				return relativeDateTime;
			}
			case 3:
				dateTimeRange.To = ((DateTimeWrapper)HnfbqibbskIFx4AswUpm(dateTimeRangeWrapper)).Value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 4;
				}
				break;
			default:
				dateTimeRange = default(DateTimeRange);
				num2 = 5;
				break;
			case 5:
				dateTimeRange.From = ((DateTimeWrapper)T8Tt5EbbUZxxpqj64orO(dateTimeRangeWrapper)).Value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				dateTimeRangeWrapper = wrapper as DateTimeRangeWrapper;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return dateTimeRange;
			}
		}
	}

	public RelativeDateTimeWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VcgnGZbhh5kAZNnpfOlS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type zUOB0ybbLy5eZLZnh8kA(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool qJQTt4bbj5j1eVCcdSC3()
	{
		return jxYRjEbb5POJBYifcjx0 == null;
	}

	internal static RelativeDateTimeWrapperDescriptor y5tURqbbYkihaGIOVNiy()
	{
		return jxYRjEbb5POJBYifcjx0;
	}

	internal static object T8Tt5EbbUZxxpqj64orO(object P_0)
	{
		return ((DateTimeRangeWrapper)P_0).From;
	}

	internal static object HnfbqibbskIFx4AswUpm(object P_0)
	{
		return ((DateTimeRangeWrapper)P_0).To;
	}

	internal static bool volvD3bbcHKcvrOFeIMG(object P_0)
	{
		return ((RelativeDateTimeWrapper)P_0).IsRelative;
	}

	internal static void QuDYDPbbzjJejuZB6oI3(object P_0, bool value)
	{
		((RelativeDateTime)P_0).IsRelative = value;
	}

	internal static object uBsH7EbhFQypJMJCI4aS(object P_0)
	{
		return ((RelativeDateTimeWrapper)P_0).DateTimeRange;
	}

	internal static void yP1HSZbhBwtYAq4w0RwF(object P_0, DateTimeRange value)
	{
		((RelativeDateTime)P_0).DateTimeRange = value;
	}

	internal static object oOgVC6bhW93aW5Fbrqg1(object P_0)
	{
		return ((RelativeDateTimeWrapper)P_0).RelativeFrom;
	}

	internal static object AJbJqEbhoarvo6KbeFLe(object P_0)
	{
		return ((RelativeDateTimeWrapper)P_0).RelativeTo;
	}

	internal static void GX9TMEbhbcvYMrPQImTy(object P_0, object P_1)
	{
		((RelativeDateTime)P_0).RelativeTo = (string)P_1;
	}

	internal static void VcgnGZbhh5kAZNnpfOlS()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
