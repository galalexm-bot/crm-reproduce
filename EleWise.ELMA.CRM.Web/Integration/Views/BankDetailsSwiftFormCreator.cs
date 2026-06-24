// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Integration.Views.BankDetailsSwiftFormCreator
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;

namespace EleWise.ELMA.CRM.Web.Integration.Views
{
  [Component(Order = 100)]
  internal class BankDetailsSwiftFormCreator : FormCreator
  {
    public override bool CheckType(Type type) => type != (Type) null && typeof (IBankDetailsSWIFT).IsAssignableFrom(type) && base.CheckType(type);
  }
}
