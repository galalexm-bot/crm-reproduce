using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Deploy.Export;

[Serializable]
public class CustomActivityExportSetting
{
	private static CustomActivityExportSetting CnN1dZT9fg85Rb9Uifl;

	public bool ExportCustomActivity
	{
		[CompilerGenerated]
		get
		{
			return _003CExportCustomActivity_003Ek__BackingField;
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
					_003CExportCustomActivity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Obsolete("Используй CustomActivityUids")]
	public List<long> CustomActivityIds { get; set; }

	public List<Guid> CustomActivityUids { get; set; }

	public CustomActivityExportSetting()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		E5VRdeTNMtEoT7NDYcb();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				ExportCustomActivity = true;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f == 0)
				{
					num = 0;
				}
				break;
			default:
				CustomActivityIds = new List<long>();
				num = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				CustomActivityUids = new List<Guid>();
				num = 3;
				break;
			case 3:
				return;
			}
		}
	}

	internal static void E5VRdeTNMtEoT7NDYcb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool FM0QQiTTQg9ettpumqd()
	{
		return CnN1dZT9fg85Rb9Uifl == null;
	}

	internal static CustomActivityExportSetting CFPemiTcBVGmXfyAH7l()
	{
		return CnN1dZT9fg85Rb9Uifl;
	}
}
