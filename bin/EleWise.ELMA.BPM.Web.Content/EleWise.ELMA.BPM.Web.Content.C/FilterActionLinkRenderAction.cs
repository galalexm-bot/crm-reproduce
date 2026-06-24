using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
public class FilterActionLinkRenderAction : IEntityLinkRenderAction
{
	public Type EntityType => null;

	public Guid TypeUid => InterfaceActivator.UID<IFilterActionLink>();

	public bool LoadEntityIfNull => true;

	public void Render(HtmlHelper html, IEntity entity)
	{
		if (entity is IFilterActionLink filterActionLink)
		{
			Locator.GetService<ContentActionRegistry>().Get(filterActionLink.ActionTypeProviderId, filterActionLink.ActionId)?.OnRender(html);
		}
	}
}
