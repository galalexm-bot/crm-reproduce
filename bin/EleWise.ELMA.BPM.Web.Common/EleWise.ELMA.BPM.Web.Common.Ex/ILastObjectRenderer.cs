using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ILastObjectRenderer
{
	Guid TypeUid { get; }

	string ContextMenuName { get; }

	MvcHtmlString Render(HtmlHelper helper, ReferenceOnEntity entity);

	bool HasContextMenu(ReferenceOnEntity entity);

	List<string> NotVisibleItems(HtmlHelper helper, ReferenceOnEntity entity);

	void RenderContextMenu(HtmlHelper helper, ReferenceOnEntity entity);
}
