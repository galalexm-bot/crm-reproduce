using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public class PostPublishParameters : ImportExtensionBaseParameters
{
	internal static PostPublishParameters jLSAv2ElIZdIVNUHVRHn;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
				case 1:
					_003CServerFolderName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
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

	public Dictionary<string, string> ServiceData { get; private set; }

	internal MergeReplace MergeReplace
	{
		[CompilerGenerated]
		get
		{
			return _003CMergeReplace_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CMergeReplace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal List<IEntityMetadata> EntityMetadataList { get; set; }

	public PostPublishParameters(List<DeployLogMessage> messages, List<DeploySystemMessage> systemMessages, string serverFolderName, Dictionary<string, string> serviceData, IImportSettings settings)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(messages, systemMessages);
		ImportSettings = settings;
		ServerFolderName = serverFolderName;
		ServiceData = serviceData;
	}

	internal static bool y3bp5kElVdeSwiyoXCd9()
	{
		return jLSAv2ElIZdIVNUHVRHn == null;
	}

	internal static PostPublishParameters rDsx88ElSya3HwpKp943()
	{
		return jLSAv2ElIZdIVNUHVRHn;
	}
}
