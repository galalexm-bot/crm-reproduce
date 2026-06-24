// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.MarketingStatisticModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Components;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class MarketingStatisticModel
  {
    public MarketingStatisticModel()
    {
      MarketingStatisticState marketingStatisticState = MarketingStatisticState.LoadState();
      this.Mode = marketingStatisticState.Mode;
      this.CurrentDate = marketingStatisticState.CurrentDate;
      this.InitializeMarketingStatistic();
    }

    public MarketingStatisticModel(
      IMarketingBase marketingBase,
      MarketingPeriodEnum mode,
      DateTime currentDate)
    {
      this.CurrentDate = currentDate;
      this.Mode = mode;
      MarketingStatisticState.SaveState(this.CurrentDate, this.Mode);
      this.MarketingBase = marketingBase;
      this.InitializeMarketingStatistic();
    }

    public List<DateTimeRange> PeriodList { get; set; }

    public List<OnePeriodStatisticModel> PeriodModelList { get; set; }

    public DateTime CurrentDate { get; set; }

    public MarketingPeriodEnum Mode { get; set; }

    public IMarketingBase MarketingBase { get; set; }

    private void InitializeMarketingStatistic()
    {
      this.PeriodList = MarketingHelper.GetPeriodList(this.Mode, this.CurrentDate);
      ILeadFilter filter = InterfaceActivator.Create<ILeadFilter>();
      if (this.MarketingBase != null)
        filter.MarketingObjects.Add(this.MarketingBase);
      this.PeriodModelList = new List<OnePeriodStatisticModel>();
      foreach (DateTimeRange period in this.PeriodList)
      {
        filter.RelativeCreationDate = new RelativeDateTime(period.From, period.To);
        this.PeriodModelList.Add(new OnePeriodStatisticModel()
        {
          LeadCount = LeadManager.Instance.SummaryLeadMarketingStatisticCounts(filter),
          Period = period,
          SumPayment = MarketingPaymentManager.Instance.GetMarketingPayments(this.MarketingBase, period).Sum<IMarketingPayment>((Func<IMarketingPayment, double>) (m => (double) m.Sum))
        });
      }
    }
  }
}
