using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Constants;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Components;

[Component(Order = 10000, Type = ComponentType.Server)]
internal class UpdateFullTextSearchSettings : IModuleContainerEvents
{
	private static UpdateFullTextSearchSettings GygMwEGViE1VeXrD26Mh;

	public void Activated()
	{
		CheckSettings();
	}

	public void Terminating()
	{
	}

	private static void CheckSettings()
	{
		//Discarded unreachable code: IL_0199, IL_01c1, IL_01d0, IL_02a4, IL_02e5, IL_02f4
		switch (1)
		{
		case 1:
			try
			{
				Guid guid = default(Guid);
				int num = 2;
				FullTextSearchSettingsModule serviceNotNull = default(FullTextSearchSettingsModule);
				bool flag2 = default(bool);
				IFullTextSearchService serviceNotNull2 = default(IFullTextSearchService);
				bool? flag3 = default(bool?);
				bool? flag = default(bool?);
				while (true)
				{
					int num2;
					bool? flag4;
					switch (num)
					{
					case 10:
						if (DXJyBrGVX7iiiW2wymUm(guid, Guid.Empty))
						{
							num2 = 7;
							goto IL_0037;
						}
						return;
					case 1:
						if (serviceNotNull.Settings == null)
						{
							num = 13;
							break;
						}
						goto case 10;
					case 7:
					{
						IRuntimeApplication service = Locator.GetService<IRuntimeApplication>();
						if (service == null)
						{
							num = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num = 1;
							}
							break;
						}
						DbPreUpdater dbPreUpdater = service.DbPreUpdater;
						if (dbPreUpdater == null)
						{
							num2 = 11;
							goto IL_0037;
						}
						flag4 = dbPreUpdater.IsFirstStart;
						goto IL_0255;
					}
					case 14:
						if (serviceNotNull.Settings != null)
						{
							num = 12;
							break;
						}
						goto case 1;
					case 6:
						flag2 = true;
						num = 8;
						break;
					case 3:
						if (Mb98npGVOtCPpcFgACnr(serviceNotNull2) != 0)
						{
							num = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
							{
								num = 4;
							}
							break;
						}
						goto case 15;
					case 17:
						WP8GMqGVkMq5T3ExbEk7(serviceNotNull.Settings, QBCIqmGVThZNwBfq88jh());
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num = 0;
						}
						break;
					case 15:
						serviceNotNull2.StartIndexing();
						num = 16;
						break;
					case 11:
						flag3 = null;
						num = 18;
						break;
					case 5:
						serviceNotNull2 = Locator.GetServiceNotNull<IFullTextSearchService>();
						num = 3;
						break;
					case 4:
						return;
					case 2:
						serviceNotNull = Locator.GetServiceNotNull<FullTextSearchSettingsModule>();
						num2 = 14;
						goto IL_0037;
					case 13:
						return;
					default:
						b4dbeXGVndCmr91P6jC2(serviceNotNull);
						num = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num = 5;
						}
						break;
					case 12:
						guid = EcCvofGVKbaQkkBVp4Z6(serviceNotNull.Settings);
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num = 1;
						}
						break;
					case 18:
						flag4 = flag3;
						goto IL_0255;
					case 8:
						if (flag == flag2)
						{
							num = 17;
							break;
						}
						return;
					case 9:
						return;
					case 16:
						return;
						IL_0037:
						num = num2;
						break;
						IL_0255:
						flag = flag4;
						num = 6;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 1:
						rPUq1pGVeEddG65i5Xte(Y82GiXGV2onRk3hqf4bk(), ex);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num3 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		case 0:
			break;
		}
	}

	public UpdateFullTextSearchSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		S2ALX1GVPm5HMtuxVlbh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid EcCvofGVKbaQkkBVp4Z6(object P_0)
	{
		return ((FullTextSearchSettings)P_0).ProviderUid;
	}

	internal static bool DXJyBrGVX7iiiW2wymUm(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid QBCIqmGVThZNwBfq88jh()
	{
		return FullTextSearchConst.DeafultProviderUid;
	}

	internal static void WP8GMqGVkMq5T3ExbEk7(object P_0, Guid value)
	{
		((FullTextSearchSettings)P_0).ProviderUid = value;
	}

	internal static void b4dbeXGVndCmr91P6jC2(object P_0)
	{
		((GlobalSettingsModuleBase<FullTextSearchSettings>)P_0).SaveSettings();
	}

	internal static FullTextSearchState Mb98npGVOtCPpcFgACnr(object P_0)
	{
		return ((IFullTextSearchService)P_0).GetIndexState();
	}

	internal static object Y82GiXGV2onRk3hqf4bk()
	{
		return Logger.Log;
	}

	internal static void rPUq1pGVeEddG65i5Xte(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static bool phedceGVRJFK2ccJuxFi()
	{
		return GygMwEGViE1VeXrD26Mh == null;
	}

	internal static UpdateFullTextSearchSettings q7x0SwGVqO9LxfoDnTYR()
	{
		return GygMwEGViE1VeXrD26Mh;
	}

	internal static void S2ALX1GVPm5HMtuxVlbh()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
