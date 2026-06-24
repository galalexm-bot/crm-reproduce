using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

[Service]
public class ScriptExecutionService
{
	private readonly IContextBoundVariableService contextBoundVariableService;

	private static readonly ILogger ScriptLog;

	private static ScriptExecutionService XEx9Q6bSag1G0QHV7d51;

	public bool Turned
	{
		get
		{
			bool value;
			return contextBoundVariableService.TryGetValue<bool>((string)flsuHSbS4bLk3OpnyXU4(0x7EC153F ^ 0x7EEA87B), out value) && value;
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
				case 1:
					RtI3mobS6UP9Zvr20A6d(contextBoundVariableService, flsuHSbS4bLk3OpnyXU4(-643786247 ^ -643685187), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
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

	public ScriptExecutionService(IContextBoundVariableService contextBoundVariableService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		e76harbSwVCo7HSZfxL3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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
			this.contextBoundVariableService = contextBoundVariableService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
			{
				num = 1;
			}
		}
	}

	public static void ScriptExecution(Action action, string errorTitle)
	{
		//Discarded unreachable code: IL_0052, IL_0085, IL_0101, IL_0114
		int num = 1;
		int num2 = num;
		ScriptExecutionService serviceNotNull = default(ScriptExecutionService);
		bool turned = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					action();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							throw;
						}
						CK2Ss5bSxZrM8FBD7CNU(ScriptLog, OYjlZ1bS7Q5WCe5CZ5Em(errorTitle, dCAQUPbSA9a3PqI40GhJ(ex) ?? ex), ex);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num4 = 0;
						}
					}
				}
				finally
				{
					kfIGBcbSH30qupgW46mf(serviceNotNull, turned);
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 3:
				return;
			case 1:
				serviceNotNull = Locator.GetServiceNotNull<ScriptExecutionService>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				kfIGBcbSH30qupgW46mf(serviceNotNull, true);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				turned = serviceNotNull.Turned;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public static void MethodNotFound(Type type, string scriptName)
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
				ws3sPxbS0uOqlfgjYjW8(ScriptLog, SR.T((string)flsuHSbS4bLk3OpnyXU4(-583745292 ^ -583632758), type, scriptName));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static ScriptExecutionService()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				e76harbSwVCo7HSZfxL3();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				ScriptLog = (ILogger)CvFZTmbSmmR8steSt9hS(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A55EF8));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void e76harbSwVCo7HSZfxL3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool EyAOJxbSDLnwxYee5MxR()
	{
		return XEx9Q6bSag1G0QHV7d51 == null;
	}

	internal static ScriptExecutionService SUfsO5bStj0rgoeGhOH9()
	{
		return XEx9Q6bSag1G0QHV7d51;
	}

	internal static object flsuHSbS4bLk3OpnyXU4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void RtI3mobS6UP9Zvr20A6d(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}

	internal static void kfIGBcbSH30qupgW46mf(object P_0, bool value)
	{
		((ScriptExecutionService)P_0).Turned = value;
	}

	internal static object dCAQUPbSA9a3PqI40GhJ(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}

	internal static object OYjlZ1bS7Q5WCe5CZ5Em(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void CK2Ss5bSxZrM8FBD7CNU(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void ws3sPxbS0uOqlfgjYjW8(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object CvFZTmbSmmR8steSt9hS(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
