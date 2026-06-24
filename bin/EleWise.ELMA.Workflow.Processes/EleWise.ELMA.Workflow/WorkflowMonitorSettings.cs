using System.Runtime.CompilerServices;
using System.Web.Mvc;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow;

public class WorkflowMonitorSettings : GlobalSettingsBase
{
	private static WorkflowMonitorSettings sV0VxyCDoxXGM2O2xFd;

	[DisplayName(typeof(WorkflowMonitorSettings_SR), "P_DisableAutoUpdateMonitorCache")]
	public bool DisableAutoUpdateMonitorCache
	{
		[CompilerGenerated]
		get
		{
			return _003CDisableAutoUpdateMonitorCache_003Ek__BackingField;
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
					_003CDisableAutoUpdateMonitorCache_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(WorkflowMonitorSettings_SR), "P_PlanRecreateMonitorCache")]
	public bool PlanRecreateMonitorCache
	{
		[CompilerGenerated]
		get
		{
			return _003CPlanRecreateMonitorCache_003Ek__BackingField;
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
					_003CPlanRecreateMonitorCache_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[HiddenInput(DisplayValue = false)]
	[DisplayName(typeof(WorkflowMonitorSettings_SR), "P_DateTimeUpdateSettings")]
	public NthIncludedDaySettings DateTimeUpdateSettings
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 1:
					return ClassSerializationHelper.DeserializeObjectByJson<NthIncludedDaySettings>(DateTimeUpdateSettingsString);
				case 2:
					if (!string.IsNullOrEmpty(DateTimeUpdateSettingsString))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
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
					DateTimeUpdateSettingsString = (string)((value != null) ? QFg5uoCafnyqO1vXnYm(value) : null);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string DateTimeUpdateSettingsString
	{
		[CompilerGenerated]
		get
		{
			return _003CDateTimeUpdateSettingsString_003Ek__BackingField;
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
					_003CDateTimeUpdateSettingsString_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowMonitorSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		N3yT0xCY9B3ELhwmywO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool fAttebCKu5lpKEUBCbK()
	{
		return sV0VxyCDoxXGM2O2xFd == null;
	}

	internal static WorkflowMonitorSettings vhwUAVCM3enbhDaJ1bl()
	{
		return sV0VxyCDoxXGM2O2xFd;
	}

	internal static object QFg5uoCafnyqO1vXnYm(object P_0)
	{
		return ClassSerializationHelper.SerializeObjectByJson(P_0);
	}

	internal static void N3yT0xCY9B3ELhwmywO()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
