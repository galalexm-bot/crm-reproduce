// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Extensions.ContractorLegalWatchNotifier
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Extensions
{
  [Component]
  public class ContractorLegalWatchNotifier : IWatchNotifier
  {
    public IEntityActionHandler EntityActionHandler { get; set; }

    public bool IsAvailable(Guid TypeUid) => MetadataLoader.IsBaseOrChildClass<IContractor>(TypeUid);

    [Transaction]
    public virtual void Notify(
      object entityId,
      IEnumerable<EleWise.ELMA.Security.Models.IUser> addUsers,
      IEnumerable<EleWise.ELMA.Security.Models.IUser> deleteUsers)
    {
      IEntity contractor = (IEntity) null;
      Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies((Action) (() => contractor = (IEntity) ContractorManager.Instance.Load(Convert.ToInt64(entityId))));
      EntityActionEventArgs e = new EntityActionEventArgs((IEntity) null, contractor, "d17e073c-0f95-4c57-9322-4f18d560401e");
      if (addUsers != null)
        e.ExtendedProperties.Add("AddMembers", (object) addUsers);
      if (deleteUsers != null)
        e.ExtendedProperties.Add("DeleteMembers", (object) deleteUsers);
      this.EntityActionHandler.ActionExecuted(e);
    }
  }
}
