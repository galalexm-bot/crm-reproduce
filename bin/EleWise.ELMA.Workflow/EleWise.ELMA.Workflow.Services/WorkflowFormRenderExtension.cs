using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Services;

[Component(Order = -100)]
internal sealed class WorkflowFormRenderExtension : IFormRenderExtension
{
	internal static WorkflowFormRenderExtension CxRlJpMH2FY2duFQPZD;

	public bool Check(IEntity<long> entity)
	{
		return entity is IWorkflowTaskBase;
	}

	public bool CanRenderRuntimeVersion2(IEntity<long> entity, Guid formUid)
	{
		IWorkflowTaskBase workflowTaskBase = entity as IWorkflowTaskBase;
		if ((workflowTaskBase?.WorkflowBookmark.Instance.Process.Context)?.ViewModelMetadata == null)
		{
			return false;
		}
		if (((formUid != Guid.Empty) ? WorkflowTaskFormViewTransformate.GetViewItem(workflowTaskBase, formUid) : WorkflowTaskFormViewTransformate.GetViewItem(workflowTaskBase)) is FormViewItem formViewItem)
		{
			return formViewItem.RuntimeVersion == RuntimeVersion.Version2;
		}
		return false;
	}

	public WorkflowFormRenderExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FxfcEUM9qQMfjcu93jr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void FxfcEUM9qQMfjcu93jr()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool DbgmLTMLoN3ujkjyjEe()
	{
		return CxRlJpMH2FY2duFQPZD == null;
	}

	internal static WorkflowFormRenderExtension nxHSpeMfufUdR0fWQXA()
	{
		return CxRlJpMH2FY2duFQPZD;
	}
}
