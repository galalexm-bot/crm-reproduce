using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using System.Web.Services.Description;
using System.Web.Services.Discovery;
using System.Xml;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scripts.ServiceReference;

public class WebReferenceDiscoverer : ServiceReferenceDiscovererBase
{
	internal static WebReferenceDiscoverer Vh4hWdBzOVt50scX5QyZ;

	protected override string WsdlName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852936188);

	protected override void DiscoveredWebServices(DiscoveryClientProtocol protocol)
	{
		//Discarded unreachable code: IL_00a0, IL_00af, IL_016e, IL_017d
		int num = 6;
		int num2 = num;
		List<System.Web.Services.Description.ServiceDescription> list = default(List<System.Web.Services.Description.ServiceDescription>);
		while (true)
		{
			switch (num2)
			{
			case 11:
				base.WebReference = new WebReference((string)DcPUEZBzPDu5dy4C7bvv(base.DiscoveryUri), base.ReferenceName, base.NameSpace, protocol, base.ProjectDir, base.MetadataSet);
				num2 = 2;
				break;
			case 4:
				list = new List<System.Web.Services.Description.ServiceDescription>();
				num2 = 9;
				break;
			case 1:
				return;
			case 2:
				return;
			case 5:
				base.ClientProtocol = null;
				num2 = 12;
				break;
			default:
				base.NameSpace = GetDefaultNamespace(list);
				num2 = 7;
				break;
			case 10:
				list.AddRange(GetServiceDescriptions(protocol));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 3;
				}
				break;
			case 9:
				if (!base.IsWsdlFile)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 10;
			case 6:
				if (protocol == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 7:
				base.ReferenceName = GetReferenceName(list);
				num2 = 3;
				break;
			case 3:
				base.ClientProtocol = protocol;
				num2 = 11;
				break;
			case 12:
				base.WebReference = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override void DiscoveryCompleted(AsyncDiscoveryState state, bool exception, Uri uri)
	{
		//Discarded unreachable code: IL_00be, IL_0112, IL_0234, IL_0243, IL_0253, IL_0279, IL_02a7, IL_0309, IL_0341, IL_0350, IL_0377, IL_0386
		int num = 7;
		int num2 = num;
		WebServiceDiscoveryClientProtocol webServiceDiscoveryClientProtocol = default(WebServiceDiscoveryClientProtocol);
		HttpAuthenticationHeader httpAuthenticationHeader = default(HttpAuthenticationHeader);
		bool flag = default(bool);
		WebReferenceDiscoverer webReferenceDiscoverer = default(WebReferenceDiscoverer);
		bool lockTaken = default(bool);
		HttpAuthenticationHeader httpAuthenticationHeader2 = default(HttpAuthenticationHeader);
		while (true)
		{
			switch (num2)
			{
			case 8:
				return;
			case 10:
				J3qZYgBzahcqF38uGDah(this, webServiceDiscoveryClientProtocol);
				num2 = 2;
				continue;
			case 2:
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				continue;
			case 12:
				httpAuthenticationHeader = (HttpAuthenticationHeader)Hv612iBz32yx0eBp8lME(webServiceDiscoveryClientProtocol);
				num2 = 5;
				continue;
			case 4:
				return;
			case 1:
				if (!flag)
				{
					return;
				}
				num2 = 9;
				continue;
			case 3:
				try
				{
					Monitor.Enter(webReferenceDiscoverer, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							flag = base.DiscoveryClientProtocol == webServiceDiscoveryClientProtocol;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
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
				finally
				{
					if (lockTaken)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								QONYwABzNm3SaShjkCGW(webReferenceDiscoverer);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 1;
			case 5:
				AuthenticateUser((string)xGeWETBzpM5wfiFlVTRQ(httpAuthenticationHeader));
				num2 = 8;
				continue;
			case 7:
				webServiceDiscoveryClientProtocol = (WebServiceDiscoveryClientProtocol)A0u8EnBz1D0fUekpKcIP(state);
				num2 = 6;
				continue;
			case 6:
				webReferenceDiscoverer = this;
				num2 = 11;
				continue;
			case 11:
				lockTaken = false;
				num2 = 3;
				continue;
			case 9:
				if (!webServiceDiscoveryClientProtocol.IsAuthenticationRequired)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 12;
			}
			try
			{
				int num5;
				if (!nylQGWBzDfr75nFQxtjN(state.Credential))
				{
					num5 = 2;
					goto IL_00c2;
				}
				goto IL_011c;
				IL_0174:
				J3qZYgBzahcqF38uGDah(this, webServiceDiscoveryClientProtocol);
				num5 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num5 = 0;
				}
				goto IL_00c2;
				IL_011c:
				if (exception)
				{
					num5 = 4;
					goto IL_00c2;
				}
				goto IL_00e8;
				IL_00c2:
				while (true)
				{
					switch (num5)
					{
					default:
						return;
					case 0:
						return;
					case 5:
						break;
					case 1:
						goto IL_011c;
					case 2:
						AddCredential(state.Uri, (DiscoveryNetworkCredential)S7CnaeBzt6SxVHctlD2m(state));
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num5 = 1;
						}
						continue;
					case 6:
						MfcYYcBz4fIZKL2XdCnw(this, state.Credential, WpEsCoBzw6IrgPxf9A3J(state));
						num5 = 3;
						continue;
					case 3:
					case 4:
						goto IL_0174;
					}
					break;
				}
				goto IL_00e8;
				IL_00e8:
				if (!base.IsWsdlFile)
				{
					num5 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num5 = 6;
					}
					goto IL_00c2;
				}
				goto IL_0174;
			}
			catch
			{
				int num6 = 6;
				int num7 = num6;
				while (true)
				{
					switch (num7)
					{
					case 2:
						return;
					case 5:
						return;
					default:
						J3qZYgBzahcqF38uGDah(this, webServiceDiscoveryClientProtocol);
						num7 = 2;
						break;
					case 4:
						httpAuthenticationHeader2 = (HttpAuthenticationHeader)Hv612iBz32yx0eBp8lME(webServiceDiscoveryClientProtocol);
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num7 = 1;
						}
						break;
					case 6:
						if (!JRfUEOBz6ZOcjMwVfrUK(webServiceDiscoveryClientProtocol))
						{
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num7 = 0;
							}
							break;
						}
						goto case 4;
					case 1:
						AuthenticateUser((string)xGeWETBzpM5wfiFlVTRQ(httpAuthenticationHeader2));
						num7 = 5;
						break;
					}
				}
			}
		}
	}

	protected override void RunDiscovery(DiscoveryNetworkCredential credential, Uri uri)
	{
		//Discarded unreachable code: IL_0069, IL_0120, IL_0168, IL_01dd, IL_0240
		int num = 1;
		int num2 = num;
		MetadataExchangeClient metadataExchangeClient = default(MetadataExchangeClient);
		while (true)
		{
			switch (num2)
			{
			default:
				if (credential == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 9;
			case 4:
				return;
			case 3:
				if (base.MetadataSet == null)
				{
					num2 = 4;
					break;
				}
				goto case 7;
			case 7:
				base.WebReference = new WebReference((string)DcPUEZBzPDu5dy4C7bvv(base.DiscoveryUri), base.ReferenceName, base.NameSpace, base.ClientProtocol, base.ProjectDir, base.MetadataSet);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				vRP51OBz0mC1EymxAqIL(metadataExchangeClient, credential);
				num2 = 6;
				break;
			case 6:
			case 8:
				iROWtuBzmGtE2yhqAUoB(metadataExchangeClient, true);
				num2 = 5;
				break;
			case 5:
				try
				{
					MetadataSet metadataSet = (MetadataSet)g6W7PcBzytAUEUVwZIeg(metadataExchangeClient, uri, MetadataExchangeClientMode.HttpGet);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							base.MetadataSet = metadataSet;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
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
				catch (InvalidOperationException)
				{
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 2:
							base.ErrorMessage = SR.T((string)bJX5GbBzMoW8c410yDed(0x57A5235E ^ 0x57A4A11E));
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num4 = 1;
							}
							break;
						case 1:
							base.MetadataSet = null;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				goto case 3;
			case 2:
				return;
			case 1:
			{
				WSHttpBinding wSHttpBinding = new WSHttpBinding(SecurityMode.None);
				P5lZPHBzHMNHLRBdy7YZ(wSHttpBinding, 2147483647L);
				hQQMH7Bz7LUVZX5VvVdh(j0hEJ6BzAQGpwKsRxNdx(wSHttpBinding), int.MaxValue);
				nLJZe1Bzxrjvv3vcSjl1(wSHttpBinding.ReaderQuotas, int.MaxValue);
				metadataExchangeClient = new MetadataExchangeClient(wSHttpBinding);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private IEnumerable<System.Web.Services.Description.ServiceDescription> GetServiceDescriptions(DiscoveryClientProtocol protocol)
	{
		List<System.Web.Services.Description.ServiceDescription> list = new List<System.Web.Services.Description.ServiceDescription>();
		protocol.ResolveOneLevel();
		foreach (DictionaryEntry reference in protocol.References)
		{
			if (reference.Value is ContractReference contractReference)
			{
				list.Add(contractReference.Contract);
			}
		}
		return list;
	}

	public WebReferenceDiscoverer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kwpM5hBzJXuLCMOBZ7RE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool x7NF5CBz2d1hy7KQ084v()
	{
		return Vh4hWdBzOVt50scX5QyZ == null;
	}

	internal static WebReferenceDiscoverer AfZRmLBzetbIdwHejnKs()
	{
		return Vh4hWdBzOVt50scX5QyZ;
	}

	internal static object DcPUEZBzPDu5dy4C7bvv(object P_0)
	{
		return ((Uri)P_0).AbsoluteUri;
	}

	internal static object A0u8EnBz1D0fUekpKcIP(object P_0)
	{
		return ((AsyncDiscoveryState)P_0).Protocol;
	}

	internal static void QONYwABzNm3SaShjkCGW(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object Hv612iBz32yx0eBp8lME(object P_0)
	{
		return ((WebServiceDiscoveryClientProtocol)P_0).GetAuthenticationHeader();
	}

	internal static object xGeWETBzpM5wfiFlVTRQ(object P_0)
	{
		return ((HttpAuthenticationHeader)P_0).AuthenticationType;
	}

	internal static void J3qZYgBzahcqF38uGDah(object P_0, object P_1)
	{
		((ServiceReferenceDiscovererBase)P_0).DiscoveredWebServices((DiscoveryClientProtocol)P_1);
	}

	internal static bool nylQGWBzDfr75nFQxtjN(object P_0)
	{
		return ((DiscoveryNetworkCredential)P_0).IsDefaultAuthenticationType;
	}

	internal static object S7CnaeBzt6SxVHctlD2m(object P_0)
	{
		return ((AsyncDiscoveryState)P_0).Credential;
	}

	internal static object WpEsCoBzw6IrgPxf9A3J(object P_0)
	{
		return ((AsyncDiscoveryState)P_0).Uri;
	}

	internal static void MfcYYcBz4fIZKL2XdCnw(object P_0, object P_1, object P_2)
	{
		((ServiceReferenceDiscovererBase)P_0).RunDiscovery((DiscoveryNetworkCredential)P_1, (Uri)P_2);
	}

	internal static bool JRfUEOBz6ZOcjMwVfrUK(object P_0)
	{
		return ((WebServiceDiscoveryClientProtocol)P_0).IsAuthenticationRequired;
	}

	internal static void P5lZPHBzHMNHLRBdy7YZ(object P_0, long P_1)
	{
		((WSHttpBindingBase)P_0).MaxReceivedMessageSize = P_1;
	}

	internal static object j0hEJ6BzAQGpwKsRxNdx(object P_0)
	{
		return ((WSHttpBindingBase)P_0).ReaderQuotas;
	}

	internal static void hQQMH7Bz7LUVZX5VvVdh(object P_0, int P_1)
	{
		((XmlDictionaryReaderQuotas)P_0).MaxStringContentLength = P_1;
	}

	internal static void nLJZe1Bzxrjvv3vcSjl1(object P_0, int P_1)
	{
		((XmlDictionaryReaderQuotas)P_0).MaxNameTableCharCount = P_1;
	}

	internal static void vRP51OBz0mC1EymxAqIL(object P_0, object P_1)
	{
		((MetadataExchangeClient)P_0).HttpCredentials = (ICredentials)P_1;
	}

	internal static void iROWtuBzmGtE2yhqAUoB(object P_0, bool P_1)
	{
		((MetadataExchangeClient)P_0).ResolveMetadataReferences = P_1;
	}

	internal static object g6W7PcBzytAUEUVwZIeg(object P_0, object P_1, MetadataExchangeClientMode P_2)
	{
		return ((MetadataExchangeClient)P_0).GetMetadata((Uri)P_1, P_2);
	}

	internal static object bJX5GbBzMoW8c410yDed(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void kwpM5hBzJXuLCMOBZ7RE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
