using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies;

[Serializable]
public sealed class FunctionDependency : Dependency
{
	private static FunctionDependency JmCJmjhRX8YdpHw3SDoG;

	public TypeSignature ReturnType
	{
		[CompilerGenerated]
		get
		{
			return _003CReturnType_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CReturnType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public TypeSignature ParameterType
	{
		[CompilerGenerated]
		get
		{
			return _003CParameterType_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CParameterType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FunctionDependency()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool muWbwyhRTyn3gXblrdwi()
	{
		return JmCJmjhRX8YdpHw3SDoG == null;
	}

	internal static FunctionDependency z22k1yhRkw1im7T2STgW()
	{
		return JmCJmjhRX8YdpHw3SDoG;
	}
}
