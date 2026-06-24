using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using System.Web.Services.Description;
using System.Web.Services.Discovery;
using System.Xml;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scripts.ServiceReference;

public sealed class ServiceReferenceDiscoverer : ServiceReferenceDiscovererBase
{
	internal static ServiceReferenceDiscoverer N6LWdfBzG0WXdXmjQVI6;

	public IEnumerable<System.Web.Services.Description.ServiceDescription> Services { get; private set; }

	protected override string WsdlName => (string)xM7vLcBzC4FDoq9fyyVy(0x463A0F3C ^ 0x463B8D20);

	public ServiceReferenceDiscoverer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GToTf7BzQnhDalLfB0hB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void RunDiscovery(DiscoveryNetworkCredential credential, Uri uri)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_0128, IL_01cc, IL_0224, IL_0299, IL_02a8
		int num = 14;
		MetadataExchangeClient metadataExchangeClient = default(MetadataExchangeClient);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 7:
					new WsdlImporter(base.MetadataSet).ImportAllContracts();
					num2 = 11;
					break;
				case 13:
					base.WebReference = new WebReference(base.DiscoveryUri.AbsoluteUri, base.ReferenceName, base.NameSpace, base.ClientProtocol, base.ProjectDir, null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				case 11:
					if (base.MetadataSet != null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 8;
						}
						break;
					}
					return;
				case 5:
					metadataExchangeClient.HttpCredentials = credential;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 1;
					}
					break;
				case 12:
					base.WebReference = new WebReference((string)b1HMAnBzVV14Nn0pOKBs(base.DiscoveryUri), base.ReferenceName, base.NameSpace, base.ClientProtocol, base.ProjectDir, base.MetadataSet);
					num2 = 2;
					break;
				case 14:
					if (!base.IsWsdlFile)
					{
						WSHttpBinding obj = new WSHttpBinding(SecurityMode.None)
						{
							MaxReceivedMessageSize = 2147483647L
						};
						akSTyJBzvnPMThCIAvAR(obj.ReaderQuotas, int.MaxValue);
						IpbJfrBz8Hwtgg6sdC6q(obj.ReaderQuotas, int.MaxValue);
						metadataExchangeClient = new MetadataExchangeClient(obj);
						num2 = 10;
						break;
					}
					goto end_IL_0012;
				default:
					Services = GetServiceDescriptions(base.ClientProtocol);
					num2 = 8;
					break;
				case 9:
					try
					{
						MetadataSet metadataSet = (MetadataSet)dPpTayBzufcHvwcecAOS(metadataExchangeClient, uri, MetadataExchangeClientMode.HttpGet);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								base.MetadataSet = metadataSet;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
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
					catch (InvalidOperationException)
					{
						int num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 2:
								base.ErrorMessage = (string)Y35MisBzI9fiqxdqp1yK(xM7vLcBzC4FDoq9fyyVy(0x42643203 ^ 0x4265B043));
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num4 = 1;
								}
								break;
							case 1:
								base.MetadataSet = null;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
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
				case 10:
					if (credential == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 5;
				case 3:
					if (base.MetadataSet == null)
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 7;
					}
					break;
				case 1:
				case 6:
					FG4f2iBzZVurtVnNZSu8(metadataExchangeClient, true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 9;
					}
					break;
				case 2:
					return;
				case 8:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	protected override void DiscoveryCompleted(AsyncDiscoveryState state, bool exception, Uri uri)
	{
		//Discarded unreachable code: IL_0055, IL_0095, IL_00e7, IL_0106, IL_0115, IL_0142, IL_0151, IL_0187, IL_01b2, IL_0266, IL_0295, IL_02ce, IL_02dd, IL_0325, IL_0334
		int num = 7;
		WebServiceDiscoveryClientProtocol webServiceDiscoveryClientProtocol = default(WebServiceDiscoveryClientProtocol);
		ServiceReferenceDiscoverer serviceReferenceDiscoverer = default(ServiceReferenceDiscoverer);
		bool lockTaken = default(bool);
		bool flag = default(bool);
		HttpAuthenticationHeader httpAuthenticationHeader = default(HttpAuthenticationHeader);
		HttpAuthenticationHeader httpAuthenticationHeader2 = default(HttpAuthenticationHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					webServiceDiscoveryClientProtocol = (WebServiceDiscoveryClientProtocol)GyWDhLBzSnkMaDPXulCk(state);
					num2 = 6;
					continue;
				case 5:
					try
					{
						Monitor.Enter(serviceReferenceDiscoverer, ref lockTaken);
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								flag = base.DiscoveryClientProtocol == webServiceDiscoveryClientProtocol;
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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
					finally
					{
						int num6;
						if (!lockTaken)
						{
							num6 = 2;
							goto IL_00eb;
						}
						goto IL_0120;
						IL_00eb:
						switch (num6)
						{
						case 2:
							goto end_IL_00d6;
						case 1:
							goto end_IL_00d6;
						}
						goto IL_0120;
						IL_0120:
						RL3pknBzidK2gvMOtONd(serviceReferenceDiscoverer);
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num6 = 0;
						}
						goto IL_00eb;
						end_IL_00d6:;
					}
					goto case 9;
				case 2:
					try
					{
						int num3;
						if (kCh14PBzT2QAqk7PJwp1(H99I7aBzXHuERvMJaEqj(state)))
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
							{
								num3 = 2;
							}
							goto IL_018b;
						}
						goto IL_01de;
						IL_01de:
						AddCredential(state.Uri, state.Credential);
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num3 = 3;
						}
						goto IL_018b;
						IL_018b:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								DiscoveredWebServices(webServiceDiscoveryClientProtocol);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								break;
							case 2:
							case 3:
								if (!exception)
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto case 1;
							case 5:
								EF1gpHBzkU9jNjrkdVDa(this, H99I7aBzXHuERvMJaEqj(state), state.Uri);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num3 = 1;
								}
								continue;
							case 0:
								return;
							}
							break;
						}
						goto IL_01de;
					}
					catch
					{
						int num4 = 2;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 4:
								return;
							case 1:
								httpAuthenticationHeader = (HttpAuthenticationHeader)rphMNwBzqKd7Yan2gjoA(webServiceDiscoveryClientProtocol);
								num4 = 6;
								break;
							case 6:
								AuthenticateUser((string)EjS7uEBznDS3buHa3FmN(httpAuthenticationHeader));
								num4 = 4;
								break;
							case 3:
							case 5:
								BvfeJ7BzKyl52R7H4vAB(this, webServiceDiscoveryClientProtocol);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
								{
									num4 = 0;
								}
								break;
							case 2:
								if (!lGXbEgBzRLdKEOQpMsJX(webServiceDiscoveryClientProtocol))
								{
									num4 = 5;
									break;
								}
								goto case 1;
							case 0:
								return;
							}
						}
					}
				case 6:
					break;
				default:
					num2 = 2;
					continue;
				case 8:
					lockTaken = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 5;
					}
					continue;
				case 9:
					if (flag)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 4:
					AuthenticateUser(httpAuthenticationHeader2.AuthenticationType);
					num2 = 11;
					continue;
				case 1:
					if (!lGXbEgBzRLdKEOQpMsJX(webServiceDiscoveryClientProtocol))
					{
						num2 = 12;
						continue;
					}
					goto case 3;
				case 10:
					return;
				case 3:
					httpAuthenticationHeader2 = (HttpAuthenticationHeader)rphMNwBzqKd7Yan2gjoA(webServiceDiscoveryClientProtocol);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 4;
					}
					continue;
				case 11:
					return;
				case 12:
					BvfeJ7BzKyl52R7H4vAB(this, webServiceDiscoveryClientProtocol);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			serviceReferenceDiscoverer = this;
			num = 8;
		}
	}

	protected override void DiscoveredWebServices(DiscoveryClientProtocol protocol)
	{
		//Discarded unreachable code: IL_0179
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				default:
					base.NameSpace = GetDefaultNamespace(Services);
					num2 = 9;
					continue;
				case 10:
					base.WebReference = new WebReference((string)b1HMAnBzVV14Nn0pOKBs(base.DiscoveryUri), base.ReferenceName, base.NameSpace, protocol, base.ProjectDir, base.MetadataSet);
					num2 = 3;
					continue;
				case 9:
					base.ReferenceName = GetReferenceName(Services);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (protocol == null)
					{
						base.ClientProtocol = null;
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num2 = 7;
						}
					}
					else
					{
						num2 = 4;
					}
					continue;
				case 8:
					base.WebReference = null;
					num2 = 7;
					continue;
				case 4:
					if (Services == null)
					{
						break;
					}
					goto end_IL_0012;
				case 1:
					base.ClientProtocol = protocol;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					return;
				case 2:
					break;
				}
				Services = GetServiceDescriptions(protocol).ToList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	internal static void GToTf7BzQnhDalLfB0hB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ikteEBBzE9QpjOcLdXjF()
	{
		return N6LWdfBzG0WXdXmjQVI6 == null;
	}

	internal static ServiceReferenceDiscoverer cHgCwWBzfS5RjpvldlLt()
	{
		return N6LWdfBzG0WXdXmjQVI6;
	}

	internal static object xM7vLcBzC4FDoq9fyyVy(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void akSTyJBzvnPMThCIAvAR(object P_0, int P_1)
	{
		((XmlDictionaryReaderQuotas)P_0).MaxStringContentLength = P_1;
	}

	internal static void IpbJfrBz8Hwtgg6sdC6q(object P_0, int P_1)
	{
		((XmlDictionaryReaderQuotas)P_0).MaxNameTableCharCount = P_1;
	}

	internal static void FG4f2iBzZVurtVnNZSu8(object P_0, bool P_1)
	{
		((MetadataExchangeClient)P_0).ResolveMetadataReferences = P_1;
	}

	internal static object dPpTayBzufcHvwcecAOS(object P_0, object P_1, MetadataExchangeClientMode P_2)
	{
		return ((MetadataExchangeClient)P_0).GetMetadata((Uri)P_1, P_2);
	}

	internal static object Y35MisBzI9fiqxdqp1yK(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object b1HMAnBzVV14Nn0pOKBs(object P_0)
	{
		return ((Uri)P_0).AbsoluteUri;
	}

	internal static object GyWDhLBzSnkMaDPXulCk(object P_0)
	{
		return ((AsyncDiscoveryState)P_0).Protocol;
	}

	internal static void RL3pknBzidK2gvMOtONd(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool lGXbEgBzRLdKEOQpMsJX(object P_0)
	{
		return ((WebServiceDiscoveryClientProtocol)P_0).IsAuthenticationRequired;
	}

	internal static object rphMNwBzqKd7Yan2gjoA(object P_0)
	{
		return ((WebServiceDiscoveryClientProtocol)P_0).GetAuthenticationHeader();
	}

	internal static void BvfeJ7BzKyl52R7H4vAB(object P_0, object P_1)
	{
		((ServiceReferenceDiscovererBase)P_0).DiscoveredWebServices((DiscoveryClientProtocol)P_1);
	}

	internal static object H99I7aBzXHuERvMJaEqj(object P_0)
	{
		return ((AsyncDiscoveryState)P_0).Credential;
	}

	internal static bool kCh14PBzT2QAqk7PJwp1(object P_0)
	{
		return ((DiscoveryNetworkCredential)P_0).IsDefaultAuthenticationType;
	}

	internal static void EF1gpHBzkU9jNjrkdVDa(object P_0, object P_1, object P_2)
	{
		((ServiceReferenceDiscovererBase)P_0).RunDiscovery((DiscoveryNetworkCredential)P_1, (Uri)P_2);
	}

	internal static object EjS7uEBznDS3buHa3FmN(object P_0)
	{
		return ((HttpAuthenticationHeader)P_0).AuthenticationType;
	}
}
