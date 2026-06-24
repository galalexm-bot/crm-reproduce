using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class WorkflowInstanceBaseFilterCreator : IFilterGridStateCreator
{
	public bool CheckType(FilterModel model)
	{
		if (model == null || model.Filter == null || !(model.Filter is IWorkflowInstanceFilter))
		{
			return false;
		}
		return ((IWorkflowInstanceFilter)model.Filter).ProcessHeader == null;
	}

	public GridState Create(FilterModel model)
	{
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(model.MainTypeUid ?? model.Entity.ObjectsType.TypeUid);
		GridState gridState = GridState.CreateNew($"{model.GridIdPrefix}_{model.Entity.Uid}", typeByUid);
		WorkflowInstanceFilterCreator.RefreshCustomColumns(gridState, typeByUid);
		RemoveWorkflowInstanceColumn(gridState);
		return gridState;
	}

	public GridState Refresh(FilterModel model, GridState sourceRefresh = null)
	{
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(model.MainTypeUid ?? model.Entity.ObjectsType.TypeUid);
		GridState currentGridState = sourceRefresh ?? GridState.Deserialize(model.Entity.GridState);
		WorkflowInstanceFilterCreator.RefreshCustomColumns(currentGridState, typeByUid);
		GridState gridState = GridState.CreateNew($"{model.GridIdPrefix}_{model.Entity.Uid}", typeByUid);
		WorkflowInstanceFilterCreator.RefreshCustomColumns(gridState, typeByUid);
		List<ColumnState> c2 = gridState.ColumnStates.Where((ColumnState c) => !currentGridState.ColumnStates.Any((ColumnState cs) => cs.UniqueName == c.UniqueName)).ToList();
		List<ColumnState> removedElements = currentGridState.ColumnStates.Where((ColumnState c) => !gridState.ColumnStates.Any((ColumnState cs) => cs.UniqueName == c.UniqueName)).ToList();
		currentGridState.ColumnStates.RemoveAll(removedElements);
		currentGridState.ColumnStates.AddAll(c2);
		RemoveWorkflowInstanceColumn(currentGridState);
		return currentGridState;
	}

	public Type GetGridStateEntityType(FilterModel model)
	{
		return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(model.MainTypeUid ?? model.Entity.ObjectsType.TypeUid);
	}

	protected virtual void RemoveWorkflowInstanceColumn(GridState state)
	{
		List<ColumnState> removedElements = state.ColumnStates.Where((ColumnState s) => state.CustomColumns.All((CustomColumnDescriptor cc) => cc.UniqueName != s.UniqueName)).ToList();
		state.ColumnStates.RemoveAll(removedElements);
	}
}
