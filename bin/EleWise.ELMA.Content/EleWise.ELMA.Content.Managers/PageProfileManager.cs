using System;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Content.Managers;

public class PageProfileManager : PortalObjectManager<IPageProfile, long>
{
	public RunWithElevatedPrivilegiesService RunWithElevatedPrivilegiesService { get; set; }

	public new static PageProfileManager Instance => Locator.GetServiceNotNull<PageProfileManager>();

	protected override IPageProfile LoadByUid(Guid uid)
	{
		return ContextVars.GetOrAdd(string.Concat("PageProfile_", uid, "_", RunWithElevatedPrivilegiesService.Turned.ToString()), () => LoadByUidBase(uid));
	}

	protected IPageProfile LoadByUidBase(Guid uid)
	{
		return base.LoadByUid(uid);
	}
}
