using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types;

public abstract class CLRTypeDescriptor<T> : SimpleTypeDescriptor<T>, IRuntimeTypeDescriptor
{
	internal static object slAJh3oJDY6KMD29jbAd;

	public virtual Type RuntimeType => typeof(T);

	public virtual bool IsRuntimeType => true;

	protected object GetRuntimeTypeDefaultValue()
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 3:
				if (!RuntimeType.IsNullableType())
				{
					return Activator.CreateInstance(RuntimeType);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!RuntimeType.IsValueType)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	protected CLRTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool K79Op1oJtmEUAhcAX7Cx()
	{
		return slAJh3oJDY6KMD29jbAd == null;
	}

	internal static object ULMV2XoJw6wnflYExURZ()
	{
		return slAJh3oJDY6KMD29jbAd;
	}
}
public abstract class CLRTypeDescriptor<T, SettingsT> : CLRTypeDescriptor<T>
{
	internal static object EsndKSoJ4nmSckbecBTt;

	public override Type SettingsType => typeof(SettingsT);

	protected CLRTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool pqb9HfoJ6cVSOfcSpe7g()
	{
		return EsndKSoJ4nmSckbecBTt == null;
	}

	internal static object aKJsheoJHshJHpyeQuhb()
	{
		return EsndKSoJ4nmSckbecBTt;
	}
}
