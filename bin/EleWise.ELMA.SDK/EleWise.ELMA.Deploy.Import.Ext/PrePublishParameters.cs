using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public sealed class PrePublishParameters : ImportExtensionBaseParameters
{
	private static PrePublishParameters oIB3F1E9ib1qviJx9sVX;

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
				case 1:
					_003CImportSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
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

	public IDictionary<string, string> ServiceData { get; private set; }

	public PrePublishParameters(List<DeployLogMessage> messages, List<DeploySystemMessage> systemMessages, Dictionary<string, string> serviceData, IImportSettings settings)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(messages, systemMessages);
		ImportSettings = settings;
		ServiceData = serviceData;
	}

	internal static bool U3ABg7E9RAXc0V330oS6()
	{
		return oIB3F1E9ib1qviJx9sVX == null;
	}

	internal static PrePublishParameters d4EvvuE9quQqh5PHgyjj()
	{
		return oIB3F1E9ib1qviJx9sVX;
	}
}
