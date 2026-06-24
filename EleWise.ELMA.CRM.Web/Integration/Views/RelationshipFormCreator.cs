// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Integration.Views.RelationshipFormCreator
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
  internal class RelationshipFormCreator : FormCreator
  {
    public override bool CheckType(Type type)
    {
      if (type == (Type) null)
        return false;
      if (typeof (IRelationshipCall).IsAssignableFrom(type) || typeof (IRelationshipMail).IsAssignableFrom(type))
        return base.CheckType(type);
      return !typeof (IRelationshipMeeting).IsAssignableFrom(type) && typeof (IRelationship).IsAssignableFrom(type);
    }

    public override string OnSubmitScript(HtmlHelper html, string prefix) => string.Format("{0}('Form{1}','{1}'); return false;", (object) html.ViewData.TemplateInfo.GetFullHtmlFieldId("checkEventTimePeriod"), (object) prefix);
  }
}
