// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CalendarRelationshipItemIcon
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class CalendarRelationshipItemIcon : IObjectIcon
  {
    public bool CheckType(Type type) => typeof (RelationshipCalendarItem).IsAssignableFrom(type);

    public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
    {
      RelationshipCalendarItem relationshipCalendarItem = (RelationshipCalendarItem) obj;
      if (relationshipCalendarItem.Relationship is IRelationshipCall)
        return "#phone.svg";
      if (relationshipCalendarItem.Relationship is IRelationshipMeeting)
        return "#users.svg";
      return relationshipCalendarItem.Relationship is IRelationshipMail ? "#messages.svg" : "#calendar.svg";
    }
  }
}
