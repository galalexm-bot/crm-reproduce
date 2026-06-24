using System;
using System.Collections;
using System.Web.Mvc;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.UI;

public class Zone : Shape, IZone, IEnumerable
{
	public virtual string ZoneName { get; set; }

	public IZone Add(Action<HtmlHelper> action, string position)
	{
		return this;
	}
}
