using System;
using System.Collections;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization.Formatters;
using EleWise.ELMA.Remoting.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Remoting;

public static class RemotingConfigurator
{
	private static bool remotingClientConfigured;

	internal static HttpChannel clientChannel;

	internal static Func<bool> ShowLoginDialog;

	internal static RemotingConfigurator yniP6qTL1I0dhBZnGBZ;

	public static void ConfigureRemotingClient()
	{
		int num = 1;
		int num2 = num;
		BinaryClientFormatterSinkProvider binaryClientFormatterSinkProvider = default(BinaryClientFormatterSinkProvider);
		ClientChannelSinkProvider clientChannelSinkProvider = default(ClientChannelSinkProvider);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				binaryClientFormatterSinkProvider = new BinaryClientFormatterSinkProvider();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				SHomAQTcdbP3pjA1irE(binaryClientFormatterSinkProvider, clientChannelSinkProvider);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				UrWuIVkBEGB5PS4PwWY(clientChannel, false);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				if (remotingClientConfigured)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				}
				remotingClientConfigured = true;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				return;
			case 3:
			{
				Hashtable obj = new Hashtable { [(object)z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870889439)] = XPsVOSTz7LhReREq1K9(0x7C1EE318 ^ 0x7C1E8746) };
				twNn56kF10GN8SxU1ga(obj, XPsVOSTz7LhReREq1K9(-1876063057 ^ -1876039645), 0);
				twNn56kF10GN8SxU1ga(obj, XPsVOSTz7LhReREq1K9(-1867198571 ^ -1867207923), "");
				((IDictionary)obj)[(object)z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477165194)] = "";
				clientChannel = new HttpChannel(obj, binaryClientFormatterSinkProvider, null);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 0:
				return;
			case 5:
				clientChannelSinkProvider = new ClientChannelSinkProvider();
				num2 = 7;
				break;
			}
		}
	}

	internal static void ReConfigureRemotingClient()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					zYd7BGkW22daKkHKLLB(clientChannel);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return;
				case 1:
					remotingClientConfigured = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (clientChannel != null)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				}
				break;
			}
			JcOHjdko5bNAw8YLGYE();
			num = 4;
		}
	}

	public static IChannel ConfigureRemotingServer(string channelName, int port, string host)
	{
		//Discarded unreachable code: IL_004d
		int num = 10;
		int num2 = num;
		IDictionary dictionary = default(IDictionary);
		BinaryServerFormatterSinkProvider binaryServerFormatterSinkProvider = default(BinaryServerFormatterSinkProvider);
		ServerChannelSinkProvider serverChannelSinkProvider = default(ServerChannelSinkProvider);
		while (true)
		{
			switch (num2)
			{
			case 2:
				twNn56kF10GN8SxU1ga(dictionary, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107987822), port);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 3;
				}
				break;
			case 9:
				binaryServerFormatterSinkProvider = new BinaryServerFormatterSinkProvider();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				pUsCX2khwKuYxKYpGrA(serverChannelSinkProvider, binaryServerFormatterSinkProvider);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				twNn56kF10GN8SxU1ga(dictionary, XPsVOSTz7LhReREq1K9(-1876063057 ^ -1876066119), channelName);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				dictionary[XPsVOSTz7LhReREq1K9(-234299632 ^ -234308656)] = host;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (string.IsNullOrEmpty(host))
				{
					num2 = 4;
					break;
				}
				goto case 8;
			case 5:
				dictionary = new Hashtable();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 6;
				}
				break;
			case 10:
				serverChannelSinkProvider = new ServerChannelSinkProvider();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 9;
				}
				break;
			default:
			{
				HttpChannel httpChannel = new HttpChannel(dictionary, null, serverChannelSinkProvider);
				ChannelServices.RegisterChannel(httpChannel, ensureSecurity: false);
				return httpChannel;
			}
			case 1:
				DpYmYLkbY5dm9b18OED(binaryServerFormatterSinkProvider, TypeFilterLevel.Full);
				num2 = 7;
				break;
			}
		}
	}

	static RemotingConfigurator()
	{
		xiMySskGwy8veaFcbhI();
	}

	internal static void SHomAQTcdbP3pjA1irE(object P_0, object P_1)
	{
		((BinaryClientFormatterSinkProvider)P_0).Next = (IClientChannelSinkProvider)P_1;
	}

	internal static object XPsVOSTz7LhReREq1K9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void twNn56kF10GN8SxU1ga(object P_0, object P_1, object P_2)
	{
		((IDictionary)P_0)[P_1] = P_2;
	}

	internal static void UrWuIVkBEGB5PS4PwWY(object P_0, bool P_1)
	{
		ChannelServices.RegisterChannel((IChannel)P_0, P_1);
	}

	internal static bool Lew76UTUrgdu3vJwC5K()
	{
		return yniP6qTL1I0dhBZnGBZ == null;
	}

	internal static RemotingConfigurator rkPVcFTsvIMa7XGpX7X()
	{
		return yniP6qTL1I0dhBZnGBZ;
	}

	internal static void zYd7BGkW22daKkHKLLB(object P_0)
	{
		ChannelServices.UnregisterChannel((IChannel)P_0);
	}

	internal static void JcOHjdko5bNAw8YLGYE()
	{
		ConfigureRemotingClient();
	}

	internal static void DpYmYLkbY5dm9b18OED(object P_0, TypeFilterLevel P_1)
	{
		((BinaryServerFormatterSinkProvider)P_0).TypeFilterLevel = P_1;
	}

	internal static void pUsCX2khwKuYxKYpGrA(object P_0, object P_1)
	{
		((ServerChannelSinkProvider)P_0).Next = (IServerChannelSinkProvider)P_1;
	}

	internal static void xiMySskGwy8veaFcbhI()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
