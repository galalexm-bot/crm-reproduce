using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Content.Transformation;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Content.Managers;

public class HomePageSettingManager : EntityManager<IHomePageSetting, long>
{
	private const string TabsCacheKey = "PageController.GetTabs";

	private const string TabsCacheResetFlagKey = "PageController.GetTabs:Reset";

	private const string cacheRegion = "HomePageTabsRegion";

	public new static HomePageSettingManager Instance => Locator.GetServiceNotNull<HomePageSettingManager>();

	protected IBLOBDataManager BlobManager => DataAccessManager.BLOBManager;

	public ICacheService CacheService { get; set; }

	public List<HomePageTab> GetTabs(IEnumerable<IHomePageSetting> pages)
	{
		return pages.Select((IHomePageSetting homePageSetting) => new HomePageTab(homePageSetting.Page)
		{
			Order = homePageSetting.Order,
			Parameters = homePageSetting.Parameters
		}).ToList();
	}

	public List<HomePageTab> GetTabs(IWorkPlace workPlace, IUserWorkPlace user)
	{
		string text = null;
		List<HomePageTab> value;
		if ((user.WorkPlace == workPlace || (user.WorkPlace == null && workPlace.Uid == WorkPlaceManager.DefaultWorkPlaceUid)) && !WorkPlaceManager.CustomizatorId.HasValue)
		{
			text = "PageController.GetTabs" + user.Id;
			if (CacheService.TryGetValue<List<HomePageTab>>(text, "HomePageTabsRegion", out value))
			{
				return value;
			}
		}
		value = GetTabs(GetHomePageSettings(workPlace, user, disableSecurity: false));
		if (text != null)
		{
			CacheService.Insert(text, value, "HomePageTabsRegion");
		}
		return value;
	}

	public ICollection<IHomePageSetting> GetHomePageSettings(IWorkPlace workPlace, IUserWorkPlace user, bool disableSecurity)
	{
		if (user == null)
		{
			throw new Exception(SR.T("Не указан пользователь"));
		}
		WorkplacePagesTransformation workplacePagesTransformation = null;
		try
		{
			workplacePagesTransformation = BlobManager.GetBLOB<WorkplacePagesTransformation>(WorkplacePagesTransformation.BlobUid, user.Uid.ToString());
		}
		catch (Exception)
		{
		}
		ICollection<IHomePageSetting> source;
		if (workplacePagesTransformation != null)
		{
			WorkplacePagesContainer workplacePagesContainer = WorkplacePagesContainer.Pack((ICollection<IHomePageSetting>)workPlace.WorkplacePages.Pages);
			workplacePagesTransformation.Apply(workplacePagesContainer);
			source = WorkplacePagesContainer.Unpack(workplacePagesContainer);
		}
		else
		{
			source = (ICollection<IHomePageSetting>)workPlace.WorkplacePages.Pages;
		}
		if (!disableSecurity && !base.SecurityService.HasPermission(user, PermissionProvider.ContentAdminPermission))
		{
			return source.Where((IHomePageSetting s) => s.Page != null && base.SecurityService.HasPermission(user, PageSecurity.ViewPagePermission, s.Page, skipAdmin: true)).ToList();
		}
		return source.Where((IHomePageSetting s) => s.Page != null).ToList();
	}

	public void ResetTabsCache(IUserWorkPlace user = null)
	{
		if (CacheService != null && !ContextVars.Contains("PageController.GetTabs:Reset"))
		{
			ContextVars.Set("PageController.GetTabs:Reset", value: true);
			if (user == null)
			{
				CacheService.ClearRegion("HomePageTabsRegion");
			}
			else
			{
				CacheService.Remove("PageController.GetTabs" + user.Id, "HomePageTabsRegion");
			}
		}
	}

