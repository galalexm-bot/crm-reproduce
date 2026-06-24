using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class HtmlAttributeValueAttribute : Attribute
{
	internal static HtmlAttributeValueAttribute jTWbYJfCRO6FQRmYjwy7;

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
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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

	public HtmlAttributeValueAttribute([NotNull] string name)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sQo8QBfCXctHAJ9qCgty();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Name = name;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
			{
				num = 1;
			}
		}
	}

	internal static void sQo8QBfCXctHAJ9qCgty()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool q45oKmfCqhGMsC8MsePT()
	{
		return jTWbYJfCRO6FQRmYjwy7 == null;
	}

	internal static HtmlAttributeValueAttribute rM66JRfCKl7p1jjgiWL8()
	{
		return jTWbYJfCRO6FQRmYjwy7;
	}
}
