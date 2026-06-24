using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

public class FilterPropertiesZoneExtensions
{
	public static FilterPropertiesTree BuildZoneTree(FilterModel model)
	{
		List<IFilterPropertiesZone> zoneProviders = (from p in ComponentManager.Current.GetExtensionPoints<IFilterPropertiesZone>()
			where p.ZoneMode == model.ZoneMode && p.CheckType(model)
			select p).ToList();
		if (zoneProviders.Count == 0)
		{
			return null;
		}
		FilterPropertiesTree filterPropertiesTree = new FilterPropertiesTree();
		Func<IFilterPropertiesZone, FilterPropertiesZone> makeMenuNode = null;
		makeMenuNode = delegate(IFilterPropertiesZone p)
		{
			FilterPropertiesZone zone = new FilterPropertiesZone
			{
				DisplayName = p.DisplayName,
				ZoneType = p.ZoneType,
				ZoneUid = p.ZoneUid,
				Provider = p
			};
			IEnumerable<IFilterPropertiesZone> source2 = zoneProviders.Where(delegate(IFilterPropertiesZone n)
			{
				Guid? parentZone = n.ParentZone;
				Guid zoneUid = zone.ZoneUid;
				if (!parentZone.HasValue)
				{
					return false;
				}
				return !parentZone.HasValue || parentZone.GetValueOrDefault() == zoneUid;
			});
			zone.ChildZones = source2.Select(makeMenuNode).ToList();
			return zone;
		};
		IEnumerable<IFilterPropertiesZone> source = zoneProviders.Where((IFilterPropertiesZone n) => !n.ParentZone.HasValue);
		filterPropertiesTree.Zones = source.Select(makeMenuNode).ToList();
		return filterPropertiesTree;
	}

	public static FilterPropertiesZone FindZone(FilterPropertiesTree tree, Guid zoneId)
	{
		FilterPropertiesZone res = null;
		foreach (FilterPropertiesZone zone in tree.Zones)
		{
			FindZonePart(zone, zoneId, out res);
			if (res != null)
			{
				return res;
			}
		}
		return res;
	}

	private static void FindZonePart(FilterPropertiesZone zone, Guid zoneId, out FilterPropertiesZone res)
	{
		res = null;
		if (zone.ZoneUid == zoneId)
		{
			res = zone;
			return;
		}
		foreach (FilterPropertiesZone childZone in zone.ChildZones)
		{
			FindZonePart(childZone, zoneId, out res);
			if (res != null)
			{
				break;
			}
		}
	}
}
