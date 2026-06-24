// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.RelationCallEventAddAction
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class RelationCallEventAddAction : IEventAddAction
  {
    public string Uid => "add-calendar-relation-call";

    public string Name => SR.T("Звонок");

    public string Url(RequestContext context) => new UrlHelper(context).Action("Create", "RelationshipCall", (object) new
    {
      area = "EleWise.ELMA.CRM.Web",
      start = "{0}",
      end = "{1}"
    });

    public object WindowSettings => (object) null;

    public string Icon => "#add_call.svg";

    public int Order => 30;

    public bool AllowInShared => false;
  }
}
