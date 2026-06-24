using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Web.Hosting;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using log4net.Layout;
using Microsoft.Win32;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

public class PatternLayoutExt : PatternLayout
{
	private static string version;

	private static string dbVersion;

	private static string serverSoftware;

	private static string os;

	private static string framework;

	private static string cpu;

	private static string hdd;

	private static bool? ki;

	private static string applicationDirectory;

	private static string configurationDirectory;

	private static PatternLayoutExt AoL253h9htG1u7sWULuF;

	public static string Version
	{
		get
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (dbVersion == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 3:
					if (version != null)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 1:
				{
					version = (string)e9n35jh9CnWCMYX9sYDv(FN9qweh9QKJ3TOh8furk(0x637E299B ^ 0x637DBA3D), VersionInfo.GetInfoVersion<SR>(), VersionInfo.GetEdition(out var _, out dbVersion));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					continue;
				}
				}
				break;
			}
			return version;
		}
	}

	public static string ServerSoftware
	{
		get
		{
			//Discarded unreachable code: IL_0035, IL_0044
			int num = 1;
			int num2 = num;
			FileVersionInfo fileVersionInfo = default(FileVersionInfo);
			while (true)
			{
				switch (num2)
				{
				default:
					return serverSoftware;
				case 1:
					if (serverSoftware != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 4:
					fileVersionInfo = (FileVersionInfo)Sd8YyHh9ZoCJeAX7co5X(iftolIh98OGUwsoiR1uD(fO2Kxvh9vWe29RySeABi()));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					serverSoftware = (string)kg06tLh9u89qYk5IjwCF(fileVersionInfo) + (string)FN9qweh9QKJ3TOh8furk(0x34185E55 ^ 0x341BCD9D) + (string)rNGkvWh9IPqauR4VTboE(fileVersionInfo) + (string)FN9qweh9QKJ3TOh8furk(-1088304168 ^ -1088312078) + (string)(lM9MsNh9ViWXg1PXaytx() ? FN9qweh9QKJ3TOh8furk(-541731959 ^ -541704085) : FN9qweh9QKJ3TOh8furk(0x269E5FCA ^ 0x269DCC18)) + (string)FN9qweh9QKJ3TOh8furk(-87337865 ^ -87340085);
					num2 = 3;
					break;
				}
			}
		}
	}

	public static string DataBaseSoftware
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return dbVersion;
				default:
					Am3Npwh9S6NcRAm4yJwg();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (version == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
	}

	public static string OS
	{
		get
		{
			//Discarded unreachable code: IL_008e, IL_0142, IL_0159, IL_0168
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						GetValues<string, string, string>(FN9qweh9QKJ3TOh8furk(-2138958856 ^ -2138996726), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269DCBEA), FN9qweh9QKJ3TOh8furk(0x307E9FD1 ^ 0x307D0BE3), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858920235), out var v, out var v2, out var v3);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								os = (string)T1EUqHh9iohRemjarotd(new string[6]
								{
									v,
									z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A10325),
									v2,
									(string)FN9qweh9QKJ3TOh8furk(0x4785BC0D ^ 0x4785B00F),
									v3,
									(string)FN9qweh9QKJ3TOh8furk(0x10E41EDB ^ 0x10E40167)
								});
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					break;
				case 1:
					if (os == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					break;
				}
				break;
			}
			return os;
		}
	}

	public static string Framework
	{
		get
		{
			//Discarded unreachable code: IL_0069, IL_00bb, IL_00f3, IL_012b, IL_013a, IL_0165, IL_017c, IL_018b
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						RegistryKey registryKey = (RegistryKey)qPiE5uh9qDYiWN5fMMQE(wbi14Hh9RiHgsocwxd3q(RegistryHive.LocalMachine, RegistryView.Registry32), FN9qweh9QKJ3TOh8furk(0x1ECE530A ^ 0x1ECDC758));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								framework = (string)flcC1Jh9XpPv4plJDJsD(arXRwuh9Ko92SIFeE4Ue(registryKey, FN9qweh9QKJ3TOh8furk(0x4785BC0D ^ 0x47853D79)));
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							finally
							{
								if (registryKey != null)
								{
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											c71LOGh9T1qNoVQN3JuF(registryKey);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
							break;
						case 1:
							break;
						}
					}
					catch
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					break;
				case 1:
					if (framework == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					break;
				}
				break;
			}
			return framework;
		}
	}

	public static string CPU
	{
		get
		{
			//Discarded unreachable code: IL_0073, IL_00a5, IL_00bc, IL_00cb
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return cpu;
				default:
					try
					{
						cpu = GetValue<string>(FN9qweh9QKJ3TOh8furk(0x638095EB ^ 0x63830157), FN9qweh9QKJ3TOh8furk(-1710575414 ^ -1710570742));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 2;
				case 1:
					if (cpu == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
	}

	public static string Memory
	{
		get
		{
			//Discarded unreachable code: IL_007e, IL_0121, IL_0159, IL_0168
			string result = default(string);
			switch (1)
			{
			case 1:
				try
				{
					GetValues<ulong, ulong>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876025507), FN9qweh9QKJ3TOh8furk(-1334993905 ^ -1334966063), FN9qweh9QKJ3TOh8furk(0x4EDCBA32 ^ 0x4EDF2F34), out var v, out var v2);
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						case 1:
							return result;
						}
						result = (string)f2lFDSh9OsklxKxyCYDV(yghX92h9kAfpHGBAb2hu(v / 1024uL), FN9qweh9QKJ3TOh8furk(0x53CB464B ^ 0x53CB221B), yghX92h9kAfpHGBAb2hu(Sg8xhph9n2UhcxPXCVj8(v2 / 1024uL)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECDC63C));
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num = 0;
						}
					}
				}
				catch
				{
					int num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							result = null;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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
			default:
				return result;
			}
		}
	}

	public static string HDD
	{
		get
		{
			//Discarded unreachable code: IL_006e, IL_0128, IL_013f, IL_014e
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (hdd == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					try
					{
						DriveInfo[] source = (DriveInfo[])klu64Uh92PXbhYTsbCn3();
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								hdd = string.Join((string)FN9qweh9QKJ3TOh8furk(0xD3DEF7E ^ 0xD3DE37C), from d in source
									where _003C_003Ec.MkKCQHvHV01B8Q9HgV0f(d) == DriveType.Fixed
									select d into drive
									select (string)_003C_003Ec.icd6n2vHkVoZ4NQZx5Fg(new object[8]
									{
										_003C_003Ec.IKWsIFvHi86qnQXgAI0u(_003C_003Ec.vHRfHtvHScPA5S7nFFDI(drive), new char[1] { '\\' }),
										z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70047478),
										_003C_003Ec.QsT86kvHRE58huKrDxsn(drive),
										_003C_003Ec.PAZjnQvHqwOdM0FmA0ZJ(-1217523399 ^ -1217520325),
										_003C_003Ec.dxehsfvHXU1ojDT5H0GA(_003C_003Ec.YJOKYdvHKmEqJoXr9XHb(drive.AvailableFreeSpace / 1048576)),
										_003C_003Ec.PAZjnQvHqwOdM0FmA0ZJ(-561074844 ^ -561067724),
										_003C_003Ec.cqUI4WvHTMa3pkx0KO6v(drive) / 1073741824,
										_003C_003Ec.PAZjnQvHqwOdM0FmA0ZJ(-1108654032 ^ -1108441328)
									}));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					catch
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					break;
				case 2:
					break;
				}
				break;
			}
			return hdd;
		}
	}

	public static bool? KI
	{
		get
		{
			if (!ki.HasValue)
			{
				try
				{
					IFeatureFlagService service = Locator.GetService<IFeatureFlagService>();
					ki = service.Enabled(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F30D6BC), defaultEnabled: false);
				}
				catch
				{
				}
			}
			return ki;
		}
	}

	public static string ApplicationDirectory
	{
		get
		{
			//Discarded unreachable code: IL_003d, IL_004c, IL_005b
			int num = 5;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return applicationDirectory;
				case 3:
					applicationDirectory = (string)IpP22Vh9esRTwGXKuxnL(FN9qweh9QKJ3TOh8furk(0x53CACA3 ^ 0x53F39E3));
					num2 = 2;
					continue;
				case 5:
					if (applicationDirectory != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 3;
				case 2:
					if (applicationDirectory == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 6:
					break;
				}
				applicationDirectory = (string)cYRuwBh9PT7fa81FaBuM(applicationDirectory, new char[1] { '\\' });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public static string ConfigurationDirectory
	{
		get
		{
			//Discarded unreachable code: IL_008e, IL_00d8, IL_00e2, IL_0136, IL_014d, IL_015c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (configurationDirectory == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					break;
				default:
					try
					{
						string text = (string)gtFCPbh939ljGcQ3WD7A(HgrmLGh9NyIgq9db1kik(doI751h91La32g2v7N5X(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088404330)));
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							object obj;
							switch (num3)
							{
							default:
								goto end_IL_0092;
							case 1:
								if (W1gHBBh9pc0fDSjAu4BZ(text))
								{
									num3 = 3;
									continue;
								}
								goto case 2;
							case 2:
								obj = pmhGYlh9DVtH10NXkcQm(c427uwh9aUGHTm7b9Rxm(AppDomain.CurrentDomain), text);
								break;
							case 3:
								obj = text;
								break;
							case 0:
								goto end_IL_0092;
							}
							configurationDirectory = (string)HWodNRh9tKmIjq5ksyuY(obj);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num3 = 0;
							}
							continue;
							end_IL_0092:
							break;
						}
					}
					catch
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					break;
				}
				break;
			}
			return configurationDirectory;
		}
	}

	public override string Header
	{
		get
		{
			//Discarded unreachable code: IL_01a6, IL_022c, IL_023b, IL_0488, IL_04c5, IL_04d4
			string result = default(string);
			switch (1)
			{
			case 1:
				try
				{
					StringBuilder stringBuilder = new StringBuilder();
					int num = 17;
					while (true)
					{
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							case 14:
								EVHplBh9H8KFlVN1h4we(((StringBuilder)ukKOxDh9wRx4jHC7MgMu(stringBuilder, FN9qweh9QKJ3TOh8furk(-105199646 ^ -105295330))).Append((string)W5YLP9h9x0AA2mnTg1JN()));
								num2 = 3;
								continue;
							case 8:
							case 20:
								if (gO8dATh9yxfPjD0f08Bl() == null)
								{
									num = 19;
									break;
								}
								goto case 2;
							case 2:
								EVHplBh9H8KFlVN1h4we(((StringBuilder)ukKOxDh9wRx4jHC7MgMu(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218523860))).Append((string)gO8dATh9yxfPjD0f08Bl()));
								num2 = 13;
								continue;
							case 5:
								EVHplBh9H8KFlVN1h4we(stringBuilder);
								num2 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
								{
									num2 = 4;
								}
								continue;
							case 6:
								ukKOxDh9wRx4jHC7MgMu(stringBuilder, oqLsvZh9MjtCG56MOC2T(this));
								num2 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num2 = 1;
								}
								continue;
							case 11:
								EVHplBh9H8KFlVN1h4we(ukKOxDh9wRx4jHC7MgMu(ukKOxDh9wRx4jHC7MgMu(stringBuilder, FN9qweh9QKJ3TOh8furk(-87337865 ^ -87506343)), Memory));
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
								{
									num2 = 0;
								}
								continue;
							case 7:
								EVHplBh9H8KFlVN1h4we(ukKOxDh9wRx4jHC7MgMu(ukKOxDh9wRx4jHC7MgMu(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307D0A71)), nfO9Cdh96IML2qCEQDxD()));
								num2 = 16;
								continue;
							case 15:
								if (u3UYWdh9mPdrb6chR7mA() == null)
								{
									num2 = 20;
									continue;
								}
								goto case 12;
							case 12:
								((StringBuilder)ukKOxDh9wRx4jHC7MgMu(stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AE5A88)), u3UYWdh9mPdrb6chR7mA())).AppendLine();
								num2 = 8;
								continue;
							default:
								obFtx7h94BeNlyWmahD8(stringBuilder, Am3Npwh9S6NcRAm4yJwg());
								num = 7;
								break;
							case 10:
								result = stringBuilder.ToString();
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num2 = 4;
								}
								continue;
							case 3:
								EVHplBh9H8KFlVN1h4we(ukKOxDh9wRx4jHC7MgMu(ukKOxDh9wRx4jHC7MgMu(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317565712)), CPU));
								num2 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num2 = 11;
								}
								continue;
							case 17:
								((StringBuilder)ukKOxDh9wRx4jHC7MgMu(stringBuilder.Append((string)FN9qweh9QKJ3TOh8furk(-1088304168 ^ -1088266594)), DateTime.Now.ToString((string)FN9qweh9QKJ3TOh8furk(-1459557599 ^ -1459388849)))).AppendLine();
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
								{
									num2 = 0;
								}
								continue;
							case 9:
								((StringBuilder)ukKOxDh9wRx4jHC7MgMu(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853069324))).Append((string)J7heD6h97GF36u6N70O5()).AppendLine();
								num2 = 14;
								continue;
							case 16:
								if (DataBaseSoftware != null)
								{
									num2 = 18;
									continue;
								}
								goto case 9;
							case 1:
								stringBuilder.Append((string)FN9qweh9QKJ3TOh8furk(0xA592A41 ^ 0xA5ABC03)).Append((string)zUiWjvh900GrCnTWYkor()).AppendLine();
								num2 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num2 = 15;
								}
								continue;
							case 18:
								EVHplBh9H8KFlVN1h4we(ukKOxDh9wRx4jHC7MgMu(ukKOxDh9wRx4jHC7MgMu(stringBuilder, FN9qweh9QKJ3TOh8furk(0x49E27B8A ^ 0x49E1EE4C)), L9sJFlh9AeZiDxOukeXX()));
								num2 = 9;
								continue;
							case 13:
							case 19:
								((StringBuilder)ukKOxDh9wRx4jHC7MgMu(ukKOxDh9wRx4jHC7MgMu(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105295526)), KI.HasValue ? KI.Value.ToString() : FN9qweh9QKJ3TOh8furk(-2107978722 ^ -2107976620))).AppendLine();
								num2 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
								{
									num2 = 5;
								}
								continue;
							case 4:
								return result;
							}
							break;
						}
					}
				}
				catch
				{
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							result = ((LayoutSkeleton)this).get_Header();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num3 = 0;
							}
							break;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
			default:
				return result;
			}
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
					gxYifnh9JNrWLdLSqIZS(this, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
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

	private static T GetValue<T>(object resource, object property)
	{
		_003C_003Ec__DisplayClass0_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0<T>();
		CS_0024_003C_003E8__locals0.property = (string)property;
		using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978341621) + CS_0024_003C_003E8__locals0.property + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978341607) + (string)resource);
		return (from ManagementObject item in managementObjectSearcher.Get()
			select item[CS_0024_003C_003E8__locals0.property]).Cast<T>().FirstOrDefault();
	}

	private static void GetValues<T1, T2>(object resource, object p1, object p2, out T1 v1, out T2 v2)
	{
		_003C_003Ec__DisplayClass1_0<T1, T2> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0<T1, T2>();
		CS_0024_003C_003E8__locals0.p1 = (string)p1;
		CS_0024_003C_003E8__locals0.p2 = (string)p2;
		using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099744937) + CS_0024_003C_003E8__locals0.p1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x124410A6) + CS_0024_003C_003E8__locals0.p2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099744955) + (string)resource);
		var anon = (from ManagementObject i in managementObjectSearcher.Get()
			select new
			{
				v1 = (T1)i[CS_0024_003C_003E8__locals0.p1],
				v2 = (T2)i[CS_0024_003C_003E8__locals0.p2]
			}).FirstOrDefault();
		if (anon != null)
		{
			v1 = anon.v1;
			v2 = anon.v2;
		}
		else
		{
			v1 = default(T1);
			v2 = default(T2);
		}
	}

	private static void GetValues<T1, T2, T3>(object resource, object p1, object p2, object p3, out T1 v1, out T2 v2, out T3 v3)
	{
		_003C_003Ec__DisplayClass2_0<T1, T2, T3> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0<T1, T2, T3>();
		CS_0024_003C_003E8__locals0.p1 = (string)p1;
		CS_0024_003C_003E8__locals0.p2 = (string)p2;
		CS_0024_003C_003E8__locals0.p3 = (string)p3;
		using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x745A602) + CS_0024_003C_003E8__locals0.p1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFEF468) + CS_0024_003C_003E8__locals0.p2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812026804) + CS_0024_003C_003E8__locals0.p3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606664434) + (string)resource);
		var anon = (from ManagementObject i in managementObjectSearcher.Get()
			select new
			{
				v1 = (T1)i[CS_0024_003C_003E8__locals0.p1],
				v2 = (T2)i[CS_0024_003C_003E8__locals0.p2],
				v3 = (T3)i[CS_0024_003C_003E8__locals0.p3]
			}).FirstOrDefault();
		if (anon != null)
		{
			v1 = anon.v1;
			v2 = anon.v2;
			v3 = anon.v3;
		}
		else
		{
			v1 = default(T1);
			v2 = default(T2);
			v3 = default(T3);
		}
	}

	private static string Format1024(decimal mb)
	{
		int num = 1;
		int num2 = num;
		decimal num3 = default(decimal);
		while (true)
		{
			switch (num2)
			{
			default:
				return num3.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767822747));
			case 1:
				num3 = vqRhcVh9fERD9t6qaeTw(mb, 1024m);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PatternLayoutExt()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static decimal vqRhcVh9fERD9t6qaeTw(decimal P_0, decimal P_1)
	{
		return P_0 / P_1;
	}

	internal static bool ntSOash9GZ1qCjxJhrgf()
	{
		return AoL253h9htG1u7sWULuF == null;
	}

	internal static PatternLayoutExt S5bKnNh9EeAesWnUYuYZ()
	{
		return AoL253h9htG1u7sWULuF;
	}

	internal static object FN9qweh9QKJ3TOh8furk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object e9n35jh9CnWCMYX9sYDv(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object fO2Kxvh9vWe29RySeABi()
	{
		return Process.GetCurrentProcess();
	}

	internal static object iftolIh98OGUwsoiR1uD(object P_0)
	{
		return ((Process)P_0).MainModule;
	}

	internal static object Sd8YyHh9ZoCJeAX7co5X(object P_0)
	{
		return ((ProcessModule)P_0).FileVersionInfo;
	}

	internal static object kg06tLh9u89qYk5IjwCF(object P_0)
	{
		return ((FileVersionInfo)P_0).ProductName;
	}

	internal static object rNGkvWh9IPqauR4VTboE(object P_0)
	{
		return ((FileVersionInfo)P_0).ProductVersion;
	}

	internal static bool lM9MsNh9ViWXg1PXaytx()
	{
		return Environment.Is64BitProcess;
	}

	internal static object Am3Npwh9S6NcRAm4yJwg()
	{
		return Version;
	}

	internal static object T1EUqHh9iohRemjarotd(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object wbi14Hh9RiHgsocwxd3q(RegistryHive P_0, RegistryView P_1)
	{
		return RegistryKey.OpenBaseKey(P_0, P_1);
	}

	internal static object qPiE5uh9qDYiWN5fMMQE(object P_0, object P_1)
	{
		return ((RegistryKey)P_0).OpenSubKey((string)P_1);
	}

	internal static object arXRwuh9Ko92SIFeE4Ue(object P_0, object P_1)
	{
		return ((RegistryKey)P_0).GetValue((string)P_1);
	}

	internal static object flcC1Jh9XpPv4plJDJsD(object P_0)
	{
		return Convert.ToString(P_0);
	}

	internal static void c71LOGh9T1qNoVQN3JuF(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object yghX92h9kAfpHGBAb2hu(decimal mb)
	{
		return Format1024(mb);
	}

	internal static decimal Sg8xhph9n2UhcxPXCVj8(ulong P_0)
	{
		return P_0;
	}

	internal static object f2lFDSh9OsklxKxyCYDV(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object klu64Uh92PXbhYTsbCn3()
	{
		return DriveInfo.GetDrives();
	}

	internal static object IpP22Vh9esRTwGXKuxnL(object P_0)
	{
		return HostingEnvironment.MapPath((string)P_0);
	}

	internal static object cYRuwBh9PT7fa81FaBuM(object P_0, object P_1)
	{
		return ((string)P_0).TrimEnd((char[])P_1);
	}

	internal static object doI751h91La32g2v7N5X()
	{
		return ConfigurationManager.ConnectionStrings;
	}

	internal static object HgrmLGh9NyIgq9db1kik(object P_0, object P_1)
	{
		return ((ConnectionStringSettingsCollection)P_0)[(string)P_1];
	}

	internal static object gtFCPbh939ljGcQ3WD7A(object P_0)
	{
		return ((ConnectionStringSettings)P_0).ConnectionString;
	}

	internal static bool W1gHBBh9pc0fDSjAu4BZ(object P_0)
	{
		return Path.IsPathRooted((string)P_0);
	}

	internal static object c427uwh9aUGHTm7b9Rxm(object P_0)
	{
		return ((AppDomain)P_0).BaseDirectory;
	}

	internal static object pmhGYlh9DVtH10NXkcQm(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object HWodNRh9tKmIjq5ksyuY(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object ukKOxDh9wRx4jHC7MgMu(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object obFtx7h94BeNlyWmahD8(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static object nfO9Cdh96IML2qCEQDxD()
	{
		return ServerSoftware;
	}

	internal static object EVHplBh9H8KFlVN1h4we(object P_0)
	{
		return ((StringBuilder)P_0).AppendLine();
	}

	internal static object L9sJFlh9AeZiDxOukeXX()
	{
		return DataBaseSoftware;
	}

	internal static object J7heD6h97GF36u6N70O5()
	{
		return OS;
	}

	internal static object W5YLP9h9x0AA2mnTg1JN()
	{
		return Framework;
	}

	internal static object zUiWjvh900GrCnTWYkor()
	{
		return HDD;
	}

	internal static object u3UYWdh9mPdrb6chR7mA()
	{
		return ApplicationDirectory;
	}

	internal static object gO8dATh9yxfPjD0f08Bl()
	{
		return ConfigurationDirectory;
	}

	internal static object oqLsvZh9MjtCG56MOC2T(object P_0)
	{
		return ((LayoutSkeleton)P_0).get_Header();
	}

	internal static void gxYifnh9JNrWLdLSqIZS(object P_0, object P_1)
	{
		((LayoutSkeleton)P_0).set_Header((string)P_1);
	}
}
