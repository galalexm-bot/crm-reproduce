using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

public class OnViewLoadScriptNameAttribute : Attribute
{
	private string _scriptName;

	private static OnViewLoadScriptNameAttribute qsPRh2oC0FRp8cWbZFVf;

	public string ScriptName
	{
		get
		{
			return _scriptName;
		}
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
					_scriptName = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public OnViewLoadScriptNameAttribute(string scriptName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NFoOLCoCMr4SwcZfCh1p();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
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
			_scriptName = scriptName;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
			{
				num = 0;
			}
		}
	}

	internal static void NFoOLCoCMr4SwcZfCh1p()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool foGhSjoCmZarhkGJ3Bgg()
	{
		return qsPRh2oC0FRp8cWbZFVf == null;
	}

	internal static OnViewLoadScriptNameAttribute pZ3dphoCy0kY6Yo42r4u()
	{
		return qsPRh2oC0FRp8cWbZFVf;
	}
}
