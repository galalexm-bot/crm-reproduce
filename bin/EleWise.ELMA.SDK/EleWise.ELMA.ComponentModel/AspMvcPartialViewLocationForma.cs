using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
{
	private static AspMvcPartialViewLocationFormatAttribute PZT9nsfQnuuXqVmAjICs;

	public string Format
	{
		[CompilerGenerated]
		get
		{
			return _003CFormat_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CFormat_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AspMvcPartialViewLocationFormatAttribute(string format)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Format = format;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool jMQjvNfQOXGgAB5BXCQO()
	{
		return PZT9nsfQnuuXqVmAjICs == null;
	}

	internal static AspMvcPartialViewLocationFormatAttribute bxYLUGfQ2xl51w2gkgI8()
	{
		return PZT9nsfQnuuXqVmAjICs;
	}
}
