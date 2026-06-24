using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Content.Managers;

public class PageBaseManager<T> : PortalObjectManager<T, long> where T : IPageBase
{
}
public class PageBaseManager : PageBaseManager<IPageBase>
{
	public new static PageBaseManager Instance => Locator.GetServiceNotNull<PageBaseManager>();

	public List<IPortalObject> GetFolderContents(IPageFolder folder, bool needLevelUp)
	{
		InstanceOf<IPortalObjectFilter> instanceOf = new InstanceOf<IPortalObjectFilter>();
		instanceOf.New.Folder = folder;
		IPortalObjectFilter @new = instanceOf.New;
		if (@new.Folder == null)
		{
			@new.IsRoot = true;
		}
		return PortalObjectManager.Instance.Find(@new, new FetchOptions(0, 0, ListSortDirection.Ascending, "Name")).ToList();
	}

	public void TryDeletePage(long id)
	{
		IPageBase page = Load(id);
		List<IWorkplacePages> list = (from s in HomePageSettingManager.Instance.Find((IHomePageSetting s) => s.Page == page)
			select s.WorkplacePages).Distinct().ToList();
		List<string> list2 = base.Session.CreateCriteria(InterfaceActivator.TypeOf<IWorkPlace>()).Add((ICriterion)(object)Restrictions.In("WorkplacePages", (ICollection)list)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Name")) })
			.List<string>()
			.ToList();
		if (list2.Any())
		{
			throw new Exception(SR.T("Страница \"{0}\" не может быть удалена, т.к. связана с главными страницами следующих интерфейсов: {1}.", page.Name, string.Join(", ", list2)));
		}
		if (!string.IsNullOrEmpty(page.HomePageUsers))
		{
			List<string> values = base.Session.CreateCriteria(InterfaceActivator.TypeOf<IUser>()).Add((ICriterion)(object)Restrictions.In("Id", (ICollection)page.HomePageUsers.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList())).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("UserName")) })
				.List<string>()
				.ToList();
			throw new Exception(SR.T("Страница \"{0}\" не может быть удалена, т.к. связана с главными страницами следующих пользователей: {1}.", page.Name, string.Join(", ", values)));
		}
		string pageId = page.Id.ToString(CultureInfo.InvariantCulture);
		IPortletPage portletPage = page.CastAsRealType() as IPortletPage;
		IList<IFilterActionLink> list3 = base.Session.CreateCriteria(InterfaceActivator.TypeOf<IFilterActionLink>()).Add((ICriterion)(object)Restrictions.Eq("ActionTypeProviderId", (object)"PagesLinkTypeProvider")).Add((ICriterion)(object)Restrictions.Eq("ActionId", (object)pageId))
			.List<IFilterActionLink>();
		if (MenuItemManager.Instance.Find((IMenuItem m) => (int)m.Type == 0 && m.ActionTypeProviderId == "PagesLinkTypeProvider" && m.ActionId == pageId).Any())
		{
			throw new Exception(SR.T("Страница \"{0}\" не может быть удалена, т.к. связана с пунктом меню", page.Name));
		}
		if (portletPage != null && (EntityManager<IRoleMapPageItem>.Instance.Find((IRoleMapPageItem i) => i.Page == portletPage).Any() || RoleMapPageManager.Instance.Find((IRoleMapPage p) => p.DefaultMapPage == portletPage).Any()))
		{
			throw new Exception(SR.T("Страница \"{0}\" не может быть удалена, т.к. связана с ролевыми страницами", page.Name));
		}
		if (list3.Count > 0)
		{
			throw new Exception(SR.T("Страница \"{0}\" не может быть удалена, т.к. используется в качестве ссылки на действие в фильтрах", page.Name));
		}
		Delete(page);
	}
}
