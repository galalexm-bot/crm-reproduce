// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.PhoneController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  public class PhoneController : BPMController<IPhone, long>
  {
    public bool IsReplacePhoneStringByLink()
    {
      IPhoneSettingsExtension settingsExtension = ComponentManager.Current.GetExtensionPoints<IPhoneSettingsExtension>().FirstOrDefault<IPhoneSettingsExtension>();
      return settingsExtension != null && settingsExtension.IsReplacePhoneStringByLink();
    }
  }
}
