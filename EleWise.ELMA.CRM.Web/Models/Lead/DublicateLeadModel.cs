// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.Lead.DublicateLeadModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.CRM.Web.Models.Lead
{
  public class DublicateLeadModel
  {
    public DublicateLeadModel()
    {
    }

    public DublicateLeadModel(ILead lead)
    {
      this.ThisLead = lead;
      this.Link = DublicateLeadLink.Contractor;
    }

    public ILead ThisLead { get; set; }

    [DisplayName(typeof (DublicateLeadModel_SR), "To")]
    public DublicateLeadLink Link { get; set; }

    [RequiredField]
    public IContractor Contractor { get; set; }

    [RequiredField]
    public ILead Lead { get; set; }

    [RequiredField]
    public ISale Sale { get; set; }

    [DisplayName(typeof (DublicateLeadModel_SR), "CopyContacts")]
    public bool CopyContacts { get; set; }

    [StringSettings(MultiLine = true, FieldName = "Comment")]
    [DisplayName(typeof (DublicateLeadModel_SR), "Comment")]
    public string Comment { get; set; }

    public void Dublicate() => LeadManager.Instance.Dublicate(this.ThisLead, this.Comment, this.CopyContacts, this.Link == DublicateLeadLink.Contractor ? this.Contractor : (IContractor) null, this.Link == DublicateLeadLink.Lead ? this.Lead : (ILead) null, this.Link == DublicateLeadLink.Sale ? this.Sale : (ISale) null);
  }
}
