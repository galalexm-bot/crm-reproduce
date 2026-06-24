using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

[Serializable]
public class ProcessContextViewSchemeNHType : WorkflowProcessXmlSerializableType<ProcessContextViewScheme>
{
	internal static ProcessContextViewSchemeNHType akUJcK8DNxUrMbZTCJ5;

	public override Expression<Func<IWorkflowProcess, ProcessContextViewScheme>> PropertyGetter
	{
		get
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303605126));
			return Expression.Lambda<Func<IWorkflowProcess, ProcessContextViewScheme>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression });
		}
	}

	public ProcessContextViewSchemeNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IPfxJ38nxgG6WPFG2Y4()
	{
		return akUJcK8DNxUrMbZTCJ5 == null;
	}

	internal static ProcessContextViewSchemeNHType CmKYJF8HU4hoo7nrgZL()
	{
		return akUJcK8DNxUrMbZTCJ5;
	}
}
