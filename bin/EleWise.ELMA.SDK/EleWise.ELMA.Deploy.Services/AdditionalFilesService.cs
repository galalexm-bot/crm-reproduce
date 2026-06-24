using System.Configuration;
using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Services;

[Service]
internal class AdditionalFilesService : IAdditionalFilesService
{
	private IExportImportFileService exportImportFileService;

	private readonly IRuntimeApplication runtimeApplication;

	private static AdditionalFilesService hQNaPfE4KdBOMBNNnXH5;

	public AdditionalFilesService(IExportImportFileService exportImportFileService, IRuntimeApplication runtimeApplication)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ExYOvME4kb72vFGtUEIT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				this.exportImportFileService = exportImportFileService;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num = 2;
				}
				break;
			case 2:
				this.runtimeApplication = runtimeApplication;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public string GetHelpFilePath(string fileName, string helpFileName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)f7QhgOE4OBSy1C98hrBS(KmWRlnE4n5m7FtUYvT6t(exportImportFileService, fileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA13E72)), helpFileName);
			case 1:
				if (string.IsNullOrEmpty(helpFileName))
				{
					return string.Empty;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string GetStoreAdditionalFilesPath(ElmaStoreComponentManifest manifest)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)mI0SGbE4aoLw7ltTv9md(Path.GetDirectoryName((string)YF6goUE4NoQPNlAp0Pfl(bmGA1UE41KPtN3yOcrwj(mnH0FCE4PQEnqy2JqCfb(runtimeApplication)))), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD1D7F4), EOIYUfE43LXDX4QVvpnR(manifest), x8f58SE4p8IisM3EMRM9(manifest));
			case 1:
				X9LXvvE4eUQ00ig9rUc5(manifest, NvRy8BE42A5XepZJgJjV(0x18A6761F ^ 0x18A60819));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string GetStoreAdditionalFilesPathMessage(ElmaStoreComponentManifest manifest)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138246069), manifest.Title, GetStoreAdditionalFilesPath(manifest));
			case 1:
				X9LXvvE4eUQ00ig9rUc5(manifest, NvRy8BE42A5XepZJgJjV(0x1637C429 ^ 0x1637BA2F));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void ExYOvME4kb72vFGtUEIT()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool e80SXxE4XpGhAyhwE3cj()
	{
		return hQNaPfE4KdBOMBNNnXH5 == null;
	}

	internal static AdditionalFilesService wnTW2ZE4TI6s1oqmW8EY()
	{
		return hQNaPfE4KdBOMBNNnXH5;
	}

	internal static object KmWRlnE4n5m7FtUYvT6t(object P_0, object P_1, object P_2)
	{
		return ((IExportImportFileService)P_0).CreateDeployFolderName((string)P_1, (string)P_2);
	}

	internal static object f7QhgOE4OBSy1C98hrBS(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object NvRy8BE42A5XepZJgJjV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void X9LXvvE4eUQ00ig9rUc5(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object mnH0FCE4PQEnqy2JqCfb(object P_0)
	{
		return ((IRuntimeApplication)P_0).Configuration;
	}

	internal static object bmGA1UE41KPtN3yOcrwj(object P_0)
	{
		return ((RuntimeConfiguration)P_0).Config;
	}

	internal static object YF6goUE4NoQPNlAp0Pfl(object P_0)
	{
		return ((System.Configuration.Configuration)P_0).FilePath;
	}

	internal static object EOIYUfE43LXDX4QVvpnR(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Id;
	}

	internal static object x8f58SE4p8IisM3EMRM9(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Version;
	}

	internal static object mI0SGbE4aoLw7ltTv9md(object P_0, object P_1, object P_2, object P_3)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}
}
