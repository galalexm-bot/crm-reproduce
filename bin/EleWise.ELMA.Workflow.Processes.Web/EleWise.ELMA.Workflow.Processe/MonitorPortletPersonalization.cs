using System;
using System.Runtime.Serialization;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Controllers;
using EleWise.ELMA.Workflow.Processes.Web.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Portlets;

[Serializable]
public class MonitorPortletPersonalization : PortletPersonalization
{
	[NonSerialized]
	private Lazy<IProcessHeader> _processHeader;

	[OptionalField]
	private bool showByStatuses;

	[OptionalField]
	private bool showByStates;

	[OptionalField]
	private bool showByExecutors;

	[OptionalField]
	private long filterId;

	[OptionalField]
	private bool hideGrid;

	[Obsolete]
	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual long FilterId { get; set; }

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual long? NullFilterId
	{
		get
		{
			if (filterId == 0L)
			{
				if (FilterId != 0L)
				{
					return FilterId;
				}
				return null;
			}
			return filterId;
		}
		set
		{
			if (value.HasValue && filterId != value.Value)
			{
				_processHeader = null;
			}
			filterId = (value.HasValue ? value.Value : 0);
			FilterId = 0L;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ShowProcessInfo { get; set; }

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ShowBySwimlanes { get; set; }

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ShowByStatuses
	{
		get
		{
			return showByStatuses;
		}
		set
		{
			showByStatuses = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ShowByStates
	{
		get
		{
			return showByStates;
		}
		set
		{
			showByStates = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ShowByExecutors
	{
		get
		{
			return showByExecutors;
		}
		set
		{
			showByExecutors = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool HideGrid
	{
		get
		{
			return hideGrid;
		}
		set
		{
			hideGrid = value;
		}
	}

	public virtual string GridId
	{
		get
		{
			if (!NullFilterId.HasValue || NullFilterId.Value <= 0)
			{
				return null;
			}
			return $"Portlet_{base.InstanceId}_{NullFilterId.Value}";
		}
	}

	[HiddenInput(DisplayValue = false)]
	public virtual GridState GridState
	{
		get
		{
			IFilter filter = GetFilter();
			if (filter != null)
			{
				return FilterPortletPersonalization.GetGridState(filter, base.InstanceId.ToString(), GridId);
			}
			return null;
		}
		set
		{
			value.DateState = DateTime.Now;
			PersonalizationAdministration.SaveState(base.InstanceId.ToString(), GridId, value);
		}
	}

	public IFilter GetFilter()
	{
		if (NullFilterId.HasValue && NullFilterId.Value > 0)
		{
			return Locator.GetServiceNotNull<FilterManager>().LoadOrNull(NullFilterId.Value);
		}
		return null;
	}

	public IProcessHeader GetProcessHeader()
	{
		if (_processHeader == null)
		{
			_processHeader = new Lazy<IProcessHeader>(delegate
			{
				IFilter filter = GetFilter();
				return (filter == null || filter.FilterFields == null) ? null : ((IWorkflowInstanceFilter)UniversalFilterSaver.UnPack(filter.FilterFields))?.ProcessHeader;
			});
		}
		return _processHeader.Value;
	}

	public string GetApplyFunctionName()
	{
		return $"applyAllFilters{UIExtensions.PrepareId(base.InstanceId.ToString())}";
	}

	public SwimlaneGroupInfo GetSwimlaniesInfo()
	{
		IProcessHeader processHeader = GetProcessHeader();
		if (processHeader == null)
		{
			return null;
		}
		long? num = null;
		IFilter filter = GetFilter();
		if (filter != null)
		{
			num = filter.Id;
		}
		SwimlaneGroupInfo swimlanesInfo = MonitorController.GetSwimlanesInfo(processHeader, num);
		swimlanesInfo.UniquePostfix = UIExtensions.PrepareId(Guid.NewGuid().ToString());
		swimlanesInfo.ApplyFunctionName = GetApplyFunctionName();
		swimlanesInfo.NoAjaxRefresh = HideGrid;
		return swimlanesInfo;
	}

	public ExecutorsInfo GetExecutorsInfo()
	{
		IProcessHeader processHeader = GetProcessHeader();
		if (processHeader == null)
		{
			return null;
		}
		long? num = null;
		IFilter filter = GetFilter();
		if (filter != null)
		{
			num = filter.Id;
		}
		ExecutorsInfo executorsInfo = MonitorController.GetExecutorsInfo(processHeader, num);
		executorsInfo.UniquePostfix = UIExtensions.PrepareId(Guid.NewGuid().ToString());
		executorsInfo.ApplyFunctionName = GetApplyFunctionName();
		executorsInfo.NoAjaxRefresh = HideGrid;
		return executorsInfo;
	}

	public StatesInfo GetStatesInfo()
	{
		IProcessHeader processHeader = GetProcessHeader();
		if (processHeader == null)
		{
			return null;
		}
		long? num = null;
		IFilter filter = GetFilter();
		if (filter != null)
		{
			num = filter.Id;
		}
		StatesInfo instanceStatesInfo = MonitorController.GetInstanceStatesInfo(processHeader.Id, num);
		instanceStatesInfo.UniquePostfix = UIExtensions.PrepareId(Guid.NewGuid().ToString());
		instanceStatesInfo.ApplyFunctionName = GetApplyFunctionName();
		instanceStatesInfo.NoAjaxRefresh = HideGrid;
		return instanceStatesInfo;
	}

	public StatusesInfo GetStatusesInfo()
	{
		IProcessHeader processHeader = GetProcessHeader();
		if (processHeader == null)
		{
			return null;
		}
		long? num = null;
		IFilter filter = GetFilter();
		if (filter != null)
		{
			num = filter.Id;
		}
		StatusesInfo instanceStatusesInfo = MonitorController.GetInstanceStatusesInfo(processHeader.Id, num);
		if (instanceStatusesInfo == null)
		{
			return null;
		}
		instanceStatusesInfo.UniquePostfix = UIExtensions.PrepareId(Guid.NewGuid().ToString());
		instanceStatusesInfo.ApplyFunctionName = GetApplyFunctionName();
		instanceStatusesInfo.NoAjaxRefresh = HideGrid;
		return instanceStatusesInfo;
	}
}
