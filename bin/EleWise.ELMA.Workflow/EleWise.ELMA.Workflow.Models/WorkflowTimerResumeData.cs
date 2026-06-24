using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowTimerResumeData : IWorkflowExecuteData
{
	private readonly IResumeProcessSchedulerJob _job;

	private static WorkflowTimerResumeData igFBj7O3pl7LEoHNb54h;

	public IResumeProcessSchedulerJob Job => _job;

	public IWorkflowBookmark Bookmark => (IWorkflowBookmark)SU3oGOO3UxiI7Q0wR71i(_job);

	public WorkflowTimerResumeData(IResumeProcessSchedulerJob job)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				K8OITUO3kg8tAQMnWx3J(job, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495314262));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 3:
				_job = job;
				num = 2;
				break;
			default:
				K8OITUO3kg8tAQMnWx3J(SU3oGOO3UxiI7Q0wR71i(job), FgBXAfO3VR6tdBJ9keRu(--1436248540 ^ 0x55997632));
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	internal static void K8OITUO3kg8tAQMnWx3J(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object SU3oGOO3UxiI7Q0wR71i(object P_0)
	{
		return ((IResumeProcessSchedulerJob)P_0).WorkflowBookmark;
	}

	internal static object FgBXAfO3VR6tdBJ9keRu(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Tf2qEnO3C1aesfL0U6Wp()
	{
		return igFBj7O3pl7LEoHNb54h == null;
	}

	internal static WorkflowTimerResumeData uxU0jyO3MsJZj2qtBebV()
	{
		return igFBj7O3pl7LEoHNb54h;
	}
}
