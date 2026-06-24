// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CalendarRelationshipItemLink
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class CalendarRelationshipItemLink : IObjectLink
  {
    public bool CheckType(Type type) => typeof (RelationshipCalendarItem).IsAssignableFrom(type);

    public string Url(RequestContext context, object obj)
    {
      UrlHelper urlHelper = new UrlHelper(context);
      RelationshipCalendarItem relationshipCalendarItem = (RelationshipCalendarItem) obj;
      if (relationshipCalendarItem.Relationship is IRelationshipCall)
        return urlHelper.Action("Details", "RelationshipCall", (object) new
        {
          id = relationshipCalendarItem.Id,
          area = "EleWise.ELMA.CRM.Web"
        });
      if (relationshipCalendarItem.Relationship is IRelationshipMeeting)
        return urlHelper.Action("Details", "RelationshipMeeting", (object) new
        {
          id = relationshipCalendarItem.Id,
          area = "EleWise.ELMA.CRM.Web"
        });
      return relationshipCalendarItem.Relationship is IRelationshipMail ? urlHelper.Action("Details", "RelationshipMail", (object) new
      {
        id = relationshipCalendarItem.Id,
        area = "EleWise.ELMA.CRM.Web"
      }) : (string) null;
    }
  }
}
