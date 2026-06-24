using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts;

[Serializable]
public class ScriptCompileResult
{
	internal static ScriptCompileResult YDlfokbq8mb2hExrtACA;

	public bool Success
	{
		[CompilerGenerated]
		get
		{
			return _003CSuccess_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CSuccess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<ScriptCompileMessage> Messages { get; set; }

	public ScriptCompileResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Av4XkCbqItH7JS468lSB();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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
				Messages = new List<ScriptCompileMessage>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void Av4XkCbqItH7JS468lSB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool B6VaVAbqZAvP7pIsyeoM()
	{
		return YDlfokbq8mb2hExrtACA == null;
	}

	internal static ScriptCompileResult pjpJsjbqujvALsUMIAgV()
	{
		return YDlfokbq8mb2hExrtACA;
	}
}
