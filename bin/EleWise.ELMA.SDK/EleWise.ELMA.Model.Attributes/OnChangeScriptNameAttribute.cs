using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

public class OnChangeScriptNameAttribute : Attribute
{
	private string _scriptName;

	private static OnChangeScriptNameAttribute u3H9fuoCYQqGck5D4I4C;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public OnChangeScriptNameAttribute(string scriptName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
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
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
			{
				num = 1;
			}
		}
	}

	internal static bool vGyEDHoCLlgk9JHymPpN()
	{
		return u3H9fuoCYQqGck5D4I4C == null;
	}

	internal static OnChangeScriptNameAttribute bZQbjhoCUKy9NidcPf6V()
	{
		return u3H9fuoCYQqGck5D4I4C;
	}
}
