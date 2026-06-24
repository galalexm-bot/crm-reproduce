using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Content.Components;
using EleWise.ELMA.Content.Constants;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Content.Transformation;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Db;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.Web.Mvc.Portlets;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.Content.Db;

public class ContentDbStructure : DbStructureExtension
{
	private class UserUid
	{
		public long Id { get; set; }

		public Guid Uid { get; set; }
	}

	private readonly List<dynamic> savedPages = new List<object>();

	private readonly Guid defaultPageGuid = new Guid("{4DB5A2CB-F5C6-4C32-A6B7-CA0804E31A17}");

	private const string PortletsAddedKey = "EleWise.ELMA.BPM.Web.DefaultPage_PortletsAdded";

	private string darkColorSchemeName = SR.T("Тёмная");

	private string redColorSchemeName = SR.T("Красная");

	private string blueColorSchemeName = SR.T("Синяя");

	private string greenColorSchemeName = SR.T("Зелёная");

	private string yellowColorSchemeName = SR.T("Жёлтая");

	public PortletManager PortletManager => Locator.GetServiceNotNull<PortletManager>();

	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[1] { typeof(SecurityDbStructure) };

	public void UpdateMenu()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		DbModelUpdater serviceNotNull2 = Locator.GetServiceNotNull<DbModelUpdater>();
		if (serviceNotNull.ColumnExists("Menu", serviceNotNull2.GetDeletingColumnTemporaryName("Menu", "MenuUid")))
		{
			serviceNotNull.Update("Menu", new string[1] { "TypeUid" }, new object[1]
			{
				new Guid("247e6ac7-5230-4ca7-94b4-72c4b69dd2c1")
			}, serviceNotNull.Dialect.QuoteIfNeeded(serviceNotNull2.GetDeletingColumnTemporaryName("Menu", "MenuUid")) + " <> 'top'");
			serviceNotNull.Update("Menu", new string[1] { "TypeUid" }, new object[1]
			{
				new Guid("09fc95a8-2f07-4a42-97b8-37272ba07700")
			}, serviceNotNull.Dialect.QuoteIfNeeded(serviceNotNull2.GetDeletingColumnTemporaryName("Menu", "MenuUid")) + " = 'top'");
			serviceNotNull.Update("Menu", new string[1] { "Uid" }, new object[1] { MenuManager.LeftMenuUid }, serviceNotNull.Dialect.QuoteIfNeeded(serviceNotNull2.GetDeletingColumnTemporaryName("Menu", "MenuUid")) + " = 'left'");
			serviceNotNull.Update("Menu", new string[1] { "Uid" }, new object[1] { MenuManager.TopMenuUid }, serviceNotNull.Dialect.QuoteIfNeeded(serviceNotNull2.GetDeletingColumnTemporaryName("Menu", "MenuUid")) + " = 'top'");
			serviceNotNull.ExecuteNonQuery(string.Format("insert into {0}({1}) select {1} from {2} where {3}<>'top'", serviceNotNull.Dialect.QuoteIfNeeded("LeftMenu"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Menu"), serviceNotNull.Dialect.QuoteIfNeeded(serviceNotNull2.GetDeletingColumnTemporaryName("Menu", "MenuUid"))));
		}
	}

	public void UpdateWorkPlaces()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		DbModelUpdater serviceNotNull2 = Locator.GetServiceNotNull<DbModelUpdater>();
		if (serviceNotNull.ColumnExists("WorkPlace", serviceNotNull2.GetDeletingColumnTemporaryName("WorkPlace", "LeftMenu")))
		{
			serviceNotNull.ExecuteNonQuery(string.Format("update {0} set {1}={2}", serviceNotNull.Dialect.QuoteIfNeeded("WorkPlace"), serviceNotNull.Dialect.QuoteIfNeeded("LeftMenu"), serviceNotNull.Dialect.QuoteIfNeeded(serviceNotNull2.GetDeletingColumnTemporaryName("WorkPlace", "LeftMenu"))));
		}
	}

	public void CreateDefaultMenu()
	{
		if (MenuManager.Instance.LoadOrNull(MenuManager.LeftMenuUid) == null)
		{
			InstanceOf<ILeftMenu> instanceOf = new InstanceOf<ILeftMenu>();
			instanceOf.New.Uid = MenuManager.LeftMenuUid;
			instanceOf.New.Name = SR.T("Левое меню");
			instanceOf.New.Description = SR.T("Меню по умолчанию слева");
			instanceOf.New.Save();
		}
	}

	public void CreateStartMenu()
	{
		if (MenuManager.Instance.LoadOrNull(MenuManager.CreateMenuUid) == null)
		{
			InstanceOf<ICreateMenu> instanceOf = new InstanceOf<ICreateMenu>();
			instanceOf.New.Uid = MenuManager.CreateMenuUid;
			instanceOf.New.Name = SR.T("Меню создания");
			instanceOf.New.Description = SR.T("Меню по умолчанию для создания объектов");
			instanceOf.New.Save();
		}
		if (MenuManager.Instance.LoadOrNull(MenuManager.StartMenuUid) == null)
		{
			InstanceOf<IStartMenu> instanceOf2 = new InstanceOf<IStartMenu>();
			instanceOf2.New.Uid = MenuManager.StartMenuUid;
			instanceOf2.New.Name = SR.T("Главное меню");
			instanceOf2.New.Description = SR.T("Главное меню по умолчанию");
			instanceOf2.New.Save();
		}
	}

	public void CreateDefaultWorkPlase()
	{
		InstanceOf<IWorkPlace> instanceOf = new InstanceOf<IWorkPlace>();
		instanceOf.New.Name = SR.T("Интерфейс по умолчанию");
		instanceOf.New.Uid = WorkPlaceManager.DefaultWorkPlaceUid;
		instanceOf.New.Save();
	}

	public void ConvertPageFoldersSettings()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		serviceNotNull.Update("PortalObject", new string[2] { "IsSystem", "Folder" }, new object[2]
		{
			Convert.ToInt32(value: true),
			null
		}, string.Format("{1} in ({0}param1, {0}param2)", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Uid")), new Dictionary<string, object>
		{
			{
				"param1",
				PageFolderManager.HomePagesFolderUid
			},
			{
				"param2",
				PageFolderManager.UserPagesFolderUid
			}
		});
	}

	public void AssignDefaultWorkplacePages(IWorkplacePages defaultPages)
	{
		foreach (IWorkPlace item in WorkPlaceManager.Instance.Find((IWorkPlace wp) => wp.WorkplacePages == null))
		{
			item.WorkplacePages = defaultPages;
			item.Save();
		}
	}

	public void AssignDefaultWorkplacePages2()
	{
		IWorkplacePages workplacePages = EntityManager<IWorkplacePages>.Instance.LoadOrNull(WorkPlaceManager.DefaultWorkplacePagesUid);
		if (workplacePages == null)
		{
			workplacePages = InterfaceActivator.Create<IWorkplacePages>();
			workplacePages.Uid = WorkPlaceManager.DefaultWorkplacePagesUid;
			IPageFolder folder = PageFolderManager.Instance.LoadOrCreateHomePagesFolder();
			List<IHomePageSetting> homePageSettings = HomePageSettingManager.Instance.FindAll().ToList();
			foreach (IHomePageSetting item in (from p in savedPages
				where p.User == null
				select homePageSettings.First((IHomePageSetting e) => e.Id == p.Id)).ToList())
			{
				if (item.Page != null)
				{
					item.Page.Folder = folder;
					item.Page.Save();
				}
				item.WorkplacePages = workplacePages;
				item.Save();
				workplacePages.Pages.Add(item);
			}
			workplacePages.Save();
		}
		AssignDefaultWorkplacePages(workplacePages);
	}

	public void AssignDefaultMenu2()
	{
		IStartMenu startMenu = AbstractNHEntityManager<IStartMenu, int>.Instance.Load(MenuManager.StartMenuUid);
		foreach (IWorkPlace item in WorkPlaceManager.Instance.Find((IWorkPlace wp) => wp.StartMenu == null))
		{
			item.StartMenu = startMenu;
			item.Save();
		}
		ILeftMenu leftMenu = AbstractNHEntityManager<ILeftMenu, int>.Instance.Load(MenuManager.LeftMenuUid);
		foreach (IWorkPlace item2 in WorkPlaceManager.Instance.Find((IWorkPlace wp) => wp.LeftMenu == null))
		{
			item2.LeftMenu = leftMenu;
			item2.Save();
		}
	}

	public void AssignDefaultWorkPlace()
	{
		IWorkPlace workPlace = WorkPlaceManager.Instance.Load(WorkPlaceManager.DefaultWorkPlaceUid);
		foreach (IUserWorkPlace item in EntityManager<IUserWorkPlace>.Instance.Find((IUserWorkPlace u) => u.WorkPlace == null))
		{
			item.WorkPlace = workPlace;
			item.Save();
		}
	}

	public void HomePageUsers()
	{
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
		List<IBlobStoreHolder> list = session.CreateCriteria(InterfaceActivator.TypeOf<IBlobStoreHolder>()).Add((ICriterion)(object)ElmaRestrictions.Like("Key", $"{WorkplacePagesTransformation.BlobUid}%")).List<IBlobStoreHolder>()
			.ToList();
		Dictionary<Guid, List<Guid>> dictionary = new Dictionary<Guid, List<Guid>>();
		HashSet<Guid> hashSet = new HashSet<Guid>();
		foreach (IBlobStoreHolder item in list)
		{
			string g = item.Key.Substring(WorkplacePagesTransformation.BlobUid.ToString().Length);
			hashSet.Add(new Guid(g));
			WorkplacePagesTransformation workplacePagesTransformation = (WorkplacePagesTransformation)ClassSerializationHelper.DeserializeObject(item.BigData);
			if (workplacePagesTransformation == null)
			{
				continue;
			}
			foreach (WorkplacePagesTransformationAdd item2 in workplacePagesTransformation.Items.OfType<WorkplacePagesTransformationAdd>())
			{
				if (dictionary.TryGetValue(item2.Item, out var value))
				{
					value.Add(new Guid(g));
					continue;
				}
				dictionary[item2.Item] = new List<Guid>
				{
					new Guid(g)
				};
			}
		}
		List<UserUid> dbUsers = session.CreateCriteria(InterfaceActivator.TypeOf<IUser>()).Add((ICriterion)(object)Restrictions.In("Uid", (ICollection)hashSet.ToList())).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id"), "Id").Add((IProjection)(object)Projections.Property("Uid"), "Uid") })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(UserUid)))
			.List<UserUid>()
			.ToList();
		foreach (KeyValuePair<Guid, List<Guid>> item3 in dictionary)
		{
			string homePageUsers = string.Join(",", item3.Value.Select((Guid userUid) => dbUsers.FirstOrDefault((UserUid u) => u.Uid == userUid).Id));
			IPageBase pageBase = PageBaseManager.Instance.LoadOrNull(item3.Key);
			if (pageBase != null)
			{
				pageBase.HomePageUsers = homePageUsers;
				pageBase.Save();
			}
		}
	}

	public void Convert_HomePageSetting_Page()
	{
		string deletingColumnTemporaryName = Locator.GetServiceNotNull<DbModelUpdater>().GetDeletingColumnTemporaryName("HomePage", "Page");
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (!(deletingColumnTemporaryName == "Page") && serviceNotNull.TableExists("HomePage") && serviceNotNull.ColumnExists("HomePage", deletingColumnTemporaryName))
		{
			serviceNotNull.ExecuteNonQuery(string.Format("update {0} set {1}={2}", serviceNotNull.Dialect.QuoteIfNeeded("HomePage"), serviceNotNull.Dialect.QuoteIfNeeded("Page"), serviceNotNull.Dialect.QuoteIfNeeded(deletingColumnTemporaryName)));
		}
	}

	public void RemovePortletProfile()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		serviceNotNull.ExecuteNonQuery(string.Format("delete from {6} where {1} in (select {1} from {5} where {2} in (select {2} from {4} where {3}={0}portletMetadataTypeUid))", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Uid"), serviceNotNull.Dialect.QuoteIfNeeded("MetadataType"), serviceNotNull.Dialect.QuoteIfNeeded("FormMetadataItemHeader"), serviceNotNull.Dialect.QuoteIfNeeded("PortalObject"), serviceNotNull.Dialect.QuoteIfNeeded("PageProfile")), new Dictionary<string, object> { 
		{
			"portletMetadataTypeUid",
			PortletMetadata.TypeUid
		} });
		serviceNotNull.ExecuteNonQuery(string.Format("delete from {6} where {5} in (select {1} from {5} where {2} in (select {2} from {4} where {3}={0}portletMetadataTypeUid))", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Uid"), serviceNotNull.Dialect.QuoteIfNeeded("MetadataType"), serviceNotNull.Dialect.QuoteIfNeeded("FormMetadataItemHeader"), serviceNotNull.Dialect.QuoteIfNeeded("PortalObject"), serviceNotNull.Dialect.QuoteIfNeeded("PortalObjectPermission")), new Dictionary<string, object> { 
		{
			"portletMetadataTypeUid",
			PortletMetadata.TypeUid
		} });
		serviceNotNull.ExecuteNonQuery(string.Format("delete from {5} where {2} in (select {2} from {4} where {3}={0}portletMetadataTypeUid)", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Uid"), serviceNotNull.Dialect.QuoteIfNeeded("MetadataType"), serviceNotNull.Dialect.QuoteIfNeeded("FormMetadataItemHeader"), serviceNotNull.Dialect.QuoteIfNeeded("PortalObject")), new Dictionary<string, object> { 
		{
			"portletMetadataTypeUid",
			PortletMetadata.TypeUid
		} });
		serviceNotNull.ExecuteNonQuery(string.Format("delete from {6} where {1} in (select {1} from {5} where {2} in (select {2} from {4} where {3}={0}portletMetadataTypeUid))", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Uid"), serviceNotNull.Dialect.QuoteIfNeeded("MetadataType"), serviceNotNull.Dialect.QuoteIfNeeded("FormMetadataItemGroup"), serviceNotNull.Dialect.QuoteIfNeeded("PortalObject"), serviceNotNull.Dialect.QuoteIfNeeded("PageFolder")), new Dictionary<string, object> { 
		{
			"portletMetadataTypeUid",
			PortletMetadata.TypeUid
		} });
		serviceNotNull.ExecuteNonQuery(string.Format("delete from {6} where {5} in (select {1} from {5} where {2} in (select {2} from {4} where {3}={0}portletMetadataTypeUid))", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Uid"), serviceNotNull.Dialect.QuoteIfNeeded("MetadataType"), serviceNotNull.Dialect.QuoteIfNeeded("FormMetadataItemGroup"), serviceNotNull.Dialect.QuoteIfNeeded("PortalObject"), serviceNotNull.Dialect.QuoteIfNeeded("PortalObjectPermission")), new Dictionary<string, object> { 
		{
			"portletMetadataTypeUid",
			PortletMetadata.TypeUid
		} });
		serviceNotNull.ExecuteNonQuery(string.Format("delete from {5} where {2} in (select {2} from {4} where {3}={0}portletMetadataTypeUid)", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Uid"), serviceNotNull.Dialect.QuoteIfNeeded("MetadataType"), serviceNotNull.Dialect.QuoteIfNeeded("FormMetadataItemGroup"), serviceNotNull.Dialect.QuoteIfNeeded("PortalObject")), new Dictionary<string, object> { 
		{
			"portletMetadataTypeUid",
			PortletMetadata.TypeUid
		} });
	}

