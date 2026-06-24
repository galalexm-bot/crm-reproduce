using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Scripts.DTO.Manager;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class GlobalModulesReferenceService : IGlobalModulesReferenceService
{
	private readonly IGlobalScriptModuleHeaderDtoManager globalScriptModuleHeaderDtoManager;

	private static GlobalModulesReferenceService FvhTUDBawfURfiVbJFo1;

	public GlobalModulesReferenceService(IGlobalScriptModuleHeaderDtoManager globalScriptModuleHeaderDtoManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cpyPvWBaHNoxLYaA2MqK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.globalScriptModuleHeaderDtoManager = globalScriptModuleHeaderDtoManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num = 0;
				}
				break;
			default:
				ClearGlobalModuleAssemblyFolder();
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	public string CreateGlobalModuleAssembly(Guid globalModuleHeaderUid)
	{
		//Discarded unreachable code: IL_0097, IL_00c7, IL_00d6
		int num = 2;
		int num2 = num;
		string globalModuleAssemblyPath = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				globalModuleAssemblyPath = GetGlobalModuleAssemblyPath(globalModuleHeaderUid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 1;
				}
				continue;
			default:
				return null;
			case 7:
				return globalModuleAssemblyPath;
			case 3:
				array = (byte[])aEARWYBa7MdZNUHFcjww(globalScriptModuleHeaderDtoManager, globalModuleHeaderUid);
				num2 = 4;
				continue;
			case 1:
				if (!CYS72eBaA884CZVuMYVv(globalModuleAssemblyPath))
				{
					num2 = 3;
					continue;
				}
				goto case 7;
			case 4:
				if (array == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 5:
				break;
			}
			twg3f5BaxH5xfe5Qls2r(globalModuleAssemblyPath, array);
			num2 = 7;
		}
	}

	public string GetGlobalModuleAssemblyPath(Guid globalModuleHeaderUid)
	{
		//Discarded unreachable code: IL_00ad, IL_00bc
		int num = 4;
		int num2 = num;
		GlobalScriptModuleHeaderDto globalScriptModuleHeaderDto = default(GlobalScriptModuleHeaderDto);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 2:
				return (string)JQ5JUwBaJPciiu4J2eBY(Am471RBamg41qMNmCB2h(), nrFm7HBaMK8ijKjF7vC1(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571FE707), globalScriptModuleHeaderDto.Uid, globalScriptModuleHeaderDto.PublishedId, HnAlj6BayFKfCvtCEM3D(-70037984 ^ -70120806)));
			default:
				if (globalScriptModuleHeaderDto.PublishedId > 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 3:
				if (globalScriptModuleHeaderDto != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				globalScriptModuleHeaderDto = (GlobalScriptModuleHeaderDto)AEDDFNBa0KvcNt7H3eEk(globalScriptModuleHeaderDtoManager, globalModuleHeaderUid);
				num2 = 3;
				break;
			}
		}
	}

	private void ClearGlobalModuleAssemblyFolder()
	{
		//Discarded unreachable code: IL_0036, IL_0040, IL_0080, IL_00b2, IL_010c, IL_011b, IL_0185, IL_01a4, IL_01d0, IL_01fd, IL_020c
		int num = 3;
		int num2 = num;
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (AiMExRBa9X2Bsmm7NZ8C(Am471RBamg41qMNmCB2h()))
				{
					num2 = 2;
					continue;
				}
				return;
			case 4:
				return;
			case 1:
				return;
			case 2:
				enumerator = Directory.EnumerateFiles((string)Am471RBamg41qMNmCB2h(), (string)HnAlj6BayFKfCvtCEM3D(-2106517564 ^ -2106567934), SearchOption.TopDirectoryOnly).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!z87gpoBaddS99NXonrjd(enumerator))
					{
						num3 = 3;
						goto IL_0044;
					}
					goto IL_0126;
					IL_0044:
					switch (num3)
					{
					default:
						try
						{
							File.Delete(current);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						catch
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									Logger.Log.WarnFormat((string)HnAlj6BayFKfCvtCEM3D(-1876063057 ^ -1876113285), current);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						continue;
					case 2:
						break;
					case 1:
						continue;
					case 3:
						return;
					}
					goto IL_0126;
					IL_0126:
					current = enumerator.Current;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num3 = 0;
					}
					goto IL_0044;
				}
			}
			finally
			{
				int num6;
				if (enumerator == null)
				{
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num6 = 0;
					}
					goto IL_0189;
				}
				goto IL_01ae;
				IL_01ae:
				pnG0F0BalkK7mm85QPoY(enumerator);
				num6 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num6 = 1;
				}
				goto IL_0189;
				IL_0189:
				switch (num6)
				{
				default:
					goto end_IL_0164;
				case 0:
					goto end_IL_0164;
				case 2:
					break;
				case 1:
					goto end_IL_0164;
				}
				goto IL_01ae;
				end_IL_0164:;
			}
		}
	}

	internal static void cpyPvWBaHNoxLYaA2MqK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool cMDsf5Ba4m7fK3INs5BA()
	{
		return FvhTUDBawfURfiVbJFo1 == null;
	}

	internal static GlobalModulesReferenceService IF4pvgBa6MfqtaGH7icl()
	{
		return FvhTUDBawfURfiVbJFo1;
	}

	internal static bool CYS72eBaA884CZVuMYVv(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object aEARWYBa7MdZNUHFcjww(object P_0, Guid headerUid)
	{
		return ((IGlobalScriptModuleHeaderDtoManager)P_0).GetAssemblyRaw(headerUid);
	}

	internal static void twg3f5BaxH5xfe5Qls2r(object P_0, object P_1)
	{
		File.WriteAllBytes((string)P_0, (byte[])P_1);
	}

	internal static object AEDDFNBa0KvcNt7H3eEk(object P_0, Guid uid)
	{
		return ((IGlobalScriptModuleHeaderDtoManager)P_0).LoadOrNull(uid);
	}

	internal static object Am471RBamg41qMNmCB2h()
	{
		return AssemblyReferenceHelper.ExternalAssemblyLocation;
	}

	internal static object HnAlj6BayFKfCvtCEM3D(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object nrFm7HBaMK8ijKjF7vC1(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object JQ5JUwBaJPciiu4J2eBY(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool AiMExRBa9X2Bsmm7NZ8C(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static bool z87gpoBaddS99NXonrjd(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void pnG0F0BalkK7mm85QPoY(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
