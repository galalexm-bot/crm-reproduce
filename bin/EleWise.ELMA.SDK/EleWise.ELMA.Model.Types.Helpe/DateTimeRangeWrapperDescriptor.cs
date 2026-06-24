using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class DateTimeRangeWrapperDescriptor : ITypeWrapperDescriptor
{
	internal static DateTimeRangeWrapperDescriptor yHSaxybfyT3ob0YMIDlu;

	public Type OriginalType => typeof(DateTimeRange);

	public Type WrapperType => IQ9Qcvbf96GahicXFqrE(typeof(DateTimeRangeWrapper).TypeHandle);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		//Discarded unreachable code: IL_0067, IL_00ec, IL_00fb
		int num = 3;
		int num2 = num;
		DateTimeRange source = default(DateTimeRange);
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				source = (DateTimeRange)obj;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 8;
				}
				break;
			case 7:
				dateTime = source.To;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
			case 5:
				return new DateTimeRangeWrapper(source);
			case 6:
				return null;
			case 8:
				dateTime = source.From;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (dateTime.HasValue)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 7;
			case 3:
				if (obj is DateTimeRange)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			default:
				if (!dateTime.HasValue)
				{
					num2 = 6;
					break;
				}
				goto case 4;
			}
		}
	}

	public object GetObject(object wrapper)
	{
		//Discarded unreachable code: IL_0074
		int num = 2;
		int num2 = num;
		DateTimeRangeWrapper dateTimeRangeWrapper = default(DateTimeRangeWrapper);
		DateTimeRange dateTimeRange = default(DateTimeRange);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (dateTimeRangeWrapper == null)
				{
					num2 = 7;
					break;
				}
				goto case 4;
			case 2:
				dateTimeRangeWrapper = wrapper as DateTimeRangeWrapper;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				dateTimeRange.To = dateTimeRangeWrapper.To.Value;
				num2 = 6;
				break;
			case 4:
				dateTimeRange = default(DateTimeRange);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				dateTimeRange.From = dateTimeRangeWrapper.From.Value;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 3;
				}
				break;
			default:
				return dateTimeRange;
			case 6:
				return dateTimeRange;
			case 7:
				dateTimeRange = default(DateTimeRange);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public DateTimeRangeWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FP2G9QbfdWdIrR8TP2wQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type IQ9Qcvbf96GahicXFqrE(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool LlG8rMbfMBABJGVVAC3H()
	{
		return yHSaxybfyT3ob0YMIDlu == null;
	}

	internal static DateTimeRangeWrapperDescriptor rLiLLSbfJygS9Okqw2Md()
	{
		return yHSaxybfyT3ob0YMIDlu;
	}

	internal static void FP2G9QbfdWdIrR8TP2wQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
