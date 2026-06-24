using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 3000)]
public class RelativeDateTimeDateTimeNullConverter : IConvertTypeWrapper
{
	internal static RelativeDateTimeDateTimeNullConverter JoqV5ubh7MgXOdMqvrW7;

	public Type OriginalType => glQgtVbhmgs9LiIrBCDF(typeof(RelativeDateTime).TypeHandle);

	public Type ConvertType => glQgtVbhmgs9LiIrBCDF(typeof(DateTime?).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		DateTimeRange dateTimeRange = default(DateTimeRange);
		while (true)
		{
			switch (num2)
			{
			default:
				dateTimeRange = QKPJBRbhywTx91aNbr8w((RelativeDateTime)obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (RelativeConvertNeeded(obj.GetType()))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return obj;
			case 2:
				return dateTimeRange.From;
			}
		}
	}

	public RelativeDateTimeDateTimeNullConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gFPqINbhMYFQ09PZkNJs();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type glQgtVbhmgs9LiIrBCDF(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static DateTimeRange QKPJBRbhywTx91aNbr8w(object P_0)
	{
		return ((RelativeDateTime)P_0).DateTimeRange;
	}

	internal static bool k2lxFebhxuP2CBSFWUS4()
	{
		return JoqV5ubh7MgXOdMqvrW7 == null;
	}

	internal static RelativeDateTimeDateTimeNullConverter UpNV4jbh0F5H7qQGfiYN()
	{
		return JoqV5ubh7MgXOdMqvrW7;
	}

	internal static void gFPqINbhMYFQ09PZkNJs()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
