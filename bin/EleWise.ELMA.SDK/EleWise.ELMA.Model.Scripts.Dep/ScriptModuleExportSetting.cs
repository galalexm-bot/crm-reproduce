using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.Deploy.Export;

[Serializable]
public class ScriptModuleExportSetting
{
	internal static ScriptModuleExportSetting DRJlDXbTBaYpFxh0WT6s;

	public bool ExportScriptModules
	{
		[CompilerGenerated]
		get
		{
			return _003CExportScriptModules_003Ek__BackingField;
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
					_003CExportScriptModules_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Guid> ScriptModuleUids { get; set; }

	public ScriptModuleExportSetting()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ofPUHKbTbogEYhHY0W6y();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 2;
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
				ScriptModuleUids = new List<Guid>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num = 0;
				}
				break;
			case 2:
				ExportScriptModules = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void ofPUHKbTbogEYhHY0W6y()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool pMZRVfbTWp3AKBuxsBqr()
	{
		return DRJlDXbTBaYpFxh0WT6s == null;
	}

	internal static ScriptModuleExportSetting zSjWbybTo22KdQrxJQ5I()
	{
		return DRJlDXbTBaYpFxh0WT6s;
	}
}
