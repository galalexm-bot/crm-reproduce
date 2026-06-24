using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Remoting;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

internal class RemotingAssemblyResolverService : IRemotingAssemblyResolverService
{
	private ConfigurationServiceProvider configurationServiceProvider;

	private RemoteServiceProvider remoteServiceProvider;

	private BlockingCollection<KeyValuePair<string, bool>> unresolved;

	private bool resolving;

	private static RemotingAssemblyResolverService xMWCmeBxDXXA5CpjaINx;

	public RemotingAssemblyResolverService(ConfigurationServiceProvider configurationServiceProvider, RemoteServiceProvider remoteServiceProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kuyAqTBx4RMacyY1wwQD();
		unresolved = new BlockingCollection<KeyValuePair<string, bool>>();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				this.configurationServiceProvider = configurationServiceProvider;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.remoteServiceProvider = remoteServiceProvider;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public virtual byte[] ResolveAssembly(string assemblyName, bool isFullName)
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_0094, IL_00bf, IL_00ce, IL_016d, IL_01a5, IL_01d9, IL_0209, IL_0218, IL_0224, IL_0233
		int num = 9;
		bool lockTaken = default(bool);
		RemotingAssemblyResolverService obj = default(RemotingAssemblyResolverService);
		KeyValuePair<string, bool> keyValuePair = default(KeyValuePair<string, bool>);
		byte[] result = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					lockTaken = false;
					num2 = 5;
					break;
				case 5:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 5:
								resolving = true;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
								{
									num3 = 1;
								}
								break;
							default:
								if (!resolving)
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num3 = 2;
									}
									break;
								}
								goto case 3;
							case 3:
								result = null;
								num3 = 4;
								break;
							case 1:
								try
								{
									object obj2 = f8G1JWBxHqXYAMk0G0DE(configurationServiceProvider, assemblyName, isFullName);
									if (obj2 == null)
									{
										unresolved.Add(keyValuePair);
									}
									result = (byte[])obj2;
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num4 = 0;
									}
									return num4 switch
									{
										0 => result, 
										_ => result, 
									};
								}
								finally
								{
									resolving = false;
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
							case 4:
								return result;
							}
						}
					}
					finally
					{
						int num6;
						if (!lockTaken)
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num6 = 1;
							}
							goto IL_01dd;
						}
						goto IL_01f3;
						IL_01f3:
						Monitor.Exit(obj);
						num6 = 2;
						goto IL_01dd;
						IL_01dd:
						switch (num6)
						{
						case 1:
							goto end_IL_01b8;
						case 2:
							goto end_IL_01b8;
						}
						goto IL_01f3;
						end_IL_01b8:;
					}
				case 3:
					if (!DNF53sBx6WKryKcUiu66(remoteServiceProvider))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 2;
				case 6:
					if (!RemotingClientParameters.IsDebugging)
					{
						obj = this;
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto end_IL_0012;
				case 9:
					keyValuePair = new KeyValuePair<string, bool>(assemblyName, isFullName);
					num2 = 8;
					break;
				case 7:
					return null;
				default:
					if (!resolving)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 2;
				case 8:
					if (!unresolved.Contains(keyValuePair))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 7;
				case 1:
					return result;
				case 2:
					return null;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	internal static void kuyAqTBx4RMacyY1wwQD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool q0I7cyBxtZmLlP4qbd8r()
	{
		return xMWCmeBxDXXA5CpjaINx == null;
	}

	internal static RemotingAssemblyResolverService jeE4crBxwBkLkVgoOlvE()
	{
		return xMWCmeBxDXXA5CpjaINx;
	}

	internal static bool DNF53sBx6WKryKcUiu66(object P_0)
	{
		return ((RemoteServiceProvider)P_0).Reconnecting;
	}

	internal static object f8G1JWBxHqXYAMk0G0DE(object P_0, object P_1, bool isFullName)
	{
		return ((ConfigurationServiceProvider)P_0).ResolveAssembly((string)P_1, isFullName);
	}
}
