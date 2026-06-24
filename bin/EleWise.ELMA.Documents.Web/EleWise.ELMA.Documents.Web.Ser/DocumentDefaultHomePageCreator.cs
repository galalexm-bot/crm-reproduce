using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Content.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Documents.Web.Extensions;
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

namespace EleWise.ELMA.Documents.Web.Services;

[Component]
public class DocumentDefaultHomePageCreator : IModuleContainerEvents
{
	public static Guid DefaultPageGuid = new Guid("{949E908D-A218-4BA2-96D3-DD31B9D35340}");

	private string portletsAddedKey = "EleWise.ELMA.Documents.Web.DefaultPage_PortletsAdded";

	public IEntityManager<IPortletPage> PageManager { get; set; }

	public IUnitOfWorkManager UnitOfWorkManager { get; set; }

	public PortletManager PortletManager { get; set; }

	public UserManager UserManager { get; set; }

	public CustomLayout Layout { get; set; }

	public ISecurityService SecurityService { get; set; }

	public PageSecurity PageSecurity { get; set; }

	public ILogger Logger { get; set; }

	public IEnumerable<IDocumentsDefaultHomePagePortletsProvider> PortletsProviders { get; set; }

	protected IBLOBDataManager BLOBManager => DataAccessManager.BLOBManager;

	public DocumentDefaultHomePageCreator()
	{
		Logger = NullLogger.Instance;
	}

	public void Activated()
	{
		EleWise.ELMA.Security.Models.IUser admin = UserManager.Load(SecurityConstants.AdminUserUid);
		SecurityService.RunByUser(admin, delegate
		{
			IPortletPage homePage = PageManager.LoadOrNull(DefaultPageGuid);
			CreateDefaultPage(admin, homePage);
		});
	}

	public virtual void CreateDefaultPage(EleWise.ELMA.Security.IUser admin, IPortletPage homePage)
	{
		if (Logger.IsInfoEnabled())
		{
			Logger.Info(SR.T("Создается страница по умолчанию"));
		}
		List<DocumentDefaultHomePagePortlet> defaultHomePagePortlets = PortletsProviders.SelectMany((IDocumentsDefaultHomePagePortletsProvider p) => p.Portlets()).ToList();
		UnitOfWorkManager.Execute((Action)delegate
		{
			IPortletPage portletPage = homePage;
			if (portletPage == null)
			{
				portletPage = PageManager.Create();
				portletPage.Uid = DefaultPageGuid;
				portletPage.Name = SR.T("Документооборот - Домашняя страница");
				portletPage.CreationAuthor = (EleWise.ELMA.Security.Models.IUser)admin;
				portletPage.PortletsLayoutId = Layout.Id;
				PageSecurity.GrandAllUsersViewPermission(portletPage);
				portletPage.Save();
			}
			SecurityService.RunWithElevatedPrivilegies(delegate
			{
				string path = PortletsRestrictionProvider.PortalPageDataPath(portletPage);
				PortletManager portletManager = PortletManager.Create(PersonalizationScope.Shared, path);
				List<PortletViewModel> source = portletManager.GetAllPortlets(path).ToList();
				List<Guid> list = BLOBManager.GetBLOB<List<Guid>>(DefaultPageGuid, portletsAddedKey) ?? new List<Guid>();
				foreach (DocumentDefaultHomePagePortlet item in defaultHomePagePortlets)
				{
					DocumentDefaultHomePagePortlet portlet1 = item;
					if (!source.Any((PortletViewModel p) => p.Portlet.Uid == portlet1.Portlet.Uid) && !list.Contains(portlet1.Portlet.Uid))
					{
						IPortlet portlet2 = item.Portlet;
						string zone = item.Zone;
						PortletPersonalization portletPersonalization = portletManager.AddPortlet(portlet2, path);
						portletPersonalization.Zone = zone;
						portletPersonalization.Order = item.Order;
						portletPersonalization.Frame = item.Frame;
						portletPersonalization.EnableAsyncLoading = false;
						DocumentDefaultHomePagePortlet.UpdateSettings(portletPersonalization, isLastObjectPortlet: true);
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
