using System;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow;

public static class WorkflowConstants
{
	public static string MyMonitorProcessName;

	public const string MyProcessesFilterCodeId = "{934820F0-6591-4891-8341-CFF23190E816}";

	public const string MonitorFilterCodeId = "{8BB3D8A8-3D4E-4A1A-8AB7-75F0D6EFA774}";

	public const string ImprovementFilterCodeId = "{167EC7D9-814F-478A-A09F-D2D1D48F2E81}";

	public const string ChangeVersionFilterCodeId = "{f048f363-ada5-4ea4-b2df-0cc0c75245c4}";

	public static readonly Guid MyProcessesFilterCode;

	public static readonly Guid MonitorFilterCode;

	public static readonly Guid ImprovementFilterCode;

	public static readonly Guid RecreateCacheTaskId;

	public static readonly Guid RecreateCacheJobId;

	public const string MyProcessesPage = "EleWise.ELMA.Workflow.Processes.Web-Module-MyProcessesPage";

	public const string MonitorProcessesPage = "EleWise.ELMA.Workflow.Processes.Web-Module-MonitorProcessesPage";

	public const string ImprovementProcessesPage = "EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementProcessesPage";

	public const string ImprovementAllProcessesPage = "EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementAllProcessesPage";

	public const string FullMonitorProcessesPage = "EleWise.ELMA.Workflow.Processes.Web-Module-FullMonitorProcessesPage";

	public const string MyMonitorProcessesPage = "EleWise.ELMA.Workflow.Processes.Web-Module-MyMonitorProcessesPage";

	public const string ImprovementMyMonitorProcess = "EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementMyMonitorProcessAction";

	public const string ImprovementProcessesSection = "EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementProcessesSection";

	public static readonly Guid CurrentInstances;

	public static readonly Guid AllRunInstances;

	public static readonly Guid CreatedByInstances;

	public static readonly Guid CreatedByAllInstances;

	public static readonly Guid MyResponsibilityInstances;

	public static readonly Guid MyProcessesActionFilter;

	public static readonly Guid MonitorProcessesActionFilter;

	public static readonly Guid FullMonitorProcessesActionFilter;

	public static readonly Guid ImprovementProcessesActionFilter;

	public static readonly Guid ImprovementAllProcessesActionFilter;

	public static readonly Guid MyImprovements;

	public static readonly Guid CurrentImprovements;

	public static readonly Guid ImprovementProcessesGroupId;

	public static readonly GroupDescriptor ImprovementProcessesGroupDescriptor;

	public static readonly Guid ImprovementAllProcessesGroupId;

	public static readonly GroupDescriptor ImprovementAllProcessesGroupDescriptor;

	private static WorkflowConstants ff4fqWCtHP44F3kE9kI;

	public static string CurrentImprovementName => (string)DiTXEjCQThRJURhCh62(fKKAMkCqvATLXe0adtl(-437373675 ^ -437373113));

	public static string ImprovementAllProcessesName => SR.T((string)fKKAMkCqvATLXe0adtl(0x19163E7B ^ 0x19163C03));

	public static string ImprovementMyMonitorProcessName => (string)DiTXEjCQThRJURhCh62(fKKAMkCqvATLXe0adtl(-2125832759 ^ -2125832347));

