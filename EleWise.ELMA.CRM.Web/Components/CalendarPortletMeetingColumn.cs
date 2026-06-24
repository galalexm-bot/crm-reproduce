// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CalendarPortletMeetingColumn
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using System;
using System.Security;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class CalendarPortletMeetingColumn : ICalendarPortletLastColumn
  {
    public Guid EntityTypeUid => InterfaceActivator.UID<IRelationshipMeeting>();

    public Func<ICalendarItem, MvcHtmlString> LastColumnCellData(HtmlHelper html) => (Func<ICalendarItem, MvcHtmlString>) (eventItem =>
    {
      if (string.IsNullOrWhiteSpace(eventItem.SourceId))
        return MvcHtmlString.Empty;
      IRelationshipMeeting relationshipMeeting = (IRelationshipMeeting) null;
      try
      {
        relationshipMeeting = RelationshipMeetingManager.Instance.LoadOrNull(Convert.ToInt64(eventItem.SourceId));
      }
      catch (SecurityException ex)
      {
      }
      if (relationshipMeeting == null)
        return MvcHtmlString.Empty;
      return MvcHtmlString.Create(relationshipMeeting.Place.HtmlEncode());
    });
  }
}
