// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.InpaymentPersonalizationAdministration
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class InpaymentPersonalizationAdministration
  {
    static InpaymentPersonalizationAdministration()
    {
      if (PersonalizationAdministration.Provider == null)
        throw new NotInitializedException("Cannot find default Personalization provider");
    }

    private static string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

    public static InpaymentStatusFilterModel LoadState(string statusFilter) => PersonalizationAdministration.LoadState<InpaymentStatusFilterModel>(InpaymentPersonalizationAdministration.CurrentUserName, statusFilter);

    public static void SaveState(string statusFilter, InpaymentStatusFilterModel state) => PersonalizationAdministration.SaveState<InpaymentStatusFilterModel>(InpaymentPersonalizationAdministration.CurrentUserName, statusFilter, state);
  }
}
