// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.LeadDynamicModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Components;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class LeadDynamicModel
  {
    private ISecurityService securityService;

    private ISecurityService SecurityService => this.securityService ?? (this.securityService = Locator.GetServiceNotNull<ISecurityService>());

    public LeadDynamicModel()
    {
      LeadDynamicState leadDynamicState = LeadDynamicState.LoadState();
      this.Mode = leadDynamicState.Mode;
      this.ShowStatistic = leadDynamicState.ShowStatistic;
      this.ShowArchive = leadDynamicState.ShowArchive;
      this.CurrentDate = leadDynamicState.CurrentDate;
      this.InitializeMarketingElementList();
      this.InitializeAllCount();
    }

    public LeadDynamicModel(
      MarketingPeriodEnum mode,
      DateTime date,
      bool showArchive,
      bool showStatistic)
    {
      this.Mode = mode;
      this.ShowStatistic = showStatistic;
      this.ShowArchive = showArchive;
      this.CurrentDate = date;
      LeadDynamicState.SaveState(this.CurrentDate, this.Mode, this.ShowArchive, this.ShowStatistic);
      this.InitializeMarketingElementList();
      this.InitializeAllCount();
    }

    public LeadDynamicModel(
      MarketingPeriodEnum mode,
      DateTime date,
      bool showArchive,
      bool showStatistic,
      long marketingObject)
    {
      this.Mode = mode;
      this.ShowStatistic = showStatistic;
      this.ShowArchive = showArchive;
      this.CurrentDate = date;
      this.InitializeMarketingElementList(marketingObject);
    }

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

    private void InitializeMarketingElementList(long marketingObjectId = -1)
    {
      this.PeriodList = MarketingHelper.GetPeriodList(this.Mode, this.CurrentDate);
      List<MarketingElementModel> marketingElementModelList1 = new List<MarketingElementModel>();
      LeadDynamicState leadDynamicState = LeadDynamicState.LoadState();
      switch (marketingObjectId)
      {
        case -1:
          IMarketingGroupFilter filter1 = InterfaceActivator.Create<IMarketingGroupFilter>();
          filter1.Status = new MarketingObjectStatus?(MarketingObjectStatus.Active);
          ICollection<IMarketingGroup> source = MarketingGroupManager.Instance.Find((IEntityFilter) filter1, FetchOptions.All);
          List<LeadDynamicCount> listCount1 = this.ShowStatistic ? LeadManager.Instance.SummaryDynamicLeadCounts(this.PeriodList, marketingObjectId, false) : new List<LeadDynamicCount>();
          foreach (IMarketingGroup marketingGroup in (IEnumerable<IMarketingGroup>) source.OrderByDescending<IMarketingGroup, int>((Func<IMarketingGroup, int>) (m => m.MarketingActivities.Count)))
            marketingElementModelList1.Add(new MarketingElementModel(marketingGroup, (IEnumerable<LeadDynamicCount>) listCount1, this.PeriodList.Count)
            {
              IsShow = leadDynamicState.List.Contains(marketingGroup.Id),
              UserHasCreateItemsPermission = this.EvaluateUserCreateItemsPermission((IMarketingBase) marketingGroup)
            });
          IMarketingActivityFilter filter2 = InterfaceActivator.Create<IMarketingActivityFilter>();
          filter2.Query = "MarketingGroup is null";
          filter2.Status = new MarketingObjectStatus?(MarketingObjectStatus.Active);
          if (MarketingActivityManager.Instance.Exists((IEntityFilter) filter2))
          {
            MarketingElementModel marketingElementModel = new MarketingElementModel(this.ShowStatistic ? (IEnumerable<LeadDynamicCount>) LeadManager.Instance.SummaryDynamicLeadCounts(this.PeriodList, 0L, false) : (IEnumerable<LeadDynamicCount>) new List<LeadDynamicCount>(), this.PeriodList.Count);
            if (leadDynamicState.List.Contains(0L))
              marketingElementModel.IsShow = true;
            marketingElementModelList1.Add(marketingElementModel);
          }
          this.GridData = marketingElementModelList1;
          break;
        case 0:
          List<LeadDynamicCount> listCount2 = this.ShowStatistic ? LeadManager.Instance.SummaryDynamicLeadCounts(this.PeriodList, marketingObjectId, false) : new List<LeadDynamicCount>();
          IMarketingActivityFilter filter3 = InterfaceActivator.Create<IMarketingActivityFilter>();
          filter3.Query = "MarketingGroup is null";
          filter3.Status = new MarketingObjectStatus?(MarketingObjectStatus.Active);
          foreach (IMarketingActivity marketingActivity in (IEnumerable<IMarketingActivity>) MarketingActivityManager.Instance.Find((IEntityFilter) filter3, FetchOptions.All))
            marketingElementModelList1.Add(new MarketingElementModel(marketingActivity, (IEnumerable<LeadDynamicCount>) listCount2, this.PeriodList.Count)
            {
              IsShow = leadDynamicState.List.Contains(marketingActivity.Id),
              UserHasCreateItemsPermission = this.EvaluateUserCreateItemsPermission((IMarketingBase) marketingActivity)
            });
          this.GridData = marketingElementModelList1;
          break;
        default:
          this.Entity = MarketingBaseManager.Instance.Load(marketingObjectId);
          List<LeadDynamicCount> listCount3 = this.ShowStatistic ? LeadManager.Instance.SummaryDynamicLeadCounts(this.PeriodList, marketingObjectId, false) : new List<LeadDynamicCount>();
          if (this.Entity is IMarketingGroup entity1)
          {
            foreach (IMarketingActivity marketingActivity in entity1.MarketingActivities.Where<IMarketingActivity>(new Func<IMarketingActivity, bool>(this.IsActiveAccessibleMarketingObject)))
              marketingElementModelList1.Add(new MarketingElementModel(marketingActivity, (IEnumerable<LeadDynamicCount>) listCount3, this.PeriodList.Count)
              {
                IsShow = leadDynamicState.List.Contains(marketingActivity.Id),
                UserHasCreateItemsPermission = this.EvaluateUserCreateItemsPermission((IMarketingBase) marketingActivity)
              });
          }
          if (this.Entity is IMarketingActivity entity2)
          {
            foreach (IMarketingEffect marketingEffect in entity2.MarketingEffects.Where<IMarketingEffect>(new Func<IMarketingEffect, bool>(this.IsActiveAccessibleMarketingObject)))
              marketingElementModelList1.Add(new MarketingElementModel(marketingEffect, (IEnumerable<LeadDynamicCount>) listCount3, this.PeriodList.Count)
              {
                UserHasCreateItemsPermission = this.EvaluateUserCreateItemsPermission((IMarketingBase) marketingEffect)
              });
          }
          this.GridData = marketingElementModelList1;
          break;
      }
      List<MarketingElementModel> marketingElementModelList2 = new List<MarketingElementModel>();
      if (this.ShowArchive)
      {
        List<LeadDynamicCount> listCount4 = this.ShowStatistic ? LeadManager.Instance.SummaryDynamicLeadCounts(this.PeriodList, -1L, true) : new List<LeadDynamicCount>();
        switch (marketingObjectId)
        {
          case -1:
            IMarketingGroupFilter filter4 = InterfaceActivator.Create<IMarketingGroupFilter>();
            filter4.Status = new MarketingObjectStatus?(MarketingObjectStatus.Archived);
            foreach (IMarketingGroup group in (IEnumerable<IMarketingGroup>) MarketingGroupManager.Instance.Find((IEntityFilter) filter4, FetchOptions.All))
            {
              MarketingElementModel marketingElementModel = new MarketingElementModel(group, (IEnumerable<LeadDynamicCount>) listCount4, this.PeriodList.Count, true);
              if (leadDynamicState.List.Contains(group.Id))
                marketingElementModel.IsShow = true;
              marketingElementModelList2.Add(marketingElementModel);
            }
            IMarketingActivityFilter filter5 = InterfaceActivator.Create<IMarketingActivityFilter>();
            filter5.Status = new MarketingObjectStatus?(MarketingObjectStatus.Archived);
            foreach (IMarketingActivity activity in MarketingActivityManager.Instance.Find((IEntityFilter) filter5, FetchOptions.All).Where<IMarketingActivity>((Func<IMarketingActivity, bool>) (x => x.MarketingGroup != null && x.MarketingGroup.Status == MarketingObjectStatus.Active)))
            {
              MarketingElementModel marketingElementModel = new MarketingElementModel(activity, (IEnumerable<LeadDynamicCount>) listCount4, this.PeriodList.Count, true);
              if (leadDynamicState.List.Contains(activity.Id))
                marketingElementModel.IsShow = true;
              marketingElementModelList2.Add(marketingElementModel);
            }
            IMarketingEffectFilter filter6 = InterfaceActivator.Create<IMarketingEffectFilter>();
            filter6.Status = new MarketingObjectStatus?(MarketingObjectStatus.Archived);
            foreach (IMarketingEffect effect in MarketingEffectManager.Instance.Find((IEntityFilter) filter6, FetchOptions.All).Where<IMarketingEffect>((Func<IMarketingEffect, bool>) (x => x.MarketingActivity != null && x.MarketingActivity.Status == MarketingObjectStatus.Active)))
            {
              MarketingElementModel marketingElementModel = new MarketingElementModel(effect, (IEnumerable<LeadDynamicCount>) listCount4, this.PeriodList.Count, true);
              if (leadDynamicState.List.Contains(effect.Id))
                marketingElementModel.IsShow = true;
              marketingElementModelList2.Add(marketingElementModel);
            }
            IMarketingActivityFilter filter7 = InterfaceActivator.Create<IMarketingActivityFilter>();
            filter7.Query = "MarketingGroup is null";
            filter7.Status = new MarketingObjectStatus?(MarketingObjectStatus.Archived);
            if (MarketingActivityManager.Instance.Exists((IEntityFilter) filter7))
            {
              MarketingElementModel marketingElementModel = new MarketingElementModel(this.ShowStatistic ? (IEnumerable<LeadDynamicCount>) LeadManager.Instance.SummaryDynamicLeadCounts(this.PeriodList, 0L, true) : (IEnumerable<LeadDynamicCount>) new List<LeadDynamicCount>(), this.PeriodList.Count, true);
              if (leadDynamicState.List.Contains(0L))
                marketingElementModel.IsShow = true;
              marketingElementModelList2.Add(marketingElementModel);
              break;
            }
            break;
          case 0:
            IMarketingActivityFilter filter8 = InterfaceActivator.Create<IMarketingActivityFilter>();
            filter8.Query = "MarketingGroup is null";
            filter8.Status = new MarketingObjectStatus?(MarketingObjectStatus.Archived);
            using (IEnumerator<IMarketingActivity> enumerator = MarketingActivityManager.Instance.Find((IEntityFilter) filter8, FetchOptions.All).GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                IMarketingActivity current = enumerator.Current;
                MarketingElementModel marketingElementModel = new MarketingElementModel(current, (IEnumerable<LeadDynamicCount>) listCount4, this.PeriodList.Count, true);
                if (leadDynamicState.List.Contains(current.Id))
                  marketingElementModel.IsShow = true;
                marketingElementModelList2.Add(marketingElementModel);
              }
              break;
            }
          default:
            this.Entity = MarketingBaseManager.Instance.Load(marketingObjectId);
            if (this.Entity is IMarketingGroup entity3)
            {
              foreach (IMarketingActivity activity in entity3.MarketingActivities.Where<IMarketingActivity>(new Func<IMarketingActivity, bool>(this.IsArchivedAccessibleMarketingObject)))
              {
                MarketingElementModel marketingElementModel = new MarketingElementModel(activity, (IEnumerable<LeadDynamicCount>) listCount4, this.PeriodList.Count, true);
                if (leadDynamicState.List.Contains(activity.Id))
                  marketingElementModel.IsShow = true;
                marketingElementModelList2.Add(marketingElementModel);
              }
            }
            if (this.Entity is IMarketingActivity entity4)
            {
              using (IEnumerator<IMarketingEffect> enumerator = entity4.MarketingEffects.Where<IMarketingEffect>(new Func<IMarketingEffect, bool>(this.IsArchivedAccessibleMarketingObject)).GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  IMarketingEffect current = enumerator.Current;
                  marketingElementModelList2.Add(new MarketingElementModel(current, (IEnumerable<LeadDynamicCount>) listCount4, this.PeriodList.Count, true));
                }
                break;
              }
            }
            else
              break;
        }
      }
      this.GridDataArchive = marketingElementModelList2;
    }

    private void InitializeAllCount()
    {
      this.AllCount = new MarketingElementModel();
      if (this.GridData.Count <= 0 && this.GridDataArchive.Count <= 0)
        return;
      int length = this.GridData.Concat<MarketingElementModel>((IEnumerable<MarketingElementModel>) this.GridDataArchive).First<MarketingElementModel>().AllCountMonth.Length;
      this.AllCount.AllCountMonth = new long[length];
      this.AllCount.ConvertedCountMonth = new long[length];
      for (int i = 0; i < length; i++)
      {
        this.AllCount.AllCountMonth[i] = this.GridData.Sum<MarketingElementModel>((Func<MarketingElementModel, long>) (m => m.AllCountMonth[i]));
        this.AllCount.ConvertedCountMonth[i] = this.GridData.Sum<MarketingElementModel>((Func<MarketingElementModel, long>) (m => m.ConvertedCountMonth[i]));
        if (this.ShowArchive)
        {
          this.AllCount.AllCountMonth[i] += this.GridDataArchive.Sum<MarketingElementModel>((Func<MarketingElementModel, long>) (m => m.AllCountMonth[i]));
          this.AllCount.ConvertedCountMonth[i] += this.GridDataArchive.Sum<MarketingElementModel>((Func<MarketingElementModel, long>) (m => m.ConvertedCountMonth[i]));
        }
      }
    }

    public static string TemplateTd(
      HtmlHelper html,
      MarketingElementModel model,
      DateTimeRange date,
      int count,
      bool isHeader = false)
    {
      if (!isHeader && model.AllCountMonth[count] == 0L && model.ConvertedCountMonth[count] == 0L)
        return "";
      RouteValueDictionary routeValueDictionary1 = new RouteValueDictionary();
      routeValueDictionary1.Add("area", (object) "EleWise.ELMA.CRM.Web");
      routeValueDictionary1.Add("FilterId", (object) 0);
      routeValueDictionary1.Add("Filter.RelativeCreationDate.IsRelative", (object) false);
      DateTime dateTime = date.From.Value;
      routeValueDictionary1.Add("Filter.RelativeCreationDate.DateTimeRange.From", (object) dateTime.ToShortDateString());
      dateTime = date.To.Value;
      routeValueDictionary1.Add("Filter.RelativeCreationDate.DateTimeRange.To", (object) dateTime.ToShortDateString());
      routeValueDictionary1.Add("Filter.Query", (object) "not (MarketingGroup is null and MarketingActivity is null and MarketingEffect is null)");
      RouteValueDictionary routeValueDictionary2 = routeValueDictionary1;
      if (model.Entity != null)
        routeValueDictionary2.Add("Filter.MarketingObjects[0].Id", (object) model.Entity.Id.ToString());
      RouteValueDictionary routeValues1 = new RouteValueDictionary((IDictionary<string, object>) routeValueDictionary2)
      {
        {
          "Filter.SummaryLeadStatus",
          (object) SummaryLeadStatus.Qualified
        }
      };
      RouteValueDictionary routeValues2 = new RouteValueDictionary((IDictionary<string, object>) routeValueDictionary2)
      {
        {
          "Filter.SummaryLeadStatus",
          (object) ""
        }
      };
      return MvcHtmlString.Create(string.Format("<span class=\"lead-count\">{0}</span> <span class=\"lead-count\">/</span> <span class=\"lead-count\">{1}</span>", (object) LinkExtensions.ActionLink(html, model.ConvertedCountMonth[count].ToString(), "Index", "Lead", routeValues1, (IDictionary<string, object>) new Dictionary<string, object>()
      {
        {
          "title",
          (object) "Конвертированные"
        }
      }), (object) LinkExtensions.ActionLink(html, model.AllCountMonth[count].ToString(), "Index", "Lead", routeValues2, (IDictionary<string, object>) new Dictionary<string, object>()
      {
        {
          "title",
          (object) "Все"
        }
      }))).ToString();
    }

    private bool IsActiveAccessibleMarketingObject(IMarketingBase marketingObj) => this.IsAccessibleMarketingObjectWithStatus(marketingObj, MarketingObjectStatus.Active);

    private bool IsArchivedAccessibleMarketingObject(IMarketingBase marketingObj) => this.IsAccessibleMarketingObjectWithStatus(marketingObj, MarketingObjectStatus.Archived);

    private bool IsAccessibleMarketingObjectWithStatus(
      IMarketingBase marketingObj,
      MarketingObjectStatus status)
    {
      return !marketingObj.IsDeleted && marketingObj.Status == status && this.SecurityService.HasPermission(CRMPermissionProvider.ViewMarketingPermission, (object) marketingObj);
    }

    private bool EvaluateUserCreateItemsPermission(IMarketingBase marketingObj) => marketingObj != null && this.SecurityService.HasPermission(CRMPermissionProvider.CRMMarketingCreateElementPermission, (object) marketingObj);
  }
}
