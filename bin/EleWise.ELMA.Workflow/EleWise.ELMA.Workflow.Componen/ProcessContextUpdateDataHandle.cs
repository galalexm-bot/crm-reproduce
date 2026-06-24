using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.ViewItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class ProcessContextUpdateDataHandler : BaseMetadataUpdateDataHandler
{
	private readonly WorkflowProcessManager processManager;

	internal static ProcessContextUpdateDataHandler zLOsjEO8EH8jPUI70Cpu;

	public ProcessContextUpdateDataHandler(WorkflowProcessManager processManager, ScriptModuleManager scriptModuleManager)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector(scriptModuleManager);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
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
			this.processManager = processManager;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
			{
				num = 1;
			}
		}
	}

	public override bool Check(IMetadata metadata)
	{
		return metadata is ProcessContext;
	}

	public override IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		if ((_003C_003Ec__DisplayClass3_.context = updateResult.Metadata as ProcessContext) != null)
		{
			WorkflowProcessManager workflowProcessManager = processManager;
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC04FDB));
			IWorkflowProcess workflowProcess = workflowProcessManager.Find(Expression.Lambda<Func<IWorkflowProcess, bool>>(Expression.Equal(Expression.Property(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle)), Expression.Property(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle))), new ParameterExpression[1] { parameterExpression }), FetchOptions.First).FirstOrDefault();
			if (workflowProcess != null && workflowProcess.Header != null && workflowProcess.Header.Current != null && workflowProcess.Header.Current.Context.Id == _003C_003Ec__DisplayClass3_.context.Id)
			{
				updateResult.Entities.Add(workflowProcess);
				return new ScriptModule[1] { workflowProcess.Header.Current.ScriptModule };
			}
		}
		return Enumerable.Empty<ScriptModule>();
	}

	public override IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		List<Guid> list = new List<Guid>();
		_003C_003Ec__DisplayClass4_.context = updateResult.Metadata as ProcessContext;
		if (_003C_003Ec__DisplayClass4_.context == null)
		{
			return list;
		}
		WorkflowProcessManager workflowProcessManager = processManager;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1927D529));
		IWorkflowProcess workflowProcess = workflowProcessManager.Find(Expression.Lambda<Func<IWorkflowProcess, bool>>(Expression.Equal(Expression.Property(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle)), Expression.Property(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass4_, typeof(_003C_003Ec__DisplayClass4_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle))), new ParameterExpression[1] { parameterExpression }), FetchOptions.First).FirstOrDefault();
		if (workflowProcess == null || workflowProcess.Forms == null || workflowProcess.Forms.Items == null)
		{
			return list;
		}
		IProcessHeader header = workflowProcess.Header;
		if (header == null || header.Current == null || header.Current.Context.Id != _003C_003Ec__DisplayClass4_.context.Id)
		{
			return list;
		}
		foreach (WorkflowTaskForm item in workflowProcess.Forms.Items.OfType<WorkflowTaskForm>())
		{
			if (item != null && item.Transformation != null)
			{
				list.Add((item.Transformation.NewFormUid != Guid.Empty) ? item.Transformation.NewFormUid : item.Transformation.Uid);
			}
		}
		return list;
	}

	internal static bool fwKa9pO8wabXbMwNI6so()
	{
		return zLOsjEO8EH8jPUI70Cpu == null;
	}

	internal static ProcessContextUpdateDataHandler GiLuWoO84s9sVxyWHnNW()
	{
		return zLOsjEO8EH8jPUI70Cpu;
	}
}
