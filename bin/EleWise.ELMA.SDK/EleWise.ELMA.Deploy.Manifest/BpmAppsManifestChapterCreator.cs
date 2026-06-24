using System;
using System.Collections.Generic;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Manifest;

[Component]
public class BpmAppsManifestChapterCreator : IManifestChapterCreator
{
	private static BpmAppsManifestChapterCreator so0fjJEaDYth6CmS9Ne8;

	public void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc)
	{
		//Discarded unreachable code: IL_0056, IL_0060, IL_020a, IL_021d, IL_022c, IL_0276, IL_0285, IL_0295, IL_02a4, IL_02db, IL_02e5, IL_0343, IL_04c4, IL_04d7, IL_050d
		int num = 6;
		int num2 = num;
		Dictionary<string, ElmaStoreComponentManifest>.Enumerator enumerator = default(Dictionary<string, ElmaStoreComponentManifest>.Enumerator);
		BpmAppManifest item = default(BpmAppManifest);
		KeyValuePair<string, ElmaStoreComponentManifest> current = default(KeyValuePair<string, ElmaStoreComponentManifest>);
		Dictionary<string, BPMAppDTO>.Enumerator enumerator2 = default(Dictionary<string, BPMAppDTO>.Enumerator);
		BpmAppsExportSetting bpmAppsExportSetting = default(BpmAppsExportSetting);
		object value = default(object);
		BpmAppManifest item2 = default(BpmAppManifest);
		KeyValuePair<string, BPMAppDTO> current2 = default(KeyValuePair<string, BPMAppDTO>);
		while (true)
		{
			switch (num2)
			{
			case 8:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0064;
						}
						goto IL_00c8;
						IL_0064:
						while (true)
						{
							switch (num3)
							{
							case 4:
								((ElmaStoreComponentManifest)QQPnl3Ea4JD5cLEGRoOa(settings)).BpmApps.Add(item);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								break;
							case 5:
								goto IL_00c8;
							default:
								if (current.Value != null)
								{
									num3 = 3;
									continue;
								}
								break;
							case 3:
							{
								BpmAppManifest bpmAppManifest = new BpmAppManifest();
								HBkqb2EaAccrxfewrTP1(bpmAppManifest, Mat0AUEaHDdEuD1yFpiy(current.Value));
								bpmAppManifest.Author = (string)RCSsnGEa7O3Q4p4Uj3ay(current.Value);
								bpmAppManifest.Version = (string)RB4EivEa0IZovYV6riF5(current.Value);
								mwoBlZEaJmL6BkKZa2je(bpmAppManifest, string.IsNullOrWhiteSpace((string)xtBqYVEaybeUQVdjQXIZ(current.Value)) ? Mat0AUEaHDdEuD1yFpiy(current.Value) : xtBqYVEaybeUQVdjQXIZ(current.Value));
								Pcdct6Ea5QwsZ2Y78RhW(bpmAppManifest, JuJ5vdEa95NwuWgHHSPS(current.Value));
								bpmAppManifest.TagDataBase = current.Value.TagDataBase;
								tyAOYqEaryjRN7LLYXCK(bpmAppManifest, YScKn4EalTO9tkHUKqyJ(current.Value));
								r9C4mREagO8Hw13q31bZ(bpmAppManifest, o61vSGEajnHL6od8Odi9(current.Value));
								item = bpmAppManifest;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num3 = 4;
								}
								continue;
							}
							case 2:
								return;
							}
							break;
						}
						continue;
						IL_00c8:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num3 = 0;
						}
						goto IL_0064;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 9:
				enumerator2 = bpmAppsExportSetting.Components.GetEnumerator();
				num2 = 11;
				break;
			case 12:
				return;
			case 5:
				if (!settings.CustomSettings.TryGetValue(BpmAppsExportConsts.ExportBpmAppsUid, out value))
				{
					num2 = 10;
					break;
				}
				goto default;
			case 4:
				return;
			case 10:
				return;
			case 2:
				if (bpmAppsExportSetting.Files == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			case 11:
				try
				{
					while (true)
					{
						IL_034d:
						int num5;
						if (!enumerator2.MoveNext())
						{
							num5 = 4;
							goto IL_02e9;
						}
						goto IL_030f;
						IL_02e9:
						while (true)
						{
							switch (num5)
							{
							case 6:
								break;
							case 1:
								((ElmaStoreComponentManifest)QQPnl3Ea4JD5cLEGRoOa(settings)).BpmApps.Add(item2);
								num5 = 3;
								continue;
							default:
								goto IL_034d;
							case 2:
								if (current2.Value == null)
								{
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
									{
										num5 = 0;
									}
									continue;
								}
								goto case 5;
							case 5:
							{
								BpmAppManifest bpmAppManifest2 = new BpmAppManifest();
								HBkqb2EaAccrxfewrTP1(bpmAppManifest2, Mat0AUEaHDdEuD1yFpiy(xiT1s8Ea6dPIsAQnxqTp(current2.Value)));
								wMV4NvEaxW5p7ITjwS5W(bpmAppManifest2, RCSsnGEa7O3Q4p4Uj3ay(xiT1s8Ea6dPIsAQnxqTp(current2.Value)));
								ADe71fEam7siZGNXXMUU(bpmAppManifest2, RB4EivEa0IZovYV6riF5(xiT1s8Ea6dPIsAQnxqTp(current2.Value)));
								mwoBlZEaJmL6BkKZa2je(bpmAppManifest2, v6s6rvEaMDGtI2NLdREP(xtBqYVEaybeUQVdjQXIZ(xiT1s8Ea6dPIsAQnxqTp(current2.Value))) ? Mat0AUEaHDdEuD1yFpiy(xiT1s8Ea6dPIsAQnxqTp(current2.Value)) : xtBqYVEaybeUQVdjQXIZ(xiT1s8Ea6dPIsAQnxqTp(current2.Value)));
								bpmAppManifest2.Description = (string)JuJ5vdEa95NwuWgHHSPS(xiT1s8Ea6dPIsAQnxqTp(current2.Value));
								bpmAppManifest2.TagDataBase = (string)cV10Y7EadgKqSO8IDDZU(xiT1s8Ea6dPIsAQnxqTp(current2.Value));
								tyAOYqEaryjRN7LLYXCK(bpmAppManifest2, YScKn4EalTO9tkHUKqyJ(xiT1s8Ea6dPIsAQnxqTp(current2.Value)));
								r9C4mREagO8Hw13q31bZ(bpmAppManifest2, current2.Value.ComponentManifest.TagLanguage);
								item2 = bpmAppManifest2;
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
								{
									num5 = 1;
								}
								continue;
							}
							case 4:
								goto end_IL_034d;
							}
							break;
						}
						goto IL_030f;
						IL_030f:
						current2 = enumerator2.Current;
						num5 = 2;
						goto IL_02e9;
						continue;
						end_IL_034d:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			case 7:
				return;
			case 3:
				if (bpmAppsExportSetting.Components != null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 2;
			default:
				if ((bpmAppsExportSetting = value as BpmAppsExportSetting) == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				enumerator = bpmAppsExportSetting.Files.GetEnumerator();
				num2 = 8;
				break;
			case 6:
				if (QQPnl3Ea4JD5cLEGRoOa(settings) == null)
				{
					return;
				}
				num2 = 5;
				break;
			}
		}
	}

	public BpmAppsManifestChapterCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JsQl3NEaYepuDtUmpIfc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object QQPnl3Ea4JD5cLEGRoOa(object P_0)
	{
		return ((ConfigExportSettings)P_0).Manifest;
	}

	internal static object xiT1s8Ea6dPIsAQnxqTp(object P_0)
	{
		return ((BPMAppDTO)P_0).ComponentManifest;
	}

	internal static object Mat0AUEaHDdEuD1yFpiy(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Id;
	}

	internal static void HBkqb2EaAccrxfewrTP1(object P_0, object P_1)
	{
		((BpmAppManifest)P_0).Id = (string)P_1;
	}

	internal static object RCSsnGEa7O3Q4p4Uj3ay(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Author;
	}

	internal static void wMV4NvEaxW5p7ITjwS5W(object P_0, object P_1)
	{
		((BpmAppManifest)P_0).Author = (string)P_1;
	}

	internal static object RB4EivEa0IZovYV6riF5(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Version;
	}

	internal static void ADe71fEam7siZGNXXMUU(object P_0, object P_1)
	{
		((BpmAppManifest)P_0).Version = (string)P_1;
	}

	internal static object xtBqYVEaybeUQVdjQXIZ(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Title;
	}

	internal static bool v6s6rvEaMDGtI2NLdREP(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void mwoBlZEaJmL6BkKZa2je(object P_0, object P_1)
	{
		((BpmAppManifest)P_0).Title = (string)P_1;
	}

	internal static object JuJ5vdEa95NwuWgHHSPS(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Description;
	}

	internal static object cV10Y7EadgKqSO8IDDZU(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).TagDataBase;
	}

	internal static object YScKn4EalTO9tkHUKqyJ(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).TagEdition;
	}

	internal static void tyAOYqEaryjRN7LLYXCK(object P_0, object P_1)
	{
		((BpmAppManifest)P_0).TagEdition = (string)P_1;
	}

	internal static void r9C4mREagO8Hw13q31bZ(object P_0, object P_1)
	{
		((BpmAppManifest)P_0).TagLanguage = (string)P_1;
	}

	internal static void Pcdct6Ea5QwsZ2Y78RhW(object P_0, object P_1)
	{
		((BpmAppManifest)P_0).Description = (string)P_1;
	}

	internal static object o61vSGEajnHL6od8Odi9(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).TagLanguage;
	}

	internal static bool xc88qbEatc2MYml7FfR5()
	{
		return so0fjJEaDYth6CmS9Ne8 == null;
	}

	internal static BpmAppsManifestChapterCreator fRYutxEawoI179LyfKRS()
	{
		return so0fjJEaDYth6CmS9Ne8;
	}

	internal static void JsQl3NEaYepuDtUmpIfc()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
