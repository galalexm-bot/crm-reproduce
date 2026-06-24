using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class WorkTimeWrapperDescriptor : ITypeWrapperDescriptor
{
	private static WorkTimeWrapperDescriptor QI7QSZboUAkxPA0AGXPq;

	public Type OriginalType => typeof(WorkTime);

	public Type WrapperType => yVuo1pbozm5sh3nqB7nk(typeof(WorkTimeWrapper).TypeHandle);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		//Discarded unreachable code: IL_009c, IL_00ab
		int num = 1;
		int num2 = num;
		WorkTime source = default(WorkTime);
		while (true)
		{
			switch (num2)
			{
			case 4:
				source = (WorkTime)obj;
				num2 = 3;
				break;
			case 2:
				return new WorkTimeWrapper(source);
			default:
				return null;
			case 3:
				if (source.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 1:
				if (!(obj is WorkTime))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public object GetObject(object wrapper)
	{
		//Discarded unreachable code: IL_0083
		int num = 3;
		int num2 = num;
		WorkTimeWrapper workTimeWrapper = default(WorkTimeWrapper);
		WorkTime workTime = default(WorkTime);
		while (true)
		{
			switch (num2)
			{
			case 3:
				workTimeWrapper = wrapper as WorkTimeWrapper;
				num2 = 2;
				break;
			case 4:
				return new WorkTime(rCROVQbbFv3bXmCq8lBh(workTimeWrapper));
			default:
				workTime = default(WorkTime);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return workTime;
			case 2:
				if (workTimeWrapper == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public WorkTimeWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type yVuo1pbozm5sh3nqB7nk(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool yUBiHobosgjXsupGQttp()
	{
		return QI7QSZboUAkxPA0AGXPq == null;
	}

	internal static WorkTimeWrapperDescriptor E9r0Nuboc11ev9x7Wr0j()
	{
		return QI7QSZboUAkxPA0AGXPq;
	}

	internal static long rCROVQbbFv3bXmCq8lBh(object P_0)
	{
		return ((WorkTimeWrapper)P_0).Value;
	}
}
