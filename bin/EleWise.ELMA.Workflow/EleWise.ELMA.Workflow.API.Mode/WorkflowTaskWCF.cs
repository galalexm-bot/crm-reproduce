using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Tasks.API.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.API.Models;

[Serializable]
[DataContract(Name = "WorkflowTask")]
public class WorkflowTaskWCF : TaskBaseWCF
{
	private static WorkflowTaskWCF yCxj2kZH0L4CFEkh9Zf2;

	[DataMember]
	public WebData TaskForm
	{
		[CompilerGenerated]
		get
		{
			return _003CTaskForm_003Ek__BackingField;
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
					_003CTaskForm_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
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

	public static EntitySerializationFunctions ContextSerializationFunctions => WorkflowPublicServiceMethodsProvider.TasksInfoMethodExecutor.ContextSerializationFunctions;

	public WorkflowTaskWCF()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GWhFcwZHtPwPmofhpgAr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public WorkflowTaskWCF(IWorkflowTask task)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		GWhFcwZHtPwPmofhpgAr();
		base._002Ector(task);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			TaskForm = GetTaskForm((IWorkflowTaskBase)task);
			num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
			{
				num = 1;
			}
		}
	}

	public static WebData GetTaskForm(IWorkflowTaskBase task)
	{
		return ((WorkflowPublicServiceMethodsProvider.TasksInfoMethodExecutor.TaskForm)XM1EGmZHbHDq98uAditw(task)).ToWebData(needId: false);
	}

	internal static void GWhFcwZHtPwPmofhpgAr()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool rK8PweZHyAC6AE0nG99w()
	{
		return yCxj2kZH0L4CFEkh9Zf2 == null;
	}

	internal static WorkflowTaskWCF aEKV5sZHmC9MMTbHX0tA()
	{
		return yCxj2kZH0L4CFEkh9Zf2;
	}

	internal static object XM1EGmZHbHDq98uAditw(object P_0)
	{
		return WorkflowPublicServiceMethodsProvider.TasksInfoMethodExecutor.CreateTaskForm((IWorkflowTaskBase)P_0);
	}
}
