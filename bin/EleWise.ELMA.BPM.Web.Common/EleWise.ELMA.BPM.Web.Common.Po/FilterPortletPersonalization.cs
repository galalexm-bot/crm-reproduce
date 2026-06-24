using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Portlets;

[Serializable]
public class FilterPortletPersonalization : PortletPersonalization
{
	[Personalization(PersonalizationScope.Shared)]
	[HiddenInput(DisplayValue = false)]
	public virtual long? FilterId { get; set; }

	public virtual IFilter Filter
	{
		get
		{
			if (FilterId.HasValue)
			{
				try
				{
					Pair<Guid, Guid?> filterTypeCode = FilterFolderManager.Instance.GetFilterTypeCode(FilterId);
					return (IFilter)Locator.GetServiceNotNull<FilterMenuProvider>().Folders(filterTypeCode.First, filterTypeCode.Second).FirstOrDefault((IFilterFolder f) => f.Id == FilterId);
				}
				catch
				{
					return null;
				}
			}
			return null;
		}
	}

	public virtual bool SupportShowOnlyMy
	{
		get
		{
			if (CheckFilter())
			{
				return ComponentManager.Current.GetExtensionPoints<IFilterPortletShowOnlyMy>().Any((IFilterPortletShowOnlyMy p) => p.CheckShowOnlyMy(Filter.ObjectsType.TypeUid));
			}
			return false;
		}
	}

	public virtual string GridId
	{
		get
		{
			if (!CheckFilter())
			{
				return null;
			}
			return $"Portlet_{base.InstanceId}_{Filter.Id}";
		}
	}

