using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public class PostCompleteTestImportParameters : TestImportExtensionParameters
{
	private static PostCompleteTestImportParameters NP53nkElLOUTwaQokpW5;

	public IImportSettings ImportSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CImportSettings_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CImportSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PostCompleteTestImportParameters(List<TestImportMessages> messages, List<DeploySystemMessage> systemMessages, string serverFolderName, Dictionary<string, string> serviceData, ElmaStoreComponentManifest manifest, IConfigImportSettings settings)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(messages, systemMessages, serverFolderName, serviceData, manifest);
		ImportSettings = settings;
	}

	internal static bool fiwmlsElUXlhXUs1TRnK()
	{
		return NP53nkElLOUTwaQokpW5 == null;
	}

	internal static PostCompleteTestImportParameters skOu6ZElsWVYWrv9Nw6f()
	{
		return NP53nkElLOUTwaQokpW5;
	}
}
