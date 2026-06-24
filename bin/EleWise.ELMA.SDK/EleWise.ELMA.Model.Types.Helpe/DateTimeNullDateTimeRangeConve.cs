using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class DateTimeNullDateTimeRangeConvertTypeWrapper : IConvertTypeWrapper
{
	private static DateTimeNullDateTimeRangeConvertTypeWrapper Pvt10CbQoiivTNioeppo;

	public Type OriginalType => AeUncebQGCJTBy4GhvvH(typeof(DateTime?).TypeHandle);

	public Type ConvertType => AeUncebQGCJTBy4GhvvH(typeof(DateTimeRange).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 4;
		int num2 = num;
		DateTimeRange dateTimeRange = default(DateTimeRange);
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				dateTimeRange = default(DateTimeRange);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return dateTimeRange;
			default:
				dateTimeRange.From = dateTime;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				dateTimeRange.To = dateTime;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				dateTime = (DateTime?)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public DateTimeNullDateTimeRangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type AeUncebQGCJTBy4GhvvH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool MTUqfEbQbDKwVCT53Pgu()
	{
		return Pvt10CbQoiivTNioeppo == null;
	}

	internal static DateTimeNullDateTimeRangeConvertTypeWrapper JgOyAFbQhflimYRreDBw()
	{
		return Pvt10CbQoiivTNioeppo;
	}
}
