using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models.Filters;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class PropertiesViewModel
{
	public class PropertyItem
	{
		public FilterMetadataProperty Property { get; set; }

		public MvcHtmlString EditableProperty { get; set; }

		public Guid ZoneId { get; set; }
	}

	public IEnumerable<PropertyItem> Properties { get; set; }
}