	public void RemoveSecurityHomePagePortlets()
	{
		IPortletPage portletPage = EntityManager<IPortletPage>.Instance.LoadOrNull(defaultPageGuid);
		if (portletPage != null && PortletManager != null)
		{
			string portalPageDataPath = "portletPage_" + portletPage.Id;
			PortletManager sharedPortletManager = PortletManager.Create(PersonalizationScope.Shared, portalPageDataPath);
			IBLOBDataManager bLOBManager = DataAccessManager.BLOBManager;
			List<Guid> list = bLOBManager.GetBLOB<List<Guid>>(defaultPageGuid, "EleWise.ELMA.BPM.Web.DefaultPage_PortletsAdded") ?? new List<Guid>();
			list.Clear();
			sharedPortletManager.GetAllPortlets(portalPageDataPath).ForEach(delegate(PortletViewModel p)
			{
				sharedPortletManager.RemovePersonalization(p.Personalization.PortletUid, p.Personalization.InstanceId, portalPageDataPath);
			});
			bLOBManager.SetBLOB(defaultPageGuid, "EleWise.ELMA.BPM.Web.DefaultPage_PortletsAdded", list);
		}
	}

	public void FixHomePageSettings()
	{
		Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Flush();
		foreach (IHomePageSetting item in HomePageSettingManager.Instance.Find((IHomePageSetting x) => x.WorkplacePages == null).ToList())
		{
			item.Delete();
		}
	}

