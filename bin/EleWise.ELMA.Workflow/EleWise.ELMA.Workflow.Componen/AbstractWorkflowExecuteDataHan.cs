using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public abstract class AbstractWorkflowExecuteDataHandler<TData> : IWorkflowExecuteDataHandler where TData : IWorkflowExecuteData
{
	private static object apYPg3O8r4mcZQ2tyoG7;

	public string TypeName => typeof(TData).Name;

	public bool Check(IWorkflowExecuteData data)
	{
		return data is TData;
	}

	public Dictionary<string, string> ConvertData(IWorkflowExecuteData data)
	{
		return ConvertData((TData)data);
	}

	protected abstract Dictionary<string, string> ConvertData(TData data);

	protected AbstractWorkflowExecuteDataHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Y6w2xWO8e8v4GiTYdPLk()
	{
		return apYPg3O8r4mcZQ2tyoG7 == null;
	}

	internal static object aWdDyFO8NppQB6NnvZ9X()
	{
		return apYPg3O8r4mcZQ2tyoG7;
	}
}
