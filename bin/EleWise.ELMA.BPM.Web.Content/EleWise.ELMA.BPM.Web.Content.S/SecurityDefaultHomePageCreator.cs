using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Content.Security;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Portlets.Layouts;

namespace EleWise.ELMA.BPM.Web.Content.Services;

[Component]
internal class SecurityDefaultHomePageCreator : IModuleContainerEvents
{
	public static Guid DefaultPageGuid = new Guid("{4DB5A2CB-F5C6-4C32-A6B7-CA0804E31A17}");

	private string portletsAddedKey = "EleWise.ELMA.BPM.Web.DefaultPage_PortletsAdded";

	public IEntityManager<IPortletPage> PageManager { get; set; }

	public IUnitOfWorkManager UnitOfWorkManager { get; set; }

	public PortletManager PortletManager { get; set; }

	public UserManager UserManager { get; set; }

	public TwoColumn5050Layout Layout { get; set; }

	public IEnumerable<ISecurityDefaultHomePagePortletsProvider> PortletsProviders { get; set; }

	public ISecurityService SecurityService { get; set; }

	public PageSecurity PageSecurity { get; set; }

	public ILogger Logger { get; set; }

	protected IBLOBDataManager BLOBManager => DataAccessManager.BLOBManager;

	public SecurityDefaultHomePageCreator()
	{
		Logger = NullLogger.Instance;
	}

	public void Activated()
	{
		EleWise.ELMA.Security.Models.IUser admin = UserManager.Load(SecurityConstants.AdminUserUid);
		SecurityService.RunByUser(admin, delegate
		{
			IPortletPage homePage = null;
			SecurityService.RunWithElevatedPrivilegies(delegate
			{
				homePage = PageManager.LoadOrNull(DefaultPageGuid);
			});
			CreateDefaultPage(admin, homePage);
		});
	}

	public virtual void CreateDefaultPage(EleWise.ELMA.Security.Models.IUser admin, IPortletPage homePage)
	{
		if (Logger.IsInfoEnabled())
		{
			Logger.Info(SR.T("Создается страница по умолчанию"));
		}
		List<SecurityDefaultHomePagePortlet> defaultHomePagePortlets = PortletsProviders.SelectMany((ISecurityDefaultHomePagePortletsProvider p) => from d in p.Portlets()
			select Layout.Zones.All((ZoneDescriptor z) => z.Id != d.Zone) ? new SecurityDefaultHomePagePortlet(d.Portlet, Layout.Zones.First().Id, 0) : d).ToList();
		UnitOfWorkManager.Execute((Action)delegate
		{
			IPortletPage portletPage = homePage;
			if (portletPage == null)
			{
				portletPage = PageManager.Create();
				portletPage.Uid = DefaultPageGuid;
				portletPage.Name = SR.T("Администрирование - Домашняя страница");
				portletPage.CreationAuthor = admin;
				portletPage.PortletsLayoutId = Layout.Id;
				PageSecurity.GrandAllUsersViewPermission(portletPage);
				portletPage.Save();
			}
			SecurityService.RunWithElevatedPrivilegies(delegate
			{
				string path = PortletsRestrictionProvider.PortalPageDataPath(portletPage);
				PortletManager portletManager = PortletManager.Create(PersonalizationScope.Shared, path);
				IEnumerable<PortletViewModel> allPortlets = portletManager.GetAllPortlets(path);
				List<Guid> list = BLOBManager.GetBLOB<List<Guid>>(DefaultPageGuid, portletsAddedKey) ?? new List<Guid>();
				foreach (SecurityDefaultHomePagePortlet item in defaultHomePagePortlets)
				{
					SecurityDefaultHomePagePortlet portlet1 = item;
					if (!allPortlets.Any((PortletViewModel p) => p.Portlet.Uid == portlet1.Portlet.Uid) && !list.Contains(portlet1.Portlet.Uid))
					{
						IPortlet portlet2 = item.Portlet;
						string zone = item.Zone;
						PortletPersonalization portletPersonalization = portletManager.AddPortlet(portlet2, path);
						portletPersonalization.Zone = zone;
						portletPersonalization.Order = item.Order;
						portletPersonalization.Frame = PortletFrame.HeaderLine;
						portletPersonalization.EnableAsyncLoading = false;
						portletPersonalization.ImageUrl = "";
						portletPersonalization.EnableAsyncLoading = false;
						portletManager.SavePersonalization(portletPersonalization, path);
						list.Add(portlet1.Portlet.Uid);
					}
				}
				BLOBManager.SetBLOB(DefaultPageGuid, portletsAddedKey, list);
			});
		});
	}

	public void Terminating()
	{
	}
}
