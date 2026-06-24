using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.History.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Common")]
public class EntityHistoryController : BPMController<IEntityActionHistory, long>
{
	private IHistoryService historyService;

	public EntityActionHistoryManager HistoryManager { get; set; }

	public IEnumerable<IEntityActionHistoryCollectorRelated> EntityActionHistoryCollectorsRelated { get; set; }

	public IEnumerable<IEntityActionHistoryCollector> EntityActionHistoryCollectors { get; set; }

	public IEnumerable<IAuditEventRender> AuditEventRenders { get; set; }

	[NotNull]
	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public IEnumerable<IAuditEventPermissionChecker> AuditEventPermissionCheckers { get; set; }

	private IHistoryService HistoryService => historyService ?? (historyService = Locator.GetServiceNotNull<IHistoryService>());

	public IHistoryOrder HistoryOrder { get; set; }

	[OutputCache(Duration = 60, VaryByParam = "id;actionObject;orderDesc", VaryByCustom = "TimeZone")]
	public ActionResult History(long id, Guid actionObject, bool? orderDesc, string[] disableButtons = null, int? firstResult = null, int? maxResults = null, long? lastActionDate = null, int? packageIndex = null)
	{
		return SyncHistory(id, actionObject, orderDesc, disableButtons, firstResult, maxResults, lastActionDate);
	}

