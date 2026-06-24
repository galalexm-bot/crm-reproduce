using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Build.Framework;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Projects;

public class BuildLogger : ILogger
{
	private IEventSource eventSource;

	private string parameters;

	private LoggerVerbosity verbosity;

	private List<string> errors;

	private static BuildLogger YFO9QaW5nefeJQlKnYxH;

	public string Parameters
	{
		get
		{
			return parameters;
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
					parameters = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LoggerVerbosity Verbosity
	{
		get
		{
			return verbosity;
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
					verbosity = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Errors => string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12447F9A), errors);

	public void Initialize(IEventSource eventSource)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				rUUo0yW5ecLfbZQTl7NU(eventSource, new BuildErrorEventHandler(eventSource_ErrorRaised));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				this.eventSource = eventSource;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void eventSource_ErrorRaised(object sender, BuildErrorEventArgs e)
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
				errors.Add((string)ouHBaMW5Pv4UVhBZvWYH(e));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Shutdown()
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
				FLAuaJW51F9YYNcwcn0N(eventSource, new BuildErrorEventHandler(eventSource_ErrorRaised));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public BuildLogger()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		errors = new List<string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void rUUo0yW5ecLfbZQTl7NU(object P_0, object P_1)
	{
		((IEventSource)P_0).ErrorRaised += (BuildErrorEventHandler)P_1;
	}

	internal static bool vNSREYW5OLnnGMnkeKd7()
	{
		return YFO9QaW5nefeJQlKnYxH == null;
	}

	internal static BuildLogger BshBMJW52OH4gGADrM0u()
	{
		return YFO9QaW5nefeJQlKnYxH;
	}

	internal static object ouHBaMW5Pv4UVhBZvWYH(object P_0)
	{
		return ((BuildEventArgs)P_0).Message;
	}

	internal static void FLAuaJW51F9YYNcwcn0N(object P_0, object P_1)
	{
		((IEventSource)P_0).ErrorRaised -= (BuildErrorEventHandler)P_1;
	}
}
