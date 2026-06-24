using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Manifest;

[Component]
public class PackagesManifestChapterCreator : IManifestChapterCreator
{
	private static PackagesManifestChapterCreator mH6LUpEauq986n6RulCB;

	public void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc)
	{
		//Discarded unreachable code: IL_006f, IL_00a2, IL_00ea, IL_0147, IL_0156, IL_038d, IL_03a0, IL_03af, IL_03bf, IL_03ce, IL_03f5
		int num = 5;
		int num2 = num;
		string text = default(string);
		PackageExportSettings packageExportSettings = default(PackageExportSettings);
		Dictionary<string, IPackage>.Enumerator enumerator = default(Dictionary<string, IPackage>.Enumerator);
		KeyValuePair<string, IPackage> current = default(KeyValuePair<string, IPackage>);
		PackageManifest packageManifest = default(PackageManifest);
		List<Assembly> packageAssemblies = default(List<Assembly>);
		List<string> extPoints = default(List<string>);
		while (true)
		{
			switch (num2)
			{
			case 6:
				try
				{
					rlhqgPEaOUyjN8OQISug(text, true);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							KVcaWLEaPjEIkhDdQcBt(J81ifsEa2dXcQM5RXddQ(), WkqWNiEaeRgQ0B8sH5Av(ex), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			default:
				if (packageExportSettings != null)
				{
					num2 = 9;
					break;
				}
				return;
			case 7:
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				text = (string)QwgYEMEaRw5Uka9MwUD5();
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						IL_01ed:
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num5 = 0;
							}
							goto IL_0165;
						}
						goto IL_034e;
						IL_034e:
						current = enumerator.Current;
						num5 = 5;
						goto IL_0165;
						IL_0165:
						while (true)
						{
							switch (num5)
							{
							case 6:
								packageManifest.Enums = ManifestGeneratorHelper.GetEnumsFromAssemblies(packageAssemblies);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num5 = 9;
								}
								continue;
							case 1:
								packageAssemblies = ManifestGeneratorHelper.GetPackageAssemblies(text, current.Value);
								num5 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
								{
									num5 = 3;
								}
								continue;
							case 4:
								goto IL_01ed;
							case 7:
								packageManifest.Components = ManifestGeneratorHelper.GetComponentsFromAssemblies(packageAssemblies, extPoints);
								num5 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num5 = 6;
								}
								continue;
							case 5:
							{
								PackageManifest packageManifest2 = new PackageManifest();
								pGSgFTEaKrXfAKdWtCIs(packageManifest2, NcCMBuEaqncmDxR8vq4v(current.Value));
								aAJSvFEaTcFE8LGHdxAx(packageManifest2, string.Join((string)i0vcyBEaXR7t2KW0OJ8J(0x7EC153F ^ 0x7EC41E3), ((IPackageMetadata)current.Value).get_Authors()));
								packageManifest2.Version = ((object)((IPackageName)current.Value).get_Version()).ToString();
								packageManifest2.Title = (string)EUpTcBEakPvYg0oWW77w(current.Value);
								packageManifest2.Description = (string)d292hmEanUXZQfyIRW3p(current.Value);
								packageManifest2.Dependencies = ManifestGeneratorHelper.GetDepedenciesFromPackage(current.Value);
								packageManifest = packageManifest2;
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
								{
									num5 = 0;
								}
								continue;
							}
							case 2:
								packageManifest.StoredProcedures = ManifestGeneratorHelper.GetStoredProceduresFromAssemblies(packageAssemblies);
								num5 = 10;
								continue;
							case 10:
								packageManifest.ExtensionPoints = ManifestGeneratorHelper.GetExtensionPointsFromAssemblies(packageAssemblies, out extPoints);
								num5 = 7;
								continue;
							case 9:
								packageManifest.Entities = ManifestGeneratorHelper.GetEntitiesFromAssemblies(packageAssemblies);
								num5 = 2;
								continue;
							case 8:
							{
								((ElmaStoreComponentManifest)zaUeM3EaSxTUxTjoXu1C(settings)).Packages.Add(packageManifest);
								int num6 = 4;
								num5 = num6;
								continue;
							}
							case 3:
								goto IL_034e;
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
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
				goto case 7;
			case 2:
				return;
			case 10:
				enumerator = desc.ExportPackages.GetEnumerator();
				num2 = 3;
				break;
			case 9:
				if (!XmdGD6EaiyFbs3ERalhw(packageExportSettings))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 8:
				return;
			case 4:
				packageExportSettings = settings.CustomSettings[PackageExportConsts.ExportExtensionUid] as PackageExportSettings;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (zaUeM3EaSxTUxTjoXu1C(settings) == null)
				{
					return;
				}
				num2 = 4;
				break;
			case 11:
				return;
			}
		}
	}

	public PackagesManifestChapterCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		g4ciYtEa1Sdcsb1iNScf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object zaUeM3EaSxTUxTjoXu1C(object P_0)
	{
		return ((ConfigExportSettings)P_0).Manifest;
	}

	internal static bool XmdGD6EaiyFbs3ERalhw(object P_0)
	{
		return ((PackageExportSettings)P_0).ExportPackages;
	}

	internal static object QwgYEMEaRw5Uka9MwUD5()
	{
		return ManifestGeneratorHelper.CreateBaseDirForRemoteDomain();
	}

	internal static object NcCMBuEaqncmDxR8vq4v(object P_0)
	{
		return ((IPackageName)P_0).get_Id();
	}

	internal static void pGSgFTEaKrXfAKdWtCIs(object P_0, object P_1)
	{
		((PackageManifest)P_0).Id = (string)P_1;
	}

	internal static object i0vcyBEaXR7t2KW0OJ8J(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void aAJSvFEaTcFE8LGHdxAx(object P_0, object P_1)
	{
		((PackageManifest)P_0).Author = (string)P_1;
	}

	internal static object EUpTcBEakPvYg0oWW77w(object P_0)
	{
		return ((IPackageMetadata)P_0).get_Title();
	}

	internal static object d292hmEanUXZQfyIRW3p(object P_0)
	{
		return ((IPackageMetadata)P_0).get_Description();
	}

	internal static void rlhqgPEaOUyjN8OQISug(object P_0, bool P_1)
	{
		Directory.Delete((string)P_0, P_1);
	}

	internal static object J81ifsEa2dXcQM5RXddQ()
	{
		return Logger.Log;
	}

	internal static object WkqWNiEaeRgQ0B8sH5Av(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void KVcaWLEaPjEIkhDdQcBt(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool ThThCcEaIoPXeHjMHa1l()
	{
		return mH6LUpEauq986n6RulCB == null;
	}

	internal static PackagesManifestChapterCreator aBhrepEaVBIRSN8S4fRY()
	{
		return mH6LUpEauq986n6RulCB;
	}

	internal static void g4ciYtEa1Sdcsb1iNScf()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
