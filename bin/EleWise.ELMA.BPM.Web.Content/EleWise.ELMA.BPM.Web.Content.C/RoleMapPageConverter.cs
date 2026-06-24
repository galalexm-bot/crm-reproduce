using System;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
internal class RoleMapPageConverter : IPortletPageConverter
{
	public Type Type => typeof(IRoleMapPage);

	public IPortletPage Convert(IPageBase page)
	{
		return RoleMapPageManager.Instance.GetMappedPage((IRoleMapPage)page);
	}
}
