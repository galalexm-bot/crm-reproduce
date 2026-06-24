using System;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class InpaymentSubPanelModel
{
	public bool PortletView { get; set; }

	public Guid InstanceId { get; set; }

	public GridDataFilter<InpaymentModel> GridData { get; set; }

	public string GridAction { get; set; }

	public bool CheckBoxOverdue { get; set; }

	public bool CheckBoxInPlan { get; set; }

	public string StatusSetPrefix { get; set; }

	public DateTime StartDate { get; set; }

	public DateTime EndDate { get; set; }

	public InpaymentStatusFilterModel StatusFilterModel { get; set; }

	public double TotalInPlanWithDate { get; set; }

	public double TotalInPlanWithOutDate { get; set; }

	public double TotalReceived { get; set; }

	public double Total { get; set; }

	public bool HideTotalInPlanWithoutDate { get; set; }

	public InpaymentSubPanelModel()
	{
		CheckBoxOverdue = true;
		CheckBoxInPlan = true;
		StatusSetPrefix = "StatusSet";
		StatusFilterModel = new InpaymentStatusFilterModel();
	}

	public InpaymentSubPanelModel(IInpaymentFilter inpaymentFilter)
		: this()
	{
		TotalInPlanWithDate = InpaymentManager.Instance.GetInPlanWithDateTotal(inpaymentFilter);
		TotalInPlanWithOutDate = InpaymentManager.Instance.GetInPlanWithoutDateTotal(inpaymentFilter);
		TotalReceived = InpaymentManager.Instance.GetReceivedTotal(inpaymentFilter);
		Total = TotalInPlanWithDate + TotalInPlanWithOutDate + TotalReceived;
	}
}
