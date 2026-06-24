// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.ContractorContactListModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class ContractorContactListModel
  {
    public string FilterQuery { get; set; }

    [DisplayName("Контакты")]
    public IList<IContact> ContractorContacts { get; set; }
  }
}
