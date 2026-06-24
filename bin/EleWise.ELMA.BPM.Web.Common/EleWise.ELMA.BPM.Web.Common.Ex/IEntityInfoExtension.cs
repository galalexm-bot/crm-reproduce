using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityInfoExtension
{
	Guid Uid { get; }

	Guid EntityUid { get; }

	MvcHtmlString EntityInfo(HtmlHelper htmlHelper, IEntity entity, string url, string defaultTitle = "");
}
