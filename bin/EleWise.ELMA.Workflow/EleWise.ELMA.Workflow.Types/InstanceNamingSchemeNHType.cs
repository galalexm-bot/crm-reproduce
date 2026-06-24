using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

[Serializable]
public class InstanceNamingSchemeNHType : WorkflowProcessXmlSerializableType<InstanceNamingScheme>
{
	internal static InstanceNamingSchemeNHType Cau2db8Pgqt7TD48mTN;

	public override Expression<Func<IWorkflowProcess, InstanceNamingScheme>> PropertyGetter
	{
		get
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638226568));
			return Expression.Lambda<Func<IWorkflowProcess, InstanceNamingScheme>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression });
		}
	}

	public InstanceNamingSchemeNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		u6Q3wT8uKD0oTPqRLCw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void u6Q3wT8uKD0oTPqRLCw()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool cdagC98X83SlQvNBCAG()
	{
		return Cau2db8Pgqt7TD48mTN == null;
	}

	internal static InstanceNamingSchemeNHType txrc6m8dPEyTRmXnUoW()
	{
		return Cau2db8Pgqt7TD48mTN;
	}
}
