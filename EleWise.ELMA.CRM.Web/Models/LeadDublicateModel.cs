// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.LeadDublicateModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using System;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class LeadDublicateModel
  {
    public LeadDublicateModel()
    {
    }

    public LeadDublicateModel(ILead lead)
    {
      this.Lead = lead;
      ILeadDublicateState leadDublicateState = LeadDublicateStateManager.Instance.GetLeadDublicateState(lead);
      this.Status = leadDublicateState != null ? leadDublicateState.Status : LeadDublicateStatus.New;
      this.DublicateContractorCount = LeadManager.Instance.DublicateContractorsCount(lead);
      this.DublicateLeadCount = LeadManager.Instance.DublicateLeadsCount(lead);
      this.MaxPercent = Math.Max(LeadManager.Instance.GetMaxPercentPossibleDublicateContractors(lead), LeadManager.Instance.GetMaxPercentPossibleDublicateLeads(lead));
      this.StylePanel = LeadStepScoring.GetListStepScoring().OrderBy<LeadStepScoring, long>((Func<LeadStepScoring, long>) (m => m.PercentValue)).LastOrDefault<LeadStepScoring>((Func<LeadStepScoring, bool>) (item => item.PercentValue <= this.MaxPercent));
    }

    public ILead Lead { get; set; }

    public LeadDublicateStatus Status { get; set; }

    public LeadStepScoring StylePanel { get; set; }

    public long MaxPercent { get; set; }

    public long DublicateContractorCount { get; set; }

    public long DublicateLeadCount { get; set; }
  }
}
