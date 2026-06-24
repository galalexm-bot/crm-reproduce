using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Workflow.Web.Integration.Tasks;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
internal class TaskBaseFilterGridStateCreator : IFilterGridStateCreator
{
	private IMetadataRuntimeService metadataService;

	private IEnumerable<IUniqueFilterExtension> uniqueFilterExtensions;

	public TaskBaseFilterGridStateCreator(IMetadataRuntimeService metadataService, IEnumerable<IUniqueFilterExtension> uniqueFilterExtensions)
	{
		this.metadataService = metadataService;
		this.uniqueFilterExtensions = uniqueFilterExtensions;
	}

	public bool CheckType(FilterModel model)
	{
		if (model == null || model.Filter == null || !(model.Filter is ITaskBaseFilter))
		{
			return false;
		}
		return true;
	}

	public GridState Create(FilterModel model)
	{
		Type entityType = GetEntityType(model);
		GridState gridState = GridState.CreateNew($"{model.GridStatePrefix}_{model.Entity.Uid}", entityType);
		RefreshCustomColumns(gridState, entityType);
		return gridState;
	}

	public GridState Refresh(FilterModel model, GridState sourceRefresh = null)
	{
		if (!(model.Filter is ITaskBaseFilter))
		{
			return null;
		}
		GridState gridState = sourceRefresh ?? GridState.Deserialize(model.Entity.GridState);
		if (gridState == null)
		{
			gridState = Create(model);
		}
		Type entityType = GetEntityType(model);
		if (gridState.CustomColumns == null || gridState.CustomColumns.Count == 0)
		{
			RefreshCustomColumns(gridState, entityType);
		}
		gridState?.Refresh(entityType);
		return gridState;
	}

	protected static void RefreshCustomColumns(GridState state, Type typeItem)
	{
		state.CustomColumns = new List<CustomColumnDescriptor>
		{
			CustomWorkflowTaskBaseColumns.InstanceName,
			CustomWorkflowTaskBaseColumns.ProcessName
		};
		state.Refresh(typeItem, isNew: false, forceRefresh: true);
	}

	public Type GetGridStateEntityType(FilterModel model)
	{
		return GetEntityType(model);
	}

	private Type GetEntityType(FilterModel model)
	{
		Guid typeUid = model.MainTypeUid ?? model.Entity.ObjectsType.TypeUid;
		IUniqueFilterExtension uniqueFilterExtension = uniqueFilterExtensions.FirstOrDefault((IUniqueFilterExtension e) => e.Uid == typeUid);
		if (uniqueFilterExtension == null)
		{
			return metadataService.GetTypeByUid(typeUid);
		}
		return uniqueFilterExtension.EntityType;
	}
}
