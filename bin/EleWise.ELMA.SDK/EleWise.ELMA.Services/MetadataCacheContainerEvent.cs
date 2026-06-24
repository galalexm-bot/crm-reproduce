using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Component]
internal sealed class MetadataCacheContainerEvent : IInitHandler
{
	[Component]
	private sealed class RuntimeHashGenerator : IAfterDeltaPublishEventHandler, IEventHandler
	{
		private readonly object metadataCacheService;

		private readonly object unitOfWorkManager;

		private readonly object runtimeApplication;

		private static object z8li3TQK5O6kXgHB9758;

		public RuntimeHashGenerator(IMetadataCacheService metadataCacheService, IUnitOfWorkManager unitOfWorkManager, IRuntimeApplication runtimeApplication)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			MUnvCLQKL99glU3FhB8n();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					this.metadataCacheService = metadataCacheService;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num = 0;
					}
					break;
				case 3:
					this.runtimeApplication = runtimeApplication;
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num = 1;
					}
					break;
				case 2:
					return;
				default:
					this.unitOfWorkManager = unitOfWorkManager;
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public void Processing(MetadataPublishedEventArgs e)
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
					aVLmCLQKUScSmknHD3mv(unitOfWorkManager, (Action)delegate
					{
						int num3 = 1;
						int num4 = num3;
						string text = default(string);
						while (true)
						{
							switch (num4)
							{
							case 2:
								return;
							default:
								j7dIZYQKcqksckLG3aBn(metadataCacheService, text);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num4 = 2;
								}
								break;
							case 1:
								text = (string)H2ly88QKsHJJTN03MMw5(runtimeApplication);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static void MUnvCLQKL99glU3FhB8n()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool mk8MdoQKjphQsiKO2DYG()
		{
			return z8li3TQK5O6kXgHB9758 == null;
		}

		internal static RuntimeHashGenerator gs9IKaQKYXfFSwoEQycg()
		{
			return (RuntimeHashGenerator)z8li3TQK5O6kXgHB9758;
		}

		internal static void aVLmCLQKUScSmknHD3mv(object P_0, object P_1)
		{
			((IUnitOfWorkManager)P_0).RegisterPreCommitAction((Action)P_1);
		}

		internal static object H2ly88QKsHJJTN03MMw5(object P_0)
		{
			return GetHashes(P_0);
		}

		internal static void j7dIZYQKcqksckLG3aBn(object P_0, object P_1)
		{
			((IMetadataCacheService)P_0).SetRuntimeHash((string)P_1);
		}
	}

	private readonly IMetadataCacheService metadataCacheService;

	internal static MetadataCacheContainerEvent N4pYhBBDvBN18Ji35Mg4;

	public MetadataCacheContainerEvent(IMetadataCacheService metadataCacheService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.metadataCacheService = metadataCacheService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
			{
				num = 1;
			}
		}
	}

	public void Init()
	{
	}

	public void InitComplete()
	{
		//Discarded unreachable code: IL_009a, IL_00a9, IL_0153
		int num = 7;
		string text2 = default(string);
		IRuntimeApplication service = default(IRuntimeApplication);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					text2 = (string)g072bABDIlNr9sFnwpQ2(service);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (service == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 3;
						}
						continue;
					}
					text = (string)JObSN6BDu2rAamjq0TNF(metadataCacheService);
					num = 9;
					break;
				case 1:
					return;
				case 12:
					return;
				case 5:
				case 8:
					flag = true;
					num2 = 4;
					continue;
				case 2:
					flag = l9kwHABDSbPHLhFRPckW(text, text2);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
				case 11:
					if (!flag)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 10:
					WKavGTBDiGkdulJ8EFVK(metadataCacheService, text2);
					num2 = 12;
					continue;
				case 7:
					service = Locator.GetService<IRuntimeApplication>();
					num = 6;
					break;
				case 3:
					return;
				default:
					if (suXbRhBDVr4Cm3yQRA04(text))
					{
						num2 = 5;
						continue;
					}
					goto case 2;
				}
				break;
			}
		}
	}

	private static string GetHashes(object runtimeApplication)
	{
		int num = 1;
		int num2 = num;
		AssemblyInfoCache[] assemblyInfos = default(AssemblyInfoCache[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				assemblyInfos = ((ApplicationStartCache)K1XF89BDRxKULWvKJ3bU(runtimeApplication)).AssemblyInfos;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				continue;
			}
			return string.Join((string)mBpV3pBDqWsTrIORIpqQ(-606654180 ^ -606651034), from a in assemblyInfos.Where(delegate(AssemblyInfoCache a)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return _003C_003Ec.uFVBvqQXbZaAyd9FSCXj(_003C_003Ec.X5dJk1QXhPRbXhrnQ082(a), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA54A58));
						case 1:
							if (_003C_003Ec.uFVBvqQXbZaAyd9FSCXj(a.AssemblyName, _003C_003Ec.RnvB39QXoVId8rmcEhMo(-1638402543 ^ -1638400961)))
							{
								return true;
							}
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				})
				select (string)_003C_003Ec.HTnByJQXG1IAFAqKjM0D(a));
		}
	}

	internal static bool P2k7gcBD8R0NbJHDaDyT()
	{
		return N4pYhBBDvBN18Ji35Mg4 == null;
	}

	internal static MetadataCacheContainerEvent Up4mJ9BDZS8ExoYDUT49()
	{
		return N4pYhBBDvBN18Ji35Mg4;
	}

	internal static object JObSN6BDu2rAamjq0TNF(object P_0)
	{
		return ((IMetadataCacheService)P_0).GetRuntimeHash();
	}

	internal static object g072bABDIlNr9sFnwpQ2(object P_0)
	{
		return GetHashes(P_0);
	}

	internal static bool suXbRhBDVr4Cm3yQRA04(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool l9kwHABDSbPHLhFRPckW(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void WKavGTBDiGkdulJ8EFVK(object P_0, object P_1)
	{
		((IMetadataCacheService)P_0).SetRuntimeHash((string)P_1);
	}

	internal static object K1XF89BDRxKULWvKJ3bU(object P_0)
	{
		return ((IRuntimeApplication)P_0).ApplicationStartCache;
	}

	internal static object mBpV3pBDqWsTrIORIpqQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