	public void CreateDefaultLiteWorkPlace()
	{
	}

	internal void CreateDefaultMobileWorkPlace()
	{
		if (WorkPlaceManager.Instance.LoadOrNull(WorkPlaceManager.MobileWorkPlaceUid) == null)
		{
			InstanceOf<IWorkPlace> instanceOf = new InstanceOf<IWorkPlace>();
			instanceOf.New.Name = "Mobile";
			instanceOf.New.Uid = WorkPlaceManager.MobileWorkPlaceUid;
			instanceOf.New.Type = MobileWorkPlaceTypeConst.Uid;
			instanceOf.New.Save();
		}
	}

	public void FixFilterActionLink()
	{
		string deletingColumnTemporaryName = Locator.GetServiceNotNull<DbModelUpdater>().GetDeletingColumnTemporaryName("FilterActionLink", "ImageUrl");
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (serviceNotNull.ColumnExists("Filter", "ImageUrl") && serviceNotNull.ColumnExists("FilterActionLink", deletingColumnTemporaryName))
		{
			string arg = string.Format("(SELECT {2}.{1} FROM {2} WHERE {2}.{3} = {0}.{3})", serviceNotNull.Dialect.QuoteIfNeeded("Filter"), serviceNotNull.Dialect.QuoteIfNeeded(deletingColumnTemporaryName), serviceNotNull.Dialect.QuoteIfNeeded("FilterActionLink"), serviceNotNull.Dialect.QuoteIfNeeded("Id"));
			string sql = string.Format("UPDATE {0} SET {1} = COALESCE({2}, {1})", serviceNotNull.Dialect.QuoteIfNeeded("Filter"), serviceNotNull.Dialect.QuoteIfNeeded("ImageUrl"), arg);
			serviceNotNull.ExecuteNonQuery(sql);
		}
	}

