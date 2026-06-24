using System;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[AttributeUsage(AttributeTargets.Class)]
public class TaskTypeAttribute : Attribute
{
	private TaskType _taskType;

	private int _order;

	internal static TaskTypeAttribute UNhDY5ZbENAxZjSF4use;

	public TaskType TaskType => _taskType;

	public int Order => _order;

	public TaskTypeAttribute(int order, string taskType)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		Myx1GPZbz7ZcxTOX20b2();
		this._002Ector(order, poQv11Z5K8OmdXLWLr73(typeof(TaskType).TypeHandle), taskType);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TaskTypeAttribute(int order, Type taskTypeType, string taskType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				_taskType = (TaskType)A6hbA5Z5OY4cLoi6mDeT(taskTypeType.GetProperty(taskType, BindingFlags.Static | BindingFlags.Public), null, null);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				_order = order;
				num = 2;
				break;
			}
		}
	}

	internal static void Myx1GPZbz7ZcxTOX20b2()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Type poQv11Z5K8OmdXLWLr73(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool EPv7VkZbwpg5853r0RWN()
	{
		return UNhDY5ZbENAxZjSF4use == null;
	}

	internal static TaskTypeAttribute af1hYrZb4BEc0QgFMGe7()
	{
		return UNhDY5ZbENAxZjSF4use;
	}

	internal static object A6hbA5Z5OY4cLoi6mDeT(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}
}
