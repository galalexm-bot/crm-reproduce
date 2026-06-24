using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public sealed class AspMvcControllerAttribute : Attribute
{
	private static AspMvcControllerAttribute wWVXhrfQ6oPth15KisXm;

	public string AnonymousProperty
	{
		[CompilerGenerated]
		get
		{
			return _003CAnonymousProperty_003Ek__BackingField;
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
					_003CAnonymousProperty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AspMvcControllerAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DGsLUQfQ7mcgNNcGljci();
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

	public AspMvcControllerAttribute(string anonymousProperty)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DGsLUQfQ7mcgNNcGljci();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
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
				AnonymousProperty = anonymousProperty;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void DGsLUQfQ7mcgNNcGljci()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool TGvswtfQHY4qrZ4ibNwj()
	{
		return wWVXhrfQ6oPth15KisXm == null;
	}

	internal static AspMvcControllerAttribute OLpsMCfQAdjums6n5wrh()
	{
		return wWVXhrfQ6oPth15KisXm;
	}
}
