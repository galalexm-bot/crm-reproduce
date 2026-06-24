using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Extensions;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class WorkflowInstanceFilterCreator : IFilterGridStateCreator
{
	public bool CheckType(FilterModel model)
	{
		if (model == null || model.Filter == null || !(model.Filter is IWorkflowInstanceFilter))
		{
			return false;
		}
		return ((IWorkflowInstanceFilter)model.Filter).ProcessHeader != null;
	}

	protected GridState CreateFromParent(FilterModel model)
	{
		if (!(model.Filter is IWorkflowInstanceFilter workflowInstanceFilter))
		{
			return null;
		}
		Type contextType = GetContextType(model);
		if (contextType == null)
		{
			return null;
		}
		GridState gridState = null;
		if (!string.IsNullOrEmpty(model.GridIdPrefix))
		{
			gridState = ClassSerializationHelper.CloneObject(PersonalizationAdministration.LoadState<GridState>("elma", $"{model.GridIdPrefix}_{workflowInstanceFilter.ProcessHeader.Id}"));
		}
		return gridState ?? GridState.CreateNew($"{model.GridIdPrefix}_{model.Entity.Uid}", contextType);
	}

	public GridState Create(FilterModel model)
	{
		if (!(model.Filter is IWorkflowInstanceFilter workflowInstanceFilter))
		{
			return null;
		}
		Type contextType = GetContextType(model);
		if (contextType == null)
		{
			return null;
		}
		GridState gridState = CreateFromParent(model);
		RefreshCustomColumns(gridState, contextType);
		WorkflowInstanceGridStateProvider.RefreshState(gridState, workflowInstanceFilter.ProcessHeader.Id.ToString());
		return gridState;
	}

	public GridState Refresh(FilterModel model, GridState sourceRefresh = null)
	{
		if (!(model.Filter is IWorkflowInstanceFilter workflowInstanceFilter))
		{
			return null;
		}
		Type contextType = GetContextType(model);
		if (contextType == null)
		{
			return null;
		}
		GridState currentGridState = sourceRefresh ?? GridState.Deserialize(model.Entity.GridState);
		RefreshCustomColumns(currentGridState, contextType);
		GridState gridState = CreateFromParent(model);
		RefreshCustomColumns(gridState, contextType);
		List<ColumnState> c2 = gridState.ColumnStates.Where((ColumnState c) => !currentGridState.ColumnStates.Any((ColumnState cs) => cs.UniqueName == c.UniqueName)).ToList();
		List<ColumnState> removedElements = currentGridState.ColumnStates.Where((ColumnState c) => !gridState.ColumnStates.Any((ColumnState cs) => cs.UniqueName == c.UniqueName)).ToList();
		currentGridState.ColumnStates.RemoveAll(removedElements);
		currentGridState.ColumnStates.AddAll(c2);
		WorkflowInstanceGridStateProvider.RefreshState(currentGridState, workflowInstanceFilter.ProcessHeader.Id.ToString());
		return currentGridState;
	}

	protected Type GetContextType(FilterModel model)
	{
		IWorkflowInstanceFilter workflowInstanceFilter = (IWorkflowInstanceFilter)model.Filter;
		return WorkflowInstanceManager.Instance.GetContextType(workflowInstanceFilter.ProcessHeader);
	}

	public static void RefreshCustomColumns(GridState state, Type typeItem)
	{
		state.CustomColumns = new List<CustomColumnDescriptor>(CustomWorkflowInstanceColumns.GetWorkflowInstanceColumns(state));
		state.Refresh(typeItem, isNew: false, forceRefresh: true);
	}

	public Type GetGridStateEntityType(FilterModel model)
	{
		return GetContextType(model);
	}
}
