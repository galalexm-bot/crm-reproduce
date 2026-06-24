using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal class ProcessDependenciesExtension : IDependenciesExtension
{
	private WorkflowProcessManager workflowProcessManager;

	private ProcessContextManager processContextManager;

	internal static ProcessDependenciesExtension pERQ78O8xpJvKG1AT5ap;

	public ProcessDependenciesExtension(WorkflowProcessManager workflowProcessManager, ProcessContextManager processContextManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IogIqxO8huwTbgOhxKHl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.processContextManager = processContextManager;
				num = 2;
				continue;
			case 2:
				return;
			}
			this.workflowProcessManager = workflowProcessManager;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
			{
				num = 1;
			}
		}
	}

	public IEnumerable<IDependencyContainer> GetDependencyContainers(Guid uid)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		List<IDependencyContainer> list = new List<IDependencyContainer>();
		if ((_003C_003Ec__DisplayClass3_.context = processContextManager.LoadOrNull(uid)) != null)
		{
			WorkflowProcessManager obj = workflowProcessManager;
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028865955));
			if ((obj.Find(Expression.Lambda<Func<IWorkflowProcess, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }), FetchOptions.First).FirstOrDefault()?.Header)?.Current?.Dependencies is MetadataDependencyContainer item)
			{
				list.Add(item);
			}
		}
		return list;
	}

	internal static void IogIqxO8huwTbgOhxKHl()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool v5ojEMO8SA61bDppAQqO()
	{
		return pERQ78O8xpJvKG1AT5ap == null;
	}

	internal static ProcessDependenciesExtension tD95cUO81AgJeTdmJVHo()
	{
		return pERQ78O8xpJvKG1AT5ap;
	}
}
