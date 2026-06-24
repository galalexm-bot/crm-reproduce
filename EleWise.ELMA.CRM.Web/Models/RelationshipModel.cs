// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.RelationshipModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Calendar;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  public abstract class RelationshipModel : 
    DynamicEntityViewModel<IRelationship>,
    IRelationshipBaseModel2,
    IRelationshipBaseModel
  {
    protected RelationshipModel(IRelationship relationship)
    {
      this.Entity = relationship;
      this.Interval = new DateTime(2000, 1, 1, 0, 15, 0);
      this.PrevContractorContactsIds = (IList<long>) new List<long>();
    }

    protected RelationshipModel()
    {
      this.Interval = new DateTime(2000, 1, 1, 0, 15, 0);
      this.PrevContractorContactsIds = (IList<long>) new List<long>();
    }

    public new IRelationship Entity
    {
      get => base.Entity;
      set => base.Entity = value;
    }

    [DisplayName(typeof (RelationshipModel_SR), "Inform")]
    public CustomSet<IUser, IRelationshipUser> InformUsers
    {
      get
      {
        Dictionary<string, object> properties = new Dictionary<string, object>()
        {
          {
            "Status",
            (object) RelationshipUserStatus.InfromTo
          }
        };
        return new CustomSet<IUser, IRelationshipUser>(this.Entity.RelationshipUsers, (ICollection<IUser>) this.Entity.RelationshipUsers.Where<IRelationshipUser>((Func<IRelationshipUser, bool>) (s => s.Status == RelationshipUserStatus.InfromTo)).Select<IRelationshipUser, IUser>((Func<IRelationshipUser, IUser>) (u => u.User)).ToList<IUser>(), properties);
      }
      set
      {
        if (value == null)
          return;
        ((IEnumerable<IRelationshipUser>) this.Entity.RelationshipUsers.Where<IRelationshipUser>((Func<IRelationshipUser, bool>) (s => s.Status == RelationshipUserStatus.InfromTo)).ToArray<IRelationshipUser>()).Each<IRelationshipUser>((Action<IRelationshipUser>) (i => this.Entity.RelationshipUsers.Remove(i)));
        foreach (IUser user in (Set<IUser>) value)
        {
          IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();
          relationshipUser.User = user;
          relationshipUser.Status = RelationshipUserStatus.InfromTo;
          this.Entity.RelationshipUsers.Add(relationshipUser);
        }
      }
    }

    [DisplayName(typeof (RelationshipModel_SR), "Members")]
    [Required(true)]
    [RequiredField]
    public CustomSet<IUser, IRelationshipUser> PartyUsers
    {
      get
      {
        Dictionary<string, object> properties = new Dictionary<string, object>()
        {
          {
            "Status",
            (object) RelationshipUserStatus.Participant
          }
        };
        return new CustomSet<IUser, IRelationshipUser>(this.Entity.RelationshipUsers, (ICollection<IUser>) this.Entity.RelationshipUsers.Where<IRelationshipUser>((Func<IRelationshipUser, bool>) (s => s.Status == RelationshipUserStatus.Participant)).Select<IRelationshipUser, IUser>((Func<IRelationshipUser, IUser>) (u => u.User)).ToList<IUser>(), properties);
      }
      set
      {
        if (value == null)
          return;
        ((IEnumerable<IRelationshipUser>) this.Entity.RelationshipUsers.Where<IRelationshipUser>((Func<IRelationshipUser, bool>) (s => s.Status == RelationshipUserStatus.Participant)).ToArray<IRelationshipUser>()).Each<IRelationshipUser>((Action<IRelationshipUser>) (i => this.Entity.RelationshipUsers.Remove(i)));
        foreach (IUser user in (Set<IUser>) value)
        {
          IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();
          relationshipUser.User = user;
          relationshipUser.Status = RelationshipUserStatus.Participant;
          this.Entity.RelationshipUsers.Add(relationshipUser);
        }
      }
    }

    public IUser CurrentUser => AuthenticationService.GetCurrentUser<IUser>();

    public bool PrivateAccess => this.Entity.IsPrivate && !this.Entity.RelationshipUsers.Any<IRelationshipUser>((Func<IRelationshipUser, bool>) (s => s.User != null && s.User.Id == this.CurrentUser.Id)) && this.Entity.CreationAuthor.Id != this.CurrentUser.Id;

    public bool IsPrivateActivate
    {
      get
      {
        CalendarSettings settings = Locator.GetServiceNotNull<CalendarSettingsModule>().Settings;
        return settings != null && settings.EnablePrivateMode;
      }
    }

    [DisplayName(typeof (RelationshipModel_SR), "ActionState")]
    public string Completed => !this.Entity.Completed.HasValue || !this.Entity.Completed.Value ? EleWise.ELMA.SR.T("Запланировано") : EleWise.ELMA.SR.T("Выполнено");

    [DisplayName(typeof (RelationshipModel_SR), "To")]
    public RelationshipLink Link { get; set; }

    public long? PrevRelationshipId { get; set; }

    public bool LinkReadOnly { get; set; }

    public bool IsMultiCreation { get; set; }

    [DisplayName(typeof (RelationshipModel_SR), "Contacts")]
    public IList<IContact> ContractorContacts { get; set; }

    [DisplayName(typeof (RelationshipModel_SR), "To")]
    public IList<IContact> Contacts { get; set; }

    [DisplayName(typeof (RelationshipModel_SR), "To")]
    public IList<ILeadContact> LeadContacts { get; set; }

    [DisplayName(typeof (RelationshipModel_SR), "To")]
    public IList<IContractor> Contractors { get; set; }

    [DisplayName(typeof (RelationshipModel_SR), "To")]
    public IList<ILead> Leads { get; set; }

    [DisplayName(typeof (RelationshipModel_SR), "To")]
    public IList<ISale> Sales { get; set; }

    [DisplayName(typeof (RelationshipModel_SR), "Period")]
    public DateTime Interval { get; set; }

    public long? PrevContractorId { get; set; }

    public IList<long> PrevContractorContactsIds { get; set; }

    public long? PrevContactId { get; set; }

    public long? PrevLeadId { get; set; }

    public long? PrevSaleId { get; set; }

    public IList<IRelationship> Entities { get; protected set; }

    public virtual void Save()
    {
      if (this.IsMultiCreation)
      {
        this.Entities = (IList<IRelationship>) new List<IRelationship>();
        if (this.Contractors != null)
        {
          foreach (IContractor contractor in (IEnumerable<IContractor>) this.Contractors)
          {
            this.Entity.Contractor = contractor;
            this.Entities.Add(this.Entity);
            this.SaveEntityAndCreateNew();
          }
        }
        if (this.Contacts != null)
        {
          foreach (IContact contact in (IEnumerable<IContact>) this.Contacts)
          {
            this.Entity.Contact = contact;
            this.Entities.Add(this.Entity);
            this.SaveEntityAndCreateNew();
          }
        }
        if (this.Leads != null)
        {
          foreach (ILead lead in (IEnumerable<ILead>) this.Leads)
          {
            if (lead.Responsible == null)
              lead.Responsible = Locator.GetService<IAuthenticationService>().GetCurrentUser<IUser>();
            this.Entity.Lead = lead;
            this.Entities.Add(this.Entity);
            this.SaveEntityAndCreateNew();
          }
        }
        if (this.Sales == null)
          return;
        foreach (ISale sale in (IEnumerable<ISale>) this.Sales)
        {
          if (sale.Responsible == null)
            sale.Responsible = Locator.GetService<IAuthenticationService>().GetCurrentUser<IUser>();
          this.Entity.Sale = sale;
          this.Entities.Add(this.Entity);
          this.SaveEntityAndCreateNew();
        }
      }
      else
        this.SaveEntity();
    }

    protected abstract void SaveEntityAndCreateNew();

    protected T BaseCreateNew<T>() where T : IRelationship
    {
      T obj = InterfaceActivator.Create<T>();
      obj.StartDate = this.Entity.StartDate.AddMinutes((double) this.Interval.Minute);
      obj.StartDate = obj.StartDate.AddHours((double) this.Interval.Hour);
      obj.Theme = this.Entity.Theme;
      obj.Priority = this.Entity.Priority;
      obj.Description = this.Entity.Description;
      obj.IsPrivate = this.Entity.IsPrivate;
      foreach (IRelationshipUser relationshipUser1 in (IEnumerable<IRelationshipUser>) this.Entity.RelationshipUsers)
      {
        IRelationshipUser relationshipUser2 = InterfaceActivator.Create<IRelationshipUser>();
        relationshipUser2.User = relationshipUser1.User;
        relationshipUser2.Status = relationshipUser1.Status;
        obj.RelationshipUsers.Add(relationshipUser2);
      }
      return obj;
    }

    protected virtual void SaveEntity()
    {
      if (!this.LinkReadOnly)
      {
        switch (this.Link)
        {
          case RelationshipLink.Contractor:
            this.Entity.Contact = (IContact) null;
            this.Entity.Lead = (ILead) null;
            break;
          case RelationshipLink.Contact:
            this.Entity.Contractor = (IContractor) null;
            this.Entity.Lead = (ILead) null;
            this.Entity.Sale = (ISale) null;
            this.Entity.ContractorsContacts.Clear();
            this.Entity.LeadContacts.Clear();
            break;
          case RelationshipLink.Lead:
            this.Entity.Contractor = (IContractor) null;
            this.Entity.Contact = (IContact) null;
            this.Entity.Sale = (ISale) null;
            this.Entity.ContractorsContacts.Clear();
            this.Entity.LeadContacts.Clear();
            break;
        }
      }
      this.Entity.Save();
    }

    private IRelationshipUser CreateCopy(IRelationshipUser relationshipUser)
    {
      IRelationshipUser copy = InterfaceActivator.Create<IRelationshipUser>();
      copy.Relationship = relationshipUser.Relationship;
      copy.Status = relationshipUser.Status;
      copy.User = relationshipUser.User;
      return copy;
    }

    public bool IsAvailableCommentAdding
    {
      get => true;
      set
      {
      }
    }

    public bool IsAvailableDelete
    {
      get => true;
      set
      {
      }
    }

    public bool IsAvailableEdit
    {
      get => true;
      set
      {
      }
    }

    public bool IsAvailableCompleting
    {
      get => !(this.Entity.Completed ?? false);
      set
      {
      }
    }

    public bool IsAvailableDayAdding
    {
      get => !(this.Entity.Completed ?? false);
            set
      {
      }
    }

    public bool IsAvailableTimeChanging
    {
      get => !(this.Entity.Completed ?? false);
            set
      {
      }
    }

    public IRelationship Relationship => this.Entity;

    public virtual Guid RelationshipTypeUid => InterfaceActivator.UID(this.Entity.GetType().CastAsRealType<Type>());

    public abstract IRelationshipBaseModel CreateFromRelationship(IRelationship relationship);

    public abstract IRelationshipBaseModel CreateFromRelationship(
      IRelationship relationship,
      Guid customFormUid);

    public abstract string EditorViewName { get; }

    public virtual EleWise.ELMA.Model.Views.FormViewItem FormViewItem(ViewType viewType)
    {
      EleWise.ELMA.Model.Views.FormViewItem form = this.Metadata<EntityMetadata>().DefaultForms.GetForm(viewType);
      return viewType == ViewType.Display ? (EleWise.ELMA.Model.Views.FormViewItem) form.CloneAsReadOnly() : (EleWise.ELMA.Model.Views.FormViewItem) form.Clone();
    }
  }
}
