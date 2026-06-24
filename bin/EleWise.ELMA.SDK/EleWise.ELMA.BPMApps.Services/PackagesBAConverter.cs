using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Component(Order = 2500)]
public class PackagesBAConverter : IBPMAppItemsConverter
{
	private static readonly Guid _exportPackagesUid;

	private static PackagesBAConverter vnxqpkf2ljsNUlyHxOUN;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_00d3, IL_010f
		int num = 9;
		int num2 = num;
		PackageExportSettings packageExportSettings = default(PackageExportSettings);
		PackagesBAChapter packagesBAChapter = default(PackagesBAChapter);
		object value = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				if (packageExportSettings.Packages != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 8:
				x4D3mUf2j2S2PNrpJTcM(settings, HNrBAdf25goZ99MBqxsi(-1867198571 ^ -1867242213));
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 2;
				}
				break;
			case 11:
				if (packagesBAChapter.Packages.Count <= 0)
				{
					num2 = 6;
					break;
				}
				goto case 15;
			case 6:
				return;
			case 0:
				return;
			case 14:
				return;
			case 12:
				packageExportSettings = value as PackageExportSettings;
				num2 = 5;
				break;
			case 1:
				dJDB9of2UlYGiy7g2GBD(bpmAppManifest, _exportPackagesUid, pg4Toof2LOWO173tM9Cb(packageExportSettings));
				num2 = 10;
				break;
			case 13:
				if (!settings.CustomSettings.TryGetValue(PackageExportConsts.ExportExtensionUid, out value))
				{
					return;
				}
				num2 = 12;
				break;
			case 9:
				Contract.ArgumentNotNull(bpmAppManifest, (string)HNrBAdf25goZ99MBqxsi(-1998538950 ^ -1998192728));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 3:
				if (packagesBAChapter.Packages == null)
				{
					return;
				}
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 2;
				}
				break;
			case 15:
				qgQuhHf2smSt1jAXLfoG(bpmAppManifest, packagesBAChapter);
				num2 = 2;
				break;
			case 10:
				if (pg4Toof2LOWO173tM9Cb(packageExportSettings))
				{
					num2 = 7;
					break;
				}
				goto case 3;
			case 5:
				if (packageExportSettings != null)
				{
					PackagesBAChapter packagesBAChapter2 = new PackagesBAChapter();
					tAGD2Of2YytoMhj0bTHE(packagesBAChapter2, PackageExportConsts.ExportExtensionUid);
					packagesBAChapter = packagesBAChapter2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 4:
				packagesBAChapter.Packages = packageExportSettings.Packages.Select(delegate(PackageDescription p)
				{
					PackageBAItem packageBAItem = new PackageBAItem();
					_003C_003Ec.swCb7h8zjoeaCFg2wiGa(packageBAItem, _003C_003Ec.Ra2RbQ8z5rTgESMaJG7I(p));
					packageBAItem.PackageTitle = (string)_003C_003Ec.hpi8v98zYS8XKulFFds4(p);
					return packageBAItem;
				}).ToList();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_00a2, IL_00ac, IL_020d, IL_021c, IL_0297, IL_02aa, IL_02b9, IL_03ea, IL_03f9
		int num = 4;
		int num2 = num;
		PackagesBAChapter packagesBAChapter = default(PackagesBAChapter);
		PackageExportSettings packageExportSettings = default(PackageExportSettings);
		List<PackageBAItem>.Enumerator enumerator = default(List<PackageBAItem>.Enumerator);
		PackageDescription packageDescription = default(PackageDescription);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		PackageBAItem current = default(PackageBAItem);
		IEnumerable<PackageDescription> source2 = default(IEnumerable<PackageDescription>);
		List<PackageDescription> source = default(List<PackageDescription>);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (packagesBAChapter != null)
				{
					num2 = 6;
					break;
				}
				goto default;
			case 2:
				packageExportSettings.ExportPackages = bpmAppManifest.GetFlag(_exportPackagesUid, pg4Toof2LOWO173tM9Cb(packageExportSettings));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 14;
				}
				break;
			case 10:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 8;
							goto IL_00b0;
						}
						goto IL_01a4;
						IL_00b0:
						while (true)
						{
							switch (num3)
							{
							case 7:
								if (packageDescription != null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 10;
							case 11:
								_003C_003Ec__DisplayClass1_.pkg1 = current;
								num3 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num3 = 2;
								}
								continue;
							case 2:
								_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
								{
									num3 = 6;
								}
								continue;
							case 10:
								packageDescription = source2.FirstOrDefault();
								num3 = 5;
								continue;
							case 6:
								packageExportSettings.Packages.Add(packageDescription);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num3 = 9;
								}
								continue;
							case 3:
								goto IL_01a4;
							case 12:
								source2 = source.Where(_003C_003Ec__DisplayClass1_._003CToExportSettings_003Eb__0);
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num3 = 4;
								}
								continue;
							case 1:
							case 5:
								if (packageDescription == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 6;
							case 4:
								packageDescription = source2.FirstOrDefault((PackageDescription p) => _003C_003Ec.aKGRVN8zLey0MmaLDUTC(p));
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num3 = 6;
								}
								continue;
							case 8:
								goto end_IL_0153;
							}
							break;
						}
						continue;
						IL_01a4:
						current = enumerator.Current;
						num3 = 2;
						goto IL_00b0;
						continue;
						end_IL_0153:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 5:
			{
				IDeployManager serviceNotNull = Locator.GetServiceNotNull<IDeployManager>();
				PackageFilter packageFilter = new PackageFilter();
				QRoJwvfeF5JcrPrZEZV6(packageFilter, PackageLevel.All);
				U5yoSnfeBJrIt1Rk8Fe8(packageFilter, PackageStatus.Any);
				PackageFilter filter = packageFilter;
				source = serviceNotNull.FindPackages(filter).ToList();
				num2 = 9;
				break;
			}
			case 9:
				enumerator = packagesBAChapter.Packages.GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 10;
				}
				break;
			case 12:
				if (XlMvH9f2zkQpgwbAKyfC(packagesBAChapter.Packages) <= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 11;
			case 6:
				if (packagesBAChapter.Packages != null)
				{
					num2 = 12;
					break;
				}
				goto default;
			case 1:
				packageExportSettings = new PackageExportSettings();
				num2 = 2;
				break;
			default:
				settings.CustomSettings[PackageExportConsts.ExportExtensionUid] = packageExportSettings;
				num2 = 8;
				break;
			case 8:
				return;
			case 3:
				x4D3mUf2j2S2PNrpJTcM(settings, HNrBAdf25goZ99MBqxsi(0x6DC147B0 ^ 0x6DC1AD3E));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				x4D3mUf2j2S2PNrpJTcM(bpmAppManifest, HNrBAdf25goZ99MBqxsi(-541731959 ^ -542074085));
				num2 = 3;
				break;
			case 11:
				packageExportSettings.Packages = new List<PackageDescription>();
				num2 = 5;
				break;
			case 14:
				packagesBAChapter = mHgY5Yf2conm1j43K0Xf(bpmAppManifest, PackageExportConsts.ExportExtensionUid) as PackagesBAChapter;
				num2 = 7;
				break;
			}
		}
	}

	public PackagesBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PackagesBAConverter()
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
				MLeh88feWiV9NJcgVb8V();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				_exportPackagesUid = new Guid((string)HNrBAdf25goZ99MBqxsi(-606654180 ^ -606963522));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object HNrBAdf25goZ99MBqxsi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void x4D3mUf2j2S2PNrpJTcM(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void tAGD2Of2YytoMhj0bTHE(object P_0, Guid value)
	{
		((BPMAppManifestChapter)P_0).Uid = value;
	}

	internal static bool pg4Toof2LOWO173tM9Cb(object P_0)
	{
		return ((PackageExportSettings)P_0).ExportPackages;
	}

	internal static void dJDB9of2UlYGiy7g2GBD(object P_0, Guid uid, bool value)
	{
		((BPMAppManifest)P_0).SetFlag(uid, value);
	}

	internal static void qgQuhHf2smSt1jAXLfoG(object P_0, object P_1)
	{
		((BPMAppManifest)P_0).SetChapter((BPMAppManifestChapter)P_1);
	}

	internal static bool R7vnNDf2rWXBQflce80d()
	{
		return vnxqpkf2ljsNUlyHxOUN == null;
	}

	internal static PackagesBAConverter fWeaWbf2g5vq0Ci2Zb0W()
	{
		return vnxqpkf2ljsNUlyHxOUN;
	}

	internal static object mHgY5Yf2conm1j43K0Xf(object P_0, Guid uid)
	{
		return ((BPMAppManifest)P_0).GetChapter(uid);
	}

	internal static int XlMvH9f2zkQpgwbAKyfC(object P_0)
	{
		return ((List<PackageBAItem>)P_0).Count;
	}

	internal static void QRoJwvfeF5JcrPrZEZV6(object P_0, PackageLevel value)
	{
		((PackageFilter)P_0).Level = value;
	}

	internal static void U5yoSnfeBJrIt1Rk8Fe8(object P_0, PackageStatus value)
	{
		((PackageFilter)P_0).Status = value;
	}

	internal static void MLeh88feWiV9NJcgVb8V()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
