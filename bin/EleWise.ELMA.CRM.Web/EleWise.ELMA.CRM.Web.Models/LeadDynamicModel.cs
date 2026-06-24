using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Components;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadDynamicModel
{
	private ISecurityService securityService;

	private ISecurityService SecurityService => securityService ?? (securityService = Locator.GetServiceNotNull<ISecurityService>());

	public IMarketingBase Entity { get; set; }

	public List<MarketingElementModel> GridData { get; set; }

	public List<MarketingElementModel> GridDataArchive { get; set; }

	public MarketingElementModel AllCount { get; set; }

	public DateTime CurrentDate { get; set; }

	public bool ShowStatistic { get; set; }

	public bool ShowArchive { get; set; }

	public bool IsArchive { get; set; }

	public List<DateTimeRange> PeriodList { get; set; }

	public MarketingPeriodEnum Mode { get; set; }

	public LeadDynamicModel()
	{
		LeadDynamicState leadDynamicState = LeadDynamicState.LoadState();
		Mode = leadDynamicState.Mode;
		ShowStatistic = leadDynamicState.ShowStatistic;
		ShowArchive = leadDynamicState.ShowArchive;
		CurrentDate = leadDynamicState.CurrentDate;
		InitializeMarketingElementList(-1L);
		InitializeAllCount();
	}

	public LeadDynamicModel(MarketingPeriodEnum mode, DateTime date, bool showArchive, bool showStatistic)
	{
		Mode = mode;
		ShowStatistic = showStatistic;
		ShowArchive = showArchive;
		CurrentDate = date;
		LeadDynamicState.SaveState(CurrentDate, Mode, ShowArchive, ShowStatistic);
		InitializeMarketingElementList(-1L);
		InitializeAllCount();
	}

	public LeadDynamicModel(MarketingPeriodEnum mode, DateTime date, bool showArchive, bool showStatistic, long marketingObject)
	{
		Mode = mode;
		ShowStatistic = showStatistic;
		ShowArchive = showArchive;
		CurrentDate = date;
		InitializeMarketingElementList(marketingObject);
	}

	private void InitializeMarketingElementList(long marketingObjectId = -1L)
	{
		PeriodList = MarketingHelper.GetPeriodList(Mode, CurrentDate);
		List<MarketingElementModel> list = new List<MarketingElementModel>();
		LeadDynamicState leadDynamicState = LeadDynamicState.LoadState();
		switch (marketingObjectId)
		{
		case 0L:
		{
			List<LeadDynamicCount> listCount2 = (ShowStatistic ? LeadManager.Instance.SummaryDynamicLeadCounts(PeriodList, marketingObjectId, isArchive: false) : new List<LeadDynamicCount>());
			IMarketingActivityFilter marketingActivityFilter2 = InterfaceActivator.Create<IMarketingActivityFilter>();
			marketingActivityFilter2.Query = "MarketingGroup is null";
			marketingActivityFilter2.Status = MarketingObjectStatus.Active;
			foreach (IMarketingActivity item in MarketingActivityManager.Instance.Find(marketingActivityFilter2, FetchOptions.All))
			{
				list.Add(new MarketingElementModel(item, listCount2, PeriodList.Count)
				{
					IsShow = leadDynamicState.List.Contains(item.Id),
					UserHasCreateItemsPermission = EvaluateUserCreateItemsPermission(item)
				});
			}
			GridData = list;
			break;
		}
		default:
		{
			Entity = MarketingBaseManager.Instance.Load(marketingObjectId);
			List<LeadDynamicCount> listCount3 = (ShowStatistic ? LeadManager.Instance.SummaryDynamicLeadCounts(PeriodList, marketingObjectId, isArchive: false) : new List<LeadDynamicCount>());
			if (Entity is IMarketingGroup marketingGroup)
			{
				foreach (IMarketingActivity item2 in ((IEnumerable<IMarketingActivity>)marketingGroup.MarketingActivities).Where(IsActiveAccessibleMarketingObject))
				{
					list.Add(new MarketingElementModel(item2, listCount3, PeriodList.Count)
					{
						IsShow = leadDynamicState.List.Contains(item2.Id),
						UserHasCreateItemsPermission = EvaluateUserCreateItemsPermission(item2)
					});
				}
			}
			if (Entity is IMarketingActivity marketingActivity)
			{
				foreach (IMarketingEffect item3 in ((IEnumerable<IMarketingEffect>)marketingActivity.MarketingEffects).Where(IsActiveAccessibleMarketingObject))
				{
					list.Add(new MarketingElementModel(item3, listCount3, PeriodList.Count)
					{
						UserHasCreateItemsPermission = EvaluateUserCreateItemsPermission(item3)
					});
				}
			}
			GridData = list;
			break;
		}
		case -1L:
		{
			IMarketingGroupFilter marketingGroupFilter = InterfaceActivator.Create<IMarketingGroupFilter>();
			marketingGroupFilter.Status = MarketingObjectStatus.Active;
			ICollection<IMarketingGroup> source = MarketingGroupManager.Instance.Find(marketingGroupFilter, FetchOptions.All);
			List<LeadDynamicCount> listCount = (ShowStatistic ? LeadManager.Instance.SummaryDynamicLeadCounts(PeriodList, marketingObjectId, isArchive: false) : new List<LeadDynamicCount>());
			foreach (IMarketingGroup item4 in source.OrderByDescending((IMarketingGroup m) => ((ICollection<IMarketingActivity>)m.MarketingActivities).Count))
			{
				list.Add(new MarketingElementModel(item4, listCount, PeriodList.Count)
				{
					IsShow = leadDynamicState.List.Contains(item4.Id),
					UserHasCreateItemsPermission = EvaluateUserCreateItemsPermission(item4)
				});
			}
			IMarketingActivityFilter marketingActivityFilter = InterfaceActivator.Create<IMarketingActivityFilter>();
			marketingActivityFilter.Query = "MarketingGroup is null";
			marketingActivityFilter.Status = MarketingObjectStatus.Active;
			if (MarketingActivityManager.Instance.Exists(marketingActivityFilter))
			{
				MarketingElementModel marketingElementModel = new MarketingElementModel(ShowStatistic ? LeadManager.Instance.SummaryDynamicLeadCounts(PeriodList, 0L, isArchive: false) : new List<LeadDynamicCount>(), PeriodList.Count);
				if (leadDynamicState.List.Contains(0L))
				{
					marketingElementModel.IsShow = true;
				}
				list.Add(marketingElementModel);
			}
			GridData = list;
			break;
		}
		}
		List<MarketingElementModel> list2 = new List<MarketingElementModel>();
		if (ShowArchive)
		{
			List<LeadDynamicCount> listCount4 = (ShowStatistic ? LeadManager.Instance.SummaryDynamicLeadCounts(PeriodList, -1L, isArchive: true) : new List<LeadDynamicCount>());
			switch (marketingObjectId)
			{
			case 0L:
			{
				IMarketingActivityFilter marketingActivityFilter5 = InterfaceActivator.Create<IMarketingActivityFilter>();
				marketingActivityFilter5.Query = "MarketingGroup is null";
				marketingActivityFilter5.Status = MarketingObjectStatus.Archived;
				foreach (IMarketingActivity item5 in MarketingActivityManager.Instance.Find(marketingActivityFilter5, FetchOptions.All))
				{
					MarketingElementModel marketingElementModel6 = new MarketingElementModel(item5, listCount4, PeriodList.Count, showArchive: true);
					if (leadDynamicState.List.Contains(item5.Id))
					{
						marketingElementModel6.IsShow = true;
					}
					list2.Add(marketingElementModel6);
				}
				break;
			}
			default:
				Entity = MarketingBaseManager.Instance.Load(marketingObjectId);
				if (Entity is IMarketingGroup marketingGroup2)
				{
					foreach (IMarketingActivity item6 in ((IEnumerable<IMarketingActivity>)marketingGroup2.MarketingActivities).Where(IsArchivedAccessibleMarketingObject))
					{
						MarketingElementModel marketingElementModel7 = new MarketingElementModel(item6, listCount4, PeriodList.Count, showArchive: true);
						if (leadDynamicState.List.Contains(item6.Id))
						{
							marketingElementModel7.IsShow = true;
						}
						list2.Add(marketingElementModel7);
					}
				}
				if (!(Entity is IMarketingActivity marketingActivity2))
				{
					break;
				}
				foreach (IMarketingEffect item7 in ((IEnumerable<IMarketingEffect>)marketingActivity2.MarketingEffects).Where(IsArchivedAccessibleMarketingObject))
				{
					list2.Add(new MarketingElementModel(item7, listCount4, PeriodList.Count, showArchive: true));
				}
				break;
			case -1L:
			{
				IMarketingGroupFilter marketingGroupFilter2 = InterfaceActivator.Create<IMarketingGroupFilter>();
				marketingGroupFilter2.Status = MarketingObjectStatus.Archived;
				foreach (IMarketingGroup item8 in MarketingGroupManager.Instance.Find(marketingGroupFilter2, FetchOptions.All))
				{
					MarketingElementModel marketingElementModel2 = new MarketingElementModel(item8, listCount4, PeriodList.Count, showArchive: true);
					if (leadDynamicState.List.Contains(item8.Id))
					{
						marketingElementModel2.IsShow = true;
					}
					list2.Add(marketingElementModel2);
				}
				IMarketingActivityFilter marketingActivityFilter3 = InterfaceActivator.Create<IMarketingActivityFilter>();
				marketingActivityFilter3.Status = MarketingObjectStatus.Archived;
				foreach (IMarketingActivity item9 in from x in MarketingActivityManager.Instance.Find(marketingActivityFilter3, FetchOptions.All)
					where x.MarketingGroup != null && x.MarketingGroup.Status == MarketingObjectStatus.Active
					select x)
				{
					MarketingElementModel marketingElementModel3 = new MarketingElementModel(item9, listCount4, PeriodList.Count, showArchive: true);
					if (leadDynamicState.List.Contains(item9.Id))
					{
						marketingElementModel3.IsShow = true;
					}
					list2.Add(marketingElementModel3);
				}
				IMarketingEffectFilter marketingEffectFilter = InterfaceActivator.Create<IMarketingEffectFilter>();
				marketingEffectFilter.Status = MarketingObjectStatus.Archived;
				foreach (IMarketingEffect item10 in from x in MarketingEffectManager.Instance.Find(marketingEffectFilter, FetchOptions.All)
					where x.MarketingActivity != null && x.MarketingActivity.Status == MarketingObjectStatus.Active
					select x)
				{
					MarketingElementModel marketingElementModel4 = new MarketingElementModel(item10, listCount4, PeriodList.Count, showArchive: true);
					if (leadDynamicState.List.Contains(item10.Id))
					{
						marketingElementModel4.IsShow = true;
					}
					list2.Add(marketingElementModel4);
				}
				IMarketingActivityFilter marketingActivityFilter4 = InterfaceActivator.Create<IMarketingActivityFilter>();
				marketingActivityFilter4.Query = "MarketingGroup is null";
				marketingActivityFilter4.Status = MarketingObjectStatus.Archived;
				if (MarketingActivityManager.Instance.Exists(marketingActivityFilter4))
				{
					MarketingElementModel marketingElementModel5 = new MarketingElementModel(ShowStatistic ? LeadManager.Instance.SummaryDynamicLeadCounts(PeriodList, 0L, isArchive: true) : new List<LeadDynamicCount>(), PeriodList.Count, showArchive: true);
					if (leadDynamicState.List.Contains(0L))
					{
						marketingElementModel5.IsShow = true;
					}
					list2.Add(marketingElementModel5);
				}
				break;
			}
			}
		}
		GridDataArchive = list2;
	}

	private void InitializeAllCount()
	{
		AllCount = new MarketingElementModel();
		if (GridData.Count <= 0 && GridDataArchive.Count <= 0)
		{
			return;
		}
		int num = GridData.Concat(GridDataArchive).First().AllCountMonth.Length;
		AllCount.AllCountMonth = new long[num];
		AllCount.ConvertedCountMonth = new long[num];
		int i;
		for (i = 0; i < num; i++)
		{
			AllCount.AllCountMonth[i] = GridData.Sum((MarketingElementModel m) => m.AllCountMonth[i]);
			AllCount.ConvertedCountMonth[i] = GridData.Sum((MarketingElementModel m) => m.ConvertedCountMonth[i]);
			if (ShowArchive)
			{
				AllCount.AllCountMonth[i] += GridDataArchive.Sum((MarketingElementModel m) => m.AllCountMonth[i]);
				AllCount.ConvertedCountMonth[i] += GridDataArchive.Sum((MarketingElementModel m) => m.ConvertedCountMonth[i]);
			}
		}
	}

	public static string TemplateTd(HtmlHelper html, MarketingElementModel model, DateTimeRange date, int count, bool isHeader = false)
	{
		if (!isHeader && model.AllCountMonth[count] == 0L && model.ConvertedCountMonth[count] == 0L)
		{
			return "";
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.CRM.Web" },
			{ "FilterId", 0 },
			{ "Filter.RelativeCreationDate.IsRelative", false },
			{
				"Filter.RelativeCreationDate.DateTimeRange.From",
				date.From.Value.ToShortDateString()
			},
			{
				"Filter.RelativeCreationDate.DateTimeRange.To",
				date.To.Value.ToShortDateString()
			},
			{ "Filter.Query", "not (MarketingGroup is null and MarketingActivity is null and MarketingEffect is null)" }
		};
		if (model.Entity != null)
		{
			routeValueDictionary.Add("Filter.MarketingObjects[0].Id", model.Entity.Id.ToString());
		}
		RouteValueDictionary routeValueDictionary2 = new RouteValueDictionary(routeValueDictionary) { 
		{
			"Filter.SummaryLeadStatus",
			SummaryLeadStatus.Qualified
		} };
		RouteValueDictionary routeValueDictionary3 = new RouteValueDictionary(routeValueDictionary) { { "Filter.SummaryLeadStatus", "" } };
		MvcHtmlString arg = LinkExtensions.ActionLink(html, model.ConvertedCountMonth[count].ToString(), "Index", "Lead", routeValueDictionary2, (IDictionary<string, object>)new Dictionary<string, object> { { "title", "Конвертированные" } });
		MvcHtmlString arg2 = LinkExtensions.ActionLink(html, model.AllCountMonth[count].ToString(), "Index", "Lead", routeValueDictionary3, (IDictionary<string, object>)new Dictionary<string, object> { { "title", "Все" } });
		return ((object)MvcHtmlString.Create($"<span class=\"lead-count\">{arg}</span> <span class=\"lead-count\">/</span> <span class=\"lead-count\">{arg2}</span>")).ToString();
	}

	private bool IsActiveAccessibleMarketingObject(IMarketingBase marketingObj)
	{
		return IsAccessibleMarketingObjectWithStatus(marketingObj, MarketingObjectStatus.Active);
	}

	private bool IsArchivedAccessibleMarketingObject(IMarketingBase marketingObj)
	{
		return IsAccessibleMarketingObjectWithStatus(marketingObj, MarketingObjectStatus.Archived);
	}

	private bool IsAccessibleMarketingObjectWithStatus(IMarketingBase marketingObj, MarketingObjectStatus status)
	{
		if (!marketingObj.IsDeleted && marketingObj.Status == status)
		{
			return SecurityService.HasPermission(CRMPermissionProvider.ViewMarketingPermission, marketingObj);
		}
		return false;
	}

	private bool EvaluateUserCreateItemsPermission(IMarketingBase marketingObj)
	{
		if (marketingObj != null)
		{
			return SecurityService.HasPermission(CRMPermissionProvider.CRMMarketingCreateElementPermission, marketingObj);
		}
		return false;
	}
}
