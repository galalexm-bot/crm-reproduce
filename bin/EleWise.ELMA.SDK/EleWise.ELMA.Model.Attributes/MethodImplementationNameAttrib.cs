using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class MethodImplementationNameAttribute : Attribute
{
	private static MethodImplementationNameAttribute nHHhnNoQSUKQMWpd0Tpm;

	public string MethodName
	{
		[CompilerGenerated]
		get
		{
			return _003CMethodName_003Ek__BackingField;
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
					_003CMethodName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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

	public MethodImplementationNameAttribute(string methodName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ExWmj9oQqaxapPrDdOxh();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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
				MethodName = methodName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void ExWmj9oQqaxapPrDdOxh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool pB978goQiRWTsIxeROni()
	{
		return nHHhnNoQSUKQMWpd0Tpm == null;
	}

	internal static MethodImplementationNameAttribute oi22PVoQR1qhYDjrg7uy()
	{
		return nHHhnNoQSUKQMWpd0Tpm;
	}
}
