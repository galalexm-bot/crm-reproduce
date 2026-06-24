using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.IntegrationModules.Managers;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.IntegrationModules.Web.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.IntegrationModules.Web.Controllers;

[RouteArea("EleWise.ELMA.IntegrationModules.Web")]
[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
public class IntegrationModulesController : FilterTreeBaseController<IIntegrationModule, long>
{
	private const string webApiUrl = "/PublicAPI/REST/EleWise.ELMA.IntegrationModules/IntegrationPublicAPIWeb/ExecuteExternalEventPOST?eventUrl=";

	private IMetadataRuntimeService metadataRuntimeService;

	private IntegrationModuleHeaderManager integrtionModuleHeaderManager;

	private CommonSettingsModule commonSettingsModule;

	public IntegrationModulesController(IMetadataRuntimeService metadataRuntimeService, IntegrationModuleHeaderManager integrtionModuleHeaderManager, CommonSettingsModule commonSettingsModule)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.integrtionModuleHeaderManager = integrtionModuleHeaderManager;
		this.commonSettingsModule = commonSettingsModule;
	}

	[ContentItem(Name = "SR.M('Интеграции')")]
	public ActionResult Index()
	{
		string text = "IntegrationModulesTree";
		TreeState treeState = TreePersonalizationAdministration.LoadState(text);
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = text
			};
			TreePersonalizationAdministration.SaveState(text, treeState);
		}
		TreeModel treeModel = null;
		IEnumerable<IntegrationModuleMetadata> integrationModuleMetadataList = integrtionModuleHeaderManager.GetIntegrationModuleMetadataList(true);
		treeModel = ((!integrationModuleMetadataList.Any()) ? new TreeModel
		{
			Id = text,
			Children = new List<TreeMenuNode>
			{
				new TreeMenuNode
				{
					text = SR.T("Нет опубликованных модулей интеграции")
				}
			},
			HtmlAttributes = new
			{
				@class = "integrationTree"
			},
			ShowExpandCollapseButtons = true
		} : new TreeModel
		{
			Id = text,
			Children = BuildTree(integrationModuleMetadataList, treeState, (Guid guid) => ((Controller)this).get_Url().EntityList(metadataRuntimeService.GetTypeByUid(guid)) ?? ((Controller)this).get_Url().Action("ViewModule", "IntegrationModules", (object)new
			{
				uid = guid
			}), ((Controller)this).get_Url(), null),
			HtmlAttributes = new
			{
				@class = "integrationTree"
			},
			ShowExpandCollapseButtons = true
		});
		return (ActionResult)(object)((Controller)this).View((object)treeModel);
	}

	internal static List<TreeMenuNode> BuildTree(IEnumerable<IntegrationModuleMetadata> list, TreeState treeState, Func<Guid, string> href, UrlHelper url, Func<Guid, string> onclick)
	{
		List<TreeMenuNode> list2 = new List<TreeMenuNode>();
		BuildTree(list, list2, treeState, href, url, onclick);
		return list2;
	}

	internal static void BuildTree(IEnumerable<IntegrationModuleMetadata> list, List<TreeMenuNode> nodes, TreeState treeState, Func<Guid, string> href, UrlHelper url, Func<Guid, string> onclick)
	{
		foreach (IntegrationModuleMetadata item2 in list)
		{
			TreeMenuNode item = new TreeMenuNode
			{
				text = item2.DisplayName,
				expanded = treeState[item2.Uid.ToString()],
				id = item2.Uid.ToString(),
				icon = GetIconString(url, item2),
				href = href?.Invoke(item2.Uid),
				onclick = onclick?.Invoke(item2.Uid)
			};
			nodes.Add(item);
		}
	}

	private static string GetIconString(UrlHelper urlHelper, ClassMetadata metadata)
	{
		if (urlHelper != null && metadata.Images != null && metadata.Images.Any())
		{
			return urlHelper.Action("Object", "Images", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = metadata.Uid,
				size = 16,
				useParent = false
			});
		}
		return "#integration.svg";
	}

	public ActionResult ViewModule(Guid uid)
	{
		IntegrationModuleMetadata integrationModuleMetadata = metadataRuntimeService.GetMetadata(uid) as IntegrationModuleMetadata;
		return (ActionResult)(object)((Controller)this).View("ViewModule", (object)integrationModuleMetadata);
	}

	[CustomGridAction]
	public ActionResult IntegrationsGrid(Guid uid)
	{
		FilterModel filterModel = new FilterModel(InterfaceActivator.Create<IFilter>(), uid);
		if (!(filterModel.Filter is IIntegrationModuleFilter integrationModuleFilter))
		{
			((BaseController)(object)this).Notifier.Error(SR.T("Выбранный тип не является модулем интеграции"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		integrationModuleFilter.IsTemplate = true;
		GridDataFilter<IIntegrationModule> gridData = CreateGridData(null, filterModel);
		return ((BaseController<IIntegrationModule, long>)(object)this).GridView((GridData<IIntegrationModule>)gridData);
	}

	public ActionResult Edit(Guid uid, string id)
	{
		if (!string.IsNullOrEmpty(id))
		{
			return Add(uid, id);
		}
		return (ActionResult)(object)((Controller)this).HttpNotFound();
	}

	public ActionResult Add(Guid uid, string id)
	{
		Type typeByUid = metadataRuntimeService.GetTypeByUid(uid);
		IntegrationModuleMetadata metadata = metadataRuntimeService.GetMetadata(uid) as IntegrationModuleMetadata;
		IntegrationModuleModel integrationModuleModel = new IntegrationModuleModel();
		if (string.IsNullOrWhiteSpace(id))
		{
			integrationModuleModel.Entity = InterfaceActivator.Create(typeByUid) as IIntegrationModule;
		}
		else
		{
			IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
			integrationModuleModel.Entity = (IIntegrationModule)entityManager.Load(id);
		}
		integrationModuleModel.TypeUid = uid;
		integrationModuleModel.Metadata = metadata;
		return (ActionResult)(object)((Controller)this).View("Add", (object)integrationModuleModel);
	}

	[HttpPost]
	public ActionResult Save(IntegrationModuleModel model)
	{
		if (model.Entity.IsTemplate && model.Entity.WebApiKey == Guid.Empty)
		{
			model.Entity.WebApiKey = Guid.NewGuid();
		}
		model.Entity.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("ViewModule", (object)new
		{
			uid = model.TypeUid
		});
	}

	public ActionResult ViewItem(long id, Guid uid)
	{
		Type typeByUid = metadataRuntimeService.GetTypeByUid(uid);
		IntegrationModuleModel integrationModuleModel = new IntegrationModuleModel
		{
			ViewType = ViewType.Display
		};
		IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
		integrationModuleModel.Entity = (IIntegrationModule)entityManager.Load(id);
		integrationModuleModel.TypeUid = uid;
		integrationModuleModel.WebApiUrlBase = commonSettingsModule.Settings.ApplicationBaseUrl.TrimEnd('/') + "/PublicAPI/REST/EleWise.ELMA.IntegrationModules/IntegrationPublicAPIWeb/ExecuteExternalEventPOST?eventUrl=";
		integrationModuleModel.Metadata = MetadataLoader.LoadMetadata(integrationModuleModel.Entity.TypeUid) as IntegrationModuleMetadata;
		return (ActionResult)(object)((Controller)this).View((object)integrationModuleModel);
	}

	[HttpPost]
	public ActionResult Delete(Guid uid, string id)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		Type typeByUid = metadataRuntimeService.GetTypeByUid(uid);
		if (typeByUid == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		if (!string.IsNullOrEmpty(id))
		{
			try
			{
				object id2 = TypeDescriptor.GetConverter(ModelHelper.GetEntityIdType(typeByUid)).ConvertFromInvariantString(id);
				IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
				object obj = entityManager.Load(id2);
				entityManager.Delete(obj);
			}
			catch (Exception ex)
			{
				((BaseController)(object)this).Logger.Error(SR.T("Ошибка при удалении записи интеграции"), ex);
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					error = ex.Message
				});
			}
			return (ActionResult)new EmptyResult();
		}
		return (ActionResult)(object)((Controller)this).HttpNotFound();
	}

	[ContentItem(Name = "SR.M('Монитор интеграций')")]
	public ActionResult IntegrationsList()
	{
		FilterModel filterModel = CreateFilter();
		((IIntegrationModuleFilter)filterModel.Filter).IsTemplate = false;
		GridDataFilter<IIntegrationModule> gridDataFilter = CreateGridData(null, filterModel);
		return (ActionResult)(object)((Controller)this).View((object)gridDataFilter);
	}

	[CustomGridAction]
	public ActionResult IntegrationMonitorGrid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter)
	{
		if (filter == null)
		{
			filter = CreateFilter();
		}
		((IIntegrationModuleFilter)filter.Filter).IsTemplate = false;
		GridDataFilter<IIntegrationModule> gridData = CreateGridData(command, filter);
		return ((BaseController<IIntegrationModule, long>)(object)this).GridView((GridData<IIntegrationModule>)gridData);
	}
}
