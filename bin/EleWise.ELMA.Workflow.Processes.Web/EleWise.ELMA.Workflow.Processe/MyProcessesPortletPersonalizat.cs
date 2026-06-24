using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web.Mvc;
using System.Xml.Serialization;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Controllers;

namespace EleWise.ELMA.Workflow.Processes.Web.Portlets;

[Serializable]
public class MyProcessesPortletPersonalization : PortletPersonalization
{
	[Serializable]
	[XmlRoot("ProcessItem")]
	public class ProcessItem
	{
		[XmlElement("Id")]
		public long Id { get; set; }

		[XmlElement("Visible")]
		public bool Visible { get; set; }
	}

	[XmlRoot("ProcessItemList")]
	public class ProcessItemList
	{
		[XmlArray]
		public List<ProcessItem> Processes { get; set; }

		public ProcessItemList()
		{
			Processes = new List<ProcessItem>();
		}
	}

	[OptionalField]
	private bool _showAll = true;

	[OptionalField]
	private List<ProcessItem> _processes;

	[OptionalField]
	private long _filterId;

	[OptionalField]
	private MyProcessesViewMode _viewMode;

	[Obsolete]
	[Personalization(PersonalizationScope.User)]
	[DefaultValue(true)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ShowAll
	{
		get
		{
			return _showAll;
		}
		set
		{
			_showAll = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual MyProcessesViewMode ViewMode
	{
		get
		{
			return _viewMode;
		}
		set
		{
			_viewMode = value;
		}
	}

	[HiddenInput(DisplayValue = false)]
	public virtual List<ProcessItem> Processes
	{
		get
		{
			if (string.IsNullOrEmpty(ProcessesString))
			{
				return new List<ProcessItem>();
			}
			ProcessItemList processItemList = ClassSerializationHelper.DeserializeObjectByXml<ProcessItemList>(ProcessesString);
			if (processItemList == null)
			{
				return new List<ProcessItem>();
			}
			return processItemList.Processes;
		}
		set
		{
			if (value == null)
			{
				ProcessesString = null;
			}
			ProcessesString = ClassSerializationHelper.SerializeObjectByXml(new ProcessItemList
			{
				Processes = value
			});
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual string ProcessesString { get; set; }

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual long? NullFilterId
	{
		get
		{
			if (_filterId != 0L)
			{
				return _filterId;
			}
			return null;
		}
		set
		{
			_filterId = (value.HasValue ? value.Value : 0);
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

	public IEnumerable<ProcessHeaderInfo> GetAvailableProcesses()
	{
		return ProcessHeaderController.SortHeaders(ProcessHeaderManager.Instance.GetProcessesInfo(null).ToList());
	}

	public bool IsVisible(long id)
	{
		List<ProcessItem> processes = Processes;
		if (processes != null)
		{
			return !processes.Any((ProcessItem item) => item.Id == id && !item.Visible);
		}
		return true;
	}
}
