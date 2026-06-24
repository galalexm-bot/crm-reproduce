using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Authentication;
using System.Text;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Remoting.Security;

internal class ClientChannelSink : BaseChannelObjectWithProperties, IClientChannelSink, IChannelSinkBase
{
	public static long totalBytes;

	private string _url;

	private IClientChannelSink _nextSink;

	private static ClientChannelSink unmbWxkapDUsEAMfg3r;

	public IClientChannelSink NextChannelSink => _nextSink;

	public ClientChannelSink(string url, IClientChannelSink nextSink)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pslDn8kwDYcFKLqnXDF();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				_nextSink = nextSink;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				_url = url;
				num = 2;
				break;
			}
		}
	}

	public ClientChannelSink(IChannelSender channel, string url, object remoteChannelData, IClientChannelSink nextSink)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pslDn8kwDYcFKLqnXDF();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_nextSink = nextSink;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void ProcessMessage(IMessage msg, ITransportHeaders requestHeaders, Stream requestStream, out ITransportHeaders responseHeaders, out Stream responseStream)
	{
		//Discarded unreachable code: IL_00f1, IL_0143, IL_01d4, IL_0220, IL_0254, IL_0263, IL_02a0, IL_02af, IL_0419, IL_05d4, IL_05e3, IL_05f2, IL_06bb, IL_06ca
		int num = 37;
		string text = default(string);
		string text2 = default(string);
		CultureInfo currentCulture = default(CultureInfo);
		long result = default(long);
		RemotingClientSecurityContext current = default(RemotingClientSecurityContext);
		IMethodMessage methodMessage = default(IMethodMessage);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 14:
					if (!DETKICkjQHnR0Es8bvH(text))
					{
						num2 = 35;
						break;
					}
					goto case 10;
				case 31:
					throw new SecurityException(text);
				case 23:
					if (GDNSeWksIgMDYmfCRdS(text2, BfNObdkUeUcwndoee8X(vCRkTqkcmM6ZTF7mhAe(typeof(IncompatibleVersionException).TypeHandle))))
					{
						num2 = 18;
						break;
					}
					if (!GDNSeWksIgMDYmfCRdS(text2, BfNObdkUeUcwndoee8X(typeof(RequireChangePasswordException))))
					{
						num2 = 8;
						break;
					}
					goto case 46;
				case 15:
					currentCulture = SR.GetCurrentCulture();
					num2 = 34;
					break;
				case 4:
				case 32:
					_nextSink.ProcessMessage(msg, requestHeaders, requestStream, out responseHeaders, out responseStream);
					num2 = 2;
					break;
				case 49:
					if (long.TryParse(EIQMKFk53h8RQ0MyrFA(responseHeaders, Q7pRrlkHbQbenn1h1HL(0x61EC0CB8 ^ 0x61EC6B8A)).ToString(), out result))
					{
						num2 = 40;
						break;
					}
					goto case 48;
				case 36:
					responseStream = null;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 27;
					}
					break;
				case 9:
					P5OJ6uk7SRf6bYcjymr(requestHeaders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC73EB), ((string)CPApWFkmSoMTxV031eu(current)).ToBase64String());
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 19;
					}
					break;
				case 22:
					if (GDNSeWksIgMDYmfCRdS(text2, BfNObdkUeUcwndoee8X(typeof(AuthenticationException))))
					{
						num2 = 45;
						break;
					}
					if (!GDNSeWksIgMDYmfCRdS(text2, BfNObdkUeUcwndoee8X(typeof(SecurityException))))
					{
						num2 = 23;
						break;
					}
					goto case 31;
				case 18:
					throw new IncompatibleVersionException(text);
				case 13:
				case 19:
				case 25:
					methodMessage = msg as IMethodMessage;
					num2 = 24;
					break;
				case 17:
				case 38:
					current = RemotingClientSecurityContext.Current;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					break;
				case 39:
					P5OJ6uk7SRf6bYcjymr(requestHeaders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210700903), l67iefkAJXxIjbNlNce(currentCulture));
					num2 = 17;
					break;
				case 0:
					return;
				case 7:
					if (Uq4Pgck04JerQpgUvO1(hPa9hvkxwMFSSuu5ee8(current), Guid.Empty))
					{
						goto end_IL_0012;
					}
					goto case 30;
				case 24:
					if (!p947KGkynelKAqowUjD(Logger.Log))
					{
						num2 = 4;
						break;
					}
					goto case 11;
				case 1:
					if (current == null)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 7;
				case 47:
					if (DETKICkjQHnR0Es8bvH(text))
					{
						num2 = 29;
						break;
					}
					goto case 22;
				case 16:
					result = 0L;
					num2 = 43;
					break;
				case 34:
					if (currentCulture == null)
					{
						num2 = 38;
						break;
					}
					goto case 39;
				case 42:
					text = (string)EIQMKFk53h8RQ0MyrFA(responseHeaders, Q7pRrlkHbQbenn1h1HL(-882126494 ^ -882133314));
					num2 = 14;
					break;
				case 10:
					if (!DETKICkjQHnR0Es8bvH(text2))
					{
						num2 = 47;
						break;
					}
					goto case 29;
				case 2:
					if (p947KGkynelKAqowUjD(Logger.Log))
					{
						num2 = 41;
						break;
					}
					goto case 33;
				case 6:
					if (!t878mfk6GLDUWgeuEfR())
					{
						num2 = 44;
						break;
					}
					goto case 28;
				case 35:
					text = ((Encoding)A3l3iDkYoxNkuvF5KNk()).GetString((byte[])EEr2klkLPO5bEPbp33S(text));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 8;
					}
					break;
				case 37:
					responseHeaders = null;
					num2 = 36;
					break;
				case 30:
					requestHeaders[Q7pRrlkHbQbenn1h1HL(-541731959 ^ -541739737)] = current.UserName.ToBase64String();
					num2 = 9;
					break;
				case 45:
					throw new AuthenticationException(text);
				case 33:
					text2 = (string)EIQMKFk53h8RQ0MyrFA(responseHeaders, Q7pRrlkHbQbenn1h1HL(0x4D1C1EE4 ^ 0x4D1C7948));
					num2 = 42;
					break;
				case 41:
					if (methodMessage != null)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 33;
				case 48:
					result = 0L;
					num2 = 26;
					break;
				case 20:
					requestHeaders[Q7pRrlkHbQbenn1h1HL(-2107978722 ^ -2107987312)] = current.Token.ToString();
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 2;
					}
					break;
				case 43:
					if (EIQMKFk53h8RQ0MyrFA(responseHeaders, Q7pRrlkHbQbenn1h1HL(-889460160 ^ -889483918)) == null)
					{
						num2 = 51;
						break;
					}
					goto case 49;
				case 27:
					if (!L0f3Cok4kioUEnnlbRc())
					{
						num2 = 28;
						break;
					}
					goto case 6;
				case 12:
					if (!(current.Token == Guid.Empty))
					{
						num2 = 3;
						break;
					}
					goto case 50;
				case 11:
					if (methodMessage != null)
					{
						num2 = 21;
						break;
					}
					goto case 4;
				case 46:
					throw new RequireChangePasswordException();
				case 8:
					throw new Exception(SR.T((string)Q7pRrlkHbQbenn1h1HL(-2107978722 ^ -2107988980)) + (string)Q7pRrlkHbQbenn1h1HL(-1108654032 ^ -1108664220) + text);
				case 29:
					if (!(hPa9hvkxwMFSSuu5ee8(current) == Guid.Empty))
					{
						return;
					}
					num2 = 5;
					break;
				case 44:
					throw new InvalidOperationException(SR.T((string)Q7pRrlkHbQbenn1h1HL(0x7247028A ^ 0x72476484)));
				case 28:
					requestHeaders[Q7pRrlkHbQbenn1h1HL(0x6DC147B0 ^ 0x6DC12186)] = VersionInfo.GetVersion<SR>().ToString();
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 1;
					}
					break;
				case 21:
					rFCopBkgKHNAt6KYjlT(vbShGckMuZd380wfdFS(), zflCTJkrJWkuUlgakgN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EC563), S6HjCvkJQyKluRygFH5(methodMessage), (rlERm2k9y7iqn6tkynM(methodMessage) != null && methodMessage.Args.Length != 0) ? Vwjx2iklGWfHJ760vHt(Q7pRrlkHbQbenn1h1HL(0x2A7797B7 ^ 0x2A77F09D), KYxuplkdknbVmBwoVwm(Q7pRrlkHbQbenn1h1HL(-951514650 ^ -951515676), rlERm2k9y7iqn6tkynM(methodMessage)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29261089)) : ""));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 32;
					}
					break;
				case 26:
				case 40:
				case 51:
					rFCopBkgKHNAt6KYjlT(vbShGckMuZd380wfdFS(), zflCTJkrJWkuUlgakgN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42645551), methodMessage.MethodBase, (result > 0) ? zflCTJkrJWkuUlgakgN(Q7pRrlkHbQbenn1h1HL(0x307E9FD1 ^ 0x307EF8AF), result, Q7pRrlkHbQbenn1h1HL(-2112703338 ^ -2112695540)) : ""));
					num2 = 33;
					break;
				case 5:
					current.Token = ((EIQMKFk53h8RQ0MyrFA(responseHeaders, Q7pRrlkHbQbenn1h1HL(-1998538950 ^ -1998532172)) != null) ? new Guid((string)EIQMKFk53h8RQ0MyrFA(responseHeaders, Q7pRrlkHbQbenn1h1HL(-1751176224 ^ -1751167634))) : Guid.Empty);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 12;
					}
					break;
				case 50:
					throw new AuthenticationException((string)ODgq60kz9CxjIRSnixQ(Q7pRrlkHbQbenn1h1HL(-29254301 ^ -29231809)));
				case 3:
					JGLxVhnF2gvbMq2Ckij(current, (responseHeaders[Q7pRrlkHbQbenn1h1HL(0x12A5FAC7 ^ 0x12A59217)] != null) ? long.Parse((string)responseHeaders[Q7pRrlkHbQbenn1h1HL(-488881205 ^ -488887525)]) : 0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 20;
		}
	}

	public void AsyncProcessRequest(IClientChannelSinkStack sinkStack, IMessage msg, ITransportHeaders headers, Stream stream)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				dCopDnnBFEx1qw2569X(sinkStack, this, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_nextSink.AsyncProcessRequest(sinkStack, msg, headers, stream);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, Stream stream)
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
				eaZpttnW8Zv8oYBB6M6(sinkStack, headers, stream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Stream GetRequestStream(IMessage msg, ITransportHeaders headers)
	{
		return null;
	}

	internal static void pslDn8kwDYcFKLqnXDF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sJEmtckD5u42kFCPiDi()
	{
		return unmbWxkapDUsEAMfg3r == null;
	}

	internal static ClientChannelSink i7isQWktFjve0VXGX4w()
	{
		return unmbWxkapDUsEAMfg3r;
	}

	internal static bool L0f3Cok4kioUEnnlbRc()
	{
		return RemotingClientParameters.IsDebugging;
	}

	internal static bool t878mfk6GLDUWgeuEfR()
	{
		return RemotingClientParameters.TryStopDebugging();
	}

	internal static object Q7pRrlkHbQbenn1h1HL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object l67iefkAJXxIjbNlNce(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static void P5OJ6uk7SRf6bYcjymr(object P_0, object P_1, object P_2)
	{
		((ITransportHeaders)P_0)[P_1] = P_2;
	}

	internal static Guid hPa9hvkxwMFSSuu5ee8(object P_0)
	{
		return ((RemotingClientSecurityContext)P_0).Token;
	}

	internal static bool Uq4Pgck04JerQpgUvO1(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object CPApWFkmSoMTxV031eu(object P_0)
	{
		return ((RemotingClientSecurityContext)P_0).Password;
	}

	internal static bool p947KGkynelKAqowUjD(object P_0)
	{
		return ((ILogger)P_0).IsDebugEnabled();
	}

	internal static object vbShGckMuZd380wfdFS()
	{
		return Logger.Log;
	}

	internal static object S6HjCvkJQyKluRygFH5(object P_0)
	{
		return ((IMethodMessage)P_0).MethodBase;
	}

	internal static object rlERm2k9y7iqn6tkynM(object P_0)
	{
		return ((IMethodMessage)P_0).Args;
	}

	internal static object KYxuplkdknbVmBwoVwm(object P_0, object P_1)
	{
		return string.Join((string)P_0, (object[])P_1);
	}

	internal static object Vwjx2iklGWfHJ760vHt(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object zflCTJkrJWkuUlgakgN(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static void rFCopBkgKHNAt6KYjlT(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static object EIQMKFk53h8RQ0MyrFA(object P_0, object P_1)
	{
		return ((ITransportHeaders)P_0)[P_1];
	}

	internal static bool DETKICkjQHnR0Es8bvH(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object A3l3iDkYoxNkuvF5KNk()
	{
		return Encoding.UTF8;
	}

	internal static object EEr2klkLPO5bEPbp33S(object P_0)
	{
		return Convert.FromBase64String((string)P_0);
	}

	internal static object BfNObdkUeUcwndoee8X(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool GDNSeWksIgMDYmfCRdS(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Type vCRkTqkcmM6ZTF7mhAe(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object ODgq60kz9CxjIRSnixQ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void JGLxVhnF2gvbMq2Ckij(object P_0, long value)
	{
		((RemotingClientSecurityContext)P_0).UserId = value;
	}

	internal static void dCopDnnBFEx1qw2569X(object P_0, object P_1, object P_2)
	{
		((IClientChannelSinkStack)P_0).Push((IClientChannelSink)P_1, P_2);
	}

	internal static void eaZpttnW8Zv8oYBB6M6(object P_0, object P_1, object P_2)
	{
		((IClientResponseChannelSinkStack)P_0).AsyncProcessResponse((ITransportHeaders)P_1, (Stream)P_2);
	}
}
