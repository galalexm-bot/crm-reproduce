using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import;

[Serializable]
public sealed class SystemImportSettings : ISystemImportSettings, IImportSettings
{
	private static SystemImportSettings qrtg89E0fWly6lp6ERJj;

	public string FileText
	{
		[CompilerGenerated]
		get
		{
			return _003CFileText_003Ek__BackingField;
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
				case 1:
					_003CFileText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
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
		get
		{
			return 2;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public ICollection<TestImportMessages> TestResult { get; set; }

	public SystemImportSettings(string fileText)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		JfZSpUE0vunmsXkUKjVt();
		TestResult = new List<TestImportMessages>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
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
				FileText = fileText;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void JfZSpUE0vunmsXkUKjVt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool HnMW34E0Q7L12QAVOdh9()
	{
		return qrtg89E0fWly6lp6ERJj == null;
	}

	internal static SystemImportSettings Y3e0oCE0C9eM4chRngFj()
	{
		return qrtg89E0fWly6lp6ERJj;
	}
}
