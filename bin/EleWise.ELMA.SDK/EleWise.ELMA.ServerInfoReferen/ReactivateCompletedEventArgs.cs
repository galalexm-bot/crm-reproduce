using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ServerInfoReference;

[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "4.8.3761.0")]
public class ReactivateCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	internal static ReactivateCompletedEventArgs hkALIyv9ZgCiREOFZnf;

	public StartInformation Result
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					MthEe2vrJ1Z0Zv8JSAK(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return (StartInformation)results[0];
				}
			}
		}
	}

	internal ReactivateCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(exception, cancelled, userState);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
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
			this.results = results;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool y29f1svdjO05DENus6n()
	{
		return hkALIyv9ZgCiREOFZnf == null;
	}

	internal static ReactivateCompletedEventArgs EoDCmXvllSeKbH97A8t()
	{
		return hkALIyv9ZgCiREOFZnf;
	}

	internal static void MthEe2vrJ1Z0Zv8JSAK(object P_0)
	{
		((AsyncCompletedEventArgs)P_0).RaiseExceptionIfNecessary();
	}
}
