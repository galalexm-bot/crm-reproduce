// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CrmTaskParametersActionWebHandler
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using System;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class CrmTaskParametersActionWebHandler : ICommentActionWebHandler
  {
    public void BeforeCreateProcess(IValueProvider valueProvider, object target)
    {
      if (!(target is TaskModel taskModel) || !(((EntityModel<ITask>) taskModel).Entity is ICRMTaskBase entity))
        return;
      long result = 0;
      ValueProviderResult valueProviderResult1 = valueProvider.GetValue("crmEntityId");
      if (valueProviderResult1 != null)
        long.TryParse(valueProviderResult1.AttemptedValue, out result);
      Guid? nullable = new Guid?();
      ValueProviderResult valueProviderResult2 = valueProvider.GetValue("crmEntityTypeUid");
      if (valueProviderResult2 != null)
        nullable = new Guid?(Guid.Parse(valueProviderResult2.AttemptedValue));
      if (!nullable.HasValue || result <= 0L)
        return;
      Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(nullable.Value);
      if (typeof (IContractor).IsAssignableFrom(typeByUid))
        entity.Contractor = ContractorManager.Instance.LoadOrNull(result);
      if (typeof (IContact).IsAssignableFrom(typeByUid))
        entity.Contact = ContactManager.Instance.LoadOrNull(result);
      if (typeof (ILead).IsAssignableFrom(typeByUid))
        entity.Lead = LeadManager.Instance.LoadOrNull(result);
      if (!typeof (ISale).IsAssignableFrom(typeByUid))
        return;
      entity.Sale = SaleManager.Instance.LoadOrNull(result);
    }
  }
}
