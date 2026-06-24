using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Tasks.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Scripts;

public class ProcessScriptBase<TContext> : ScriptBase, IProcessScriptBase
{
	internal static object NEWATNmtXJXAREicrvC;

	public virtual void OnTaskCreate(ITaskBase task, TContext context)
	{
	}

	public virtual void OnTaskUpdate(ITaskBase oldTask, ITaskBase newTask, TContext context)
	{
	}

	void IProcessScriptBase.OnTaskCreate(ITaskBase task, object context)
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
				OnTaskCreate(task, (TContext)context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void IProcessScriptBase.OnTaskUpdate(ITaskBase oldTask, ITaskBase newTask, object context)
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
				OnTaskUpdate(oldTask, newTask, (TContext)context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ProcessScriptBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool U4fC25mbqvlS8rFMv1Q()
	{
		return NEWATNmtXJXAREicrvC == null;
	}

	internal static object ilEjDRm519rWRuSGwO3()
	{
		return NEWATNmtXJXAREicrvC;
	}
}