	public void ConvertMenuItemColumns()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		serviceNotNull.ConvertColumnString("MenuItem", InterfaceActivator.PropertyName((IMenuItem m) => m.Code), 200, substringStrings: true);
		serviceNotNull.ConvertColumnString("MenuItem", InterfaceActivator.PropertyName((IMenuItem m) => m.ActionTypeProviderId), 70, substringStrings: true);
		serviceNotNull.ConvertColumnString("MenuItem", InterfaceActivator.PropertyName((IMenuItem m) => m.ActionId), 200, substringStrings: true);
	}

	public void DisableUserPanelActions()
	{
		string text = "UserPanelTasks";
		string text2 = "UserPanelCalendar";
		string text3 = "WorkPlace";
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (serviceNotNull.ColumnExists(text3, text) && serviceNotNull.ColumnExists(text3, text2))
		{
			string sql = $"UPDATE {serviceNotNull.Dialect.QuoteIfNeeded(text3)} SET {serviceNotNull.Dialect.QuoteIfNeeded(text)}=0, {serviceNotNull.Dialect.QuoteIfNeeded(text2)}=0";
			serviceNotNull.ExecuteNonQuery(sql);
		}
	}

	internal void UpdateColors()
	{
		Guid settingsUid = ThemeSettingsModule._ModuleGuid;
		Dictionary<string, string> colors = new Dictionary<string, string>();
		Action<string, string, string> obj = delegate(string propName, string color, string colorAfter)
		{
			if (DataAccessManager.SettingsManager.GetString(settingsUid, propName) == color)
			{
				colors.Add(propName, colorAfter);
			}
		};
		obj("ValidationSuccessFontColor", "#68ba78", "#3EA853");
		obj("ValidationErrorFontColor", "#dd1717", "#E62D32");
		obj("SeparatorBlueBackgroundColor", "#ecf5fd", "#EAF0FE");
		obj("SeparatorBlueHoverBackgroundColor", "#d5e4f0", "#CDDBF8");
		obj("SeparatorYellowBackgroundColor", "#fcd109", "#F8BD2C");
		obj("SeparatorYellowHoverBackgroundColor", "#e5be08", "#F9B12A");
		obj("SeparatorRedBackgroundColor", "#f8d1d1", "#FECCD3");
		obj("SeparatorRedHoverBackgroundColor", "#f1a2a2", "#EE989B");
		obj("SeparatorGreenBackgroundColor", "#e1f1e4", "#D1F8D9");
		obj("SeparatorGreenHoverBackgroundColor", "#c3e3c9", "#AEE8B9");
		obj("ButtonBlue", "#2c76b3", "#456EBF");
		obj("ButtonHoverBlue", "#296da6", "#456EBF");
		obj("ButtonOutlineBlue", "#2c76b3", "#4069BA");
		obj("ButtonOutlineHoverBlue", "#d5e4f0", "#CDDBF8");
		obj("ButtonRed", "#dd1717", "#E62D32");
		obj("ButtonHoverRed", "#cc1515", "#D22533");
		obj("ButtonOutlineRed", "#dd1717", "#E62D32");
		obj("ButtonOutlineHoverRed", "#f8d1d1", "#FECCD3");
		obj("ButtonGreen", "#68ba78", "#3EA853");
		obj("ButtonHoverGreen", "#569963", "#3CA14F");
		obj("ButtonOutlineGreen", "#68ba78", "#3EA853");
		obj("ButtonOutlineHoverGreen", "#e1f1e4", "#D1F8D9");
		obj("ButtonYellow", "#fcd109", "#F8BD2C");
		obj("ButtonHoverYellow", "#e5be08", "#F9B12A");
		obj("ButtonOutlineYellow", "#e9b408", "#F89E27");
		obj("ButtonOutlineHoverYellow", "#fef6ce", "#FDEBB5");
		obj("TabFontColor", "#2c76b3", "#456EBF");
		obj("ActiveTabBackgroundColor", "#2c76b3", "#456EBF");
		obj("ActiveCounterBackgroundColor", "#2c76b3", "#456EBF");
		obj("ControlFocusBorderColor", "#80add1", "#8DAAE2");
		DataAccessManager.SettingsManager.SetStrings(settingsUid, colors);
		ColorSchemeManager.Instance.ClearSchemeChache(null);
	}

	internal void CreateDefaultColorSchemes1()
	{
		ICollection<Guid> collection = ExistingDefaultColorSchemeUids();
		if (!collection.Contains(ColorSchemeConst.DefaultColorSchemeUid))
		{
			IColorScheme colorScheme = CreateColorScheme(ColorSchemeConst.DefaultColorSchemeName, ColorSchemeConst.DefaultColorSchemeUid, ColorSchemeConst.DefaultColorSchemeSettings);
			Guid moduleGuid = ThemeSettingsModule._ModuleGuid;
			DataAccessManager.SettingsManager.SetString(moduleGuid, "CurrentColorSchemeId", colorScheme.Id.ToString());
		}
		if (!collection.Contains(ColorSchemeConst.DarkColorSchemeUid))
		{
			CreateColorScheme(darkColorSchemeName, ColorSchemeConst.DarkColorSchemeUid, ColorSchemeConst.DarkColorSchemeSettings);
		}
		if (!collection.Contains(ColorSchemeConst.RedColorSchemeUid))
		{
			CreateColorScheme(redColorSchemeName, ColorSchemeConst.RedColorSchemeUid, ColorSchemeConst.RedColorSchemeSettings);
		}
		if (!collection.Contains(ColorSchemeConst.BlueColorSchemeUid))
		{
			CreateColorScheme(blueColorSchemeName, ColorSchemeConst.BlueColorSchemeUid, ColorSchemeConst.BlueColorSchemeSettings);
		}
		if (!collection.Contains(ColorSchemeConst.GreenColorSchemeUid))
		{
			CreateColorScheme(greenColorSchemeName, ColorSchemeConst.GreenColorSchemeUid, ColorSchemeConst.GreenColorSchemeSettings);
		}
		if (!collection.Contains(ColorSchemeConst.YellowColorSchemeUid))
		{
			CreateColorScheme(yellowColorSchemeName, ColorSchemeConst.YellowColorSchemeUid, ColorSchemeConst.YellowColorSchemeSettings);
		}
	}

	internal void UpdateDefaultColorSchemes4()
	{
		ICollection<IColorScheme> source = ExistingDefaultColorSchemes();
		UpdateColorScheme(ColorSchemeConst.DefaultColorSchemeName, source.FirstOrDefault((IColorScheme colorScheme) => colorScheme.Uid == ColorSchemeConst.DefaultColorSchemeUid), ColorSchemeConst.DefaultColorSchemeSettings);
		UpdateColorScheme(darkColorSchemeName, source.FirstOrDefault((IColorScheme colorScheme) => colorScheme.Uid == ColorSchemeConst.DarkColorSchemeUid), ColorSchemeConst.DarkColorSchemeSettings);
		UpdateColorScheme(redColorSchemeName, source.FirstOrDefault((IColorScheme colorScheme) => colorScheme.Uid == ColorSchemeConst.RedColorSchemeUid), ColorSchemeConst.RedColorSchemeSettings);
		UpdateColorScheme(blueColorSchemeName, source.FirstOrDefault((IColorScheme colorScheme) => colorScheme.Uid == ColorSchemeConst.BlueColorSchemeUid), ColorSchemeConst.BlueColorSchemeSettings);
		UpdateColorScheme(greenColorSchemeName, source.FirstOrDefault((IColorScheme colorScheme) => colorScheme.Uid == ColorSchemeConst.GreenColorSchemeUid), ColorSchemeConst.GreenColorSchemeSettings);
		UpdateColorScheme(yellowColorSchemeName, source.FirstOrDefault((IColorScheme colorScheme) => colorScheme.Uid == ColorSchemeConst.YellowColorSchemeUid), ColorSchemeConst.YellowColorSchemeSettings);
	}

	internal void ConvertColorScheme()
	{
		Guid moduleGuid = ThemeSettingsModule._ModuleGuid;
		IDictionary<string, string> themeSettings = DataAccessManager.SettingsManager.GetAllStrings(moduleGuid);
		IDictionary<string, object> dictionary = ColorSchemeConst.DefaultColorSchemeSettings.ToDictionary();
		if (!dictionary.Any((KeyValuePair<string, object> i) => themeSettings.ContainsKey(i.Key) && !themeSettings[i.Key].IsNullOrEmpty() && themeSettings[i.Key] != i.Value.ToString()))
		{
			return;
		}
		List<PropertyInfo> source = (from property in typeof(ColorSchemeSettingsModel).GetProperties()
			where Attribute.IsDefined(property, typeof(LessVariableNameAttribute)) && property.CanWrite
			select property).ToList();
		ColorSchemeSettingsModel colorSchemeSettingsModel = new ColorSchemeSettingsModel();
		foreach (KeyValuePair<string, object> setting in colorSchemeSettingsModel.ToDictionary())
		{
			PropertyInfo propertyInfo = source.FirstOrDefault((PropertyInfo a) => a.Name == setting.Key);
			if (propertyInfo != null)
			{
				string valueOrDefault = themeSettings.GetValueOrDefault(setting.Key, string.Empty);
				propertyInfo.SetValue(colorSchemeSettingsModel, valueOrDefault.IsNullOrEmpty() ? dictionary[propertyInfo.Name].ToString() : valueOrDefault);
			}
		}
		InstanceOf<IColorScheme> instanceOf = new InstanceOf<IColorScheme>();
		instanceOf.New.Name = SR.T("Цветовая схема");
		instanceOf.New.SettingsData = ColorSchemeSettingsModel.ToJson(colorSchemeSettingsModel);
		IColorScheme @new = instanceOf.New;
		@new.Save();
		DataAccessManager.SettingsManager.SetString(moduleGuid, "CurrentColorSchemeId", @new.Id.ToString());
	}

	internal void UpdateColorSchemes5()
	{
		string sql = string.Format("SELECT {0}, {1} FROM {2}", base.Transformation.Dialect.QuoteIfNeeded("Id"), base.Transformation.Dialect.QuoteIfNeeded("SettingsData"), base.Transformation.Dialect.QuoteIfNeeded("ColorScheme"));
		ColorSchemeManager.Instance.ClearSchemeChache(null);
		IDictionary<string, object> dictionary = ColorSchemeConst.DefaultColorSchemeSettings.ToDictionary();
		DataTable dataTable = new DataTable("ColorScheme");
		dataTable.Columns.Add("Id", typeof(long));
		dataTable.Columns.Add("SettingsData", typeof(string));
		List<PropertyInfo> source = (from property in typeof(ColorSchemeSettingsModel).GetProperties()
			where Attribute.IsDefined(property, typeof(LessVariableNameAttribute)) && property.CanWrite
			select property).ToList();
		using (IDataReader dataReader = base.Transformation.ExecuteQuery(sql))
		{
			while (dataReader.Read())
			{
				bool flag = false;
				long @int = dataReader.GetInt64(dataReader.GetOrdinal("Id"));
				ColorSchemeSettingsModel colorSchemeSettingsModel = ColorSchemeSettingsModel.FromJson(dataReader.GetString(dataReader.GetOrdinal("SettingsData")));
				foreach (KeyValuePair<string, object> setting in colorSchemeSettingsModel.ToDictionary())
				{
					PropertyInfo propertyInfo = source.FirstOrDefault((PropertyInfo a) => a.Name == setting.Key);
					if (propertyInfo != null && string.IsNullOrWhiteSpace(setting.Value as string))
					{
						propertyInfo.SetValue(colorSchemeSettingsModel, dictionary[propertyInfo.Name].ToString());
						flag = true;
					}
				}
				if (flag)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["Id"] = @int;
					dataRow["SettingsData"] = ColorSchemeSettingsModel.ToJson(colorSchemeSettingsModel);
					dataTable.Rows.Add(dataRow);
				}
			}
		}
		if (dataTable.Rows.Count > 0)
		{
			base.Transformation.BulkUpdate("ColorScheme", dataTable, "Id");
		}
	}

	internal void CreateWorkplaceColorSchemes()
	{
		if (AbstractNHEntityManager<IWorkplaceColorScheme, long>.Instance.LoadOrNull(ColorSchemeConst.DefaultWorkplaceColorSchemeUid) == null)
		{
			InstanceOf<IWorkplaceColorScheme> instanceOf = new InstanceOf<IWorkplaceColorScheme>();
			instanceOf.New.Uid = ColorSchemeConst.DefaultWorkplaceColorSchemeUid;
			IWorkplaceColorScheme @new = instanceOf.New;
			IColorScheme colorScheme = ColorSchemeManager.Instance.Load(ColorSchemeConst.DefaultColorSchemeUid);
			@new.ColorSchemes.Add(colorScheme);
			@new.Save();
		}
	}

	internal void UpdateWorkplaceColorScheme()
	{
		IWorkplaceColorScheme workplaceColorScheme = AbstractNHEntityManager<IWorkplaceColorScheme, long>.Instance.LoadOrNull(ColorSchemeConst.DefaultWorkplaceColorSchemeUid);
		if (workplaceColorScheme != null)
		{
			string sql = string.Format("update {1} set {2}={0}DefaultWorkplaceColorSchemeId", base.Transformation.ParameterSeparator, base.Transformation.Dialect.QuoteIfNeeded("WorkPlace"), base.Transformation.Dialect.QuoteIfNeeded("WorkplaceColorSchemes"));
			base.Transformation.ExecuteNonQuery(sql, new Dictionary<string, object> { { "DefaultWorkplaceColorSchemeId", workplaceColorScheme.Id } });
		}
	}

	private IColorScheme CreateColorScheme(string colorSchemeName, Guid colorSchemeUid, ColorSchemeSettingsModel colorSchemeSettingsModel)
	{
		InstanceOf<IColorScheme> instanceOf = new InstanceOf<IColorScheme>();
		instanceOf.New.Name = colorSchemeName;
		instanceOf.New.Uid = colorSchemeUid;
		instanceOf.New.SettingsData = ColorSchemeSettingsModel.ToJson(colorSchemeSettingsModel);
		IColorScheme @new = instanceOf.New;
		@new.Save();
		return @new;
	}

	private void UpdateColorScheme(string colorSchemeName, IColorScheme colorScheme, ColorSchemeSettingsModel colorSchemeSettingsModel)
	{
		if (colorScheme != null)
		{
			string text = ColorSchemeSettingsModel.ToJson(colorSchemeSettingsModel);
			if (text != colorScheme.SettingsData || colorSchemeName != colorScheme.Name)
			{
				colorScheme.Name = colorSchemeName;
				colorScheme.SettingsData = text;
				colorScheme.Save();
				ColorSchemeManager.Instance.ClearSchemeChache(colorScheme.Uid);
			}
		}
	}

	private ICollection<IColorScheme> ExistingDefaultColorSchemes()
	{
		return ColorSchemeManager.Instance.FindByIdArray(ColorSchemeManager.Instance.SystemColorSchemeGuids);
	}

	private ICollection<Guid> ExistingDefaultColorSchemeUids()
	{
		return ColorSchemeManager.Instance.CreateCriteriaForArraySearch(ColorSchemeManager.Instance.SystemColorSchemeGuids, "Uid", null, null).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Uid") }).List<Guid>();
	}
}
