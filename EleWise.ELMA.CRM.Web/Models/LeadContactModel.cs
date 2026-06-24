// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.LeadContactModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class LeadContactModel : EntityModel<ILeadContact>
  {
    public LeadContactModel(ILeadContact leadContact) => this.Entity = leadContact;

    public LeadContactModel() => this.Entity = InterfaceActivator.Create<ILeadContact>();

    public void Save()
    {
      this.Entity.Name = string.Format("{0} {1} {2}", (object) this.Entity.Firstname, (object) this.Entity.Middlename, (object) this.Entity.Surname).Trim();
      this.ClearEmailSetIfEmpty(this.Entity.Email);
      this.ClearPhoneSetIfEmpty(this.Entity.Phone);
      this.Entity.Save();
    }

    private void ClearEmailSetIfEmpty(Iesi.Collections.Generic.ISet<IEmail> emailSet)
    {
      bool flag = true;
      foreach (IEmail email in (IEnumerable<IEmail>) emailSet)
      {
        if (!string.IsNullOrWhiteSpace(email.EmailString))
        {
          flag = false;
          break;
        }
      }
      if (!flag)
        return;
      emailSet.Clear();
    }

    private void ClearPhoneSetIfEmpty(Iesi.Collections.Generic.ISet<IPhone> phoneSet)
    {
      bool flag = true;
      foreach (IPhone phone in (IEnumerable<IPhone>) phoneSet)
      {
        if (!string.IsNullOrWhiteSpace(phone.PhoneString))
        {
          flag = false;
          break;
        }
      }
      if (!flag)
        return;
      phoneSet.Clear();
    }
  }
}
