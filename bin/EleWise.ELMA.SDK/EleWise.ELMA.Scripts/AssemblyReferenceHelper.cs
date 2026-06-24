using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web.Services.Description;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Scripts.ServiceReference.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scripts;

public static class AssemblyReferenceHelper
{
	private static string globalAssemblyLocation;

	private static string elmaAssemblyLocation;

	public static readonly string[] DefaultElmaReferenceList;

	public static readonly string[] DefaultGlobalReferencesList;

	public static readonly string[] DefaultWebReferences;

	internal static AssemblyReferenceHelper mZ7dnMBszP3dc7VA42Ke;

	public static string GlobalAssemblyLocation
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text;
			while (true)
			{
				switch (num2)
				{
				case 1:
					text = globalAssemblyLocation;
					if (text != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					text = (globalAssemblyLocation = (string)lrR6A1BcboudH0fWN7pB(ujTTxxBco6UYt5m2eLvT(L2CpahBcWp5j3G236erx())));
					break;
				}
				break;
			}
			return text;
		}
	}

	public static string ElmaAssemblyLocation
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text;
			while (true)
			{
				switch (num2)
				{
				case 1:
					text = elmaAssemblyLocation;
					if (text != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					text = (elmaAssemblyLocation = (string)DFgEevBchqg6ha7gFYvk(Locator.GetServiceNotNull<IOmniSharpWorker>()));
					break;
				}
				break;
			}
			return text;
		}
	}

	public static string ExternalAssemblyLocation => IOExtensions.GetTempPath(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103E962B));

	public static string[] DefaultReferenceList => DefaultElmaReferenceList.Union(DefaultGlobalReferencesList).Union(DefaultWebReferences).ToArray();

	[Obsolete("Use IGlobalModulesReferenceService.GetGlobalModuleAssemblyPath(...) instead", true)]
	public static string GetGlobalModuleAssemblyPath(Guid globalModuleAssemblyUid)
	{
		return (string)sJBlneBcQATD61cPgrJh(pUeKm2BcG12bWLtg8GNW(), f6hs2hBcfuteCgRjX7IG(Vjcn1SBcEP0FZsDVoL39(0x12441CA4 ^ 0x12456322), globalModuleAssemblyUid, Vjcn1SBcEP0FZsDVoL39(0x3C5338FF ^ 0x3C527C45)));
	}

	internal static string GetServiceString(Uri uri)
	{
		//Discarded unreachable code: IL_004c, IL_0082, IL_00ba, IL_00d9, IL_00e8, IL_0136, IL_016e, IL_017d
		int num = 2;
		int num2 = num;
		Stream stream = default(Stream);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					StreamReader streamReader = new StreamReader(stream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							result = (string)PSXW0bBcZW2jouy02RaB(streamReader);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num4 = 0;
							}
							return num4 switch
							{
								0 => result, 
								_ => result, 
							};
						}
						finally
						{
							int num5;
							if (streamReader == null)
							{
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
								{
									num5 = 0;
								}
								goto IL_00be;
							}
							goto IL_00f3;
							IL_00f3:
							PJBv4gBcuaTyBkxKDBDi(streamReader);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
							{
								num5 = 0;
							}
							goto IL_00be;
							IL_00be:
							switch (num5)
							{
							case 2:
								goto end_IL_0099;
							case 1:
								goto end_IL_0099;
							}
							goto IL_00f3;
							end_IL_0099:;
						}
					}
				}
				finally
				{
					if (stream != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								PJBv4gBcuaTyBkxKDBDi(stream);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
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
			case 2:
				stream = (Stream)ENbhCnBc8JCmjmoIlwyA(nF4I5HBcvUVRyVuYEUV7(ErFQ9UBcCYWH10YpkBJc(uri)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			}
		}
	}

	internal static ServiceReferenceInfo GetServiceReferencesInfo(IEnumerable<ServiceDescription> contracts)
	{
		ServiceReferenceInfo serviceReferenceInfo = new ServiceReferenceInfo
		{
			MethodNames = new List<string>()
		};
		foreach (ServiceDescription contract in contracts)
		{
			serviceReferenceInfo.Name = contract.Name;
			if (contract.Services.Count > 0)
			{
				foreach (Service service in contract.Services)
				{
					{
						IEnumerator enumerator3 = service.Ports.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
								CS_0024_003C_003E8__locals0.port = (Port)enumerator3.Current;
								_003C_003Ec__DisplayClass15_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass15_1();
								Binding[] source = contract.Bindings.CastToArrayOrNull<Binding>();
								CS_0024_003C_003E8__locals1.binding = source.FirstOrDefault((Binding q) => _003C_003Ec__DisplayClass15_0.scbfmoQPgQ5SLgEiFxig(q.Name, CS_0024_003C_003E8__locals0.port.Binding.Name));
								if (CS_0024_003C_003E8__locals1.binding == null)
								{
									continue;
								}
								PortType portType = contract.PortTypes.CastToArrayOrNull<PortType>().FirstOrDefault((PortType q) => _003C_003Ec__DisplayClass15_1.P2xPwlQPzt6GMC8dcRoo(_003C_003Ec__DisplayClass15_1.NGi0b7QPUWDSo3Ibe6FY(q), _003C_003Ec__DisplayClass15_1.hO26iHQPctuve9de01lb(_003C_003Ec__DisplayClass15_1.WbjvfPQPsRJBudq0GVTD(CS_0024_003C_003E8__locals1.binding))));
								if (portType == null)
								{
									continue;
								}
								foreach (Operation operation3 in portType.Operations)
								{
									serviceReferenceInfo.MethodNames.Add(operation3.Name);
								}
							}
						}
						finally
						{
							IDisposable disposable = enumerator3 as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					if (string.IsNullOrEmpty(serviceReferenceInfo.Name))
					{
						serviceReferenceInfo.Name = service.Name;
					}
				}
				continue;
			}
			foreach (PortType portType2 in contract.PortTypes)
			{
				foreach (Operation operation4 in portType2.Operations)
				{
					serviceReferenceInfo.MethodNames.Add(operation4.Name);
				}
			}
		}
		return serviceReferenceInfo;
	}

	public static string[] GetElmaAssemblyList()
	{
		int num = 2;
		int num2 = num;
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!JBjKf3BcVRQJwm0PPaak(directoryInfo))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				}
				return ((IEnumerable<FileInfo>)uGF72eBcSCIrpWoV1ieR(directoryInfo, Vjcn1SBcEP0FZsDVoL39(-2112703338 ^ -2112622512), SearchOption.TopDirectoryOnly)).Select((FileInfo info) => Path.GetFileNameWithoutExtension(info.Name)).ToArray();
			case 2:
				directoryInfo = new DirectoryInfo((string)gHWExxBcIMmdFCOSDYs2());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new string[0];
			}
		}
	}

	static AssemblyReferenceHelper()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				DefaultWebReferences = new string[5]
				{
					(string)Vjcn1SBcEP0FZsDVoL39(-1334993905 ^ -1335092103),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107945840),
					(string)Vjcn1SBcEP0FZsDVoL39(0xD3DEF7E ^ 0xD3C6FC6),
					(string)Vjcn1SBcEP0FZsDVoL39(0x5DD55050 ^ 0x5DD4D080),
					(string)Vjcn1SBcEP0FZsDVoL39(0x4EDCBA32 ^ 0x4EDD3AC8)
				};
				num2 = 4;
				continue;
			case 2:
				DefaultGlobalReferencesList = new string[5]
				{
					(string)Vjcn1SBcEP0FZsDVoL39(0x6DC147B0 ^ 0x6DC049EE),
					(string)Vjcn1SBcEP0FZsDVoL39(0x269E5FCA ^ 0x269F2074),
					(string)Vjcn1SBcEP0FZsDVoL39(0x7459E02 ^ 0x744E1DA),
					(string)Vjcn1SBcEP0FZsDVoL39(-3333094 ^ -3365828),
					(string)Vjcn1SBcEP0FZsDVoL39(-234299632 ^ -234266814)
				};
				num2 = 3;
				continue;
			case 1:
				UlHpHUBciSODPpBbkrp5();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return;
			}
			DefaultElmaReferenceList = new string[3]
			{
				(string)Vjcn1SBcEP0FZsDVoL39(0x49E27B8A ^ 0x49E26596),
				(string)Vjcn1SBcEP0FZsDVoL39(-488881205 ^ -488817583),
				(string)Vjcn1SBcEP0FZsDVoL39(-1459557599 ^ -1459560177)
			};
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static object L2CpahBcWp5j3G236erx()
	{
		return TypeOf<object>.Assembly;
	}

	internal static object ujTTxxBco6UYt5m2eLvT(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static object lrR6A1BcboudH0fWN7pB(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static bool B1OsWbBcFr7ZpqecmAfg()
	{
		return mZ7dnMBszP3dc7VA42Ke == null;
	}

	internal static AssemblyReferenceHelper AUcMgVBcBvI2Hbodo7TU()
	{
		return mZ7dnMBszP3dc7VA42Ke;
	}

	internal static object DFgEevBchqg6ha7gFYvk(object P_0)
	{
		return ((IOmniSharpWorker)P_0).CompletionLibsPath;
	}

	internal static object pUeKm2BcG12bWLtg8GNW()
	{
		return ExternalAssemblyLocation;
	}

	internal static object Vjcn1SBcEP0FZsDVoL39(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object f6hs2hBcfuteCgRjX7IG(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object sJBlneBcQATD61cPgrJh(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object ErFQ9UBcCYWH10YpkBJc(object P_0)
	{
		return WebRequest.Create((Uri)P_0);
	}

	internal static object nF4I5HBcvUVRyVuYEUV7(object P_0)
	{
		return ((WebRequest)P_0).GetResponse();
	}

	internal static object ENbhCnBc8JCmjmoIlwyA(object P_0)
	{
		return ((WebResponse)P_0).GetResponseStream();
	}

	internal static object PSXW0bBcZW2jouy02RaB(object P_0)
	{
		return ((TextReader)P_0).ReadToEnd();
	}

	internal static void PJBv4gBcuaTyBkxKDBDi(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object gHWExxBcIMmdFCOSDYs2()
	{
		return ElmaAssemblyLocation;
	}

	internal static bool JBjKf3BcVRQJwm0PPaak(object P_0)
	{
		return ((FileSystemInfo)P_0).Exists;
	}

	internal static object uGF72eBcSCIrpWoV1ieR(object P_0, object P_1, SearchOption P_2)
	{
		return ((DirectoryInfo)P_0).GetFiles((string)P_1, P_2);
	}

	internal static void UlHpHUBciSODPpBbkrp5()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
