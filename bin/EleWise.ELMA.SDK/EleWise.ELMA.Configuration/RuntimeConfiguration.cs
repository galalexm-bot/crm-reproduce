using System;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Properties;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

public class RuntimeConfiguration
{
	private static RuntimeConfiguration IbOBQ5fBdeOXSb5TL0jC;

	public System.Configuration.Configuration Config
	{
		[CompilerGenerated]
		get
		{
			return _003CConfig_003Ek__BackingField;
		}
		[CompilerGenerated]
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
					_003CConfig_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IMainBaseSettingsSection MainDB
	{
		get
		{
			//Discarded unreachable code: IL_009d
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					throw new ConfigurationInitializeException(SR.T((string)mWcAqDfB5JH4VeXQw5BG(0x4EDCBA32 ^ 0x4ED9AB08)));
				case 2:
					return ((IEnumerable)gsm9qXfWudwqnfnXlLwS(Config)).OfType<IMainBaseSettingsSection>().FirstOrDefault();
				default:
					if (Config.Sections.OfType<IMainBaseSettingsSection>().Count() <= 1)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 3;
				case 1:
					Contract.NotNull(Config, (string)mWcAqDfB5JH4VeXQw5BG(0x5DD55050 ^ 0x5DD0417A));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					break;
				}
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
				case 3:
					if (MainDB != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 2;
				case 1:
					Contract.NotNull(Config, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3656400));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				default:
					fiv40kfBjx3vZOLHE4J9(value, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC5C49));
					num2 = 3;
					break;
				case 2:
					EE1MV7fWSaLbhTYV0bO9(gsm9qXfWudwqnfnXlLwS(Config), mWcAqDfB5JH4VeXQw5BG(0x42643203 ^ 0x4265F291), value as DataBaseSettingsSection);
					num2 = 5;
					break;
				case 4:
					nK7W7kfWVEMB2RfxED5Q(gsm9qXfWudwqnfnXlLwS(Config), ((SectionInformation)X2b0eSfWI1d3qXwg2UGm(MainDB as DataBaseSettingsSection)).Name);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					return;
				}
			}
		}
	}

	protected RuntimeConfiguration()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xuHWUefBgJPq9iTHcJca();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static RuntimeConfiguration Load(string fileName)
	{
		//Discarded unreachable code: IL_00a7, IL_00d9, IL_00f3, IL_0102, IL_0134, IL_018b, IL_01a2, IL_01b1
		int num = 7;
		RuntimeConfiguration runtimeConfiguration = default(RuntimeConfiguration);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					throw new ConfigurationInitializeException((string)GjGXY1fBUYG2vqBXqVLk(mWcAqDfB5JH4VeXQw5BG(-538519530 ^ -538720042)));
				case 5:
					try
					{
						runtimeConfiguration = new RuntimeConfiguration
						{
							Config = (System.Configuration.Configuration)WJ9JRIfBzJsYwB6hcVqO(text)
						};
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (ConfigurationInitializeException)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							throw;
						}
					}
					catch (Exception innerException)
					{
						throw new ConfigurationInitializeException(innerException);
					}
					goto case 1;
				case 3:
					try
					{
						if (CO8crifWFDgNRkJCjNHf(text))
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									return runtimeConfiguration;
								}
								File.Delete(text);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
								{
									num5 = 1;
								}
							}
						}
						return runtimeConfiguration;
					}
					catch
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num6 = 0;
						}
						return num6 switch
						{
							0 => runtimeConfiguration, 
							_ => runtimeConfiguration, 
						};
					}
				default:
					text = (string)dRxb7bfBc2jW6AYHg6aL(fileName);
					num2 = 5;
					continue;
				case 1:
					num2 = 3;
					continue;
				case 6:
					if (tBLCrUfBLO5S0koxwdZ6(mWcAqDfB5JH4VeXQw5BG(-488881205 ^ -489073819), LHk6AAfBYxnWkDd9mvkb(fileName), StringComparison.InvariantCultureIgnoreCase))
					{
						UnmXDgfBsyiLJ2jZBDxw(fileName);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 0;
						}
						continue;
					}
					num = 2;
					break;
				case 7:
					fiv40kfBjx3vZOLHE4J9(fileName, mWcAqDfB5JH4VeXQw5BG(-951514650 ^ -951486468));
					num = 6;
					break;
				case 4:
					return runtimeConfiguration;
				}
				break;
			}
		}
	}

	private static void CreateEmptyConfig(object fileName)
	{
		//Discarded unreachable code: IL_005c, IL_006b, IL_008a, IL_00b9, IL_00c8, IL_0142, IL_0151, IL_0195, IL_01cd, IL_0226, IL_025e, IL_026d
		int num = 5;
		int num2 = num;
		bool lockTaken = default(bool);
		string text = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				lockTaken = false;
				num2 = 2;
				break;
			case 5:
				if (!CO8crifWFDgNRkJCjNHf(fileName))
				{
					num2 = 4;
					break;
				}
				return;
			case 1:
				return;
			case 2:
				try
				{
					Monitor.Enter(text, ref lockTaken);
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 2:
							if (CO8crifWFDgNRkJCjNHf(fileName))
							{
								return;
							}
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num3 = 6;
							}
							break;
						case 5:
							((Stream)GuBcD1fWotsutrdtglv1(fileName)).Close();
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
							{
								num3 = 3;
							}
							break;
						default:
							dBmuCEfWWmqxQqquamBr(fileName);
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num3 = 1;
							}
							break;
						case 3:
							streamWriter = new StreamWriter((string)fileName);
							num3 = 4;
							break;
						case 4:
							try
							{
								G1q5nffWhnYJlZK3GjgH(streamWriter, tQXOLRfWbFQbEAl7h7dR());
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
								return;
							}
							finally
							{
								if (streamWriter != null)
								{
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											jj1MGPfWGGWAu1LBZU7t(streamWriter);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
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
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								jqBVaFfWEy5UZpnuWiAS(text);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			case 4:
				text = (string)Q3dbvufWBupJ6Lv1bdR7(fileName);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private static string GetExeFile(object fileName)
	{
		int num = 5;
		string directoryName = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				case 2:
					if (directoryName != null)
					{
						num2 = 3;
						continue;
					}
					goto case 6;
				case 6:
					if (!CO8crifWFDgNRkJCjNHf(text))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				case 3:
					if (text != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 5:
					text = (string)NDvfVpfWffXhErP3S6Pe(fileName);
					num2 = 4;
					continue;
				case 1:
					text = Path.Combine(directoryName, text);
					num2 = 6;
					continue;
				case 7:
					return text;
				default:
					XRJMKIfWQsKmmJFgcqGb(GuBcD1fWotsutrdtglv1(text));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
			directoryName = Path.GetDirectoryName((string)fileName);
			num = 2;
		}
	}

	public void Save(string fileName)
	{
		//Discarded unreachable code: IL_00c0
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				XtjYOnfWvLbF6gJrD9EL(Config, fileName);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				Config.Save();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				Contract.ArgumentNotNull(fileName, (string)mWcAqDfB5JH4VeXQw5BG(-234299632 ^ -234315510));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			default:
				if (!jSdbbnfWCGAs3iS1voOc(fileName, Config.FilePath, StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 2;
					break;
				}
				goto case 3;
			case 5:
				EnsureDirectoryExists(fileName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static void EnsureDirectoryExists(object fileName)
	{
		//Discarded unreachable code: IL_0075, IL_0096, IL_00a5
		int num = 5;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				text = (string)vMyyp4fW8ioSjHwC9wZW(fileName);
				num2 = 4;
				break;
			default:
				if (BMXXWVfWZmBEdgbuKn8Z(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 1:
				return;
			case 2:
				Directory.CreateDirectory(text);
				num2 = 6;
				break;
			case 3:
				return;
			case 4:
				if (text == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 6:
				return;
			}
		}
	}

	internal static void xuHWUefBgJPq9iTHcJca()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool UsMqGJfBluBOKgYuur1t()
	{
		return IbOBQ5fBdeOXSb5TL0jC == null;
	}

	internal static RuntimeConfiguration vlGAqHfBrrj9JlFPyJGg()
	{
		return IbOBQ5fBdeOXSb5TL0jC;
	}

	internal static object mWcAqDfB5JH4VeXQw5BG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void fiv40kfBjx3vZOLHE4J9(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object LHk6AAfBYxnWkDd9mvkb(object P_0)
	{
		return Path.GetExtension((string)P_0);
	}

	internal static bool tBLCrUfBLO5S0koxwdZ6(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object GjGXY1fBUYG2vqBXqVLk(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void UnmXDgfBsyiLJ2jZBDxw(object P_0)
	{
		CreateEmptyConfig(P_0);
	}

	internal static object dRxb7bfBc2jW6AYHg6aL(object P_0)
	{
		return GetExeFile(P_0);
	}

	internal static object WJ9JRIfBzJsYwB6hcVqO(object P_0)
	{
		return ConfigurationManager.OpenExeConfiguration((string)P_0);
	}

	internal static bool CO8crifWFDgNRkJCjNHf(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object Q3dbvufWBupJ6Lv1bdR7(object P_0)
	{
		return string.Intern((string)P_0);
	}

	internal static void dBmuCEfWWmqxQqquamBr(object P_0)
	{
		EnsureDirectoryExists(P_0);
	}

	internal static object GuBcD1fWotsutrdtglv1(object P_0)
	{
		return File.Create((string)P_0);
	}

	internal static object tQXOLRfWbFQbEAl7h7dR()
	{
		return Resources.Configuration;
	}

	internal static void G1q5nffWhnYJlZK3GjgH(object P_0, object P_1)
	{
		((TextWriter)P_0).Write((string)P_1);
	}

	internal static void jj1MGPfWGGWAu1LBZU7t(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void jqBVaFfWEy5UZpnuWiAS(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object NDvfVpfWffXhErP3S6Pe(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static void XRJMKIfWQsKmmJFgcqGb(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static bool jSdbbnfWCGAs3iS1voOc(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static void XtjYOnfWvLbF6gJrD9EL(object P_0, object P_1)
	{
		((System.Configuration.Configuration)P_0).SaveAs((string)P_1);
	}

	internal static object vMyyp4fW8ioSjHwC9wZW(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static bool BMXXWVfWZmBEdgbuKn8Z(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object gsm9qXfWudwqnfnXlLwS(object P_0)
	{
		return ((System.Configuration.Configuration)P_0).Sections;
	}

	internal static object X2b0eSfWI1d3qXwg2UGm(object P_0)
	{
		return ((ConfigurationSection)P_0).SectionInformation;
	}

	internal static void nK7W7kfWVEMB2RfxED5Q(object P_0, object P_1)
	{
		((ConfigurationSectionCollection)P_0).Remove((string)P_1);
	}

	internal static void EE1MV7fWSaLbhTYV0bO9(object P_0, object P_1, object P_2)
	{
		((ConfigurationSectionCollection)P_0).Add((string)P_1, (ConfigurationSection)P_2);
	}
}
