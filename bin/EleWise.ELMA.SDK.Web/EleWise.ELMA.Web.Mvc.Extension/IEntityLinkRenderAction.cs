using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityLinkRenderAction
{
	Type EntityType { get; }

	Guid TypeUid { get; }

	bool LoadEntityIfNull { get; }

	void Render(HtmlHelper html, IEntity entity);
}
