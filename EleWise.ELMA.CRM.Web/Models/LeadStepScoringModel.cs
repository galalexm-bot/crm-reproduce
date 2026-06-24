// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.LeadStepScoringModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class LeadStepScoringModel
  {
    public LeadStepScoringModel() => this.Entity = new LeadStepScoring();

    public LeadStepScoringModel(long id)
    {
      this.Entity = LeadStepScoring.LoadStepScoring(id);
      this.PercentValue = this.Entity.PercentValue;
      this.Color = EntityManager<IColor>.Instance.Load((object) this.Entity.ColorId);
    }

    public void Save()
    {
      this.Entity.PercentValue = this.PercentValue;
      IColor color = EntityManager<IColor>.Instance.LoadOrNull((object) this.Color.Id);
      if (color == null)
      {
        color = InterfaceActivator.Create<IColor>();
        color.ColorCode = this.Color.ColorCode;
        color.Save();
      }
      this.Entity.ColorId = color.Id;
      this.Entity.Save();
    }

    public LeadStepScoring Entity { get; set; }

    [DisplayName(typeof (LeadStepScoringModel_SR), "PercentValue")]
    public long PercentValue { get; set; }

    [DisplayName(typeof (LeadStepScoringModel_SR), "ColorCode")]
    public IColor Color { get; set; }
  }
}