	[HiddenInput(DisplayValue = false)]
	public virtual GridState GridState
	{
		get
		{
			if (CheckFilter())
			{
				return GetGridState(Filter, base.InstanceId.ToString(), GridId);
			}
			return null;
		}
		set
		{
			value.DateState = DateTime.Now;
			PersonalizationAdministration.SaveState(base.InstanceId.ToString(), GridId, value);
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	[DefaultValue(false)]
	public virtual bool ShowOnlyMy { get; set; }

	[HiddenInput(DisplayValue = false)]
	public override string Name { get; set; }

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public string CustomName { get; set; }

	[HiddenInput(DisplayValue = false)]
	public override string NameUrl { get; set; }

	[HiddenInput(DisplayValue = false)]
	public override string ImageUrl { get; set; }

	[Personalization(PersonalizationScope.User)]
	[DefaultValue(false)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ShowFilterFields { get; set; }

	internal bool CheckFilter()
	{
		if (FilterId.HasValue)
		{
			return Filter != null;
		}
		return false;
	}

	public static GridState MergeStates(GridState state, GridState stateToMerge, bool stateToMergeIsDefault, bool mergeOrder, bool hideAvailableFilterColumns = true)
	{
		if (state != null)
		{
			if (stateToMerge != null && stateToMerge.DateState > state.DateState)
			{
				List<ColumnState> source = stateToMerge.ColumnStates.Where((ColumnState c) => !c.Hidden && !c.ForceHidden).ToList();
				List<string> list = source.Select((ColumnState c) => c.UniqueName).ToList();
				foreach (ColumnState columnState in state.ColumnStates)
				{
					if (columnState.ForceHidden || (columnState.Hidden && !hideAvailableFilterColumns))
					{
						if (list.Contains(columnState.UniqueName))
						{
							columnState.Hidden = false;
							columnState.ForceHidden = false;
						}
					}
					else if (!list.Contains(columnState.UniqueName))
					{
						columnState.ForceHidden = hideAvailableFilterColumns;
						columnState.Hidden = true;
					}
				}
				if (mergeOrder)
				{
					foreach (ColumnState cs2 in state.ColumnStates)
					{
						if (!cs2.ForceHidden && list.Contains(cs2.UniqueName))
						{
							int order = source.FirstOrDefault((ColumnState scs) => scs.UniqueName == cs2.UniqueName).Order;
							cs2.Order = order;
						}
					}
				}
				if (!stateToMergeIsDefault)
				{
					state.PageSize = stateToMerge.PageSize;
					state.SortDirection = stateToMerge.SortDirection;
					state.SortColumnUniqueName = stateToMerge.SortColumnUniqueName;
					state.DateState = stateToMerge.DateState;
				}
			}
			return state;
		}
		if (hideAvailableFilterColumns)
		{
			foreach (ColumnState item in stateToMerge.ColumnStates.Where((ColumnState cs) => cs.Hidden))
			{
				item.ForceHidden = true;
			}
		}
		stateToMerge.DateState = DateTime.Now;
		return stateToMerge;
	}

	public static GridState GetGridState(IFilter filter, string instanceId, string gridId, bool hideAvailableFilterColumns = true)
	{
		GridState filterState = GridState.Deserialize(filter.GridState);
		if (filterState == null)
		{
			FilterModel filterModel = new FilterModel(filter, filter.ObjectsType.TypeUid);
			filterState = filterModel.GridState;
		}
		IFilterPortletAvailablePropertyUids filterPortletAvailablePropertyUids = ComponentManager.Current.GetExtensionPoints<IFilterPortletAvailablePropertyUids>().FirstOrDefault((IFilterPortletAvailablePropertyUids p) => p.AvailableFilterType(filter.ObjectsType.TypeUid, filter.Code));
		if (filterPortletAvailablePropertyUids != null)
		{
			List<Guid> availablePropertyUids = filterPortletAvailablePropertyUids.AvailablePropertyUids();
			filterState.ColumnStates.Where((ColumnState cs) => !availablePropertyUids.Contains(new Guid(cs.UniqueName))).ForEach(delegate(ColumnState cs)
			{
				cs.Hidden = true;
				cs.ForceHidden = true;
			});
			filterState.ColumnStates.Where((ColumnState cs) => (cs.Hidden || cs.ForceHidden) && availablePropertyUids.Contains(new Guid(cs.UniqueName))).ForEach(delegate(ColumnState cs)
			{
				cs.Hidden = false;
				cs.ForceHidden = false;
				cs.Order = int.MaxValue;
			});
		}
		GridState state = PersonalizationAdministration.LoadState<GridState>(instanceId, gridId);
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(filter.ObjectsType.TypeUid);
		bool mergeOrder = filter.GridState != null || filter.UseDefaultSettings;
		if (filter.UseDefaultSettings)
		{
			string gridId2 = filterState.GridId;
			GridState gridState = PersonalizationAdministration.LoadState<GridState>("elma", gridId2);
			if (gridState != null)
			{
				GridState gridState2 = filterState;
				filterState = ClassSerializationHelper.CloneObject(gridState);
				foreach (ColumnState item in gridState2.ColumnStates.Where((ColumnState cs) => filterState.ColumnStates.All((ColumnState fcs) => fcs.UniqueName != cs.UniqueName)))
				{
					ColumnState columnState = ClassSerializationHelper.CloneObject(item);
					columnState.Hidden = true;
					filterState.ColumnStates.Add(columnState);
				}
				if (gridState2.DateState > gridState.DateState)
				{
					filterState.DateState = gridState2.DateState;
				}
			}
			else
			{
				FilterModel filterModel2 = new FilterModel(InterfaceActivator.Create<IFilter>(), filter.ObjectsType.TypeUid);
				filterModel2.FillGridState();
				filterState = filterModel2.GridState;
				mergeOrder = false;
			}
		}
		GridState gridState3 = MergeStates(state, filterState, filter.UseDefaultSettings, mergeOrder, hideAvailableFilterColumns);
		gridState3.TypeGridState = typeByUid;
		return gridState3;
	}

	public static GridState GetGridState(string instanceId, string gridId, bool hideAvailableFilterColumns = true)
	{
		if (long.TryParse(gridId.Split(new string[1] { "_" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault(), out var result))
		{
			return GetGridState(AbstractNHEntityManager<IFilter, long>.Instance.Load(result), instanceId, gridId, hideAvailableFilterColumns);
		}
		return null;
	}
}
