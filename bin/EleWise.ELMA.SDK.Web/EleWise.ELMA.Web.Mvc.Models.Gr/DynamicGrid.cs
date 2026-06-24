using System;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public class DynamicGrid : Grid
{
	private string stateId;

	protected string dynamicContentId;

	public string DynamicContentId => dynamicContentId;

	public GridState State => GetState(withSave: true);

	public GridState DefaultState => CreateDefaultState(GridStateSaveMode.SaveInSessionAndDb);

	public int EmptyDataPage { get; set; }

	public string StateId
	{
		get
		{
			if (!string.IsNullOrWhiteSpace(stateId))
			{
				return stateId;
			}
			return base.UniqueName;
		}
		set
		{
			stateId = value;
		}
	}

	public DynamicGrid(string uniqueName, string dynamicContentId, IGridData gridData, Type type, string callbackFunction = null)
		: this(uniqueName, dynamicContentId, gridData, type, callbackFunction, null)
	{
	}

	public DynamicGrid(string uniqueName, string dynamicContentId, IGridData gridData, Type type, string callbackFunction, string stateId)
		: base(gridData, type)
	{
		this.stateId = stateId;
		this.dynamicContentId = dynamicContentId;
		base.UniqueName = uniqueName;
		base.CallbackFunction = callbackFunction;
	}

	internal GridState GetState(bool withSave)
	{
		GridState gridState = GridPersonalizationAdministration.LoadState(StateId, base.StateProviderUid);
		if (gridState == null)
		{
			gridState = GridState.CreateNew(StateId, base.Type);
			if (withSave)
			{
				GridPersonalizationAdministration.SaveState(StateId, gridState, base.StateProviderUid);
			}
		}
		gridState.Refresh(base.Type, isNew: false, forceRefresh: false, addEntityName: false);
		return gridState;
	}

	internal GridState CreateDefaultState(GridStateSaveMode gridStateSaveMode)
	{
		GridState gridState = GridState.CreateNew(StateId, base.Type);
		if (!string.IsNullOrEmpty(gridData.SortExpression))
		{
			gridState.SortDirection = gridData.SortDirection;
			gridState.SortExpression = gridData.SortExpression;
		}
		if (gridData.GroupDescriptors != null)
		{
			gridState.GroupDescriptors = gridData.GroupDescriptors;
		}
		gridState.PageSize = gridData.PageSize;
		gridState.SaveOnlyInSession = gridStateSaveMode == GridStateSaveMode.SaveInSession;
		if (gridStateSaveMode != 0)
		{
			GridPersonalizationAdministration.SaveState(StateId, gridState, base.StateProviderUid, true);
		}
		if (gridStateSaveMode == GridStateSaveMode.SaveInSessionAndDb)
		{
			GridPersonalizationAdministration.SaveState(StateId, gridState, base.StateProviderUid, false);
		}
		gridState.Refresh(base.Type, isNew: false, forceRefresh: false, addEntityName: false);
		return gridState;
	}
}
