using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.TranslateData;

[Serializable]
public class ScriptDesignerSettings
{
	private static ScriptDesignerSettings G9LoZI8jio7hMmDkj4S;

	public bool DontShowAgain
	{
		[CompilerGenerated]
		get
		{
			return _003CDontShowAgain_003Ek__BackingField;
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
					_003CDontShowAgain_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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

	public ScriptDesignerSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YLqSCv8Uh5Jnu3iCkKx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool AP38258Y8xXNLx7TsbW()
	{
		return G9LoZI8jio7hMmDkj4S == null;
	}

	internal static ScriptDesignerSettings QupCEx8LX2sMKJ6P0Gj()
	{
		return G9LoZI8jio7hMmDkj4S;
	}

	internal static void YLqSCv8Uh5Jnu3iCkKx()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
