using System;
using System.Collections.Generic;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Deploy;
using EleWise.ELMA.Workflow.Deploy.Export;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMApps;

[Component(Order = 410)]
public class CustomActivityBAConverter : IBPMAppItemsConverter
{
	private static readonly Guid _exportCustomActivitiesUid;

	internal static CustomActivityBAConverter p6VwDXU0NQJtuKcpNMh;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_00ee, IL_0197, IL_024c, IL_025b, IL_0354, IL_0367, IL_0376, IL_0386, IL_0395, IL_03a5, IL_03c5, IL_03d4, IL_0536, IL_0545, IL_0550, IL_0625, IL_0634, IL_0694, IL_06a7, IL_06b6
		int num = 29;
		CustomActivityFolderDTO group = default(CustomActivityFolderDTO);
		Dictionary<long, CustomActivityHeaderDTO> dictionary = default(Dictionary<long, CustomActivityHeaderDTO>);
		Dictionary<Guid, CustomActivityHeaderDTO> dictionary2 = default(Dictionary<Guid, CustomActivityHeaderDTO>);
		HashSet<Guid> hashSet = default(HashSet<Guid>);
		object value2 = default(object);
		CustomActivityBAChapter customActivityBAChapter = default(CustomActivityBAChapter);
		CustomActivityExportSetting customActivityExportSetting = default(CustomActivityExportSetting);
		List<long>.Enumerator enumerator = default(List<long>.Enumerator);
		List<Guid>.Enumerator enumerator2 = default(List<Guid>.Enumerator);
		Guid current2 = default(Guid);
		CustomActivityHeaderDTO value3 = default(CustomActivityHeaderDTO);
		long current = default(long);
		CustomActivityHeaderDTO value = default(CustomActivityHeaderDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 9:
					FillDictionaryById(group, dictionary, dictionary2);
					num = 21;
					break;
				case 21:
					hashSet = new HashSet<Guid>();
					num = 6;
					break;
				case 11:
					return;
				case 31:
					if (settings.CustomSettings.TryGetValue(CustomActivityExportConsts.ExportExtensionUid, out value2))
					{
						num2 = 14;
						continue;
					}
					return;
				case 22:
					customActivityBAChapter.CustomActivities = new List<CustomActivityBAItem>();
					num2 = 26;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e == 0)
					{
						num2 = 20;
					}
					continue;
				case 6:
					if (customActivityExportSetting.CustomActivityIds != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 != 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 17;
				case 20:
					enumerator = customActivityExportSetting.CustomActivityIds.GetEnumerator();
					num2 = 3;
					continue;
				case 2:
					return;
				case 14:
					customActivityExportSetting = value2 as CustomActivityExportSetting;
					num2 = 12;
					continue;
				case 25:
					return;
				case 7:
					if (yLgTp5UL971hnUU0Ywg(customActivityBAChapter.CustomActivities) <= 0)
					{
						num2 = 25;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb != 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 30;
				case 4:
					dictionary2 = new Dictionary<Guid, CustomActivityHeaderDTO>();
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2e79a6d6eb444d33993dd78f88b64832 == 0)
					{
						num2 = 9;
					}
					continue;
				case 30:
					dqvjPEUJvJVRK15ITbr(bpmAppManifest, customActivityBAChapter);
					num2 = 17;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f == 0)
					{
						num2 = 24;
					}
					continue;
				case 10:
					if (customActivityExportSetting.CustomActivityUids == null)
					{
						num2 = 8;
						continue;
					}
					goto case 15;
				case 28:
					vWTPeCUHt4RCeW8CZ2A(settings, zqWXGQUe0fggB0p1uUv(-7731921 ^ -7693309));
					num2 = 31;
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_02b4:
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 != 0)
								{
									num5 = 0;
								}
								goto IL_026a;
							}
							goto IL_02f7;
							IL_02f7:
							current2 = enumerator2.Current;
							int num6 = 5;
							num5 = num6;
							goto IL_026a;
							IL_026a:
							while (true)
							{
								switch (num5)
								{
								case 2:
								{
									List<CustomActivityBAItem> customActivities = customActivityBAChapter.CustomActivities;
									CustomActivityBAItem customActivityBAItem = new CustomActivityBAItem();
									lJPANeUfky37nilfoSH(customActivityBAItem, kHLsqKUlotYmnu0HMYY(value3));
									customActivities.Add(customActivityBAItem);
									num5 = 3;
									continue;
								}
								case 3:
									goto IL_02b4;
								case 4:
									if (hashSet.Add(value3.Uid))
									{
										num5 = 2;
										continue;
									}
									goto IL_02b4;
								case 1:
									goto IL_02f7;
								case 5:
									if (dictionary2.TryGetValue(current2, out value3))
									{
										num5 = 4;
										continue;
									}
									goto IL_02b4;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 1;
				case 23:
					dictionary = new Dictionary<long, CustomActivityHeaderDTO>();
					num2 = 4;
					continue;
				case 18:
					if (customActivityExportSetting.CustomActivityIds != null)
					{
						num2 = 15;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 10;
				case 17:
					if (customActivityExportSetting.CustomActivityUids != null)
					{
						num2 = 13;
						continue;
					}
					goto case 1;
				case 13:
					enumerator2 = customActivityExportSetting.CustomActivityUids.GetEnumerator();
					num2 = 5;
					continue;
				case 12:
					if (customActivityExportSetting == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						WU0ffZUuwXhVR639Cba(bpmAppManifest, _exportCustomActivitiesUid, uZ0ky0Uib9G3X5gdnyr(customActivityExportSetting));
						num2 = 27;
					}
					continue;
				case 15:
				case 16:
					group = Locator.GetServiceNotNull<ICustomActivityFolderDTOManager>().LoadRootFolder(0L);
					num2 = 23;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
					{
						num2 = 9;
					}
					continue;
				case 29:
					vWTPeCUHt4RCeW8CZ2A(bpmAppManifest, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51F798FE ^ 0x51F701F2));
					num = 28;
					break;
				case 1:
				case 8:
				case 19:
					if (customActivityBAChapter.CustomActivities == null)
					{
						num2 = 11;
						continue;
					}
					goto case 7;
				case 26:
					if (!uZ0ky0Uib9G3X5gdnyr(customActivityExportSetting))
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 18;
				case 27:
					customActivityBAChapter = new CustomActivityBAChapter
					{
						Uid = CustomActivityExportConsts.ExportExtensionUid
					};
					num2 = 22;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
					{
						num2 = 16;
					}
					continue;
				case 0:
					return;
				case 24:
					return;
				case 3:
					try
					{
						while (true)
						{
							IL_0642:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 7;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f != 0)
								{
									num3 = 4;
								}
								goto IL_0554;
							}
							goto IL_0598;
							IL_0598:
							current = enumerator.Current;
							num3 = 6;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 == 0)
							{
								num3 = 4;
							}
							goto IL_0554;
							IL_0554:
							while (true)
							{
								switch (num3)
								{
								case 6:
									if (!dictionary.TryGetValue(current, out value))
									{
										num3 = 4;
										continue;
									}
									goto case 2;
								case 5:
									break;
								case 3:
									customActivityBAChapter.CustomActivities.Add(new CustomActivityBAItem
									{
										Uid = value.Uid
									});
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa != 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
									if (!hashSet.Add(value.Uid))
									{
										num3 = 0;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 3;
								default:
									goto IL_0642;
								case 7:
									goto end_IL_0642;
								}
								break;
							}
							goto IL_0598;
							continue;
							end_IL_0642:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 17;
				}
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_00d1, IL_00db, IL_010a, IL_0119, IL_01f2, IL_0205, IL_0214
		int num = 4;
		List<CustomActivityBAItem>.Enumerator enumerator = default(List<CustomActivityBAItem>.Enumerator);
		CustomActivityBAChapter customActivityBAChapter = default(CustomActivityBAChapter);
		Dictionary<Guid, CustomActivityHeaderDTO> dictionary = default(Dictionary<Guid, CustomActivityHeaderDTO>);
		CustomActivityBAItem current = default(CustomActivityBAItem);
		CustomActivityExportSetting customActivityExportSetting = default(CustomActivityExportSetting);
		CustomActivityHeaderDTO value = default(CustomActivityHeaderDTO);
		CustomActivityFolderDTO group = default(CustomActivityFolderDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					enumerator = customActivityBAChapter.CustomActivities.GetEnumerator();
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 != 0)
					{
						num2 = 5;
					}
					break;
				case 6:
					dictionary = new Dictionary<Guid, CustomActivityHeaderDTO>();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
					{
						num2 = 1;
					}
					break;
				case 13:
					if (customActivityBAChapter.CustomActivities != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 8;
				case 5:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e == 0)
								{
									num3 = 1;
								}
								goto IL_00df;
							}
							goto IL_014a;
							IL_014a:
							current = enumerator.Current;
							num3 = 6;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
							{
								num3 = 6;
							}
							goto IL_00df;
							IL_00df:
							while (true)
							{
								switch (num3)
								{
								case 3:
								case 4:
									break;
								case 2:
									goto IL_014a;
								case 5:
									customActivityExportSetting.CustomActivityUids.Add(value.Uid);
									num3 = 3;
									continue;
								default:
									customActivityExportSetting.CustomActivityIds.Add(value.Id);
									num3 = 5;
									continue;
								case 6:
									if (!dictionary.TryGetValue(G8bl3lU5aGUj4m0DMFI(current), out value))
									{
										num3 = 4;
										continue;
									}
									goto default;
								case 1:
									goto end_IL_0124;
								}
								break;
							}
							continue;
							end_IL_0124:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 8;
				case 8:
					settings.CustomSettings[CustomActivityExportConsts.ExportExtensionUid] = customActivityExportSetting;
					num2 = 14;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 == 0)
					{
						num2 = 5;
					}
					break;
				case 4:
					vWTPeCUHt4RCeW8CZ2A(bpmAppManifest, zqWXGQUe0fggB0p1uUv(0x6C324F5C ^ 0x6C32D650));
					num2 = 3;
					break;
				default:
					if (customActivityBAChapter != null)
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 10:
					group = Locator.GetServiceNotNull<ICustomActivityFolderDTOManager>().LoadRootFolder(0L);
					num2 = 6;
					break;
				case 11:
					customActivityBAChapter = q2EWn2U7XKDjN6b4ZRu(bpmAppManifest, CustomActivityExportConsts.ExportExtensionUid) as CustomActivityBAChapter;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
					{
						num2 = 0;
					}
					break;
				case 12:
					customActivityExportSetting = new CustomActivityExportSetting();
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5158ff5e06d54ab9b6f7b04c47b15f73 == 0)
					{
						num2 = 9;
					}
					break;
				case 7:
					customActivityExportSetting.CustomActivityUids = new List<Guid>();
					num2 = 10;
					break;
				case 9:
					customActivityExportSetting.ExportCustomActivity = GfGslBUrrny5jc3mxuq(bpmAppManifest, _exportCustomActivitiesUid, uZ0ky0Uib9G3X5gdnyr(customActivityExportSetting));
					num2 = 11;
					break;
				case 3:
					Contract.ArgumentNotNull(settings, (string)zqWXGQUe0fggB0p1uUv(0x51B6C0BE ^ 0x51B65992));
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
					{
						num2 = 3;
					}
					break;
				case 14:
					return;
				case 2:
					customActivityExportSetting.CustomActivityIds = new List<long>();
					num2 = 7;
					break;
				case 1:
					FillDictionaryByUid(group, dictionary);
					num2 = 15;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	private void FillDictionaryById(CustomActivityFolderDTO group, Dictionary<long, CustomActivityHeaderDTO> headers, Dictionary<Guid, CustomActivityHeaderDTO> headersUids)
	{
		foreach (CustomActivityHeaderDTO customActivity in group.CustomActivitys)
		{
			headers[customActivity.Id] = customActivity;
			headersUids[customActivity.Uid] = customActivity;
		}
		foreach (CustomActivityFolderDTO subFolder in group.SubFolders)
		{
			FillDictionaryById(subFolder, headers, headersUids);
		}
	}

	private void FillDictionaryByUid(CustomActivityFolderDTO group, Dictionary<Guid, CustomActivityHeaderDTO> headers)
	{
		foreach (CustomActivityHeaderDTO customActivity in group.CustomActivitys)
		{
			headers[customActivity.Uid] = customActivity;
		}
		foreach (CustomActivityFolderDTO subFolder in group.SubFolders)
		{
			FillDictionaryByUid(subFolder, headers);
		}
	}

	public CustomActivityBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PZN4sTUgpFX2X0u9oQb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CustomActivityBAConverter()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				PZN4sTUgpFX2X0u9oQb();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				_exportCustomActivitiesUid = new Guid((string)zqWXGQUe0fggB0p1uUv(--1059430085 ^ 0x3F250785));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void vWTPeCUHt4RCeW8CZ2A(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object zqWXGQUe0fggB0p1uUv(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool uZ0ky0Uib9G3X5gdnyr(object P_0)
	{
		return ((CustomActivityExportSetting)P_0).ExportCustomActivity;
	}

	internal static void WU0ffZUuwXhVR639Cba(object P_0, Guid P_1, bool P_2)
	{
		((BPMAppManifest)P_0).SetFlag(P_1, P_2);
	}

	internal static Guid kHLsqKUlotYmnu0HMYY(object P_0)
	{
		return ((CustomActivityHeaderDTO)P_0).Uid;
	}

	internal static void lJPANeUfky37nilfoSH(object P_0, Guid P_1)
	{
		((BPMAppManifestItem)P_0).Uid = P_1;
	}

	internal static int yLgTp5UL971hnUU0Ywg(object P_0)
	{
		return ((List<CustomActivityBAItem>)P_0).Count;
	}

	internal static void dqvjPEUJvJVRK15ITbr(object P_0, object P_1)
	{
		((BPMAppManifest)P_0).SetChapter((BPMAppManifestChapter)P_1);
	}

	internal static bool j2HjEwUBlY9YANyKVMc()
	{
		return p6VwDXU0NQJtuKcpNMh == null;
	}

	internal static CustomActivityBAConverter yXl25iUWq70jkIgbftt()
	{
		return p6VwDXU0NQJtuKcpNMh;
	}

	internal static bool GfGslBUrrny5jc3mxuq(object P_0, Guid P_1, bool P_2)
	{
		return ((BPMAppManifest)P_0).GetFlag(P_1, P_2);
	}

	internal static object q2EWn2U7XKDjN6b4ZRu(object P_0, Guid P_1)
	{
		return ((BPMAppManifest)P_0).GetChapter(P_1);
	}

	internal static Guid G8bl3lU5aGUj4m0DMFI(object P_0)
	{
		return ((BPMAppManifestItem)P_0).Uid;
	}

	internal static void PZN4sTUgpFX2X0u9oQb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
