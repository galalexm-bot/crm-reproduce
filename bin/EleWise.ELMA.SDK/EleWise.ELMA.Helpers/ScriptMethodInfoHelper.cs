using System;
using System.Web.Script.Serialization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class ScriptMethodInfoHelper
{
	internal static ScriptMethodInfoHelper Yrw9uyhj2ESEoTGTfLsd;

	public static string Serialize(ScriptMethodInfo methodInfo)
	{
		//Discarded unreachable code: IL_00b7
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (methodInfo == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				if (TenUDkhjNtFdiOmV4aXT(dy9e5rhj1nxF4GZbTwYt(methodInfo)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					if (!WwRWeNhj3Hhc6t1rZ0kS(methodInfo.MetadataUid, Guid.Empty))
					{
						return (string)PRlnKLhjpuPTVoso5T8Q(new JsonSerializer(), methodInfo);
					}
					num2 = 3;
				}
				break;
			default:
				return string.Empty;
			case 3:
				return methodInfo.Name;
			}
		}
	}

	public static ScriptMethodInfo Deserialize(string methodName)
	{
		//Discarded unreachable code: IL_0054, IL_0099, IL_00a8, IL_00d9, IL_00e8, IL_0114, IL_0155
		int num = 2;
		int num2 = num;
		ScriptMethodInfo result = default(ScriptMethodInfo);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return new ScriptMethodInfo
				{
					Name = methodName
				};
			default:
				try
				{
					ScriptMethodInfo scriptMethodInfo = new JsonSerializer().Deserialize<ScriptMethodInfo>(methodName);
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						default:
							return result;
						case 0:
							return result;
						case 4:
							result = scriptMethodInfo;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							if (scriptMethodInfo == null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 4;
						case 1:
							break;
						case 3:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							CR45j4hjDxpZIDoj4Zcv(Logger.Log, ex);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				goto case 3;
			case 1:
				if (YmsAoZhjacqekLBr7RXs(methodName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4DFA0F)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				if (!TenUDkhjNtFdiOmV4aXT(methodName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	internal static object dy9e5rhj1nxF4GZbTwYt(object P_0)
	{
		return ((ScriptMethodInfo)P_0).Name;
	}

	internal static bool TenUDkhjNtFdiOmV4aXT(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool WwRWeNhj3Hhc6t1rZ0kS(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object PRlnKLhjpuPTVoso5T8Q(object P_0, object P_1)
	{
		return ((JavaScriptSerializer)P_0).Serialize(P_1);
	}

	internal static bool sq0POAhjej43CUCfthJI()
	{
		return Yrw9uyhj2ESEoTGTfLsd == null;
	}

	internal static ScriptMethodInfoHelper mpAXlrhjPHlBtMT1tFJF()
	{
		return Yrw9uyhj2ESEoTGTfLsd;
	}

	internal static bool YmsAoZhjacqekLBr7RXs(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static void CR45j4hjDxpZIDoj4Zcv(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}
}