	[OutputCache(Duration = 60, VaryByParam = "id;actionObject;orderDesc;firstResult;lastActionDate;packageIndex", VaryByCustom = "TimeZone")]
	public ActionResult HistoryPart(long id, Guid actionObject, bool? orderDesc, string[] disableButtons = null, long? firstResult = null, int? maxResults = null, long? lastActionDate = null, int? packageIndex = null)
	{
		EntityHistoryViewModel model = GetHistoryModel(id, actionObject, orderDesc, disableButtons, firstResult, maxResults, lastActionDate, packageIndex);
		((ControllerBase)this).get_ViewData().set_Model((object)model);
		HtmlCatchViewResult htmlCatchViewResult = new HtmlCatchViewResult();
		((ViewResultBase)htmlCatchViewResult).set_ViewName("History");
		((ViewResultBase)htmlCatchViewResult).set_ViewData(((ControllerBase)this).get_ViewData());
		((ViewResultBase)htmlCatchViewResult).set_TempData(((ControllerBase)this).get_TempData());
		HtmlCatchViewResult htmlCatchViewResult2 = htmlCatchViewResult;
		return (ActionResult)(object)new CompositeActionResult((IEnumerable<ActionResult>)(object)new HtmlCatchViewResult[1] { htmlCatchViewResult2 }, delegate(ControllerContext context, IEnumerable<ActionResult> results)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (results.Any())
			{
				if (model.UnitOfWorks.Any())
				{
					RelatedEntityActionHistoryUnitOfWorkModel relatedEntityActionHistoryUnitOfWorkModel = model.UnitOfWorks.Last();
					if (relatedEntityActionHistoryUnitOfWorkModel != null)
					{
						long ticks = relatedEntityActionHistoryUnitOfWorkModel.ActionDate.Ticks;
						dictionary["html"] = ((HtmlCatchViewResult)(object)results.First()).HtmlResult;
						dictionary["info"] = new
						{
							lastPackage = false,
							lastId = relatedEntityActionHistoryUnitOfWorkModel.Id,
							lastActionDate = relatedEntityActionHistoryUnitOfWorkModel.ActionDate.Ticks,
							packageIndex = ((lastActionDate == ticks) ? packageIndex : new int?(0))
						};
					}
				}
				else
				{
					dictionary["info"] = new
					{
						lastPackage = true
					};
				}
			}
			else
			{
				base.Logger.Error(SR.T("При формировании ответа на запрос загрузки истории не сформировано ни одного результата."));
				dictionary["html"] = SR.T("В ходе загрузки истории произошла ошибка. Подробную информацию об ошибке можно найти в лог-файле сервера ELMA.");
				dictionary["info"] = new
				{
					lastPackage = true
				};
			}
			context.get_HttpContext().Response.ContentType = "application/json";
			context.get_HttpContext().Response.Output.Write(dictionary.ToJson());
		})
		{
			ResultType = ActionResultType.Unknown
		};
	}

	[OutputCache(Duration = 60, VaryByParam = "id;actionObject;orderDesc", VaryByCustom = "TimeZone")]
	public ActionResult SyncHistory(long id, Guid actionObject, bool? orderDesc, string[] disableButtons = null, long? firstResult = null, int? maxResults = null, long? lastActionDate = null, int? packageIndex = null)
	{
		EntityHistoryViewModel historyModel = GetHistoryModel(id, actionObject, orderDesc, disableButtons, firstResult, maxResults, lastActionDate);
		return (ActionResult)(object)((Controller)this).PartialView("History", (object)historyModel);
	}

	private EntityHistoryViewModel GetHistoryModel(long id, Guid actionObject, bool? orderDesc, string[] disableButtons = null, long? firstResult = null, int? maxResults = null, long? lastActionDate = null, int? packageIndex = null)
	{
		return new EntityHistoryViewModel(HistoryService.GetHistoryModel(id, actionObject, orderDesc, firstResult, maxResults, lastActionDate, packageIndex), AuditEventPermissionCheckers)
		{
			Renders = AuditEventRenders.ToList()
		};
	}

	[Obsolete]
	private IEnumerable<EntityActionEventArgs> CollectOldHistory(long id, Guid actionObject, IEnumerable<Guid> unitOfWorks)
	{
		if (EntityActionHistoryCollectors.Any())
		{
			base.Logger.Warn(SR.T("В системе задействованы устаревшие сборщики истории: {0}", string.Join(",", EntityActionHistoryCollectors.Select((IEntityActionHistoryCollector a) => a.ToString()))));
		}
		IEnumerable<EntityActionEventArgs> seed = Enumerable.Empty<EntityActionEventArgs>();
		seed = EntityActionHistoryCollectors.Aggregate(seed, (IEnumerable<EntityActionEventArgs> current, IEntityActionHistoryCollector collector) => current.Union(collector.CollectHistory(id, actionObject)));
		return seed.Where((EntityActionEventArgs a) => unitOfWorks.Any((Guid ofw) => ofw.Equals(a.UnitOfWorkUid)));
	}

	[OutputCache(Duration = 60, VaryByParam = "id;actionObject;orderDesc;divPanelId;inTab", VaryByCustom = "TimeZone")]
	public ActionResult EventHistory(long id, Guid actionObject, string divPanelId, bool? orderDesc, string[] disableButtons = null, bool inTab = true, bool asyncLoading = false)
	{
		Type typeByUid = MetadataRuntimeService.GetTypeByUid(actionObject);
		IEntity<long> entity = (IEntity<long>)EntityHelper.GetEntityManager(typeByUid).Load(id);
		EntityHistoryPanelViewModel entityHistoryPanelViewModel = new EntityHistoryPanelViewModel
		{
			ObjectUid = actionObject,
			DivId = ((!string.IsNullOrEmpty(divPanelId)) ? divPanelId : $"eh_{TagBuilder.CreateSanitizedId(typeByUid.FullName)}_{id}"),
			InTab = inTab,
			Entity = entity,
			DisableButtons = disableButtons?.ToList(),
			AsyncLoading = asyncLoading
		};
		return (ActionResult)(object)((Controller)this).PartialView("EntityHistoryPanel", (object)entityHistoryPanelViewModel);
	}

	public ActionResult MultipleEventHistory(Guid unitOfWorkUid, Guid? actionObject, Guid? actionTypeUid, bool? inPopup, long? actionObjectId)
	{
		IEnumerable<EntityActionEventArgs> relatedEventList = HistoryManager.LoadHistory(unitOfWorkUid, actionObject ?? Guid.Empty, actionTypeUid ?? Guid.Empty, null, withGrouping: false);
		if (actionObject.HasValue && actionObjectId.HasValue)
		{
			Type actionObjectType = MetadataRuntimeService.GetTypeByUid(actionObject.Value);
			IEnumerable<IEntityActionHistoryCollectorRelated> source = EntityActionHistoryCollectorsRelated.Where((IEntityActionHistoryCollectorRelated collector) => collector.CanUse(actionObjectId.Value, actionObject.Value));
			IEnumerable<HistoryCollectorRelatedModel> relatedObjects = Enumerable.Empty<HistoryCollectorRelatedModel>();
			relatedObjects = source.Aggregate(relatedObjects, (IEnumerable<HistoryCollectorRelatedModel> current, IEntityActionHistoryCollectorRelated collector) => current.Union(collector.RelatedObjects(actionObjectId.Value, actionObject.Value)));
			IEnumerable<EntityActionEventArgs> seed = relatedEventList.Where((EntityActionEventArgs a) => a.EntityType == actionObjectType && (long)a.New.GetId() == actionObjectId);
			seed = source.Aggregate(seed, (IEnumerable<EntityActionEventArgs> current, IEntityActionHistoryCollectorRelated collector) => current.Union(collector.CollectHistory(actionObjectId.Value, actionObject.Value, relatedEventList, relatedObjects)));
			IEnumerable<Guid> unitOfWorks = seed.Select((EntityActionEventArgs a) => a.UnitOfWorkUid);
			relatedEventList = from e in seed.Union(CollectOldHistory(actionObjectId.Value, actionObject.Value, unitOfWorks))
				where !AuditEventPermissionCheckers.Any((IAuditEventPermissionChecker c) => !c.HasPermission(e))
				orderby e.ActionDate
				select e;
		}
		List<IAuditEventRender> renders = AuditEventRenders.ToList();
		CachedEntityActionHistoryLoader historyLoader = new CachedEntityActionHistoryLoader(relatedEventList);
		EntityHistoryViewModel entityHistoryViewModel = new EntityHistoryViewModel
		{
			EventArray = relatedEventList.ToArray(),
			Renders = renders,
			HistoryLoader = historyLoader,
			InPopup = (inPopup == true)
		};
		return (ActionResult)(object)((Controller)this).PartialView("History", (object)entityHistoryViewModel);
	}

	[Obsolete("Больше не используется")]
	public ActionResult OrderDescHistory(bool orderDesc)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		ListSortDirection direction = (orderDesc ? ListSortDirection.Descending : ListSortDirection.Ascending);
		HistoryOrder.SetOrderType(direction, new HistoryIdParams());
		return (ActionResult)new EmptyResult();
	}
}
