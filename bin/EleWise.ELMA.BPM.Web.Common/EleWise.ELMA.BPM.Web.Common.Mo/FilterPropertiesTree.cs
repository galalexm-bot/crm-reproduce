using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterPropertiesTree
{
	public List<FilterPropertiesZone> Zones { get; set; }

	public FilterPropertiesTree()
	{
		Zones = new List<FilterPropertiesZone>();
	}
}
