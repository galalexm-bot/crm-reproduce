using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class Int64RangeLongNullConvertTypeWrapper : IConvertTypeWrapper
{
	internal static Int64RangeLongNullConvertTypeWrapper aDGG7qbG09qVr8cca8kx;

	public Type OriginalType => typeof(Int64Range);

	public Type ConvertType => FhDqPpbGMdZYFdS3Ar9L(typeof(long?).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		Int64Range int64Range = default(Int64Range);
		while (true)
		{
			switch (num2)
			{
			case 1:
				int64Range = (Int64Range)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return int64Range.From;
			}
		}
	}

	public Int64RangeLongNullConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VCoiYObGJJ1cxEihZshb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type FhDqPpbGMdZYFdS3Ar9L(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool VeEWxWbGmUOm05FLNN0U()
	{
		return aDGG7qbG09qVr8cca8kx == null;
	}

	internal static Int64RangeLongNullConvertTypeWrapper OaZNGObGyV5bjpmXtv5S()
	{
		return aDGG7qbG09qVr8cca8kx;
	}

	internal static void VCoiYObGJJ1cxEihZshb()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
