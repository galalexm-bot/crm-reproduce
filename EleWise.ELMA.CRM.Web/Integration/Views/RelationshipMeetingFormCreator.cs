// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Integration.Views.RelationshipMeetingFormCreator
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Integration.Views
{
  [Component(Order = 90)]
  internal class RelationshipMeetingFormCreator : FormCreator
  {
    public override bool CheckType(Type type) => !(type == (Type) null) && typeof (IRelationshipMeeting).IsAssignableFrom(type) && base.CheckType(type);

    public override string OnSubmitScript(HtmlHelper html, string prefix) => string.Format("{0}('Form{1}','{1}'); return false;", (object) html.ViewData.TemplateInfo.GetFullHtmlFieldId("checkEventTimePeriodMeeting"), (object) prefix);
  }
}
