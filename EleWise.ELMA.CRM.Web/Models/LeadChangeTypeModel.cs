// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.LeadChangeTypeModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class LeadChangeTypeModel
  {
    public long[] LeadsId { get; set; }

    [DisplayName(typeof (LeadChangeTypeModel_SR), "Type")]
    public ICollection<ILeadType> Types { get; set; }

    public bool Save(out string leadsWithoutEditAccess)
    {
      bool flag = false;
      leadsWithoutEditAccess = string.Empty;
      foreach (long id in this.LeadsId)
      {
        ILead target = LeadManager.Instance.Load(id);
        if (!Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.EditLeadPermission, (object) target))
        {
          leadsWithoutEditAccess = leadsWithoutEditAccess + target.Name + ", ";
        }
        else
        {
          flag = true;
          target.Types.Clear();
          if (this.Types != null)
            target.Types.AddAll(this.Types);
          if (target.Responsible == null)
            target.Responsible = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
          target.Save();
        }
      }
      if (leadsWithoutEditAccess != string.Empty)
        leadsWithoutEditAccess = leadsWithoutEditAccess.Remove(leadsWithoutEditAccess.Length - 2);
      return flag;
    }
  }
}