	public static string ImprovementProcessSearchName => (string)DiTXEjCQThRJURhCh62(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1587393812 ^ -1587394506));

	static WorkflowConstants()
	{
		int num = 16;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					MyImprovements = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-275868378 ^ -275869040));
					num2 = 10;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
					{
						num2 = 12;
					}
					continue;
				case 12:
					CurrentImprovements = new Guid((string)fKKAMkCqvATLXe0adtl(-30505303 ^ -30503249));
					num2 = 10;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 != 0)
					{
						num2 = 14;
					}
					continue;
				case 23:
					ImprovementAllProcessesActionFilter = new Guid((string)fKKAMkCqvATLXe0adtl(-796330436 ^ -796331686));
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					MyResponsibilityInstances = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x664EA08F ^ 0x664EA559));
					num2 = 10;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					RecreateCacheJobId = new Guid((string)fKKAMkCqvATLXe0adtl(-1164596236 ^ -1164595278));
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc != 0)
					{
						num2 = 4;
					}
					continue;
				default:
					FullMonitorProcessesActionFilter = new Guid((string)fKKAMkCqvATLXe0adtl(-275456087 ^ -275457681));
					num2 = 9;
					continue;
				case 22:
					MonitorFilterCode = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x21359E1C ^ 0x21359D4A));
					num2 = 2;
					continue;
				case 2:
					ImprovementFilterCode = new Guid((string)fKKAMkCqvATLXe0adtl(0x3907FE5 ^ 0x3907C43));
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b != 0)
					{
						num2 = 21;
					}
					continue;
				case 20:
					return;
				case 15:
					MyMonitorProcessName = (string)DiTXEjCQThRJURhCh62(fKKAMkCqvATLXe0adtl(0x4244DF13 ^ 0x4244DDBF));
					num2 = 13;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9f9823be58b94730af510f3472045ea6 != 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					ImprovementProcessesGroupDescriptor = new GroupDescriptor(ImprovementProcessesGroupId, (string)DiTXEjCQThRJURhCh62(fKKAMkCqvATLXe0adtl(0x48B7D69C ^ 0x48B7DE3A)), SR.T((string)fKKAMkCqvATLXe0adtl(-1633140121 ^ -1633137993)));
					num2 = 17;
					continue;
				case 11:
					ImprovementAllProcessesGroupDescriptor = new GroupDescriptor(ImprovementAllProcessesGroupId, (string)DiTXEjCQThRJURhCh62(fKKAMkCqvATLXe0adtl(-275456087 ^ -275458645)), (string)DiTXEjCQThRJURhCh62(fKKAMkCqvATLXe0adtl(-680549150 ^ -680546604)));
					num2 = 20;
					continue;
				case 5:
					CurrentInstances = new Guid((string)fKKAMkCqvATLXe0adtl(-351702578 ^ -351701672));
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c == 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					MyProcessesActionFilter = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x77CE159B ^ 0x77CE13BD));
					num2 = 19;
					continue;
				case 18:
					break;
				case 21:
					RecreateCacheTaskId = new Guid((string)fKKAMkCqvATLXe0adtl(0x47356CA4 ^ 0x47356F52));
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5158ff5e06d54ab9b6f7b04c47b15f73 != 0)
					{
						num2 = 4;
					}
					continue;
				case 17:
					ImprovementAllProcessesGroupId = new Guid((string)fKKAMkCqvATLXe0adtl(0x2C817E00 ^ 0x2C8177B2));
					num2 = 11;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
					{
						num2 = 5;
					}
					continue;
				case 16:
					iNkJRACVNIKhokX6Inn();
					num2 = 15;
					continue;
				case 3:
					AllRunInstances = new Guid((string)fKKAMkCqvATLXe0adtl(0x27475F40 ^ 0x27475BA6));
					num2 = 18;
					continue;
				case 14:
					ImprovementProcessesGroupId = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--47835757 ^ 0x2D9E23B));
					num2 = 7;
					continue;
				case 19:
					MonitorProcessesActionFilter = new Guid((string)fKKAMkCqvATLXe0adtl(-193507406 ^ -193508924));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					ImprovementProcessesActionFilter = new Guid((string)fKKAMkCqvATLXe0adtl(-1756425685 ^ -1756424899));
					num2 = 23;
					continue;
				case 13:
					MyProcessesFilterCode = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1535001335 ^ -1535001073));
					num2 = 18;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b != 0)
					{
						num2 = 22;
					}
					continue;
				case 6:
					CreatedByAllInstances = new Guid((string)fKKAMkCqvATLXe0adtl(-1643416224 ^ -1643417370));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			CreatedByInstances = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2038019883 ^ -2038018589));
			num = 6;
		}
	}

	internal static object fKKAMkCqvATLXe0adtl(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object DiTXEjCQThRJURhCh62(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool wgywUiCsXrfYhDFpqee()
	{
		return ff4fqWCtHP44F3kE9kI == null;
	}

	internal static WorkflowConstants WtgRjuC25RrncQ8BgI6()
	{
		return ff4fqWCtHP44F3kE9kI;
	}

	internal static void iNkJRACVNIKhokX6Inn()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
