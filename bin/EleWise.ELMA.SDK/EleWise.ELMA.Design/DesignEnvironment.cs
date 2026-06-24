using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.Components;
using EleWise.ELMA.Packaging.Components.Web;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Design;

public static class DesignEnvironment
{
	private static object lockObject;

	private static object syncObj;

	private static bool initialized;

	private static bool libsLoaded;

	private static string workDir;

	private static string libsDir;

	private static string importCommandDir;

	private static DesignEnvironment OWHqxsqsjLisbXR3tMQ;

	public static string WorkDir
	{
		get
		{
			w2tJuyKF95UwMQw0UrW();
			return workDir;
		}
	}

	public static string ImportCommandDir
	{
		get
		{
			w2tJuyKF95UwMQw0UrW();
			return importCommandDir;
		}
	}

	public static string SettingsDir
	{
		get
		{
			w2tJuyKF95UwMQw0UrW();
			return (string)KQduuXKBZBP82Fdb83x();
		}
	}

	public static string LibsDir => (string)rWsBB1KWvtIGZeIArHI(loadLibs: true);

	public static string GetLibsDir(bool loadLibs)
	{
		//Discarded unreachable code: IL_0035
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					goto end_IL_0012;
				case 2:
					if (!loadLibs)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				default:
					return libsDir;
				case 4:
					break;
				}
				TwcQ7oKol2Ry0N1wyXs();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			w2tJuyKF95UwMQw0UrW();
			num = 2;
		}
	}

	public static string GetSettingsDir()
	{
		//Discarded unreachable code: IL_006c
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				if (!Directory.Exists(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return text;
			default:
				return ((FileSystemInfo)IE9MudKEj9ifS5DX5H9(text)).FullName;
			case 2:
				obj = j5KIq6Kb6SkdYdmg4xy();
				break;
			case 3:
				if (!ComponentManager.Initialized)
				{
					num2 = 2;
					continue;
				}
				obj = nJe2W2KhAdZT546a0ON(ComponentManager.Current);
				break;
			}
			text = (string)Ak4oEDKGkDXxKbI5HVJ(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107970424));
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
			{
				num2 = 1;
			}
		}
	}

	private static void CheckInitialized()
	{
		//Discarded unreachable code: IL_010c, IL_0140, IL_014f, IL_02be, IL_0330, IL_0368, IL_0387, IL_0396, IL_03b3, IL_03c2, IL_04d4, IL_0514, IL_0523, IL_052f, IL_053e, IL_054e, IL_055d
		int num = 2;
		int num2 = num;
		object obj = default(object);
		bool lockTaken = default(bool);
		string text2 = default(string);
		string setting = default(string);
		string text = default(string);
		SHA1 sHA = default(SHA1);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (!initialized)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 4:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num3 = 19;
					}
					while (true)
					{
						object obj2;
						switch (num3)
						{
						default:
							return;
						case 14:
						{
							importCommandDir = (string)Ak4oEDKGkDXxKbI5HVJ(workDir, dy7d8qKikyrZ2LmNfsJ(-787452571 ^ -787465955));
							int num4 = 12;
							num3 = num4;
							continue;
						}
						case 0:
							return;
						case 6:
							IE9MudKEj9ifS5DX5H9(importCommandDir);
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num3 = 7;
							}
							continue;
						case 3:
							return;
						case 11:
							text2 = ((string)dUeYuIKvdD3Z1pR13If(pdkhomKCUARnkLoJAd2(GFEoEXKQv2sImBvcofo(x3OZLxKftikTeyX4FyY())))).ToUpper();
							num3 = 9;
							continue;
						case 10:
							UvMQ8aKTB7Sh68tOWwf(Ak4oEDKGkDXxKbI5HVJ(workDir, dy7d8qKikyrZ2LmNfsJ(0x1C9495B4 ^ 0x1C94C1A0)), PagsYsKXZOakxwqTRpR(dy7d8qKikyrZ2LmNfsJ(-70007027 ^ -70020315), text2), EjvCfhKZu87sMFWXVR1());
							num3 = 14;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num3 = 3;
							}
							continue;
						case 18:
							IE9MudKEj9ifS5DX5H9(libsDir);
							num3 = 17;
							continue;
						case 15:
							initialized = true;
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num3 = 11;
							}
							continue;
						case 2:
							IE9MudKEj9ifS5DX5H9(workDir);
							num3 = 10;
							continue;
						case 4:
							if (HnlIVcKKdsXGHCPbXk3(libsDir))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto case 18;
						case 1:
							setting = SR.GetSetting((string)dy7d8qKikyrZ2LmNfsJ(-1411196499 ^ -1411216773));
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
							{
								num3 = 1;
							}
							continue;
						case 13:
							obj2 = TNJCNiKqfb8UqaC3ut2(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), dy7d8qKikyrZ2LmNfsJ(-629844702 ^ -629864746), dy7d8qKikyrZ2LmNfsJ(0x7EC153F ^ 0x7EC413F), text);
							break;
						case 5:
							if (dU80sPKR2TpnM0yh7He(setting))
							{
								num3 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
								{
									num3 = 13;
								}
								continue;
							}
							obj2 = setting;
							break;
						case 8:
							try
							{
								text = (string)VUKl2VKS5JLRRIHhFqj(((string)FNcFWnKVQlRbpuWbN4M(iy0EVUKIQHv1pVBYm9l(sHA, OTYi9UKuGbf2hTjtI5l(EjvCfhKZu87sMFWXVR1(), text2)))).Replace('/', '#'), '=', '@');
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							finally
							{
								int num6;
								if (sHA == null)
								{
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
									{
										num6 = 1;
									}
									goto IL_036c;
								}
								goto IL_03a1;
								IL_03a1:
								((IDisposable)sHA).Dispose();
								num6 = 2;
								goto IL_036c;
								IL_036c:
								switch (num6)
								{
								case 1:
									goto end_IL_0347;
								case 2:
									goto end_IL_0347;
								}
								goto IL_03a1;
								end_IL_0347:;
							}
							goto case 1;
						case 16:
							if (!HnlIVcKKdsXGHCPbXk3(workDir))
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto case 14;
						case 7:
							libsDir = Path.Combine(workDir, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637E7D0D));
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
							{
								num3 = 3;
							}
							continue;
						case 9:
							sHA = (SHA1)HgDyfbK8O7uBfjt0BNK();
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
							{
								num3 = 7;
							}
							continue;
						case 19:
							if (initialized)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 15;
						case 12:
							if (!Directory.Exists(importCommandDir))
							{
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 7;
						case 17:
							return;
						}
						workDir = (string)obj2;
						num3 = 16;
					}
				}
				finally
				{
					int num7;
					if (!lockTaken)
					{
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num7 = 0;
						}
						goto IL_04d8;
					}
					goto IL_04ee;
					IL_04ee:
					bLnYdcKkgJZNr81hpUd(obj);
					num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num7 = 2;
					}
					goto IL_04d8;
					IL_04d8:
					switch (num7)
					{
					default:
						goto end_IL_04b3;
					case 1:
						break;
					case 0:
						goto end_IL_04b3;
					case 2:
						goto end_IL_04b3;
					}
					goto IL_04ee;
					end_IL_04b3:;
				}
			case 5:
				lockTaken = false;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 3;
				}
				break;
			case 0:
				return;
			case 3:
				return;
			case 1:
				obj = syncObj;
				num2 = 5;
				break;
			}
		}
	}

	private static void LoadLibs()
	{
		//Discarded unreachable code: IL_00be, IL_00cd, IL_0124, IL_0133, IL_0162, IL_0239, IL_0248, IL_0258, IL_0267, IL_02cf, IL_02ff, IL_030e, IL_0364, IL_03be, IL_0413, IL_0579, IL_0588, IL_05c2, IL_05d1, IL_069e, IL_06de, IL_06ed, IL_06fc, IL_07c1, IL_07f9
		int num = 3;
		int num2 = num;
		IServerInfoManager service = default(IServerInfoManager);
		object obj = default(object);
		bool lockTaken = default(bool);
		string text3 = default(string);
		AssemblyHashInfo assemblyHashInfo = default(AssemblyHashInfo);
		AssemblyHashInfo[] array = default(AssemblyHashInfo[]);
		int num4 = default(int);
		byte[] array2 = default(byte[]);
		bool flag2 = default(bool);
		bool flag = default(bool);
		string text2 = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string text = default(string);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (service == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 6;
					}
				}
				else
				{
					obj = lockObject;
					num2 = 7;
				}
				break;
			case 7:
				lockTaken = false;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 9;
				}
				break;
			case 3:
				if (VZljJ1Knf9384OS83vV())
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 2;
					}
					break;
				}
				return;
			case 5:
				return;
			case 6:
				return;
			case 1:
				return;
			case 2:
				if (!libsLoaded)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 8:
				return;
			default:
				service = Locator.GetService<IServerInfoManager>();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 4;
				}
				break;
			case 9:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num3 = 5;
					}
					while (true)
					{
						switch (num3)
						{
						case 22:
							return;
						case 25:
							return;
						case 26:
							if (File.Exists(text3))
							{
								num3 = 32;
								break;
							}
							goto case 19;
						case 2:
							if (zwGfPRKtJ5vxbqxyoZB(text3))
							{
								num3 = 9;
								break;
							}
							goto case 12;
						case 3:
							libsLoaded = true;
							num3 = 25;
							break;
						default:
							assemblyHashInfo = array[num4];
							num3 = 28;
							break;
						case 24:
						case 30:
							num4++;
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
							{
								num3 = 7;
							}
							break;
						case 27:
							array2 = (byte[])MMSTWiKA5WAjM6pLud6(service, assemblyHashInfo.AssemblyName);
							num3 = 23;
							break;
						case 21:
							num4 = 0;
							num3 = 18;
							break;
						case 4:
						case 29:
							if (flag2)
							{
								num3 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
								{
									num3 = 27;
								}
								break;
							}
							goto case 24;
						case 14:
							if (!flag2)
							{
								num3 = 33;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num3 = 2;
								}
								break;
							}
							goto case 7;
						case 11:
						case 18:
							if (num4 < array.Length)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
								{
									num3 = 0;
								}
								break;
							}
							goto case 3;
						case 12:
							tAeQWFKxFnCGgTtJ0CX(text3, array2);
							num3 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num3 = 24;
							}
							break;
						case 7:
						case 31:
							if (!(flag2 && flag))
							{
								num3 = 29;
								break;
							}
							goto case 20;
						case 33:
							e0C1NUK4rBDLH3MlVyH(text2, text3, true);
							num3 = 31;
							break;
						case 10:
							if (zwGfPRKtJ5vxbqxyoZB(text2))
							{
								num3 = 16;
								break;
							}
							goto case 7;
						case 20:
							enumerator = Directory.EnumerateFiles(text, (string)whmlkxKDBqOyYImOZvM(assemblyHashInfo), SearchOption.AllDirectories).GetEnumerator();
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num3 = 11;
							}
							break;
						case 28:
							flag2 = true;
							num3 = 6;
							break;
						case 23:
							if (array2 == null)
							{
								num3 = 30;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
								{
									num3 = 21;
								}
								break;
							}
							goto case 2;
						case 32:
						{
							AssemblyHashInfo assemblyHashInfo4 = new AssemblyHashInfo();
							syvRRmK3xiAZpjj02mw(assemblyHashInfo4, text3);
							flag2 = (string)sZY9HjKpoeEBZNJ3EIF(assemblyHashInfo4) != (string)sZY9HjKpoeEBZNJ3EIF(assemblyHashInfo);
							num3 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
							{
								num3 = 12;
							}
							break;
						}
						case 19:
							if (!flag2)
							{
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
								{
									num3 = 7;
								}
								break;
							}
							goto case 1;
						case 16:
						{
							AssemblyHashInfo assemblyHashInfo3 = new AssemblyHashInfo();
							syvRRmK3xiAZpjj02mw(assemblyHashInfo3, text2);
							flag2 = iE9jTHKwPkGVnmnfeeX(sZY9HjKpoeEBZNJ3EIF(assemblyHashInfo3), sZY9HjKpoeEBZNJ3EIF(assemblyHashInfo));
							num3 = 14;
							break;
						}
						case 5:
							if (libsLoaded)
							{
								return;
							}
							num3 = 15;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num3 = 7;
							}
							break;
						case 9:
							yRQ0A7K7m0MSJbMSICI(text3);
							num3 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
							{
								num3 = 10;
							}
							break;
						case 1:
							text2 = Path.Combine((string)dUeYuIKvdD3Z1pR13If(YjWh2jKaUlmYSudhYGs(typeof(SR).TypeHandle).Assembly.Location), (string)whmlkxKDBqOyYImOZvM(assemblyHashInfo));
							num3 = 10;
							break;
						case 6:
							text3 = (string)Ak4oEDKGkDXxKbI5HVJ(libsDir, assemblyHashInfo.AssemblyName);
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num3 = 26;
							}
							break;
						case 13:
							try
							{
								while (true)
								{
									IL_0616:
									int num5;
									if (!vI99b4K6NwE218iqsaF(enumerator))
									{
										num5 = 3;
										goto IL_0597;
									}
									goto IL_0655;
									IL_0597:
									while (true)
									{
										switch (num5)
										{
										case 2:
											break;
										case 1:
										{
											AssemblyHashInfo assemblyHashInfo2 = new AssemblyHashInfo();
											syvRRmK3xiAZpjj02mw(assemblyHashInfo2, current);
											flag2 = iE9jTHKwPkGVnmnfeeX(sZY9HjKpoeEBZNJ3EIF(assemblyHashInfo2), assemblyHashInfo.HashCode);
											num5 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
											{
												num5 = 1;
											}
											continue;
										}
										default:
											goto IL_0616;
										case 4:
											if (!flag2)
											{
												int num6 = 5;
												num5 = num6;
												continue;
											}
											goto IL_0616;
										case 5:
											File.Copy(current, text3, overwrite: true);
											num5 = 2;
											continue;
										case 6:
											goto IL_0655;
										case 3:
											break;
										}
										break;
									}
									break;
									IL_0655:
									current = enumerator.Current;
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
									{
										num5 = 0;
									}
									goto IL_0597;
								}
							}
							finally
							{
								int num7;
								if (enumerator == null)
								{
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
									{
										num7 = 0;
									}
									goto IL_06a2;
								}
								goto IL_06b8;
								IL_06b8:
								kBfxQGKHkfZrFKLtAsL(enumerator);
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num7 = 1;
								}
								goto IL_06a2;
								IL_06a2:
								switch (num7)
								{
								default:
									goto end_IL_067d;
								case 2:
									break;
								case 0:
									goto end_IL_067d;
								case 1:
									goto end_IL_067d;
								}
								goto IL_06b8;
								end_IL_067d:;
							}
							goto case 4;
						case 8:
						case 15:
						{
							object obj2 = NxySP6KOeewKasPj7Ex(service);
							PackageService packageService = ((ComponentManager)aaPjafK2gk3nfxkghm2()).PackageService;
							WebComponent webComponent = (NGArInKeCB2eWSWdGhl(packageService) ? (packageService.GetComponent((string)dy7d8qKikyrZ2LmNfsJ(0x53FA00CE ^ 0x53FA546C)) as WebComponent) : null);
							text = null;
							if (webComponent != null && W65h9FKPbj3xrSPA1my(webComponent))
							{
								text = (string)fjZyAxK1FS0Y7GaIEfE(webComponent);
							}
							flag = !lNkTZTKNhjcmd5OgAR3(text) && HnlIVcKKdsXGHCPbXk3(text);
							array = (AssemblyHashInfo[])obj2;
							num3 = 21;
							break;
						}
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								Monitor.Exit(obj);
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num8 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	private static bool IsAssembly(object fileName)
	{
		//Discarded unreachable code: IL_0046, IL_0078, IL_00cb, IL_0103, IL_0112
		switch (1)
		{
		case 1:
		{
			bool result = default(bool);
			try
			{
				BDAKr0K0dacVy6R31Qu(fileName);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			catch (FileNotFoundException)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return result;
					}
					result = false;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 1;
					}
				}
			}
			catch (BadImageFormatException)
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return result;
					}
					result = false;
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num3 = 1;
					}
				}
			}
			break;
		}
		}
		return true;
	}

	private static void CopyFileIfChanged(object newFileName, object oldFileName)
	{
		//Discarded unreachable code: IL_0062, IL_00b5, IL_00d4, IL_00e3, IL_00f3, IL_0127, IL_0180, IL_01b8
		int num = 5;
		FileStream fileStream = default(FileStream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 6:
					try
					{
						FileStream fileStream2 = new FileStream((string)oldFileName, FileMode.Open, FileAccess.Read);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								byte[] a = new MD5CryptoServiceProvider().ComputeHash(fileStream);
								byte[] b = (byte[])jnCQZBKmeWmkMRAb5Je(new MD5CryptoServiceProvider(), fileStream2);
								if (Compare(a, b))
								{
									return;
								}
								int num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num4 = 1;
								}
								switch (num4)
								{
								case 2:
									return;
								case 1:
									break;
								case 0:
									break;
								}
							}
							finally
							{
								if (fileStream2 != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											((IDisposable)fileStream2).Dispose();
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
											{
												num5 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
							break;
						}
					}
					finally
					{
						if (fileStream != null)
						{
							int num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									kBfxQGKHkfZrFKLtAsL(fileStream);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
									{
										num6 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 7;
				case 1:
					fileStream = new FileStream((string)newFileName, FileMode.Open, FileAccess.Read);
					num2 = 6;
					continue;
				case 7:
					if (zwGfPRKtJ5vxbqxyoZB(oldFileName))
					{
						num = 2;
						break;
					}
					goto default;
				case 4:
					return;
				default:
					File.Copy((string)newFileName, (string)oldFileName);
					num = 3;
					break;
				case 2:
					yRQ0A7K7m0MSJbMSICI(oldFileName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (File.Exists((string)newFileName))
					{
						if (zwGfPRKtJ5vxbqxyoZB(oldFileName))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 7;
					}
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	private static bool Compare(object a, object b)
	{
		//Discarded unreachable code: IL_00b5
		int num = 2;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (((byte[])a)[num3] == ((byte[])b)[num3])
					{
						goto end_IL_0012;
					}
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 6;
					}
					break;
				case 3:
					return true;
				default:
					if (num3 >= ((Array)a).Length)
					{
						num2 = 3;
						break;
					}
					goto case 5;
				case 2:
					if (((Array)a).Length != ((Array)b).Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 1;
						}
						break;
					}
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					return false;
				case 1:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num3++;
			num = 4;
		}
	}

	static DesignEnvironment()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				lockObject = new object();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				syncObj = new object();
				num2 = 3;
				break;
			case 3:
				return;
			case 1:
				GX52oIKyrsShxTMfTp2();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void w2tJuyKF95UwMQw0UrW()
	{
		CheckInitialized();
	}

	internal static object KQduuXKBZBP82Fdb83x()
	{
		return GetSettingsDir();
	}

	internal static object rWsBB1KWvtIGZeIArHI(bool loadLibs)
	{
		return GetLibsDir(loadLibs);
	}

	internal static void TwcQ7oKol2Ry0N1wyXs()
	{
		LoadLibs();
	}

	internal static bool bSpHXjqcTgZwijGepKO()
	{
		return OWHqxsqsjLisbXR3tMQ == null;
	}

	internal static DesignEnvironment crMoeVqze5lidwdQIFN()
	{
		return OWHqxsqsjLisbXR3tMQ;
	}

	internal static object j5KIq6Kb6SkdYdmg4xy()
	{
		return WorkDir;
	}

	internal static object nJe2W2KhAdZT546a0ON(object P_0)
	{
		return ((ComponentManager)P_0).WorkDirectory;
	}

	internal static object Ak4oEDKGkDXxKbI5HVJ(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object IE9MudKEj9ifS5DX5H9(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object x3OZLxKftikTeyX4FyY()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object GFEoEXKQv2sImBvcofo(object P_0)
	{
		return ((AppDomain)P_0).SetupInformation;
	}

	internal static object pdkhomKCUARnkLoJAd2(object P_0)
	{
		return ((AppDomainSetup)P_0).ConfigurationFile;
	}

	internal static object dUeYuIKvdD3Z1pR13If(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object HgDyfbK8O7uBfjt0BNK()
	{
		return SHA1.Create();
	}

	internal static object EjvCfhKZu87sMFWXVR1()
	{
		return Encoding.UTF8;
	}

	internal static object OTYi9UKuGbf2hTjtI5l(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object iy0EVUKIQHv1pVBYm9l(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static object FNcFWnKVQlRbpuWbN4M(object P_0)
	{
		return Convert.ToBase64String((byte[])P_0);
	}

	internal static object VUKl2VKS5JLRRIHhFqj(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	internal static object dy7d8qKikyrZ2LmNfsJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool dU80sPKR2TpnM0yh7He(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object TNJCNiKqfb8UqaC3ut2(object P_0, object P_1, object P_2, object P_3)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}

	internal static bool HnlIVcKKdsXGHCPbXk3(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object PagsYsKXZOakxwqTRpR(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void UvMQ8aKTB7Sh68tOWwf(object P_0, object P_1, object P_2)
	{
		File.WriteAllText((string)P_0, (string)P_1, (Encoding)P_2);
	}

	internal static void bLnYdcKkgJZNr81hpUd(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool VZljJ1Knf9384OS83vV()
	{
		return Locator.Initialized;
	}

	internal static object NxySP6KOeewKasPj7Ex(object P_0)
	{
		return ((IServerInfoManager)P_0).GetBinaryHashInfos();
	}

	internal static object aaPjafK2gk3nfxkghm2()
	{
		return ComponentManager.Current;
	}

	internal static bool NGArInKeCB2eWSWdGhl(object P_0)
	{
		return ((PackageService)P_0).Initialized;
	}

	internal static bool W65h9FKPbj3xrSPA1my(object P_0)
	{
		return ((ElmaComponent)P_0).IsInstalled();
	}

	internal static object fjZyAxK1FS0Y7GaIEfE(object P_0)
	{
		return ((ElmaComponent)P_0).ComponentRoot;
	}

	internal static bool lNkTZTKNhjcmd5OgAR3(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void syvRRmK3xiAZpjj02mw(object P_0, object P_1)
	{
		((AssemblyHashInfo)P_0).EvaluteMD5((string)P_1);
	}

	internal static object sZY9HjKpoeEBZNJ3EIF(object P_0)
	{
		return ((AssemblyHashInfo)P_0).HashCode;
	}

	internal static Type YjWh2jKaUlmYSudhYGs(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object whmlkxKDBqOyYImOZvM(object P_0)
	{
		return ((AssemblyHashInfo)P_0).AssemblyName;
	}

	internal static bool zwGfPRKtJ5vxbqxyoZB(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static bool iE9jTHKwPkGVnmnfeeX(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void e0C1NUK4rBDLH3MlVyH(object P_0, object P_1, bool P_2)
	{
		File.Copy((string)P_0, (string)P_1, P_2);
	}

	internal static bool vI99b4K6NwE218iqsaF(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void kBfxQGKHkfZrFKLtAsL(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object MMSTWiKA5WAjM6pLud6(object P_0, object P_1)
	{
		return ((IServerInfoManager)P_0).GetAssemblyRaw((string)P_1);
	}

	internal static void yRQ0A7K7m0MSJbMSICI(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static void tAeQWFKxFnCGgTtJ0CX(object P_0, object P_1)
	{
		File.WriteAllBytes((string)P_0, (byte[])P_1);
	}

	internal static object BDAKr0K0dacVy6R31Qu(object P_0)
	{
		return AssemblyName.GetAssemblyName((string)P_0);
	}

	internal static object jnCQZBKmeWmkMRAb5Je(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((Stream)P_1);
	}

	internal static void GX52oIKyrsShxTMfTp2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
