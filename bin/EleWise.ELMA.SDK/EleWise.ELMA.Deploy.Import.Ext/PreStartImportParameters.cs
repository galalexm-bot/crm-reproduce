using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public class PreStartImportParameters : ImportExtensionBaseParameters
{
	internal static PreStartImportParameters PGyZLMErCyUf2xhgilb3;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
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

	public PreStartImportParameters(List<DeployLogMessage> messages, List<DeploySystemMessage> systemMessages, IImportSettings importSettings)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(messages, systemMessages);
		Contract.ArgumentNotNull(importSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4ED8050C));
		ImportSettings = importSettings;
	}

	internal static bool ukDyW1ErvwvJeIeJbsjf()
	{
		return PGyZLMErCyUf2xhgilb3 == null;
	}

	internal static PreStartImportParameters vLbNb1Er8LkhjHCgWBYZ()
	{
		return PGyZLMErCyUf2xhgilb3;
	}
}
