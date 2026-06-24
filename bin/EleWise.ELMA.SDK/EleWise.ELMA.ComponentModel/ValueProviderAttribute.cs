using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class ValueProviderAttribute : Attribute
{
	internal static ValueProviderAttribute Il8ABjfffI5gEM0tGCvd;

	[NotNull]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ValueProviderAttribute(string name)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tMfP5dffvIaKbGuLAmmN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
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
				Name = name;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void tMfP5dffvIaKbGuLAmmN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool qgTOoOffQnj7vfhiUC7e()
	{
		return Il8ABjfffI5gEM0tGCvd == null;
	}

	internal static ValueProviderAttribute gwjdeSffCaKXgbeRT6Pb()
	{
		return Il8ABjfffI5gEM0tGCvd;
	}
}
