using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Content.Managers;

public class RoleMapPageManager : PageBaseManager<IRoleMapPage>
{
	public new static RoleMapPageManager Instance => Locator.GetServiceNotNull<RoleMapPageManager>();

	public IPortletPage GetMappedPage(IRoleMapPage roleMapPage)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		UserManager instance = UserManager.Instance;
		UserGroupManager instance2 = UserGroupManager.Instance;
		foreach (IRoleMapPageItem item2 in from i in (IEnumerable<IRoleMapPageItem>)roleMapPage.MapItems
			orderby i.Order, i.Id
			select i)
		{
			IRoleMapPageItem item = item2;
			if (((ICollection<IUser>)item.Users).Contains(currentUser))
			{
				return item.Page;
			}
			foreach (IOrganizationItem item3 in (IEnumerable<IOrganizationItem>)item.OrganizationItems)
			{
				if (instance.GetUsersByDepartament(item3).Contains(currentUser))
				{
					return item.Page;
				}
			}
			if (instance2.GetGroupsByUser(currentUser.Id).Any((long g) => ((IEnumerable<IUserGroup>)item.UserGroups).Any((IUserGroup ug) => ug.Id == g)))
			{
				return item.Page;
			}
		}
		return roleMapPage.DefaultMapPage;
	}
}
