using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ServerInfoReference;

[GeneratedCode("System.Web.Services", "4.8.3761.0")]
public delegate void AdminHasEmptyPasswordCompletedEventHandler(object sender, AdminHasEmptyPasswordCompletedEventArgs e);
[GeneratedCode("System.Web.Services", "4.8.3761.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class AdminHasEmptyPasswordCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	internal static AdminHasEmptyPasswordCompletedEventArgs I850yIv08h2HZP5wHEw;

	public bool Result
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
					pFSwp9vJvQ6GqKcyqwn(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return (bool)results[0];
				}
			}
		}
	}

	internal AdminHasEmptyPasswordCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		FpVV2YvMI5Qyo9LdD5t();
		base._002Ector(exception, cancelled, userState);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
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
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
			{
				num = 1;
			}
		}
	}

	internal static void FpVV2YvMI5Qyo9LdD5t()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool u9kSqTvmvREohiVla35()
	{
		return I850yIv08h2HZP5wHEw == null;
	}

	internal static AdminHasEmptyPasswordCompletedEventArgs o0s4hVvyPITI94SUom0()
	{
		return I850yIv08h2HZP5wHEw;
	}

	internal static void pFSwp9vJvQ6GqKcyqwn(object P_0)
	{
		((AsyncCompletedEventArgs)P_0).RaiseExceptionIfNecessary();
	}
}
