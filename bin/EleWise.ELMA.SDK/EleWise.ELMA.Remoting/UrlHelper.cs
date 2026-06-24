using System;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Remoting;

public static class UrlHelper
{
	internal static UrlHelper kURgcDTtfTY0M7wG9kA;

	public static string GetParameter(string queryString, string parameterName)
	{
		int num = 5;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return (string)xHENaQT0pnnrJYf7Qpf(queryString, num3, num4 - num3);
				case 3:
					num4 = NLdBJFTHK2b34QKRIVS(queryString);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					if (num3 != -1)
					{
						num2 = 8;
						break;
					}
					goto IL_004e;
				case 4:
					if (NLdBJFTHK2b34QKRIVS(queryString) > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_004e;
				case 7:
					num4 = KjBX9STxY6cEDKvmj35(queryString, hmHcxQT7kB8G9XcYImM(0x26FFCB59 ^ 0x26FFAF41), num3);
					num2 = 2;
					break;
				case 5:
					parameterName = (string)AJSrkuT6Y4CpFmCLmsS(parameterName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4785B007));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					if (num4 == -1)
					{
						goto end_IL_0012;
					}
					goto case 1;
				default:
					num3 = BsK3DiTA8J7AeEy5mRJ(queryString, parameterName);
					num2 = 6;
					break;
				case 8:
					{
						num3 += NLdBJFTHK2b34QKRIVS(parameterName);
						num2 = 7;
						break;
					}
					IL_004e:
					return "";
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public static string PrepareUrl(string serverUrl, int? port, string path, string protocol)
	{
		Contract.ArgumentNotNull(serverUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099760311));
		Contract.ArgumentNotNullOrEmpty(serverUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x831102C));
		if (!serverUrl.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106493968)))
		{
			serverUrl = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBD100) + serverUrl;
		}
		UriBuilder uriBuilder = new UriBuilder(serverUrl);
		if (port.HasValue)
		{
			uriBuilder.Port = port.Value;
		}
		if (!string.IsNullOrEmpty(path))
		{
			if (path.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106494060)))
			{
				path = path.Substring(1);
			}
			uriBuilder.Path += path;
		}
		if (!string.IsNullOrWhiteSpace(protocol))
		{
			uriBuilder.Scheme = protocol;
		}
		return uriBuilder.Uri.AbsoluteUri;
	}

	public static string PrepareUrl(string serverUrl, int? port, string path, string protocol, string fragment)
	{
		Contract.ArgumentNotNull(serverUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548BCA94));
		Contract.ArgumentNotNullOrEmpty(serverUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E47AC5));
		if (!serverUrl.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309648504)))
		{
			serverUrl = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87347127) + serverUrl;
		}
		UriBuilder uriBuilder = new UriBuilder(serverUrl);
		if (port.HasValue)
		{
			uriBuilder.Port = port.Value;
		}
		if (!string.IsNullOrEmpty(path))
		{
			path = (path.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939400998)) ? path.Substring(2) : path);
			path = (path.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459581071)) ? path.Substring(1) : path);
			uriBuilder.Path += path;
		}
		if (!string.IsNullOrWhiteSpace(protocol))
		{
			uriBuilder.Scheme = protocol;
		}
		if (!string.IsNullOrWhiteSpace(fragment))
		{
			uriBuilder.Fragment = fragment;
		}
		return uriBuilder.Uri.AbsoluteUri;
	}

	public static string GetHost(string serverUrl)
	{
		//Discarded unreachable code: IL_0059
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				bKtdhuTmkWdnrBBAV6a(serverUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C535CE1));
				num2 = 3;
				break;
			case 3:
				PItmIGTyqWRybjfsprK(serverUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4785D813));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			case 5:
				return (string)TOFmCqTJy9A6Ooxn7Bk(new UriBuilder(serverUrl));
			case 2:
				serverUrl = (string)hmHcxQT7kB8G9XcYImM(--1867379187 ^ 0x6F4D95CD) + serverUrl;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (VdB3rkTMMmw9pCPSW2A(serverUrl, hmHcxQT7kB8G9XcYImM(-1876063057 ^ -1876039525)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static int GetPort(string serverUrl)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				serverUrl = (string)AJSrkuT6Y4CpFmCLmsS(hmHcxQT7kB8G9XcYImM(-1123633026 ^ -1123623872), serverUrl);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (!VdB3rkTMMmw9pCPSW2A(serverUrl, hmHcxQT7kB8G9XcYImM(0x3A6135BE ^ 0x3A61518A)))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 3:
				Contract.ArgumentNotNullOrEmpty(serverUrl, (string)hmHcxQT7kB8G9XcYImM(0x6A81B9B4 ^ 0x6A81DDAA));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return lVqRdiT9pDXb4w6fyIJ(new UriBuilder(serverUrl));
			case 4:
				Contract.ArgumentNotNull(serverUrl, (string)hmHcxQT7kB8G9XcYImM(0x4EA5403C ^ 0x4EA52422));
				num2 = 3;
				break;
			}
		}
	}

	public static string GetUrlWithoutFragment(string url, out string fragment)
	{
		//Discarded unreachable code: IL_00a8, IL_00b7, IL_00e3, IL_00f2
		int num = 6;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					url = (string)K5BD53Trtr7v3ETlwWc(url, num3);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (num3 < 0)
					{
						num2 = 7;
						continue;
					}
					break;
				case 6:
					num3 = qfKcFUTdsp0jPLnPRtL(url, '#');
					num2 = 5;
					continue;
				case 2:
				case 7:
					fragment = null;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 4;
					}
					continue;
				default:
					return url;
				case 1:
					break;
				}
				break;
			}
			fragment = (string)svlbPOTlm94MwR6sVQ4(url, num3 + 1);
			num = 3;
		}
	}

	internal static object AJSrkuT6Y4CpFmCLmsS(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int NLdBJFTHK2b34QKRIVS(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static int BsK3DiTA8J7AeEy5mRJ(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object hmHcxQT7kB8G9XcYImM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int KjBX9STxY6cEDKvmj35(object P_0, object P_1, int P_2)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	internal static object xHENaQT0pnnrJYf7Qpf(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static bool hxlbQNTw0Lp2bqB6MDf()
	{
		return kURgcDTtfTY0M7wG9kA == null;
	}

	internal static UrlHelper UUhImpT4myRVmZDkHYg()
	{
		return kURgcDTtfTY0M7wG9kA;
	}

	internal static void bKtdhuTmkWdnrBBAV6a(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void PItmIGTyqWRybjfsprK(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static bool VdB3rkTMMmw9pCPSW2A(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object TOFmCqTJy9A6Ooxn7Bk(object P_0)
	{
		return ((UriBuilder)P_0).Host;
	}

	internal static int lVqRdiT9pDXb4w6fyIJ(object P_0)
	{
		return ((UriBuilder)P_0).Port;
	}

	internal static int qfKcFUTdsp0jPLnPRtL(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object svlbPOTlm94MwR6sVQ4(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object K5BD53Trtr7v3ETlwWc(object P_0, int P_1)
	{
		return ((string)P_0).Remove(P_1);
	}
}
