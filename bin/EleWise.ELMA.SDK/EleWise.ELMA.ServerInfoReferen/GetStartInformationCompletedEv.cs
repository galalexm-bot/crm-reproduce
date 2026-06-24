using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ServerInfoReference;

[GeneratedCode("System.Web.Services", "4.8.3761.0")]
public delegate void GetStartInformationCompletedEventHandler(object sender, GetStartInformationCompletedEventArgs e);
[GeneratedCode("System.Web.Services", "4.8.3761.0")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class GetStartInformationCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	internal static GetStartInformationCompletedEventArgs BjcQTAv3wmRWbl5hLdo;

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
				default:
					return (StartInformation)results[0];
				case 1:
					arXQPwvDfU867FQ33Om(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal GetStartInformationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(exception, cancelled, userState);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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
				this.results = results;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool v0mFXXvpXuBeDwL5naI()
	{
		return BjcQTAv3wmRWbl5hLdo == null;
	}

	internal static GetStartInformationCompletedEventArgs RlhkG2vaXiiAjuypr5E()
	{
		return BjcQTAv3wmRWbl5hLdo;
	}

	internal static void arXQPwvDfU867FQ33Om(object P_0)
	{
		((AsyncCompletedEventArgs)P_0).RaiseExceptionIfNecessary();
	}
}
