using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

[Serializable]
public class ProcessRegulationNHType : WorkflowProcessXmlSerializableType<ProcessRegulation>
{
	private static ProcessRegulationNHType QHRSry8L5sAXLuiMLgi;

	public override Expression<Func<IWorkflowProcess, ProcessRegulation>> PropertyGetter
	{
		get
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708125190));
			return Expression.Lambda<Func<IWorkflowProcess, ProcessRegulation>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression });
		}
	}

	public ProcessRegulationNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		l6jFNb8WiL7IwHgG98L();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void l6jFNb8WiL7IwHgG98L()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool RuAMRU8fmTnk547EKxu()
	{
		return QHRSry8L5sAXLuiMLgi == null;
	}

	internal static ProcessRegulationNHType YDkL3W89y3Oa21Rpxup()
	{
		return QHRSry8L5sAXLuiMLgi;
	}
}
