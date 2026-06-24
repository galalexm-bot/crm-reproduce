using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Component(Order = 1050)]
internal class ComponentsBAConverter : IBPMAppItemsConverter
{
	internal static ComponentsBAConverter DwLCxBfOwLFRvyPuJXrd;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_00a3, IL_0176, IL_019b, IL_01aa
		int num = 1;
		ComponentExportSetting componentExportSetting = default(ComponentExportSetting);
		ComponentBAChapter componentBAChapter = default(ComponentBAChapter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
				{
					if (!settings.CustomSettings.TryGetValue(ComponentExportConsts.ExportExtensionUid, out var value))
					{
						num2 = 12;
						continue;
					}
					componentExportSetting = value as ComponentExportSetting;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 4;
					}
					continue;
				}
				case 12:
					return;
				case 9:
					return;
				case 11:
					return;
				default:
					Contract.ArgumentNotNull(settings, (string)BI5uvXfOH1ZE8ssNtGM5(0x3A6135BE ^ 0x3A61DF30));
					num2 = 13;
					continue;
				case 14:
					return;
				case 7:
				{
					ComponentBAChapter componentBAChapter2 = new ComponentBAChapter();
					mK1W5cfO71adsHaP3JHR(componentBAChapter2, ComponentExportConsts.ExportExtensionUid);
					componentBAChapter = componentBAChapter2;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 6:
				case 10:
					if (componentBAChapter.Components == null)
					{
						return;
					}
					num = 3;
					break;
				case 4:
					if (componentExportSetting == null)
					{
						return;
					}
					num2 = 7;
					continue;
				case 1:
					GgLUWPfOA5mD71Duu5q3(bpmAppManifest, BI5uvXfOH1ZE8ssNtGM5(-1765851862 ^ -1766165064));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (componentExportSetting.ComponentsIds == null)
					{
						num2 = 10;
						continue;
					}
					goto case 5;
				case 2:
					FYNVpRfO0A0WuxVeYZIS(bpmAppManifest, componentBAChapter);
					num = 9;
					break;
				case 3:
					if (pAo6MnfOxAOmmW95xPaJ(componentBAChapter.Components) <= 0)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 2;
				case 5:
					componentBAChapter.Components = componentExportSetting.ComponentsIds.Select((Guid uid) => new ComponentBAItem
					{
						Uid = uid
					}).ToList();
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_0093, IL_00a1, IL_0151, IL_0164, IL_0173
		int num = 6;
		int num2 = num;
		ComponentBAChapter componentBAChapter = default(ComponentBAChapter);
		List<ComponentBAItem>.Enumerator enumerator = default(List<ComponentBAItem>.Enumerator);
		ComponentBAItem current = default(ComponentBAItem);
		ComponentExportSetting componentExportSetting = default(ComponentExportSetting);
		while (true)
		{
			switch (num2)
			{
			case 11:
				return;
			case 2:
				if (componentBAChapter != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				try
				{
					while (true)
					{
						IL_00e2:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num3 = 1;
							}
							goto IL_00a5;
						}
						goto IL_00bf;
						IL_00bf:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num3 = 0;
						}
						goto IL_00a5;
						IL_00a5:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 3:
								goto IL_00e2;
							default:
								componentExportSetting.ComponentsIds.Add(H4QWBrfOyh9b14yIwuAN(current));
								num3 = 3;
								continue;
							case 1:
								goto end_IL_00e2;
							}
							break;
						}
						goto IL_00bf;
						continue;
						end_IL_00e2:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 9;
			case 1:
				return;
			default:
				componentExportSetting = new ComponentExportSetting();
				num2 = 10;
				break;
			case 9:
				settings.CustomSettings[ComponentExportConsts.ExportExtensionUid] = componentExportSetting;
				num2 = 11;
				break;
			case 5:
				GgLUWPfOA5mD71Duu5q3(settings, BI5uvXfOH1ZE8ssNtGM5(0x10E41EDB ^ 0x10E4F455));
				num2 = 8;
				break;
			case 10:
				if (componentBAChapter.Components != null)
				{
					num2 = 4;
					break;
				}
				goto case 9;
			case 7:
				enumerator = componentBAChapter.Components.GetEnumerator();
				num2 = 3;
				break;
			case 4:
				componentExportSetting.ComponentsIds = new List<Guid>();
				num2 = 7;
				break;
			case 8:
				componentBAChapter = LtNjbUfOmEW8FiJ2uSZw(bpmAppManifest, ComponentExportConsts.ExportExtensionUid) as ComponentBAChapter;
				num2 = 2;
				break;
			case 6:
				GgLUWPfOA5mD71Duu5q3(bpmAppManifest, BI5uvXfOH1ZE8ssNtGM5(-978351861 ^ -978665063));
				num2 = 5;
				break;
			}
		}
	}

	public ComponentsBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XHgxDufOM3nMGcEUrrhE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object BI5uvXfOH1ZE8ssNtGM5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void GgLUWPfOA5mD71Duu5q3(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void mK1W5cfO71adsHaP3JHR(object P_0, Guid value)
	{
		((BPMAppManifestChapter)P_0).Uid = value;
	}

	internal static int pAo6MnfOxAOmmW95xPaJ(object P_0)
	{
		return ((List<ComponentBAItem>)P_0).Count;
	}

	internal static void FYNVpRfO0A0WuxVeYZIS(object P_0, object P_1)
	{
		((BPMAppManifest)P_0).SetChapter((BPMAppManifestChapter)P_1);
	}

	internal static bool hf0BkjfO4lNjMPPiwJ1Q()
	{
		return DwLCxBfOwLFRvyPuJXrd == null;
	}

	internal static ComponentsBAConverter QQyNxAfO6ZvnGPrVMVFu()
	{
		return DwLCxBfOwLFRvyPuJXrd;
	}

	internal static object LtNjbUfOmEW8FiJ2uSZw(object P_0, Guid uid)
	{
		return ((BPMAppManifest)P_0).GetChapter(uid);
	}

	internal static Guid H4QWBrfOyh9b14yIwuAN(object P_0)
	{
		return ((BPMAppManifestItem)P_0).Uid;
	}

	internal static void XHgxDufOM3nMGcEUrrhE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
