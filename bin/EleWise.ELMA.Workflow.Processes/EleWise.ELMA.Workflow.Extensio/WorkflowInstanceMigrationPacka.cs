using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Extensions;

[Component(Type = ComponentType.Server)]
public class WorkflowInstanceMigrationPackageHandler : IInitHandler
{
	private static WorkflowInstanceMigrationPackageHandler JRLufUYTLtYAhnS7bTQ;

	public void Init()
	{
	}

	public void InitComplete()
	{
		BFURXoYdQQUe5QyHPB3(WorkflowInstanceMigrationPackageManager.Instance);
	}

	public WorkflowInstanceMigrationPackageHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mNm8aWYj5hporD2aJQu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void BFURXoYdQQUe5QyHPB3(object P_0)
	{
		((WorkflowInstanceMigrationPackageManager)P_0).ResetStatuses();
	}

	internal static void mNm8aWYj5hporD2aJQu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool QR4fsIYcKSB7PEt9qoN()
	{
		return JRLufUYTLtYAhnS7bTQ == null;
	}

	internal static WorkflowInstanceMigrationPackageHandler X8m2qJYNGUVrqWvTGrh()
	{
		return JRLufUYTLtYAhnS7bTQ;
	}
}
