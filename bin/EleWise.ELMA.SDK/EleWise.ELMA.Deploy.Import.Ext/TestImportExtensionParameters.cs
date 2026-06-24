using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public abstract class TestImportExtensionParameters : TestImportExtensionBaseParameters
{
	private static TestImportExtensionParameters muyhGDElcyjRtOwGgTWy;

	public string ServerFolderName
	{
		[CompilerGenerated]
		get
		{
			return _003CServerFolderName_003Ek__BackingField;
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
					_003CServerFolderName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Dictionary<string, string> ServiceData { get; private set; }

	public ElmaStoreComponentManifest Manifest
	{
		[CompilerGenerated]
		get
		{
			return _003CManifest_003Ek__BackingField;
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
					_003CManifest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TestImportExtensionParameters(List<TestImportMessages> messages, List<DeploySystemMessage> systemMessages, string serverFolderName, Dictionary<string, string> serviceData, ElmaStoreComponentManifest manifest)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(messages, systemMessages);
		Contract.ArgumentNotNull(serverFolderName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269AA522));
		Contract.ArgumentNotNull(serviceData, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978640865));
		ServerFolderName = serverFolderName;
		ServiceData = serviceData;
		Manifest = manifest;
	}

	internal static bool pNNR3AElzx2N01nlPxij()
	{
		return muyhGDElcyjRtOwGgTWy == null;
	}

	internal static TestImportExtensionParameters BcrdjCErFQf6SiECItpF()
	{
		return muyhGDElcyjRtOwGgTWy;
	}
}
