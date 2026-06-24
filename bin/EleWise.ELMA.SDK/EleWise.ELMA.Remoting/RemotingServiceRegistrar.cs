using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Remoting;

public static class RemotingServiceRegistrar
{
	private class ConfiguredInfo
	{
		private static object DdsdLNf0lTTRd1P6MJdk;

		public Type ServiceType
		{
			[CompilerGenerated]
			get
			{
				return _003CServiceType_003Ek__BackingField;
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
					case 1:
						_003CServiceType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
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

		public int Port
		{
			[CompilerGenerated]
			get
			{
				return _003CPort_003Ek__BackingField;
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
					case 1:
						_003CPort_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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

		public string ServiceName
		{
			[CompilerGenerated]
			get
			{
				return _003CServiceName_003Ek__BackingField;
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
					case 1:
						_003CServiceName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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

		public IChannel Channel
		{
			[CompilerGenerated]
			get
			{
				return _003CChannel_003Ek__BackingField;
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
					case 1:
						_003CChannel_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
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

		public string Host
		{
			[CompilerGenerated]
			get
			{
				return _003CHost_003Ek__BackingField;
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
						_003CHost_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfiguredInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
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

		internal static bool m17BTGf0rXTJXjdIsZTp()
		{
			return DdsdLNf0lTTRd1P6MJdk == null;
		}

		internal static ConfiguredInfo mVRLhcf0g9L8ad9AltF8()
		{
			return (ConfiguredInfo)DdsdLNf0lTTRd1P6MJdk;
		}
	}

	private static bool remotingRegistered;

	private static Dictionary<Type, ConfiguredInfo> configuredInfos;

	internal static RemotingServiceRegistrar eV0MeokEQyHPujk3uDa;

	public static int GetRegisterdPort<TService>()
	{
		return GetRegisterdPort(typeof(TService));
	}

	public static int GetRegisterdPort(Type serviceType)
	{
		//Discarded unreachable code: IL_003b, IL_004a
		int num = 3;
		int num2 = num;
		ConfiguredInfo value = default(ConfiguredInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return SmgxQBk88iNuqvfri3K(value);
			default:
				return -1;
			case 3:
				AKLnVmkvUQKQ3Sl9dPH(serviceType, HV2CuhkCxDC5BCRMc8e(0x269E5FCA ^ 0x269E3B10));
				num2 = 2;
				break;
			case 2:
				if (!configuredInfos.TryGetValue(serviceType, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public static bool Register<TService>(int port, string serviceName, string host) where TService : MarshalByRefObject
	{
		return Register(typeof(TService), port, serviceName, host);
	}

	public static bool Register(Type serviceType, int port, string serviceName, string host)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_0190, IL_019f, IL_01ea, IL_0236, IL_0245, IL_033f, IL_034e, IL_039a, IL_0402
		int num = 1;
		int num2 = num;
		ConfiguredInfo value = default(ConfiguredInfo);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 10:
				if (!((string)aaDLYnkZnEYnQI2XeKM(value) == serviceName))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 8;
			case 1:
				AKLnVmkvUQKQ3Sl9dPH(serviceType, HV2CuhkCxDC5BCRMc8e(0x7EC153F ^ 0x7EC71E5));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				Contract.CheckArgument(typeof(MarshalByRefObject).IsAssignableFrom(serviceType), (string)HV2CuhkCxDC5BCRMc8e(-2106517564 ^ -2106494160));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 2;
				}
				continue;
			case 9:
				return result;
			case 7:
				if (SmgxQBk88iNuqvfri3K(value) == port)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 10;
					}
					continue;
				}
				goto case 3;
			case 8:
				if (!(value.Host == host))
				{
					num2 = 4;
					continue;
				}
				goto case 6;
			case 2:
				if (configuredInfos.TryGetValue(serviceType, out value))
				{
					num2 = 7;
					continue;
				}
				break;
			case 6:
				return true;
			case 3:
			case 4:
				Unregister(value);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 10;
				}
				continue;
			case 5:
				try
				{
					IChannel channel = (IChannel)TKKNACkI7CJR4LWKymY(pufqIQkubMhpK4tSeo6(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBD056), serviceName), port, host);
					int num3 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 10:
							return result;
						default:
							result = true;
							num3 = 10;
							continue;
						case 7:
						case 9:
						{
							Dictionary<Type, ConfiguredInfo> dictionary = configuredInfos;
							ConfiguredInfo obj = new ConfiguredInfo
							{
								ServiceType = serviceType
							};
							ysJGXPki9xvwKoQt0f8(obj, port);
							H2TTCxkRqlql72QICMG(obj, serviceName);
							XMAfWjkqoMdeaXVxh57(obj, channel);
							dictionary[serviceType] = obj;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num3 = 0;
							}
							continue;
						}
						case 3:
							if (!tm1iaakSLda5YbMWRdp(aaDLYnkZnEYnQI2XeKM(value), serviceName))
							{
								num3 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num3 = 9;
								}
								continue;
							}
							goto case 4;
						case 4:
							RemotingConfiguration.RegisterWellKnownServiceType(serviceType, serviceName, WellKnownObjectMode.Singleton);
							num3 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num3 = 1;
							}
							continue;
						case 5:
							if (remotingRegistered)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							break;
						case 1:
						case 6:
							if (value != null)
							{
								num3 = 3;
								continue;
							}
							goto case 4;
						case 2:
							remotingRegistered = true;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
							{
								num3 = 6;
							}
							continue;
						case 8:
							break;
						}
						b74xcXkVyHX2IXYt6CH(CustomErrorsModes.Off);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num3 = 2;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							zUj18KkKHjiH8SjBYW0(Logger.Log, HV2CuhkCxDC5BCRMc8e(0x12A5FAC7 ^ 0x12A59F53), ex);
							num4 = 2;
							break;
						case 2:
							result = false;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}
			case 11:
				break;
			}
			num2 = 5;
		}
	}

	private static void Unregister(object info)
	{
		//Discarded unreachable code: IL_0056, IL_00c7, IL_0118, IL_0127, IL_0137, IL_0146
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					int num3;
					if (((ConfiguredInfo)info).Channel != null)
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num3 = 1;
						}
						goto IL_005a;
					}
					goto IL_0095;
					IL_0095:
					XMAfWjkqoMdeaXVxh57(info, null);
					num3 = 2;
					goto IL_005a;
					IL_005a:
					while (true)
					{
						switch (num3)
						{
						case 1:
							juFUkEkTRsekFvGsmDv(rTY29XkXnC0OwSIjIw7(info));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							return;
						}
						break;
					}
					goto IL_0095;
				}
				catch (Exception exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							((ILogger)BBOtk5kk6lWJEkxyZOn()).Error(HV2CuhkCxDC5BCRMc8e(0x7247028A ^ 0x7247674C), exception);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			case 2:
				return;
			case 4:
				return;
			default:
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (info == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static RemotingServiceRegistrar()
	{
		int num = 2;
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
				dHVadxknClkK7eLJQPy();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				configuredInfos = new Dictionary<Type, ConfiguredInfo>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object HV2CuhkCxDC5BCRMc8e(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void AKLnVmkvUQKQ3Sl9dPH(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static int SmgxQBk88iNuqvfri3K(object P_0)
	{
		return ((ConfiguredInfo)P_0).Port;
	}

	internal static bool M2RX7ekfAshnjjYve1s()
	{
		return eV0MeokEQyHPujk3uDa == null;
	}

	internal static RemotingServiceRegistrar saEHKUkQy6dcL15eFMG()
	{
		return eV0MeokEQyHPujk3uDa;
	}

	internal static object aaDLYnkZnEYnQI2XeKM(object P_0)
	{
		return ((ConfiguredInfo)P_0).ServiceName;
	}

	internal static object pufqIQkubMhpK4tSeo6(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object TKKNACkI7CJR4LWKymY(object P_0, int port, object P_2)
	{
		return RemotingConfigurator.ConfigureRemotingServer((string)P_0, port, (string)P_2);
	}

	internal static void b74xcXkVyHX2IXYt6CH(CustomErrorsModes P_0)
	{
		RemotingConfiguration.CustomErrorsMode = P_0;
	}

	internal static bool tm1iaakSLda5YbMWRdp(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void ysJGXPki9xvwKoQt0f8(object P_0, int value)
	{
		((ConfiguredInfo)P_0).Port = value;
	}

	internal static void H2TTCxkRqlql72QICMG(object P_0, object P_1)
	{
		((ConfiguredInfo)P_0).ServiceName = (string)P_1;
	}

	internal static void XMAfWjkqoMdeaXVxh57(object P_0, object P_1)
	{
		((ConfiguredInfo)P_0).Channel = (IChannel)P_1;
	}

	internal static void zUj18KkKHjiH8SjBYW0(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object rTY29XkXnC0OwSIjIw7(object P_0)
	{
		return ((ConfiguredInfo)P_0).Channel;
	}

	internal static void juFUkEkTRsekFvGsmDv(object P_0)
	{
		ChannelServices.UnregisterChannel((IChannel)P_0);
	}

	internal static object BBOtk5kk6lWJEkxyZOn()
	{
		return Logger.Log;
	}

	internal static void dHVadxknClkK7eLJQPy()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
