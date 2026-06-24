using System;
using System.IO;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class MetadataAssemblyPublishResult
{
	private static MetadataAssemblyPublishResult bYphSPb3tJMS8pnXQcQr;

	public AssemblyModelsMetadata ConfigurationAssembly { get; }

	public AssemblyModelsMetadata ScriptsAssembly { get; }

	public AssemblyModelsMetadata DynamicAssembly { get; }

	internal MemoryStream ConfigurationDeltaAssemblyRaw { get; }

	internal MemoryStream DynamicDeltaAssemblyRaw { get; }

	public MetadataAssemblyPublishResult(AssemblyModelsMetadata configurationAssembly, AssemblyModelsMetadata dynamicAssembly)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BE1Cngb36pmQRJjYgr2M();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				DynamicAssembly = dynamicAssembly;
				num = 2;
				continue;
			case 2:
				return;
			}
			ConfigurationAssembly = configurationAssembly;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
			{
				num = 0;
			}
		}
	}

	public MetadataAssemblyPublishResult(AssemblyModelsMetadata configurationAssembly, AssemblyModelsMetadata scriptsAssembly, AssemblyModelsMetadata dynamicAssembly)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		BE1Cngb36pmQRJjYgr2M();
		this._002Ector(configurationAssembly, dynamicAssembly);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				ScriptsAssembly = scriptsAssembly;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal MetadataAssemblyPublishResult(AssemblyModelsMetadata configurationAssembly, AssemblyModelsMetadata scriptsAssembly, AssemblyModelsMetadata dynamicAssembly, MemoryStream configurationDeltaAssemblyRaw, MemoryStream dynamicDeltaAssemblyRaw)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(configurationAssembly, scriptsAssembly, dynamicAssembly);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ConfigurationDeltaAssemblyRaw = configurationDeltaAssemblyRaw;
				num = 2;
				break;
			case 2:
				DynamicDeltaAssemblyRaw = dynamicDeltaAssemblyRaw;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void BE1Cngb36pmQRJjYgr2M()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool dCSZWNb3whEL6JCl2UFB()
	{
		return bYphSPb3tJMS8pnXQcQr == null;
	}

	internal static MetadataAssemblyPublishResult kFnId9b34ssxdrxtmOcj()
	{
		return bYphSPb3tJMS8pnXQcQr;
	}
}
