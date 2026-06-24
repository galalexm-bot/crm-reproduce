using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public class ImportSuccessfullParameters : ImportExtensionBaseParameters
{
	internal static ImportSuccessfullParameters zrYoR0E9IfPWAu09SZU0;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ImportSuccessfullParameters(List<DeployLogMessage> messages, List<DeploySystemMessage> systemMessages, IImportSettings settings)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(messages, systemMessages);
		ImportSettings = settings;
	}

	internal static bool wrateFE9VGLghrRRqKdC()
	{
		return zrYoR0E9IfPWAu09SZU0 == null;
	}

	internal static ImportSuccessfullParameters EkoQv7E9SEwHbBunioZG()
	{
		return zrYoR0E9IfPWAu09SZU0;
	}
}
