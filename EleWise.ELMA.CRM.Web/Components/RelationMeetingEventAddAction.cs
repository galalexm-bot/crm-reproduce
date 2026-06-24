// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.RelationMeetingEventAddAction
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
  public class RelationMeetingEventAddAction : IEventAddAction
  {
    public string Uid => "add-calendar-relation-meeting";

    public string Name => SR.T("Встречу");

    public string Url(RequestContext context) => new UrlHelper(context).Action("Create", "RelationshipMeeting", (object) new
    {
      area = "EleWise.ELMA.CRM.Web",
      start = "{0}",
      end = "{1}",
      schedule = "{2}"
    });

    public object WindowSettings => (object) null;

    public string Icon => "#user_add.svg";

    public int Order => 50;

    public bool AllowInShared => false;
  }
}
