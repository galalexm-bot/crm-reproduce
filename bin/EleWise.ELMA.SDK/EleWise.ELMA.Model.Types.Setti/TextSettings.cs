using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class TextSettings : StringSettings
{
	private static TextSettings W5l6qwozxZo9doTl7uCg;

	[DefaultValue(true)]
	[JsonSerializationIgnore]
	public override bool MultiLine
	{
		[CompilerGenerated]
		get
		{
			return _003CMultiLine_003Ek__BackingField;
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
					_003CMultiLine_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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

	public TextSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		t7q3wfozyxI004XXUlhx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected TextSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		t7q3wfozyxI004XXUlhx();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void t7q3wfozyxI004XXUlhx()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FEhHnfoz0DYf3pX5Wbw6()
	{
		return W5l6qwozxZo9doTl7uCg == null;
	}

	internal static TextSettings DJF1SgozmBXEKBNIYV3D()
	{
		return W5l6qwozxZo9doTl7uCg;
	}
}
