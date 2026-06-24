using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ServerInfoReference;

[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "4.8.3761.0")]
[DebuggerStepThrough]
public class GetRemotingPortCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	private static GetRemotingPortCompletedEventArgs h7bVEEvHYKx1pSd2oru;

	public int Result
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
					LikLESvxBmSda2hvLp5(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return (int)results[0];
				}
			}
		}
	}

	internal GetRemotingPortCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(exception, cancelled, userState);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
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
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
			{
				num = 0;
			}
		}
	}

	internal static bool WFR2m2vA0WwDqSrB0Cc()
	{
		return h7bVEEvHYKx1pSd2oru == null;
	}

	internal static GetRemotingPortCompletedEventArgs khqZ1jv7t7B9YjUaLLY()
	{
		return h7bVEEvHYKx1pSd2oru;
	}

	internal static void LikLESvxBmSda2hvLp5(object P_0)
	{
		((AsyncCompletedEventArgs)P_0).RaiseExceptionIfNecessary();
	}
}
