using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Components;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Models;

public class MarketingStatisticModel
{
	public List<DateTimeRange> PeriodList { get; set; }

	public List<OnePeriodStatisticModel> PeriodModelList { get; set; }

	public DateTime CurrentDate { get; set; }

	public MarketingPeriodEnum Mode { get; set; }

	public IMarketingBase MarketingBase { get; set; }

	public MarketingStatisticModel()
	{
		MarketingStatisticState marketingStatisticState = MarketingStatisticState.LoadState();
		Mode = marketingStatisticState.Mode;
		CurrentDate = marketingStatisticState.CurrentDate;
		InitializeMarketingStatistic();
	}

	public MarketingStatisticModel(IMarketingBase marketingBase, MarketingPeriodEnum mode, DateTime currentDate)
	{
		CurrentDate = currentDate;
		Mode = mode;
		MarketingStatisticState.SaveState(CurrentDate, Mode);
		MarketingBase = marketingBase;
		InitializeMarketingStatistic();
	}

	private void InitializeMarketingStatistic()
	{
		PeriodList = MarketingHelper.GetPeriodList(Mode, CurrentDate);
		ILeadFilter leadFilter = InterfaceActivator.Create<ILeadFilter>();
		if (MarketingBase != null)
		{
			leadFilter.MarketingObjects.Add(MarketingBase);
		}
		PeriodModelList = new List<OnePeriodStatisticModel>();
		foreach (DateTimeRange period in PeriodList)
		{
			leadFilter.RelativeCreationDate = new RelativeDateTime(period.From, period.To);
			PeriodModelList.Add(new OnePeriodStatisticModel
			{
				LeadCount = LeadManager.Instance.SummaryLeadMarketingStatisticCounts(leadFilter),
				Period = period,
				SumPayment = MarketingPaymentManager.Instance.GetMarketingPayments(MarketingBase, period).Sum((IMarketingPayment m) => m.Sum)
			});
		}
	}
}
