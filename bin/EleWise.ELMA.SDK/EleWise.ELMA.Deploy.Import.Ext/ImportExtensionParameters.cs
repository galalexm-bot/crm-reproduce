using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public abstract class ImportExtensionParameters : ImportExtensionBaseParameters
{
	internal static ImportExtensionParameters l0vfcoErZ9MKOcQH69vh;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
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
				case 1:
					_003CManifest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public int ImportStep
	{
		[CompilerGenerated]
		get
		{
			return _003CImportStep_003Ek__BackingField;
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
					_003CImportStep_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string TreeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTreeUid_003Ek__BackingField;
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
					_003CTreeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ImportExtensionParameters(List<DeployLogMessage> messages, List<DeploySystemMessage> systemMessages, string serverFolderName, Dictionary<string, string> serviceData, ElmaStoreComponentManifest manifest, int importStep)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(messages, systemMessages, serverFolderName, serviceData, manifest, importStep, null);
	}

	public ImportExtensionParameters(List<DeployLogMessage> messages, List<DeploySystemMessage> systemMessages, string serverFolderName, Dictionary<string, string> serviceData, ElmaStoreComponentManifest manifest, int importStep, string treeUid)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(messages, systemMessages);
		Contract.ArgumentNotNull(serviceData, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A733EA3));
		ServerFolderName = serverFolderName;
		ServiceData = serviceData;
		Manifest = manifest;
		ImportStep = importStep;
		TreeUid = treeUid;
	}

	internal static bool dQ3wgQErum2jeabuY1Dg()
	{
		return l0vfcoErZ9MKOcQH69vh == null;
	}

	internal static ImportExtensionParameters xDPN53ErIMvndELvtx44()
	{
		return l0vfcoErZ9MKOcQH69vh;
	}
}
