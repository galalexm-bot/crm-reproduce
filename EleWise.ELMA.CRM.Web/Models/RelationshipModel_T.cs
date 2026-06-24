// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.RelationshipModel`1
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  public abstract class RelationshipModel<T> : RelationshipModel where T : class, IRelationship
  {
    protected RelationshipModel(T relationship)
      : base((IRelationship) relationship)
    {
    }

    protected RelationshipModel()
    {
      this.Entity = InterfaceActivator.Create<T>();
      IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();
      relationshipUser.User = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
      relationshipUser.Status = RelationshipUserStatus.Participant;
      this.Entity.RelationshipUsers.Add(relationshipUser);
    }

    protected RelationshipModel(ViewType viewType)
      : this()
    {
      this.ViewType = viewType;
    }

    protected RelationshipModel(T relationship, ViewType viewType)
      : this(relationship)
    {
      this.ViewType = viewType;
      if ((object) relationship != null)
        return;
      this.Entity = InterfaceActivator.Create<T>();
      IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();
      relationshipUser.User = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
      relationshipUser.Status = RelationshipUserStatus.Participant;
      this.Entity.RelationshipUsers.Add(relationshipUser);
    }

    public T Entity
    {
      get => (T) base.Entity;
      set => base.Entity = value;
    }

    public IEnumerable<T> Entities => base.Entities.OfType<T>();

    public override Guid RelationshipTypeUid => InterfaceActivator.UID(typeof (T));

    public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

    public bool CanDelete => this.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, (object) this.Entity) && this.SecurityService.HasPermission(CRMPermissionProvider.CRMDeletePermission) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);

    public bool CanEdit
    {
      get
      {
        if (this.Entity.Sale != null)
        {
          if (this.Entity.Sale.SaleClosed())
            return false;
          return this.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, (object) this.Entity) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, (object) this.Entity) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
        }
        return this.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, (object) this.Entity) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, (object) this.Entity) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
      }
    }

    public bool CreateElement
    {
      get
      {
        if (this.Entity.Sale != null)
        {
          if (this.Entity.Sale.SaleClosed())
            return false;
          return this.SecurityService.HasPermission(CRMPermissionProvider.CRMSaleCreateElementPermission, (object) this.Entity.Sale) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, (object) this.Entity) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
        }
        return this.Entity.Contractor != null ? this.SecurityService.HasPermission(CRMPermissionProvider.CRMContractorCreateElementPermission, (object) this.Entity.Contractor) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, (object) this.Entity) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission) : (this.Entity.Contact != null ? this.SecurityService.HasPermission(CRMPermissionProvider.CRMContactCreateElementPermission, (object) this.Entity.Contact) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, (object) this.Entity) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission) : (this.Entity.Lead != null ? this.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, (object) this.Entity.Lead) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, (object) this.Entity) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission) : this.SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, (object) this.Entity) || this.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission)));
      }
    }

    public bool CanExecute => this.SecurityService.HasPermission(CRMPermissionProvider.ExecuteRelationshipPermission, (object) this.Entity);

    public bool CanComment => this.CanEdit || this.Entity.RelationshipUsers.Any<IRelationshipUser>((Func<IRelationshipUser, bool>) (r => r.User == Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>()));

    public override sealed IRelationshipBaseModel CreateFromRelationship(IRelationship relationship) => this.CreateModel(relationship, ViewType.Create, new Guid?());

    public override sealed IRelationshipBaseModel CreateFromRelationship(
      IRelationship relationship,
      Guid customFormUid)
    {
      return this.CreateModel(relationship, ViewType.Custom, new Guid?(customFormUid));
    }

    protected IRelationshipBaseModel CreateModel(
      IRelationship relationship,
      ViewType viewType,
      Guid? customFormUid)
    {
      if (!(relationship.CastAsRealType<IRelationship>() is T entity))
        return (IRelationshipBaseModel) null;
      if (customFormUid.HasValue)
        viewType = ViewType.Custom;
      return this.CreateConcreteModel(entity, viewType, customFormUid);
    }

    protected abstract IRelationshipBaseModel CreateConcreteModel(
      T entity,
      ViewType viewType,
      Guid? customFormUid);
  }
}
