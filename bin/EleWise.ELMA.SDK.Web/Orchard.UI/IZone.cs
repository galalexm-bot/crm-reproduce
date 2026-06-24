using System;
using System.Collections;
using System.Web.Mvc;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.UI;

public interface IZone : IEnumerable
{
	string ZoneName { get; set; }

	Shape Add(object item, string position);

	IZone Add(Action<HtmlHelper> action, string position);
}
