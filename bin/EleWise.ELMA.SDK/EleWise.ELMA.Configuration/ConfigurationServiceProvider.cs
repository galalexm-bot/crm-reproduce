using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Remoting;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

internal class ConfigurationServiceProvider : EternalRefObject
{
	[Component(Type = ComponentType.WebServer)]
	internal class RemotingRegistrar : IModuleContainerEvents
	{
		internal static RemotingRegistrar Jlbn9n89ELLqyg74PUIi;

		public void Activated()
		{
			Register();
		}

		public void Terminating()
		{
		}

		public RemotingRegistrar()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			JqiLru89CCUvKdGZ4yWp();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void JqiLru89CCUvKdGZ4yWp()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool ulu3kE89f9xA5PvhVxCL()
		{
			return Jlbn9n89ELLqyg74PUIi == null;
		}

		internal static RemotingRegistrar x4oEae89QuUqkYtQfugh()
		{
			return Jlbn9n89ELLqyg74PUIi;
		}
	}

	public const string RemotingServiceName = "ConfigurationServiceProvider.asmx";

	private List<EternalRefObject> services;

	private static bool registering;

	internal static ConfigurationServiceProvider Wmx0l6fF5ECKnEOw8Ff8;

	public int Count => qM1UXrfBEsIUcm8w2QT8(services);

