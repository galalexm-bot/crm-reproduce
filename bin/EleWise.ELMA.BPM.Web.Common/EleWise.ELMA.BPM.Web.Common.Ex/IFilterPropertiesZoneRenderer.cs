using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPropertiesZoneRenderer
{
	Guid ZoneUid { get; }

	void Render(HtmlHelper html, FilterPropertiesZone zone);
}
