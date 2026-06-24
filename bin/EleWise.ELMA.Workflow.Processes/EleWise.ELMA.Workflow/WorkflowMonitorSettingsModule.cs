using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Workflow.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow;

[Component]
public class WorkflowMonitorSettingsModule : GlobalSettingsModuleBase<WorkflowMonitorSettings>
{
	private static WorkflowMonitorSettingsModule SYlH5OCcLcm3IyLVgQx;

	public override string ModuleNamespace => (string)TvM8FBCjNAyKUsrpFVQ(-711228462 ^ -711227344);

	public override string ModuleName => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-588615921 ^ -588618977));

	public override Guid ModuleGuid => X6SvINCSoBZ57UnD2sr();

	public override void SaveSettings()
	{
		//Discarded unreachable code: IL_0094, IL_00e0, IL_00ef
		int num = 5;
		List<string> list = default(List<string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					list = new List<string>();
					num2 = 4;
					continue;
				case 10:
					if (Settings == null)
					{
						num2 = 9;
						continue;
					}
					break;
				case 8:
					if (Settings.DateTimeUpdateSettings.Validate(list))
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				case 2:
					throw new Exception(string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1967154668 ^ -1967155678), list));
				case 7:
					base.SaveSettings();
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c == 0)
					{
						num2 = 10;
					}
					continue;
				case 9:
					return;
				case 6:
					if (AtvK6FCby76GYreioj1(Settings))
					{
						num2 = 8;
						continue;
					}
					goto case 7;
				case 4:
					if (Settings != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				case 3:
					return;
				case 1:
					if (FIX8ITCkCaD189kg3Ye(Settings) != null)
					{
						num2 = 6;
						continue;
					}
					goto case 7;
				}
				break;
			}
			ProcessesWorkflowInstanceManager.Instance.CreateOrUpdatePlanRecreateCacheJob();
			num = 3;
		}
	}

	public WorkflowMonitorSettingsModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object TvM8FBCjNAyKUsrpFVQ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool dqr0CmCNGF3otkV8Nku()
	{
		return SYlH5OCcLcm3IyLVgQx == null;
	}

	internal static WorkflowMonitorSettingsModule T4VBgBCdOHv5iIVi1u8()
	{
		return SYlH5OCcLcm3IyLVgQx;
	}

	internal static Guid X6SvINCSoBZ57UnD2sr()
	{
		return __AssemblyInfo.UID;
	}

	internal static object FIX8ITCkCaD189kg3Ye(object P_0)
	{
		return ((WorkflowMonitorSettings)P_0).DateTimeUpdateSettings;
	}

	internal static bool AtvK6FCby76GYreioj1(object P_0)
	{
		return ((WorkflowMonitorSettings)P_0).DisableAutoUpdateMonitorCache;
	}
}
