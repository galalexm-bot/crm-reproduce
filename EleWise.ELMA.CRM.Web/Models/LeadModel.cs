// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.LeadModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class LeadModel : DynamicEntityViewModel<ILead>, IDeleteCategoriesDialogModel
  {
    public IEnumerable<ILeadType> LeadTypes { get; set; }

    public LeadModel(ILead lead)
      : this(lead, EleWise.ELMA.Model.Views.ViewType.Create)
    {
    }

    public LeadModel(ILead lead, EleWise.ELMA.Model.Views.ViewType viewType)
      : base(lead, viewType)
    {
      if (lead != null)
        return;
      this.NewContact = InterfaceActivator.Create<ILeadContact>();
      this.Entity.Responsible = AuthenticationService.GetCurrentUser<IUser>();
    }

    public LeadModel()
    {
      this.ViewType = EleWise.ELMA.Model.Views.ViewType.Create;
      this.NewContact = InterfaceActivator.Create<ILeadContact>();
      this.Entity.Responsible = AuthenticationService.GetCurrentUser<IUser>();
    }

    private void PrepareSave()
    {
      if (this.Entity.IsNew())
      {
        this.Entity.Status = LeadStatus.New;
        this.NewContact.Name = string.Format("{0} {1} {2}", (object) this.NewContact.Firstname, (object) this.NewContact.Middlename, (object) this.NewContact.Surname).Trim();
        if (!string.IsNullOrEmpty(this.NewContact.Name))
        {
          this.ClearEmailSetIfEmpty(this.NewContact.Email);
          this.ClearPhoneSetIfEmpty(this.NewContact.Phone);
          this.Entity.Contacts.Add(this.NewContact);
        }
      }
      this.ClearEmailSetIfEmpty(this.Entity.Email);
      this.ClearPhoneSetIfEmpty(this.Entity.Phone);
      if (this.Entity.Address == null || this.Entity.Address.Country == null)
        return;
      ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault<ICountryInfo>((Func<ICountryInfo, bool>) (p => p.NeedAdd(this.Entity.Address.Country.Name)))?.Adding(this.Entity.Address);
    }

    public void Save()
    {
      this.PrepareSave();
      this.Entity.Save();
    }

    public SaveWithCategoryRulesResult SaveWithCategoryRules(
      RuleDeletedCategoryAction ruleDeletedCategoryAction = RuleDeletedCategoryAction.Delete)
    {
      this.PrepareSave();
      return LeadManager.Instance.SaveWithCategoryRules(this.Entity, ruleDeletedCategoryAction);
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

    public List<SelectListItem> AvailableLeadTypes => this.LeadTypes.Select<ILeadType, SelectListItem>((Func<ILeadType, SelectListItem>) (c => new SelectListItem()
    {
      Text = c.Type,
      Value = c.Id.ToString()
    })).ToList<SelectListItem>();

    public ILeadContact NewContact { get; set; }

    public bool? UnassignOldCategories { get; set; }

    public IEnumerable<ICategory> CategoriesToDelete { get; set; }

    public bool LockEditPermission { get; set; }
  }
}
