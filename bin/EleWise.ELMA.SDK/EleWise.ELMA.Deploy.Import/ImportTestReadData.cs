using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import;

public class ImportTestReadData
{
	private static ImportTestReadData fWk0y3Emx4uN2j10rFEG;

	public XmlReader Reader
	{
		[CompilerGenerated]
		get
		{
			return _003CReader_003Ek__BackingField;
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
					_003CReader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
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

	public MergeReplace MergeMDReplace
	{
		[CompilerGenerated]
		get
		{
			return _003CMergeMDReplace_003Ek__BackingField;
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
					_003CMergeMDReplace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
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

	public IConfigImportSettings ConfigImportSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CConfigImportSettings_003Ek__BackingField;
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
					_003CConfigImportSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
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

	public ImportTestReadData(XmlReader reader, MergeReplace mergeReplace, Dictionary<string, string> serviceData, IConfigImportSettings configImportSettings)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Reader = reader;
		MergeMDReplace = mergeReplace;
		ServiceData = serviceData;
		ConfigImportSettings = configImportSettings;
	}

	internal static bool FlgVUbEm01vlF3E0mP78()
	{
		return fWk0y3Emx4uN2j10rFEG == null;
	}

	internal static ImportTestReadData T9N4Q1Emm3YHEEN1ANKb()
	{
		return fWk0y3Emx4uN2j10rFEG;
	}
}
