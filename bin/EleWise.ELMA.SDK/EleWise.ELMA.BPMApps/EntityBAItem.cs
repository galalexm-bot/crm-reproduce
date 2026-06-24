using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.BPMApps;

public class EntityBAItem : BPMAppManifestItem
{
	private static EntityBAItem pNc8uufkaTjJlkQOOLem;

	[DefaultValue(false)]
	[XmlElement("ExportData")]
	public bool ExportData
	{
		[CompilerGenerated]
		get
		{
			return _003CExportData_003Ek__BackingField;
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
					_003CExportData_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
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

	public EntityBAItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rx2gTsfkDpLIdX9fbRov()
	{
		return pNc8uufkaTjJlkQOOLem == null;
	}

	internal static EntityBAItem R6C66hfktoRdwKx71JEA()
	{
		return pNc8uufkaTjJlkQOOLem;
	}
}
