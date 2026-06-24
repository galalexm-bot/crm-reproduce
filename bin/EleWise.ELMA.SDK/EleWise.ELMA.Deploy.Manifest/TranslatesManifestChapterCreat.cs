using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Manifest;

[Component]
internal class TranslatesManifestChapterCreator : IManifestChapterCreator
{
	private static TranslatesManifestChapterCreator g6jrqBEpxqQS7WwycXGA;

	public void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc)
	{
		//Discarded unreachable code: IL_005b, IL_00d3
		int num = 4;
		int num2 = num;
		TranslateExportSettings translateExportSettings = default(TranslateExportSettings);
		string path = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (translateExportSettings == null)
				{
					num2 = 5;
					break;
				}
				goto case 7;
			case 1:
				return;
			case 5:
				return;
			case 6:
				DeleteDirectory(path);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				if (!QCTbBnEpyLKRxAaIVY1p(translateExportSettings))
				{
					return;
				}
				num2 = 8;
				break;
			default:
				AddExportPackages(desc.ExportPackages, settings.Manifest.Packages);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				return;
			case 3:
				translateExportSettings = settings.CustomSettings[TranslateExportConst.ExportExtensionUid] as TranslateExportSettings;
				num2 = 2;
				break;
			case 4:
				if (settings.Manifest == null)
				{
					return;
				}
				num2 = 3;
				break;
			case 8:
				path = (string)LlVXruEpMyRbjJS7iHEf();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void AddExportPackages(IDictionary<string, IPackage> packages, ICollection<PackageManifest> packageManifest)
	{
		using IEnumerator<KeyValuePair<string, IPackage>> enumerator = packages.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
			CS_0024_003C_003E8__locals0.exportTranslate = enumerator.Current;
			if (!packageManifest.Any((PackageManifest x) => _003C_003Ec__DisplayClass1_0.TtWnaK82CXC89ZUYPtw8(_003C_003Ec__DisplayClass1_0.sXAVEY82fhi6wB9TOO6p(x), _003C_003Ec__DisplayClass1_0.O8ZVRv82QWcq68YWXxZg(CS_0024_003C_003E8__locals0.exportTranslate.Value))))
			{
				PackageManifest item = new PackageManifest
				{
					Id = ((IPackageName)CS_0024_003C_003E8__locals0.exportTranslate.Value).get_Id(),
					Author = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852856616), ((IPackageMetadata)CS_0024_003C_003E8__locals0.exportTranslate.Value).get_Authors()),
					Version = ((object)((IPackageName)CS_0024_003C_003E8__locals0.exportTranslate.Value).get_Version()).ToString(),
					Title = ((IPackageMetadata)CS_0024_003C_003E8__locals0.exportTranslate.Value).get_Title(),
					Description = ((IPackageMetadata)CS_0024_003C_003E8__locals0.exportTranslate.Value).get_Description(),
					Dependencies = ManifestGeneratorHelper.GetDepedenciesFromPackage(CS_0024_003C_003E8__locals0.exportTranslate.Value),
					Tags = ((IPackageMetadata)CS_0024_003C_003E8__locals0.exportTranslate.Value).get_Tags()
				};
				packageManifest.AddIfNotContains(item);
			}
		}
	}

	private void DeleteDirectory(string path)
	{
		//Discarded unreachable code: IL_0047, IL_007a, IL_00c2, IL_00d1
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				JtY5G7EpJAZkVSWULKPu(path, true);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch (Exception ex)
			{
				int num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						WSrxUqEpluyLyWwyvQec(BoUiOQEp9JF4UTXD6Xvl(), gdwOETEpd3gY6l9XvVKh(ex), ex);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public TranslatesManifestChapterCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yO6FSnEprc8hBgqbrjmv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool QCTbBnEpyLKRxAaIVY1p(object P_0)
	{
		return ((TranslateExportSettings)P_0).ExportTranslate;
	}

	internal static object LlVXruEpMyRbjJS7iHEf()
	{
		return ManifestGeneratorHelper.CreateBaseDirForRemoteDomain();
	}

	internal static bool WwZ926Ep0XpDjbl4SCaC()
	{
		return g6jrqBEpxqQS7WwycXGA == null;
	}

	internal static TranslatesManifestChapterCreator vGoJXTEpmO0QBEPVp4KG()
	{
		return g6jrqBEpxqQS7WwycXGA;
	}

	internal static void JtY5G7EpJAZkVSWULKPu(object P_0, bool P_1)
	{
		Directory.Delete((string)P_0, P_1);
	}

	internal static object BoUiOQEp9JF4UTXD6Xvl()
	{
		return Logger.Log;
	}

	internal static object gdwOETEpd3gY6l9XvVKh(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void WSrxUqEpluyLyWwyvQec(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void yO6FSnEprc8hBgqbrjmv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
