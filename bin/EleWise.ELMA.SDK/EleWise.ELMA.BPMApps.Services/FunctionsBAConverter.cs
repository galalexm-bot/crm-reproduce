using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Component(Order = 1050)]
internal class FunctionsBAConverter : IBPMAppItemsConverter
{
	internal static FunctionsBAConverter Tf0JpXfO5Y0hGsxTsYr1;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_00e1, IL_00f0, IL_0100
		int num = 3;
		int num2 = num;
		FunctionBAChapter functionBAChapter = default(FunctionBAChapter);
		FunctionExportSetting functionExportSetting = default(FunctionExportSetting);
		while (true)
		{
			switch (num2)
			{
			case 2:
				uyawnSfOUKlTQkVPF8sL(settings, Vc3PUofOLibih4DpJKVK(-1317790512 ^ -1317734818));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 4;
				}
				break;
			case 9:
				if (functionBAChapter.Functions == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 5;
			case 4:
			{
				if (!settings.CustomSettings.TryGetValue(FunctionExportConsts.ExportExtensionUid, out var value))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 12;
					}
					break;
				}
				functionExportSetting = value as FunctionExportSetting;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 11;
				}
				break;
			}
			case 1:
				return;
			case 7:
				return;
			case 11:
				if (functionExportSetting != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 5:
				if (G97fCkfOsvIePRs868AH(functionBAChapter.Functions) <= 0)
				{
					return;
				}
				num2 = 8;
				break;
			case 13:
				return;
			default:
				functionBAChapter = new FunctionBAChapter
				{
					Uid = FunctionExportConsts.ExportExtensionUid
				};
				num2 = 10;
				break;
			case 12:
				return;
			case 8:
				bpmAppManifest.SetChapter(functionBAChapter);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				uyawnSfOUKlTQkVPF8sL(bpmAppManifest, Vc3PUofOLibih4DpJKVK(-345420348 ^ -345242282));
				num2 = 2;
				break;
			case 10:
				if (functionExportSetting.FunctionsIds != null)
				{
					num2 = 6;
					break;
				}
				goto case 9;
			case 6:
				functionBAChapter.Functions = functionExportSetting.FunctionsIds.Select(delegate(Guid uid)
				{
					FunctionBAItem functionBAItem = new FunctionBAItem();
					_003C_003Ec.YvqXyh8zDf0k5Mr1YpCa(functionBAItem, uid);
					return functionBAItem;
				}).ToList();
				num2 = 9;
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_0091, IL_00a0, IL_00ab, IL_015b, IL_016e, IL_017d
		int num = 8;
		int num2 = num;
		FunctionBAChapter functionBAChapter = default(FunctionBAChapter);
		FunctionExportSetting functionExportSetting = default(FunctionExportSetting);
		List<FunctionBAItem>.Enumerator enumerator = default(List<FunctionBAItem>.Enumerator);
		FunctionBAItem current = default(FunctionBAItem);
		while (true)
		{
			switch (num2)
			{
			case 10:
				if (functionBAChapter.Functions != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 6;
			case 6:
				settings.CustomSettings[FunctionExportConsts.ExportExtensionUid] = functionExportSetting;
				num2 = 5;
				break;
			case 5:
				return;
			default:
				try
				{
					while (true)
					{
						IL_0119:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_00af;
						}
						goto IL_00c9;
						IL_00af:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 2:
								functionExportSetting.FunctionsIds.Add(A68WB7fOzgUUhwFhgndX(current));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
								{
									num3 = 0;
								}
								continue;
							default:
								goto IL_0119;
							case 3:
								goto end_IL_0119;
							}
							break;
						}
						goto IL_00c9;
						IL_00c9:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num3 = 2;
						}
						goto IL_00af;
						continue;
						end_IL_0119:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 6;
			case 4:
				functionBAChapter = m6Qx5YfOcMSLR6j5RP5C(bpmAppManifest, FunctionExportConsts.ExportExtensionUid) as FunctionBAChapter;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 9:
				enumerator = functionBAChapter.Functions.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (functionBAChapter != null)
				{
					functionExportSetting = new FunctionExportSetting();
					num2 = 10;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 3;
				}
				break;
			case 8:
				uyawnSfOUKlTQkVPF8sL(bpmAppManifest, Vc3PUofOLibih4DpJKVK(0x5DD55050 ^ 0x5DD018C2));
				num2 = 7;
				break;
			case 7:
				Contract.ArgumentNotNull(settings, (string)Vc3PUofOLibih4DpJKVK(0x57A5235E ^ 0x57A5C9D0));
				num2 = 4;
				break;
			case 2:
				functionExportSetting.FunctionsIds = new List<Guid>();
				num2 = 9;
				break;
			}
		}
	}

	public FunctionsBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tILH16f2FW1NvgwOnXX5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Vc3PUofOLibih4DpJKVK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void uyawnSfOUKlTQkVPF8sL(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static int G97fCkfOsvIePRs868AH(object P_0)
	{
		return ((List<FunctionBAItem>)P_0).Count;
	}

	internal static bool P642F0fOjEEyI3E3YLMn()
	{
		return Tf0JpXfO5Y0hGsxTsYr1 == null;
	}

	internal static FunctionsBAConverter pN7TjsfOYYh7lWYKQALX()
	{
		return Tf0JpXfO5Y0hGsxTsYr1;
	}

	internal static object m6Qx5YfOcMSLR6j5RP5C(object P_0, Guid uid)
	{
		return ((BPMAppManifest)P_0).GetChapter(uid);
	}

	internal static Guid A68WB7fOzgUUhwFhgndX(object P_0)
	{
		return ((BPMAppManifestItem)P_0).Uid;
	}

	internal static void tILH16f2FW1NvgwOnXX5()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