	[Transaction]
	public virtual void SaveOrganizerSettings([NotNull] IUserWorkPlace user, ICollection<IHomePageSetting> pages)
	{
		WorkplacePagesContainer originalItem = WorkplacePagesContainer.Pack((ICollection<IHomePageSetting>)(user.WorkPlace ?? WorkPlaceManager.Instance.Load(WorkPlaceManager.DefaultWorkPlaceUid)).WorkplacePages.Pages);
		WorkplacePagesContainer item = WorkplacePagesContainer.Pack(pages);
		WorkplacePagesTransformation bLOB = DataAccessManager.BLOBManager.GetBLOB<WorkplacePagesTransformation>(WorkplacePagesTransformation.BlobUid, user.Uid.ToString());
		WorkplacePagesTransformation workplacePagesTransformation = Transformation<IPageTransformationContainer, WorkplacePagesTransformation, Guid, Guid?>.CreateTransformation(item, originalItem);
		DataAccessManager.BLOBManager.SetBLOB(WorkplacePagesTransformation.BlobUid, user.Uid.ToString(), workplacePagesTransformation);
		List<Guid> list = ((bLOB != null) ? (from x in bLOB.Items.OfType<WorkplacePagesTransformationAdd>()
			select x.Item).ToList() : new List<Guid>());
		List<Guid> list2 = ((workplacePagesTransformation != null) ? (from x in workplacePagesTransformation.Items.OfType<WorkplacePagesTransformationAdd>()
			select x.Item).ToList() : new List<Guid>());
		IEnumerable<Guid> deletedPages = list.Except(list2);
		IEnumerable<Guid> addedPages = list2.Except(list);
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			foreach (Guid item2 in deletedPages)
			{
				IPageBase pageBase = PageBaseManager.Instance.LoadOrNull(item2);
				if (pageBase != null && !string.IsNullOrEmpty(pageBase.HomePageUsers))
				{
					List<string> list3 = pageBase.HomePageUsers.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
					list3.Remove(user.Id.ToString(CultureInfo.InvariantCulture));
					pageBase.HomePageUsers = string.Join(",", list3);
					pageBase.Save();
				}
			}
			foreach (Guid item3 in addedPages)
			{
				IPageBase pageBase2 = PageBaseManager.Instance.LoadOrNull(item3);
				if (pageBase2 != null)
				{
					List<string> list4 = ((!string.IsNullOrEmpty(pageBase2.HomePageUsers)) ? pageBase2.HomePageUsers.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
					list4.Add(user.Id.ToString(CultureInfo.InvariantCulture));
					pageBase2.HomePageUsers = string.Join(",", list4);
					pageBase2.Save();
				}
			}
		});
		ResetTabsCache(user);
	}

	[Transaction]
	public virtual void AddPage([NotNull] IWorkPlace workPlace, [NotNull] IUserWorkPlace user, IPageBase page)
	{
		if (workPlace.WorkplacePages == null)
		{
			throw new Exception(SR.T("Для интерфейса пользователя не задан набор главных страниц"));
		}
		page.Folder = PageFolderManager.Instance.LoadOrCreateUserFolder(user);
		page.Save();
		ICollection<IHomePageSetting> homePageSettings = GetHomePageSettings(workPlace, user, disableSecurity: true);
		InstanceOf<IHomePageSetting> instanceOf = new InstanceOf<IHomePageSetting>();
		instanceOf.New.Page = page;
		instanceOf.New.Visible = false;
		instanceOf.New.Order = (homePageSettings.Any() ? (homePageSettings.Max((IHomePageSetting s) => s.Order) + 1) : 1);
		IHomePageSetting @new = instanceOf.New;
		homePageSettings.Add(@new);
		SaveOrganizerSettings(user, homePageSettings);
		homePageSettings.Remove(@new);
	}

	[Transaction]
	public virtual void AddPage([NotNull] IWorkPlace wp, IPageBase page)
	{
		if (wp.WorkplacePages == null)
		{
			throw new Exception(SR.T("Для интерфейса не задан набор главных страниц"));
		}
		page.Save();
		InstanceOf<IHomePageSetting> instanceOf = new InstanceOf<IHomePageSetting>();
		instanceOf.New.Page = page;
		instanceOf.New.Visible = false;
		instanceOf.New.Order = (((IEnumerable<IHomePageSetting>)wp.WorkplacePages.Pages).Any() ? (((IEnumerable<IHomePageSetting>)wp.WorkplacePages.Pages).Max((IHomePageSetting s) => s.Order) + 1) : 1);
		instanceOf.New.WorkplacePages = wp.WorkplacePages;
		instanceOf.New.Save();
		wp.WorkplacePages.Save();
	}
}
