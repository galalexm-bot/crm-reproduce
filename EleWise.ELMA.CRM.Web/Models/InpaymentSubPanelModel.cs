// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.InpaymentSubPanelModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class InpaymentSubPanelModel
  {
    public InpaymentSubPanelModel()
    {
      this.CheckBoxOverdue = true;
      this.CheckBoxInPlan = true;
      this.StatusSetPrefix = "StatusSet";
      this.StatusFilterModel = new InpaymentStatusFilterModel();
    }

    public InpaymentSubPanelModel(IInpaymentFilter inpaymentFilter)
      : this()
    {
      this.TotalInPlanWithDate = InpaymentManager.Instance.GetInPlanWithDateTotal(inpaymentFilter);
      this.TotalInPlanWithOutDate = InpaymentManager.Instance.GetInPlanWithoutDateTotal(inpaymentFilter);
      this.TotalReceived = InpaymentManager.Instance.GetReceivedTotal(inpaymentFilter);
      this.Total = this.TotalInPlanWithDate + this.TotalInPlanWithOutDate + this.TotalReceived;
    }

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
  }
}
