using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterPropertiesZone
{
	private IFilterPropertiesZoneRenderer renderer;

	public Guid ZoneUid { get; set; }

	public string DisplayName { get; set; }

	public ZoneType ZoneType { get; set; }

	public FilterPropertiesZone ParentZone { get; set; }

	public List<FilterPropertiesZone> ChildZones { get; set; }

	public IFilterPropertiesZone Provider { get; set; }

	public List<PropertiesViewModel.PropertyItem> VisibleProperties { get; set; }

	public List<PropertiesViewModel.PropertyItem> InvisibleProperties { get; set; }

	public FilterModel FilterModel { get; set; }

	public IFilterPropertiesZoneRenderer GetRenderer()
	{
		if (renderer == null)
		{
			renderer = ComponentManager.Current.GetExtensionPoints<IFilterPropertiesZoneRenderer>().FirstOrDefault((IFilterPropertiesZoneRenderer z) => z.ZoneUid == ZoneUid);
		}
		return renderer;
	}

	public FilterPropertiesZone()
	{
		ChildZones = new List<FilterPropertiesZone>();
		VisibleProperties = new List<PropertiesViewModel.PropertyItem>();
	}

	public virtual string GetContainerId()
	{
		return $"FilterPropertiesZone_{UIExtensions.PrepareId(ZoneUid.ToString())}";
	}
}
