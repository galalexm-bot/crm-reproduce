using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate)]
public sealed class StringFormatMethodAttribute : Attribute
{
	private static StringFormatMethodAttribute bf85oSffbLPyYCS6VGHW;

	public string FormatParameterName
	{
		[CompilerGenerated]
		get
		{
			return _003CFormatParameterName_003Ek__BackingField;
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
				case 1:
					_003CFormatParameterName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
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

	public StringFormatMethodAttribute(string formatParameterName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		p00Ak6ffEk5DKfGRFFLO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				FormatParameterName = formatParameterName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void p00Ak6ffEk5DKfGRFFLO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QWWif2ffh9tUtkVnQmdx()
	{
		return bf85oSffbLPyYCS6VGHW == null;
	}

	internal static StringFormatMethodAttribute eo9ZfqffG3AJ9ta5HUu7()
	{
		return bf85oSffbLPyYCS6VGHW;
	}
}
