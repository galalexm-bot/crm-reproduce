using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ServerInfoReference;

[GeneratedCode("System.Web.Services", "4.8.3761.0")]
public delegate void GetStartInformationLocalizedCompletedEventHandler(object sender, GetStartInformationLocalizedCompletedEventArgs e);
[GeneratedCode("System.Web.Services", "4.8.3761.0")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class GetStartInformationLocalizedCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	internal static GetStartInformationLocalizedCompletedEventArgs toJv1rvtEJqaPQjjNrr;

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
					vmONbQv6XftA6Ewjobb(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal GetStartInformationLocalizedCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(exception, cancelled, userState);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool SyGO3Avw3fQYlUuyTkm()
	{
		return toJv1rvtEJqaPQjjNrr == null;
	}

	internal static GetStartInformationLocalizedCompletedEventArgs Ni8aRkv4mL7tk7hXBlS()
	{
		return toJv1rvtEJqaPQjjNrr;
	}

	internal static void vmONbQv6XftA6Ewjobb(object P_0)
	{
		((AsyncCompletedEventArgs)P_0).RaiseExceptionIfNecessary();
	}
}
