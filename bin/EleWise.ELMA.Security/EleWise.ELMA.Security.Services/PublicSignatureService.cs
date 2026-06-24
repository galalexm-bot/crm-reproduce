using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Cryptography;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Web.Service;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services.API;

[Service]
internal sealed class PublicSignatureService : IPublicSignatureService
{
	private readonly IHmacService HmacService;

	private readonly IEcdhService EcdhService;

	private static PublicSignatureService ucZRrfvQrkGFlc0y76h;

	public PublicSignatureService(IHmacService hmacService, IEcdhService ecdhService)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				HmacService = hmacService;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 1:
				EcdhService = ecdhService;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public bool CheckRequestSignature(EleWise.ELMA.API.Models.IPublicClientSession session)
	{
		int num = 4;
		EleWise.ELMA.Security.Models.API.IPublicClientSession publicClientSession = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
		string normalizedRequest = default(string);
		string requestHeader = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (KZWrZZvr2OCkLjoj0M1(publicClientSession) != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 7;
				case 3:
					publicClientSession = session as EleWise.ELMA.Security.Models.API.IPublicClientSession;
					num2 = 6;
					continue;
				default:
					return HmacService.CheckSignature(normalizedRequest, (byte[])KZWrZZvr2OCkLjoj0M1(publicClientSession), requestHeader);
				case 1:
					requestHeader = APIRouteProvider.GetRequestHeader(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFD0849E ^ 0xFD0E216));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					qHhEgvv8iyxGBDEB2k2(session, W1t17vvgnK8bpT5N5Lp(-737960346 ^ -737937392));
					num2 = 3;
					continue;
				case 6:
					if (publicClientSession != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 7;
				case 2:
					if (((Array)KZWrZZvr2OCkLjoj0M1(publicClientSession)).Length != 0)
					{
						normalizedRequest = GetNormalizedRequest();
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 7:
					return true;
				}
				break;
			}
			num = 7;
		}
	}

	public IEcdhKey ProcessAuthInfo()
	{
		//Discarded unreachable code: IL_00c8
		int num = 2;
		int num2 = num;
		string text = default(string);
		byte[] array = default(byte[]);
		string value = default(string);
		IEcdhKey ecdhKey = default(IEcdhKey);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return null;
			case 1:
				if (!njC0Zcvyutima1d1Fp8(text))
				{
					array = (byte[])hHc6g3vb0vmWyxGVeIb(text);
					num2 = 3;
				}
				else
				{
					num2 = 6;
				}
				break;
			case 8:
				SetResponseHeader(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-185816410 ^ -185807826), value);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				value = (string)QhfmYLv10LtpfoFvgew(mCG2Hjvfbnuda6cTY7y(EcdhService, eMiL5Cv92M3dlRGdHgT(ecdhKey)));
				num2 = 8;
				break;
			default:
				return ecdhKey;
			case 2:
				text = (string)lpfvkIv3CdJHpK96MTi(W1t17vvgnK8bpT5N5Lp(-192929954 ^ -192906794));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (ecdhKey == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 4;
			case 3:
				ecdhKey = (IEcdhKey)jE3wxVvSx3REHmsb7Nq(EcdhService, array);
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private static byte[] HexStringToByteArray(object hex)
	{
		//Discarded unreachable code: IL_010c, IL_011b
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		byte[] array = default(byte[]);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				num3 += 2;
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				return array;
			default:
				array[num3 / 2] = GFVplvCprTdyot6xCbn(iETveACkE8XwvQw5YKw(hex, num3, 2), 16);
				num2 = 3;
				break;
			case 2:
				num4 = YZK1fkvzbub5pk8rK9n(hex);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				array = new byte[num4 / 2];
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
			case 6:
				if (num3 >= num4)
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			case 7:
				num3 = 0;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	private static string ByteArrayToString(object ba)
	{
		return (string)oyqsfFC5XOFmSjKCnUe(BitConverter.ToString((byte[])ba), W1t17vvgnK8bpT5N5Lp(0x1B3723C5 ^ 0x1B372A5D), "");
	}

	private string GetVerb()
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (aNqepxCAS3cvH0yZkct() == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return (string)J9YeoxCXImC4mWpdmHm(nArF8SCWhpefveTARjY(aNqepxCAS3cvH0yZkct()));
			default:
				return string.Empty;
			}
		}
	}

	private string GetNormalizedRequest()
	{
		//Discarded unreachable code: IL_0046
		int num = 3;
		int num2 = num;
		byte[] requestBody = default(byte[]);
		Dictionary<string, string> headers = default(Dictionary<string, string>);
		string verb = default(string);
		string resource = default(string);
		string queryParams = default(string);
		string contentType = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				obj = string.Empty;
				break;
			case 2:
				requestBody = GetRequestBody();
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
				{
					num2 = 2;
				}
				continue;
			case 7:
				headers = GetHeaders((ICollection<string>)qQ7gdXCirjF8Q3MUYSM(APIRouteProvider.GetRequestHeader((string)W1t17vvgnK8bpT5N5Lp(0x4A799728 ^ 0x4A79F1B6)), new char[2] { ',', ';' }));
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
				{
					num2 = 4;
				}
				continue;
			case 4:
				if (aNqepxCAS3cvH0yZkct() == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				obj = K0rqJ0CnEio9gAWP5qB(nArF8SCWhpefveTARjY(WebOperationContext.Current));
				break;
			case 3:
				verb = GetVerb();
				num2 = 2;
				continue;
			default:
				return HmacService.GetNormalizedMessage(verb, resource, queryParams, headers, contentType, requestBody);
			case 1:
				queryParams = GetQueryParams();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				resource = GetResource();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
				{
					num2 = 1;
				}
				continue;
			}
			contentType = (string)obj;
			num2 = 4;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
			{
				num2 = 7;
			}
		}
	}

	private Dictionary<string, string> GetHeaders(ICollection<string> headerNames)
	{
		return headerNames.ToDictionary((string hn) => hn, (string hn) => (string)_003C_003Ec.lSEhsYpeIw8A4OvODYfM(hn));
	}

	private string GetResource()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (aNqepxCAS3cvH0yZkct() != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return string.Empty;
			default:
				return (string)iXRY0LCllPpegYa8QZs(AR0tFuC622OekTxgwYo(kt0CpNC7TbsPR4H5GOs(nArF8SCWhpefveTARjY(aNqepxCAS3cvH0yZkct()))));
			}
		}
	}

	private byte[] GetRequestBody()
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_00a2, IL_0135, IL_0144, IL_0153, IL_0184, IL_01c4, IL_01d3, IL_01df, IL_0204, IL_0213
		int num = 4;
		int num2 = num;
		Message message = default(Message);
		byte[] result = default(byte[]);
		XmlDictionaryReader xmlDictionaryReader = default(XmlDictionaryReader);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 3:
				message = (Message)rxpljtCxs5UbfdWcphx(kyjtnZCZ73B8LniWZLf(OperationContext.Current));
				num2 = 6;
				break;
			case 2:
				return result;
			case 1:
				try
				{
					int num3;
					if (!lhajoaCmq04fAgyqAwd(xmlDictionaryReader))
					{
						num3 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
						{
							num3 = 2;
						}
						goto IL_00a6;
					}
					goto IL_00c8;
					IL_00c8:
					text = (string)CWuQlhCekBcD1iJKSSl(xmlDictionaryReader);
					num3 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
					{
						num3 = 2;
					}
					goto IL_00a6;
					IL_00a6:
					while (true)
					{
						switch (num3)
						{
						default:
							return result;
						case 0:
							return result;
						case 4:
							return result;
						case 1:
							break;
						case 2:
							result = (byte[])QDqMqYCjhcLhSdEysKX(cOWr3rCLZjuKMgtA8mY(), text);
							num3 = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
							{
								num3 = 4;
							}
							continue;
						case 3:
						case 5:
							result = null;
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					goto IL_00c8;
				}
				finally
				{
					int num4;
					if (xmlDictionaryReader == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
						{
							num4 = 1;
						}
						goto IL_0188;
					}
					goto IL_019e;
					IL_019e:
					((IDisposable)xmlDictionaryReader).Dispose();
					num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
					{
						num4 = 0;
					}
					goto IL_0188;
					IL_0188:
					switch (num4)
					{
					default:
						goto end_IL_0163;
					case 2:
						break;
					case 1:
						goto end_IL_0163;
					case 0:
						goto end_IL_0163;
					}
					goto IL_019e;
					end_IL_0163:;
				}
			case 6:
				if (!DHqjBqCBUh3ewuee8NJ(message))
				{
					num2 = 7;
					break;
				}
				goto case 5;
			case 5:
				return null;
			case 7:
				xmlDictionaryReader = (XmlDictionaryReader)pRbGu6CuOkmm8rQ9psa(message);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (FwfKa1CNiiOKiuDqOmj() != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	private string GetQueryParams()
	{
		int num = 1;
		object value = default(object);
		HttpRequestMessageProperty httpRequestMessageProperty = default(HttpRequestMessageProperty);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (((MessageProperties)xb8CReCH9VVTSg6lVkR(FwfKa1CNiiOKiuDqOmj())).TryGetValue((string)aplQsvCaDGn4ExunUhw(), out value))
					{
						goto end_IL_0012;
					}
					goto IL_0061;
				case 3:
					return (string)VV6P00CRiTclUTX1y9t(httpRequestMessageProperty);
				case 4:
					httpRequestMessageProperty = value as HttpRequestMessageProperty;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (OperationContext.Current != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0061;
				case 2:
					{
						if (httpRequestMessageProperty != null)
						{
							num2 = 3;
							break;
						}
						goto IL_0061;
					}
					IL_0061:
					return string.Empty;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private void SetResponseHeader(string headerName, string value)
	{
		int num = 4;
		int num2 = num;
		HttpResponseMessageProperty httpResponseMessageProperty = default(HttpResponseMessageProperty);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				DACj0YCvkJJdGOGguRh(zVUJI4CPG8W7QK9mKmb(httpResponseMessageProperty), headerName, value);
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				return;
			case 5:
				((MessageProperties)VDAtRACCb5RTBogStRc(FwfKa1CNiiOKiuDqOmj())).Add((string)maOklVCU73EEw0WmTHV(), (object)httpResponseMessageProperty);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (aNqepxCAS3cvH0yZkct() == null)
				{
					httpResponseMessageProperty = new HttpResponseMessageProperty();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			case 3:
				((NameValueCollection)posVj1C2KRRnlRJQh0k(XCHeFQCw4hDByUO7duw(aNqepxCAS3cvH0yZkct()))).Add(headerName, value);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool T0SkMyvdgdbMXiFbmMD()
	{
		return ucZRrfvQrkGFlc0y76h == null;
	}

	internal static PublicSignatureService V6ORPDvTvy3jvUY2VDt()
	{
		return ucZRrfvQrkGFlc0y76h;
	}

	internal static object W1t17vvgnK8bpT5N5Lp(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void qHhEgvv8iyxGBDEB2k2(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static object KZWrZZvr2OCkLjoj0M1(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).Secret;
	}

	internal static object lpfvkIv3CdJHpK96MTi(object P_0)
	{
		return APIRouteProvider.GetRequestHeader((string)P_0);
	}

	internal static bool njC0Zcvyutima1d1Fp8(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object hHc6g3vb0vmWyxGVeIb(object P_0)
	{
		return HexStringToByteArray(P_0);
	}

	internal static object jE3wxVvSx3REHmsb7Nq(object P_0, object P_1)
	{
		return ((IEcdhService)P_0).DeriveKeyMaterial((byte[])P_1);
	}

	internal static object eMiL5Cv92M3dlRGdHgT(object P_0)
	{
		return ((IEcdhKey)P_0).PublicKey;
	}

	internal static object mCG2Hjvfbnuda6cTY7y(object P_0, object P_1)
	{
		return ((IEcdhService)P_0).DotNetToUncompressed((byte[])P_1);
	}

	internal static object QhfmYLv10LtpfoFvgew(object P_0)
	{
		return ByteArrayToString(P_0);
	}

	internal static int YZK1fkvzbub5pk8rK9n(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object iETveACkE8XwvQw5YKw(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static byte GFVplvCprTdyot6xCbn(object P_0, int P_1)
	{
		return Convert.ToByte((string)P_0, P_1);
	}

	internal static object oyqsfFC5XOFmSjKCnUe(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object aNqepxCAS3cvH0yZkct()
	{
		return WebOperationContext.Current;
	}

	internal static object nArF8SCWhpefveTARjY(object P_0)
	{
		return ((WebOperationContext)P_0).IncomingRequest;
	}

	internal static object J9YeoxCXImC4mWpdmHm(object P_0)
	{
		return ((IncomingWebRequestContext)P_0).Method;
	}

	internal static object K0rqJ0CnEio9gAWP5qB(object P_0)
	{
		return ((IncomingWebRequestContext)P_0).ContentType;
	}

	internal static object qQ7gdXCirjF8Q3MUYSM(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object kt0CpNC7TbsPR4H5GOs(object P_0)
	{
		return ((IncomingWebRequestContext)P_0).UriTemplateMatch;
	}

	internal static object AR0tFuC622OekTxgwYo(object P_0)
	{
		return ((UriTemplateMatch)P_0).RequestUri;
	}

	internal static object iXRY0LCllPpegYa8QZs(object P_0)
	{
		return ((Uri)P_0).AbsolutePath;
	}

	internal static object FwfKa1CNiiOKiuDqOmj()
	{
		return OperationContext.Current;
	}

	internal static object kyjtnZCZ73B8LniWZLf(object P_0)
	{
		return ((OperationContext)P_0).RequestContext;
	}

	internal static object rxpljtCxs5UbfdWcphx(object P_0)
	{
		return ((RequestContext)P_0).RequestMessage;
	}

	internal static bool DHqjBqCBUh3ewuee8NJ(object P_0)
	{
		return ((Message)P_0).IsEmpty;
	}

	internal static object pRbGu6CuOkmm8rQ9psa(object P_0)
	{
		return ((Message)P_0).GetReaderAtBodyContents();
	}

	internal static bool lhajoaCmq04fAgyqAwd(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static object CWuQlhCekBcD1iJKSSl(object P_0)
	{
		return ((XmlReader)P_0).ReadContentAsString();
	}

	internal static object cOWr3rCLZjuKMgtA8mY()
	{
		return Encoding.UTF8;
	}

	internal static object QDqMqYCjhcLhSdEysKX(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object xb8CReCH9VVTSg6lVkR(object P_0)
	{
		return ((OperationContext)P_0).IncomingMessageProperties;
	}

	internal static object aplQsvCaDGn4ExunUhw()
	{
		return HttpRequestMessageProperty.Name;
	}

	internal static object VV6P00CRiTclUTX1y9t(object P_0)
	{
		return ((HttpRequestMessageProperty)P_0).QueryString;
	}

	internal static object XCHeFQCw4hDByUO7duw(object P_0)
	{
		return ((WebOperationContext)P_0).OutgoingResponse;
	}

	internal static object posVj1C2KRRnlRJQh0k(object P_0)
	{
		return ((OutgoingWebResponseContext)P_0).Headers;
	}

	internal static object zVUJI4CPG8W7QK9mKmb(object P_0)
	{
		return ((HttpResponseMessageProperty)P_0).Headers;
	}

	internal static void DACj0YCvkJJdGOGguRh(object P_0, object P_1, object P_2)
	{
		((NameValueCollection)P_0).Add((string)P_1, (string)P_2);
	}

	internal static object VDAtRACCb5RTBogStRc(object P_0)
	{
		return ((OperationContext)P_0).OutgoingMessageProperties;
	}

	internal static object maOklVCU73EEw0WmTHV()
	{
		return HttpResponseMessageProperty.Name;
	}
}
