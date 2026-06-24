using System;
using System.Collections.Generic;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Services;

public class MetadataServiceContext : IDisposable
{
	private static AsyncLocal<IMetadataService> currentService;

	private IMetadataService _previousService;

	private static IMetadataEditorService _metadataEditorService;

	private static IMetadataRuntimeService _metadataRuntimeService;

	private static MetadataServiceContext TdA0FhbZNUH66ZDpembH;

	[NotNull]
	public static IMetadataService Service => ServiceOrNull ?? throw new ServiceNotFoundException((string)Jayw0UbZDNbAKYN3feOW(-583745292 ^ -583633400));

	[NotNull]
	public static IMetadataEditorService MetadataEditorService => (IMetadataEditorService)(U4DrDSbZtcohv1RJnrWj() ?? throw new ServiceNotFoundException((string)Jayw0UbZDNbAKYN3feOW(0x4DC2B14D ^ 0x4DC0066D)));

	[NotNull]
	public static IMetadataRuntimeService MetadataRuntimeService => (IMetadataRuntimeService)(zC4FdCbZwXQcRtAAj13r() ?? throw new ServiceNotFoundException((string)Jayw0UbZDNbAKYN3feOW(-1146510045 ^ -1146416525)));

	[CanBeNull]
	public static IMetadataService ServiceOrNull
	{
		get
		{
			int num = 7;
			IMetadataService metadataService2 = default(IMetadataService);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					IMetadataService metadataService;
					switch (num2)
					{
					case 7:
						if (currentService.Value != null)
						{
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num2 = 2;
							}
						}
						else if (gPgrpfbZ4NFRc4xWWcJO())
						{
							metadataService2 = _metadataRuntimeService;
							num2 = 8;
						}
						else
						{
							num2 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num2 = 8;
							}
						}
						continue;
					case 9:
						return null;
					case 8:
						metadataService = metadataService2;
						if (metadataService == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num2 = 4;
							}
							continue;
						}
						break;
					case 6:
						return currentService.Value;
					case 3:
						metadataService2 = (IMetadataService)U4DrDSbZtcohv1RJnrWj();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 5;
						}
						continue;
					case 2:
						metadataService2 = (IMetadataService)zC4FdCbZwXQcRtAAj13r();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 1;
						}
						continue;
					case 5:
						metadataService = metadataService2;
						if (metadataService == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 4:
						metadataService2 = _metadataEditorService;
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 6;
						}
						continue;
					case 10:
						metadataService = metadataService2;
						if (metadataService != null)
						{
							break;
						}
						num2 = 2;
						continue;
					case 1:
						metadataService = metadataService2;
						if (metadataService == null)
						{
							goto end_IL_0012;
						}
						break;
					default:
						metadataService = Locator.GetService<IMetadataService>();
						break;
					}
					return metadataService;
					continue;
					end_IL_0012:
					break;
				}
				num = 3;
			}
		}
	}

	[CanBeNull]
	public static IMetadataEditorService MetadataEditorServiceOrNull
	{
		get
		{
			int num = 1;
			int num2 = num;
			IMetadataEditorService metadataEditorService;
			while (true)
			{
				switch (num2)
				{
				case 1:
					metadataEditorService = _metadataEditorService;
					if (metadataEditorService != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					metadataEditorService = (_metadataEditorService = Locator.GetService<IMetadataEditorService>());
					break;
				}
				break;
			}
			return metadataEditorService;
		}
	}

	[CanBeNull]
	public static IMetadataRuntimeService MetadataRuntimeServiceOrNull
	{
		get
		{
			int num = 1;
			int num2 = num;
			IMetadataRuntimeService metadataRuntimeService;
			while (true)
			{
				switch (num2)
				{
				case 1:
					metadataRuntimeService = _metadataRuntimeService;
					if (metadataRuntimeService == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					metadataRuntimeService = (_metadataRuntimeService = Locator.GetService<IMetadataRuntimeService>());
					break;
				}
				break;
			}
			return metadataRuntimeService;
		}
	}

	public MetadataServiceContext(IMetadataService service)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VnemkDbZaZQWSAwC1vTx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				_previousService = currentService.Value;
				num = 2;
				break;
			case 1:
				return;
			case 2:
				currentService.Value = service;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void Dispose()
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
				currentService.Value = _previousService;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void ClearInjections()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				_metadataRuntimeService = null;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_metadataEditorService = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static MetadataServiceContext New<TService>() where TService : IMetadataService
	{
		return new MetadataServiceContext(Locator.GetServiceNotNull<TService>());
	}

	public static MetadataServiceContext Extend(IEnumerable<IMetadata> metadataList)
	{
		return new MetadataServiceContext(new ExtendedMetadataService(Service, metadataList));
	}

	static MetadataServiceContext()
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
				currentService = new AsyncLocal<IMetadataService>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void VnemkDbZaZQWSAwC1vTx()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool k9CI0JbZ3Nr3YgSVFr5m()
	{
		return TdA0FhbZNUH66ZDpembH == null;
	}

	internal static MetadataServiceContext tTVPwCbZpP0tFmGFbLQM()
	{
		return TdA0FhbZNUH66ZDpembH;
	}

	internal static object Jayw0UbZDNbAKYN3feOW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object U4DrDSbZtcohv1RJnrWj()
	{
		return MetadataEditorServiceOrNull;
	}

	internal static object zC4FdCbZwXQcRtAAj13r()
	{
		return MetadataRuntimeServiceOrNull;
	}

	internal static bool gPgrpfbZ4NFRc4xWWcJO()
	{
		return Locator.Initialized;
	}
}