	public static void Register()
	{
		//Discarded unreachable code: IL_00fb, IL_01c7, IL_01e8, IL_01f7, IL_026f, IL_027e, IL_03a0, IL_03b3, IL_03c2
		int num = 1;
		bool flag = default(bool);
		int num5 = default(int);
		string text = default(string);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					return;
				case 1:
					if (registering)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					try
					{
						CommonSettingsModule serviceNotNull = Locator.GetServiceNotNull<CommonSettingsModule>();
						int num3 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num3 = 20;
						}
						while (true)
						{
							int num6;
							switch (num3)
							{
							case 1:
								return;
							case 9:
								return;
							case 18:
								flag = RemotingServiceRegistrar.Register<ConfigurationServiceProvider>(num5, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811829364), text);
								num3 = 10;
								break;
							case 21:
								if (!VCrNEUfFz9l9jXHVgWU8(GFkFiufFcc8JxqZudVKm(serviceNotNull.Settings)))
								{
									num6 = 11;
									goto IL_0088;
								}
								goto case 8;
							case 15:
								if (y0yM0OfFsOyJX32Tl7o1(serviceNotNull.Settings))
								{
									num3 = 21;
									break;
								}
								goto case 8;
							case 2:
								if (DcAPlufBWHu2gPYZ36MO(U7OgycfBoEFucvgGRpxf(text), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D8396)))
								{
									num3 = 16;
									break;
								}
								goto case 8;
							case 11:
								text = (string)jFU0vkfBF5RfWBnvM5HI(new Uri(serviceNotNull.Settings.ApplicationBaseUrl, UriKind.RelativeOrAbsolute));
								num3 = 4;
								break;
							case 7:
							case 12:
								if (num4 <= 0)
								{
									return;
								}
								num3 = 14;
								break;
							case 13:
								num4 = uOFENmfFUeH7ciPvvQRT(serviceNotNull.Settings);
								num3 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
								{
									num3 = 12;
								}
								break;
							case 5:
								if (num5 > 65000)
								{
									num6 = 9;
									goto IL_0088;
								}
								goto case 18;
							case 19:
								if (DcAPlufBWHu2gPYZ36MO(text, KK5b0qfBBHkJPmxqPoDx(0x4EA5403C ^ 0x4EA5173E)))
								{
									num3 = 6;
									break;
								}
								goto case 2;
							case 3:
								num5++;
								num3 = 22;
								break;
							case 10:
								if (!flag)
								{
									num3 = 3;
									break;
								}
								goto case 17;
							case 6:
							case 16:
								text = null;
								num3 = 8;
								break;
							case 8:
								flag = false;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
								{
									num3 = 0;
								}
								break;
							case 14:
								text = null;
								num3 = 15;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
								{
									num3 = 1;
								}
								break;
							case 17:
							case 22:
								if (flag)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
									{
										num3 = 1;
									}
									break;
								}
								goto case 5;
							case 4:
								if (text != null)
								{
									num3 = 19;
									break;
								}
								goto case 8;
							case 23:
								if (num4 > 0)
								{
									num3 = 7;
									break;
								}
								goto case 13;
							default:
								num5 = num4;
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
								{
									num3 = 17;
								}
								break;
							case 20:
								{
									num4 = pjgTdMfFL4KrcAoMDwtR(serviceNotNull.Settings);
									num3 = 23;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
									{
										num3 = 11;
									}
									break;
								}
								IL_0088:
								num3 = num6;
								break;
							}
						}
					}
					finally
					{
						registering = false;
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
				}
				break;
			}
			registering = true;
			num = 3;
		}
	}

	public ConfigurationServiceProvider()
	{
		//Discarded unreachable code: IL_003a, IL_003f, IL_007a, IL_0089, IL_0094, IL_00e6, IL_016a, IL_01a2, IL_01b1
		Nb6bJjfBbHNvuU7LNqdT();
		services = new List<EternalRefObject>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
		{
			num = 1;
		}
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		EternalRefObject eternalRefObject = default(EternalRefObject);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_010d:
						int num2;
						if (!XoQ9SDfBGVhyGwCtq8en(enumerator))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
							{
								num2 = 5;
							}
							goto IL_0098;
						}
						goto IL_00f0;
						IL_00f0:
						eternalRefObject = Locator.GetService(enumerator.Current) as EternalRefObject;
						num2 = 3;
						goto IL_0098;
						IL_0098:
						while (true)
						{
							switch (num2)
							{
							case 4:
								services.Add(eternalRefObject);
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
								{
									num2 = 0;
								}
								continue;
							case 1:
								break;
							default:
								goto IL_010d;
							case 3:
								if (eternalRefObject == null)
								{
									num2 = 2;
									continue;
								}
								goto case 4;
							case 5:
								return;
							}
							break;
						}
						goto IL_00f0;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								enumerator.Dispose();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
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
				}
			case 0:
				return;
			}
			enumerator = ((ComponentManager)BD4lJvfBhlXqqJ3ChFbT()).GetExtensionPointTypes<IConfigurationService>().GetEnumerator();
			num = 2;
		}
	}

	public RemoteServiceInfo Get(int index)
	{
		return GetItem(index);
	}

	public RemoteServiceInfo GetItem(int index)
	{
		//Discarded unreachable code: IL_006a, IL_0079, IL_0088
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (index < 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 2:
			case 4:
				return null;
			default:
				return new RemoteServiceInfo(services[index]);
			case 1:
				if (index < qM1UXrfBEsIUcm8w2QT8(services))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public byte[] ResolveAssembly(string assemblyName, bool isFullName)
	{
		//Discarded unreachable code: IL_0078, IL_0087, IL_0168, IL_0189, IL_0198
		int num = 9;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		Assembly assembly = default(Assembly);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass8_.assemblyName = assemblyName;
					num2 = 6;
					continue;
				case 11:
					return (byte[])aUXN1cfBvaJeSyp3Qs2l(enL0V1fBQosh8XNiBGBW(assembly));
				case 1:
				case 10:
					return ComponentManager.GetLoadedAssemblyRaw(assembly);
				case 5:
					if (!string.IsNullOrEmpty(assembly.Location))
					{
						num = 4;
						break;
					}
					goto case 1;
				case 4:
					if (!bURk4hfBCESiAcuEn4r1(enL0V1fBQosh8XNiBGBW(assembly)))
					{
						num = 10;
						break;
					}
					goto case 11;
				case 6:
					assembly = ((IEnumerable<Assembly>)x7TSDSfBf6FAUos7Ral1()).FirstOrDefault(_003C_003Ec__DisplayClass8_._003CResolveAssembly_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 8;
					continue;
				case 2:
					return null;
				case 7:
					if (assembly.IsDynamic)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				default:
					if (!(assembly == null))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 2;
				case 8:
					_003C_003Ec__DisplayClass8_.isFullName = isFullName;
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	internal static int pjgTdMfFL4KrcAoMDwtR(object P_0)
	{
		return ((CommonSettings)P_0).GetRealRemotingPort();
	}

	internal static int uOFENmfFUeH7ciPvvQRT(object P_0)
	{
		return ((CommonSettings)P_0).RemotingPort;
	}

	internal static bool y0yM0OfFsOyJX32Tl7o1(object P_0)
	{
		return ((CommonSettings)P_0).UseBaseUrlForRemoting;
	}

	internal static object GFkFiufFcc8JxqZudVKm(object P_0)
	{
		return ((CommonSettings)P_0).ApplicationBaseUrl;
	}

	internal static bool VCrNEUfFz9l9jXHVgWU8(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object jFU0vkfBF5RfWBnvM5HI(object P_0)
	{
		return ((Uri)P_0).Host;
	}

	internal static object KK5b0qfBBHkJPmxqPoDx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool DcAPlufBWHu2gPYZ36MO(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object U7OgycfBoEFucvgGRpxf(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static bool Sdq0V7fFjHZeGQrOKRs1()
	{
		return Wmx0l6fF5ECKnEOw8Ff8 == null;
	}

	internal static ConfigurationServiceProvider BOyR6jfFY4L1T9KrGdiM()
	{
		return Wmx0l6fF5ECKnEOw8Ff8;
	}

	internal static void Nb6bJjfBbHNvuU7LNqdT()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object BD4lJvfBhlXqqJ3ChFbT()
	{
		return ComponentManager.Current;
	}

	internal static bool XoQ9SDfBGVhyGwCtq8en(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static int qM1UXrfBEsIUcm8w2QT8(object P_0)
	{
		return ((List<EternalRefObject>)P_0).Count;
	}

	internal static object x7TSDSfBf6FAUos7Ral1()
	{
		return ComponentManager.GetAssemblies();
	}

	internal static object enL0V1fBQosh8XNiBGBW(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static bool bURk4hfBCESiAcuEn4r1(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object aUXN1cfBvaJeSyp3Qs2l(object P_0)
	{
		return File.ReadAllBytes((string)P_0);
	}
}
