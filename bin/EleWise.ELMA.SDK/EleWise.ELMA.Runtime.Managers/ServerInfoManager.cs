using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Managers;

public class ServerInfoManager : DTOManager, IServerInfoManager, IConfigurationService
{
	private static ServerInfoManager bG76jKWJ17Ms0O5hMMJh;

	public virtual AssemblyHashInfo[] GetBinaryHashInfos()
	{
		//Discarded unreachable code: IL_00fc, IL_010b, IL_011b, IL_012a, IL_01ab, IL_0288, IL_0297, IL_037c, IL_039e, IL_04b5, IL_04c4
		int num = 4;
		List<AssemblyHashInfo> list = default(List<AssemblyHashInfo>);
		AssemblyHashInfo assemblyHashInfo = default(AssemblyHashInfo);
		int num3 = default(int);
		string text4 = default(string);
		int num4 = default(int);
		string[] assemblyPaths = default(string[]);
		string text2 = default(string);
		string[] array = default(string[]);
		string text3 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (w0vlTKWJpEXnLLaL85ci())
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 23;
				case 30:
					list.Add(assemblyHashInfo);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
				case 17:
				case 28:
					num3++;
					num2 = 29;
					continue;
				case 16:
					if (v6vQhQWJwyC4ZCaR0i2e(fFJoStWJtWMrrG1E7B6T(text4), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099615815), StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 6;
				case 12:
				case 34:
					if (num4 < assemblyPaths.Length)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 31;
				case 5:
					text2 = array[num3];
					num2 = 18;
					continue;
				default:
					text4 = assemblyPaths[num4];
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 11;
					}
					continue;
				case 23:
					return new AssemblyHashInfo[0];
				case 6:
					array = (string[])VIHn6uWJ6SeWEvKc7tom(text4, sF9ldNWJ4c45PUgeKGNn(-889460160 ^ -889540986));
					num2 = 36;
					continue;
				case 21:
				case 32:
					text3 = (string)NTWUGnWJ7EMZpiZ9fBx7(text2, sF9ldNWJ4c45PUgeKGNn(0x4EDCBA32 ^ 0x4EDC347C));
					num2 = 7;
					continue;
				case 25:
					assemblyPaths = GetAssemblyPaths();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 3;
					}
					continue;
				case 26:
					list.Add(assemblyHashInfo);
					num2 = 8;
					continue;
				case 15:
				case 35:
					num4++;
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 28;
					}
					continue;
				case 7:
					if (!T6C3VhWJ0lukG0DQVv4y(text3))
					{
						num2 = 17;
						continue;
					}
					goto case 22;
				case 33:
					list.Add(assemblyHashInfo);
					num = 32;
					break;
				case 11:
					if (mq4JOXWJDR94hpJmxeHX(text4))
					{
						num2 = 16;
						continue;
					}
					goto case 15;
				case 24:
					kHYGb5WJxhYd2XPZcsjk(assemblyHashInfo, text);
					num2 = 33;
					continue;
				case 22:
				{
					AssemblyHashInfo assemblyHashInfo3 = new AssemblyHashInfo();
					FxkZsRWJA5OiJ89b2T6V(assemblyHashInfo3, fFJoStWJtWMrrG1E7B6T(text3));
					assemblyHashInfo = assemblyHashInfo3;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 13;
					}
					continue;
				}
				case 19:
				{
					AssemblyHashInfo assemblyHashInfo2 = new AssemblyHashInfo();
					FxkZsRWJA5OiJ89b2T6V(assemblyHashInfo2, fFJoStWJtWMrrG1E7B6T(text2));
					assemblyHashInfo = assemblyHashInfo2;
					num2 = 14;
					continue;
				}
				case 14:
					assemblyHashInfo.EvaluteMD5(text2);
					num2 = 30;
					continue;
				case 13:
					kHYGb5WJxhYd2XPZcsjk(assemblyHashInfo, text3);
					num2 = 26;
					continue;
				case 9:
					num4 = 0;
					num2 = 12;
					continue;
				case 1:
					text = (string)NTWUGnWJ7EMZpiZ9fBx7(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108097306));
					num2 = 27;
					continue;
				case 3:
					if (((ComponentManager)xE6lTuWJaQOWGbR6rBJ1()).AssemblyPaths != null)
					{
						list = new List<AssemblyHashInfo>();
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 5;
						}
					}
					else
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 23;
						}
					}
					continue;
				case 18:
					if (!OC1R0CWJHAUqtKo8K1hj(text2))
					{
						num2 = 28;
						continue;
					}
					goto case 19;
				case 31:
					return (AssemblyHashInfo[])NEm5ZqWJm9kU78ascSwl(list);
				case 20:
					assemblyHashInfo = new AssemblyHashInfo
					{
						AssemblyName = Path.GetFileName(text)
					};
					num = 24;
					break;
				case 36:
					num3 = 0;
					num2 = 2;
					continue;
				case 27:
					if (!File.Exists(text))
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 20;
				case 2:
				case 29:
					if (num3 >= array.Length)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 5;
				}
				break;
			}
		}
	}

	public virtual byte[] GetAssemblyRaw(string assemblyName)
	{
		//Discarded unreachable code: IL_010f, IL_011e, IL_012d, IL_013d, IL_014c, IL_015c, IL_016b, IL_01f9
		int num = 6;
		string text2 = default(string);
		string[] assemblyPaths = default(string[]);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (!w0vlTKWJpEXnLLaL85ci())
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 7;
				case 3:
				case 10:
					text2 = assemblyPaths[num3];
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 8;
					}
					break;
				case 5:
				case 12:
					return null;
				case 14:
					assemblyPaths = GetAssemblyPaths();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					return (byte[])jsZj7rWJJdXphkY10gMg(text);
				case 13:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					if (rcxOXMWJyEoKKFGf18cV(xE6lTuWJaQOWGbR6rBJ1()) != null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 8:
					if (mq4JOXWJDR94hpJmxeHX(text2))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 15;
						}
						break;
					}
					goto case 13;
				case 15:
					text = (string)DfsA4HWJML3NWLYiDEcy(text2, assemblyName);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 9;
					}
					break;
				default:
					if (num3 < assemblyPaths.Length)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 2:
					return null;
				case 4:
					num3 = 0;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 6;
					}
					break;
				case 9:
					if (!T6C3VhWJ0lukG0DQVv4y(text))
					{
						num2 = 13;
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 14;
		}
	}

	public virtual string GetMainProviderType()
	{
		//Discarded unreachable code: IL_0057
		int num = 1;
		int num2 = num;
		RuntimeApplication runtimeApplication;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (((ComponentManager)xE6lTuWJaQOWGbR6rBJ1()).Stage != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				runtimeApplication = ((ComponentManager)xE6lTuWJaQOWGbR6rBJ1()).GetComponentsForRegister<RuntimeApplication>().FirstOrDefault();
				break;
			default:
				runtimeApplication = Locator.GetServiceNotNull<RuntimeApplication>();
				break;
			}
			break;
		}
		if (runtimeApplication == null)
		{
			throw new InvalidOperationException((string)sF9ldNWJ4c45PUgeKGNn(0x53FA00CE ^ 0x53FA73CA));
		}
		return (string)QPNOg6WJd2rP4dCBxDPn((geCs29WJ9YcRN0RQgq7o(runtimeApplication) ?? throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87349429))).GetType());
	}

	public virtual string GetEdition()
	{
		return (string)dYR5ZLWJl0YSFpXAnnjU();
	}

	public virtual ModuleStatusInfo[] GetModuleStatuses()
	{
		int num = 1;
		int num2 = num;
		List<ModuleStatusInfo> list = default(List<ModuleStatusInfo>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (ModuleStatusInfo[])GGpU5CWJg4XMZhTuicQY(list);
			default:
				AddModuleStatuses(((IModuleManager)vT8CotWJrZ8S9ylWXrvX(xE6lTuWJaQOWGbR6rBJ1())).MainApplication, list);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				list = new List<ModuleStatusInfo>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static bool IsAssembly(object fileName)
	{
		//Discarded unreachable code: IL_0046, IL_0078, IL_00b0, IL_00bf
		switch (1)
		{
		case 1:
			try
			{
				AssemblyName.GetAssemblyName((string)fileName);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			catch
			{
				int num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 1;
				}
				bool result = default(bool);
				while (true)
				{
					switch (num2)
					{
					case 1:
						result = false;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 0;
						}
						break;
					default:
						return result;
					case 0:
						return result;
					}
				}
			}
			break;
		}
		return true;
	}

	private string[] GetAssemblyPaths()
	{
		string[] assemblyPaths = ((ComponentManager)xE6lTuWJaQOWGbR6rBJ1()).AssemblyPaths;
		string text = (string)DfsA4HWJML3NWLYiDEcy(YgWm64WJ5uPl8fcaKjRG(xE6lTuWJaQOWGbR6rBJ1()), sF9ldNWJ4c45PUgeKGNn(0x6A81B9B4 ^ 0x6A80E9DC));
		return assemblyPaths.Union(new string[1] { text }).ToArray();
	}

	private void AddModuleStatuses(IModule module, List<ModuleStatusInfo> result)
	{
		if (module != null)
		{
			result.Add(new ModuleStatusInfo
			{
				Uid = module.Uid,
				Status = module.Status
			});
		}
		foreach (IModule extensionModule in module.ExtensionModules)
		{
			AddModuleStatuses(extensionModule, result);
		}
		if (!(module is IApplication application))
		{
			return;
		}
		foreach (IModule systemModule in application.SystemModules)
		{
			AddModuleStatuses(systemModule, result);
		}
	}

	public ServerInfoManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VWVf4OWJjfROEWtZXYX2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool w0vlTKWJpEXnLLaL85ci()
	{
		return ComponentManager.Initialized;
	}

	internal static object xE6lTuWJaQOWGbR6rBJ1()
	{
		return ComponentManager.Current;
	}

	internal static bool mq4JOXWJDR94hpJmxeHX(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object fFJoStWJtWMrrG1E7B6T(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static bool v6vQhQWJwyC4ZCaR0i2e(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object sF9ldNWJ4c45PUgeKGNn(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VIHn6uWJ6SeWEvKc7tom(object P_0, object P_1)
	{
		return Directory.GetFiles((string)P_0, (string)P_1);
	}

	internal static bool OC1R0CWJHAUqtKo8K1hj(object P_0)
	{
		return IsAssembly(P_0);
	}

	internal static void FxkZsRWJA5OiJ89b2T6V(object P_0, object P_1)
	{
		((AssemblyHashInfo)P_0).AssemblyName = (string)P_1;
	}

	internal static object NTWUGnWJ7EMZpiZ9fBx7(object P_0, object P_1)
	{
		return Path.ChangeExtension((string)P_0, (string)P_1);
	}

	internal static void kHYGb5WJxhYd2XPZcsjk(object P_0, object P_1)
	{
		((AssemblyHashInfo)P_0).EvaluteMD5((string)P_1);
	}

	internal static bool T6C3VhWJ0lukG0DQVv4y(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object NEm5ZqWJm9kU78ascSwl(object P_0)
	{
		return ((List<AssemblyHashInfo>)P_0).ToArray();
	}

	internal static bool i6oJ9QWJNp8jWbgfvMth()
	{
		return bG76jKWJ17Ms0O5hMMJh == null;
	}

	internal static ServerInfoManager yoP2TqWJ3jUsI7WGEcYl()
	{
		return bG76jKWJ17Ms0O5hMMJh;
	}

	internal static object rcxOXMWJyEoKKFGf18cV(object P_0)
	{
		return ((ComponentManager)P_0).AssemblyPaths;
	}

	internal static object DfsA4HWJML3NWLYiDEcy(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object jsZj7rWJJdXphkY10gMg(object P_0)
	{
		return File.ReadAllBytes((string)P_0);
	}

	internal static object geCs29WJ9YcRN0RQgq7o(object P_0)
	{
		return ((RuntimeApplication)P_0).MainProvider;
	}

	internal static object QPNOg6WJd2rP4dCBxDPn(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object dYR5ZLWJl0YSFpXAnnjU()
	{
		return VersionInfo.GetEdition();
	}

	internal static object vT8CotWJrZ8S9ylWXrvX(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object GGpU5CWJg4XMZhTuicQY(object P_0)
	{
		return ((List<ModuleStatusInfo>)P_0).ToArray();
	}

	internal static object YgWm64WJ5uPl8fcaKjRG(object P_0)
	{
		return ((ComponentManager)P_0).WorkDirectory;
	}

	internal static void VWVf4OWJjfROEWtZXYX2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
