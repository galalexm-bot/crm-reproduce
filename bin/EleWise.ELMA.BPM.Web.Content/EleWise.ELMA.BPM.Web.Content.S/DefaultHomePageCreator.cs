using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Content.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Portlets.Layouts;

namespace EleWise.ELMA.BPM.Web.Content.Services;

[Component]
public class DefaultHomePageCreator : IModuleContainerEvents
{
	public IEntityManager<IHomePageSetting> HomePageSettingManager { get; set; }

	public IEntityManager<IPortletPage> PortletPageManager { get; set; }

	public IUnitOfWorkManager UnitOfWorkManager { get; set; }

	public PortletManager PortletManager { get; set; }

	public TwoColumn5050Layout Layout { get; set; }

	public IEnumerable<IDefaultHomePagePortletsProvider> DefaultHomePagePortletsProviders { get; set; }

	public ISecurityService SecurityService { get; set; }

	public PageSecurity PageSecurity { get; set; }

	public ILogger Logger { get; set; }

	public DefaultHomePageCreator()
	{
		Logger = NullLogger.Instance;
	}

	public void Activated()
	{
		if (!HomePageSettingManager.Exists())
		{
			CreateDefaultPage();
		}
	}

	public virtual void CreateDefaultPage()
	{
		if (Logger.IsInfoEnabled())
		{
			Logger.InfoFormat(SR.T("Создается страница по умолчанию"));
		}
		IPortletPage portletPage = null;
		List<DefaultHomePagePortlet> defaultHomePagePortlets = DefaultHomePagePortletsProviders.SelectMany((IDefaultHomePagePortletsProvider p) => from d in p.Portlets()
			select Layout.Zones.All((ZoneDescriptor z) => z.Id != d.Zone) ? new DefaultHomePagePortlet(d.Portlet, Layout.Zones.First().Id, 0) : d).ToList();
		UnitOfWorkManager.Execute((Action)delegate
		{
			portletPage = InterfaceActivator.Create<IPortletPage>();
			portletPage.Name = SR.T("Главная");
			portletPage.Folder = PageFolderManager.Instance.LoadOrCreateHomePagesFolder();
			portletPage.PortletsLayoutId = Layout.Id;
			PageSecurity.GrandAllUsersViewPermission(portletPage);
			PortletPageManager.Save(portletPage);
			IHomePageSetting homePageSetting = InterfaceActivator.Create<IHomePageSetting>();
			homePageSetting.Order = 0L;
			homePageSetting.Visible = true;
			homePageSetting.Page = portletPage;
			HomePageSettingManager.Save(homePageSetting);
			IWorkplacePages workplacePages = AbstractNHEntityManager<IWorkplacePages, long>.Instance.Load(WorkPlaceManager.DefaultWorkplacePagesUid);
			workplacePages.Pages.Add(homePageSetting);
			workplacePages.Save();
			IWorkPlace workPlace = WorkPlaceManager.Instance.Load(WorkPlaceManager.DefaultWorkPlaceUid);
			workPlace.WorkplacePages = workplacePages;
			workPlace.Save();
			SecurityService.RunWithElevatedPrivilegies(delegate
			{
				string path = PortletsRestrictionProvider.PortalPageDataPath(portletPage);
				PortletManager portletManager = PortletManager.Create(PersonalizationScope.Shared, path);
				foreach (DefaultHomePagePortlet item in defaultHomePagePortlets)
				{
					IPortlet portlet = item.Portlet;
					string zone = item.Zone;
					PortletPersonalization portletPersonalization = portletManager.AddPortlet(portlet, path);
					portletPersonalization.Zone = zone;
					portletPersonalization.Order = item.Order;
					portletPersonalization.EnableAsyncLoading = false;
					portletManager.SavePersonalization(portletPersonalization, path);
				}
			});
		});
	}

	public void Terminating()
	{
	}
}
