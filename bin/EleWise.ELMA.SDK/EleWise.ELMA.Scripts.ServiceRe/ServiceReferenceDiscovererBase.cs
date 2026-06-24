using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.ServiceModel.Description;
using System.Threading;
using System.Web.Services.Description;
using System.Web.Services.Discovery;
using System.Web.Services.Protocols;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scripts.ServiceReference;

public abstract class ServiceReferenceDiscovererBase
{
	internal static ServiceReferenceDiscovererBase FCbVoNBc9ecv8TP2q64v;

	private static CredentialCache CredentialCache { get; set; }

	protected string ReferenceName
	{
		[CompilerGenerated]
		get
		{
			return _003CReferenceName_003Ek__BackingField;
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
					_003CReferenceName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
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

	protected Uri DiscoveryUri
	{
		[CompilerGenerated]
		get
		{
			return _003CDiscoveryUri_003Ek__BackingField;
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
					_003CDiscoveryUri_003Ek__BackingField = value;
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

	protected MetadataSet MetadataSet
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataSet_003Ek__BackingField;
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
					_003CMetadataSet_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
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

	protected DiscoveryClientProtocol ClientProtocol
	{
		[CompilerGenerated]
		get
		{
			return _003CClientProtocol_003Ek__BackingField;
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
					_003CClientProtocol_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
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

	protected WebServiceDiscoveryClientProtocol DiscoveryClientProtocol
	{
		[CompilerGenerated]
		get
		{
			return _003CDiscoveryClientProtocol_003Ek__BackingField;
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
					_003CDiscoveryClientProtocol_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected bool IsWsdlFile
	{
		[CompilerGenerated]
		get
		{
			return _003CIsWsdlFile_003Ek__BackingField;
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
					_003CIsWsdlFile_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
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

	public string NamespacePrefix
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespacePrefix_003Ek__BackingField;
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
					_003CNamespacePrefix_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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

	protected string NameSpace
	{
		[CompilerGenerated]
		get
		{
			return _003CNameSpace_003Ek__BackingField;
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
					_003CNameSpace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool NeedAuthenticateUser
	{
		[CompilerGenerated]
		get
		{
			return _003CNeedAuthenticateUser_003Ek__BackingField;
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
					_003CNeedAuthenticateUser_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
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

	public string ErrorMessage
	{
		[CompilerGenerated]
		get
		{
			return _003CErrorMessage_003Ek__BackingField;
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
					_003CErrorMessage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ProjectDir
	{
		[CompilerGenerated]
		get
		{
			return _003CProjectDir_003Ek__BackingField;
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
					_003CProjectDir_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WebReference WebReference
	{
		[CompilerGenerated]
		get
		{
			return _003CWebReference_003Ek__BackingField;
		}
		[CompilerGenerated]
		protected set
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
					_003CWebReference_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string AuthenticationType
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationType_003Ek__BackingField;
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
					_003CAuthenticationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
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

	public bool ExistReferences => ((DictionaryBase)H2Y2BoBcggHP2xJLBo2e(DiscoveryClientProtocol)).Count > 0;

	protected abstract string WsdlName { get; }

	static ServiceReferenceDiscovererBase()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				CredentialCache = new CredentialCache();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				UBTcOMBcrC9EGUlIh8xD();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ServiceReferenceDiscovererBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UBTcOMBcrC9EGUlIh8xD();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ReferenceName = "";
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Run(Uri uri, DiscoveryNetworkCredential credential = null)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			DiscoveryNetworkCredential discoveryNetworkCredential;
			switch (num2)
			{
			case 1:
				DiscoveryUri = uri;
				num2 = 5;
				continue;
			case 2:
				IsWsdlFile = w27gi4Bc5vmA0LYA9ksW(uri.ToString());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 1;
				}
				continue;
			default:
				StartDiscovery(uri, credential);
				num2 = 4;
				continue;
			case 4:
				return;
			case 5:
				discoveryNetworkCredential = credential;
				if (discoveryNetworkCredential != null)
				{
					break;
				}
				num2 = 3;
				continue;
			case 3:
				discoveryNetworkCredential = new DiscoveryNetworkCredential((NetworkCredential)WiuqNjBcjlPxlhQYhIMJ(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6ED69D));
				break;
			}
			credential = discoveryNetworkCredential;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
			{
				num2 = 0;
			}
		}
	}

	protected void StartDiscovery(Uri uri, DiscoveryNetworkCredential credential)
	{
		//Discarded unreachable code: IL_0061, IL_0093, IL_00cb
		int num = 1;
		int num2 = num;
		bool exception = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					Sn0WCHBcUSdyaG3G5GlW(DiscoveryClientProtocol, duTPwDBcLDIYPkWZkCou(uri));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							exception = true;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				break;
			default:
				exception = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 5;
				}
				continue;
			case 1:
				StopDiscovery();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				FGuaGvBcY0WH1JJUXi1W(DiscoveryClientProtocol, credential);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				return;
			case 3:
				break;
			}
			tZpva8BcsXrrUVyZ0g6q(this, new AsyncDiscoveryState(DiscoveryClientProtocol, uri, credential), exception, uri);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
			{
				num2 = 4;
			}
		}
	}

	protected IEnumerable<System.Web.Services.Description.ServiceDescription> GetServiceDescriptions(DiscoveryClientProtocol protocol, bool checkContract = false)
	{
		List<System.Web.Services.Description.ServiceDescription> list = new List<System.Web.Services.Description.ServiceDescription>();
		protocol.ResolveOneLevel();
		foreach (DictionaryEntry reference in protocol.References)
		{
			if (reference.Value is ContractReference contractReference)
			{
				if (checkContract && string.IsNullOrEmpty(contractReference.Contract.Name) && contractReference.Contract.Services.Count == 0)
				{
					contractReference.Contract.Name = Path.GetFileName(contractReference.Url);
				}
				list.Add(contractReference.Contract);
			}
		}
		return list;
	}

	protected void AuthenticateUser(string authenticationType)
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
			case 1:
				AuthenticationType = authenticationType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				NeedAuthenticateUser = true;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected void AddCredential(Uri uri, DiscoveryNetworkCredential credential)
	{
		int num = 3;
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
				f5IP2YBzWMs2K333HgWh(s8pv2vBzBacDFrGj1OcK(), uri, k8UiTABccTfrKFQApps9(credential), credential);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				aQ4UB6BzFVHL2eSOa4qm(CredentialCache, uri, k8UiTABccTfrKFQApps9(credential));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (Tio2RYBczA1MtBpbOtnL(CredentialCache, uri, k8UiTABccTfrKFQApps9(credential)) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	protected string GetDefaultNamespace(IEnumerable<System.Web.Services.Description.ServiceDescription> services)
	{
		ContractDescription contractDescription = null;
		if (MetadataSet != null)
		{
			contractDescription = new WsdlImporter(MetadataSet).ImportAllContracts().FirstOrDefault(delegate(ContractDescription q)
			{
				//Discarded unreachable code: IL_005e, IL_006d
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return _003C_003Ec.TBMKl8Q18mLvPxwgwBnG(q) != null;
					default:
						return true;
					case 1:
						if (_003C_003Ec.F9iw9BQ1vxFj53iWBhEs(q) != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 2;
					}
				}
			});
		}
		string text = WsdlName;
		string text2 = WsdlName;
		if (contractDescription != null)
		{
			text = contractDescription.Name;
			text2 = contractDescription.Namespace;
		}
		else
		{
			System.Web.Services.Description.ServiceDescription serviceDescription = services.FirstOrDefault((System.Web.Services.Description.ServiceDescription q) => q.TargetNamespace != null);
			if (serviceDescription != null)
			{
				if (string.IsNullOrEmpty(serviceDescription.Name))
				{
					foreach (Service service in serviceDescription.Services)
					{
						if (string.IsNullOrEmpty(text))
						{
							text = service.Name;
						}
					}
				}
				else
				{
					text = serviceDescription.Name;
				}
				text2 = serviceDescription.TargetNamespace;
			}
		}
		if (!string.IsNullOrEmpty(text2) && !text2.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521167422)))
		{
			if (!text2.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BA3494)))
			{
				text2 = ScriptHelper.ServiceNamespace(text2);
				return NamespacePrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7F28D6) + text2;
			}
			if (!string.IsNullOrEmpty(text))
			{
				return NamespacePrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561072224) + ((!text.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218398600))) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53D2D4B), text) : text);
			}
		}
		else if (!string.IsNullOrEmpty(text))
		{
			return NamespacePrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477137122) + ((!text.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317692154))) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870793761), text) : text);
		}
		if (NamespacePrefix.Length > 0 && DiscoveryUri != null)
		{
			string text3 = DiscoveryUri.Segments.LastOrDefault();
			if (text3 != null && !text3.IsNullOrEmpty())
			{
				return NamespacePrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138961604) + string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD4D1B8), text3.Replace('.', '_'));
			}
			return NamespacePrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103FF3B1) + DiscoveryUri.Host;
		}
		if (!(DiscoveryUri != null))
		{
			return string.Empty;
		}
		return DiscoveryUri.Host;
	}

	protected string GetReferenceName(IEnumerable<System.Web.Services.Description.ServiceDescription> services)
	{
		ContractDescription contractDescription = null;
		if (MetadataSet != null)
		{
			contractDescription = new WsdlImporter(MetadataSet).ImportAllContracts().FirstOrDefault(delegate(ContractDescription q)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 1:
						if (_003C_003Ec.F9iw9BQ1vxFj53iWBhEs(q) != null)
						{
							return true;
						}
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num4 = 0;
						}
						break;
					default:
						return _003C_003Ec.TBMKl8Q18mLvPxwgwBnG(q) != null;
					}
				}
			});
		}
		string text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -98004394);
		string text2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218397778);
		if (contractDescription != null)
		{
			text = contractDescription.Name;
			text2 = contractDescription.Namespace;
		}
		else
		{
			System.Web.Services.Description.ServiceDescription serviceDescription = services.FirstOrDefault(delegate(System.Web.Services.Description.ServiceDescription q)
			{
				//Discarded unreachable code: IL_002d, IL_003c
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (_003C_003Ec.ubugWVQ1ZShaVkCbrELx(q) == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 2;
					case 2:
						return _003C_003Ec.umYwXLQ1up77lviMfIId(q) != null;
					default:
						return false;
					}
				}
			});
			if (serviceDescription != null)
			{
				text = serviceDescription.Name;
				text2 = serviceDescription.TargetNamespace;
			}
		}
		if (!string.IsNullOrEmpty(text2) && !text2.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606687074)))
		{
			if (!text2.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426192749)))
			{
				return ScriptHelper.ServiceNamespace(text2);
			}
			if (!string.IsNullOrEmpty(text))
			{
				if (text.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138061906)))
				{
					return text;
				}
				return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576117172), text);
			}
		}
		else if (!string.IsNullOrEmpty(text))
		{
			if (text.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638500409)))
			{
				return text;
			}
			return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76C5566), text);
		}
		if (DiscoveryUri != null)
		{
			string text3 = DiscoveryUri.Segments.LastOrDefault();
			if (text3 != null && !text3.IsNullOrEmpty())
			{
				return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE25C61), text3.Replace('.', '_'));
			}
			return DiscoveryUri.Host;
		}
		return string.Empty;
	}

	protected abstract void DiscoveryCompleted(AsyncDiscoveryState state, bool exception, Uri uri);

	protected abstract void RunDiscovery(DiscoveryNetworkCredential credential, Uri uri);

	protected abstract void DiscoveredWebServices(DiscoveryClientProtocol protocol);

	private void StopDiscovery()
	{
		//Discarded unreachable code: IL_00c7, IL_00f9, IL_0110, IL_011f, IL_0193, IL_01cb, IL_01da
		int num = 2;
		ServiceReferenceDiscovererBase serviceReferenceDiscovererBase = default(ServiceReferenceDiscovererBase);
		bool lockTaken = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					serviceReferenceDiscovererBase = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				case 0:
					return;
				case 3:
					try
					{
						Monitor.Enter(serviceReferenceDiscovererBase, ref lockTaken);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 2:
								try
								{
									Dg4oQJBzoQJjbPmBbTBp(DiscoveryClientProtocol);
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								catch (ObjectDisposedException)
								{
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
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
							case 4:
								DiscoveryClientProtocol = new WebServiceDiscoveryClientProtocol();
								num3 = 3;
								continue;
							default:
								if (DiscoveryClientProtocol != null)
								{
									int num4 = 2;
									num3 = num4;
									continue;
								}
								goto case 4;
							case 1:
								break;
							}
							Uwh0hBBzbSPgSbvggGbs(DiscoveryClientProtocol);
							num3 = 4;
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
							{
								num7 = 1;
							}
							while (true)
							{
								switch (num7)
								{
								case 1:
									FlUxYIBzho9nvOi0SQBW(serviceReferenceDiscovererBase);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
									{
										num7 = 0;
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
				break;
			}
			lockTaken = false;
			num = 3;
		}
	}

	internal static bool GW3AelBcdyWoqxvZqRL4()
	{
		return FCbVoNBc9ecv8TP2q64v == null;
	}

	internal static ServiceReferenceDiscovererBase ECn88uBclGpOZbHX4LUv()
	{
		return FCbVoNBc9ecv8TP2q64v;
	}

	internal static void UBTcOMBcrC9EGUlIh8xD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object H2Y2BoBcggHP2xJLBo2e(object P_0)
	{
		return ((DiscoveryClientProtocol)P_0).References;
	}

	internal static bool w27gi4Bc5vmA0LYA9ksW(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object WiuqNjBcjlPxlhQYhIMJ()
	{
		return CredentialCache.DefaultNetworkCredentials;
	}

	internal static void FGuaGvBcY0WH1JJUXi1W(object P_0, object P_1)
	{
		((WebClientProtocol)P_0).Credentials = (ICredentials)P_1;
	}

	internal static object duTPwDBcLDIYPkWZkCou(object P_0)
	{
		return ((Uri)P_0).AbsoluteUri;
	}

	internal static object Sn0WCHBcUSdyaG3G5GlW(object P_0, object P_1)
	{
		return ((DiscoveryClientProtocol)P_0).DiscoverAny((string)P_1);
	}

	internal static void tZpva8BcsXrrUVyZ0g6q(object P_0, object P_1, bool exception, object P_3)
	{
		((ServiceReferenceDiscovererBase)P_0).DiscoveryCompleted((AsyncDiscoveryState)P_1, exception, (Uri)P_3);
	}

	internal static object k8UiTABccTfrKFQApps9(object P_0)
	{
		return ((DiscoveryNetworkCredential)P_0).AuthenticationType;
	}

	internal static object Tio2RYBczA1MtBpbOtnL(object P_0, object P_1, object P_2)
	{
		return ((CredentialCache)P_0).GetCredential((Uri)P_1, (string)P_2);
	}

	internal static void aQ4UB6BzFVHL2eSOa4qm(object P_0, object P_1, object P_2)
	{
		((CredentialCache)P_0).Remove((Uri)P_1, (string)P_2);
	}

	internal static object s8pv2vBzBacDFrGj1OcK()
	{
		return CredentialCache;
	}

	internal static void f5IP2YBzWMs2K333HgWh(object P_0, object P_1, object P_2, object P_3)
	{
		((CredentialCache)P_0).Add((Uri)P_1, (string)P_2, (NetworkCredential)P_3);
	}

	internal static void Dg4oQJBzoQJjbPmBbTBp(object P_0)
	{
		((WebClientProtocol)P_0).Abort();
	}

	internal static void Uwh0hBBzbSPgSbvggGbs(object P_0)
	{
		((Component)P_0).Dispose();
	}

	internal static void FlUxYIBzho9nvOi0SQBW(object P_0)
	{
		Monitor.Exit(P_0);
	}
}
