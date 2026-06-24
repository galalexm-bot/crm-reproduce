// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CalendarPortletCallColumn
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using System;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 10)]
  public class CalendarPortletCallColumn : ICalendarPortletLastColumn
  {
    public Guid EntityTypeUid => InterfaceActivator.UID<IRelationshipCall>();

    public Func<ICalendarItem, MvcHtmlString> LastColumnCellData(HtmlHelper html) => (Func<ICalendarItem, MvcHtmlString>) (eventItem =>
    {
      if (string.IsNullOrWhiteSpace(eventItem.SourceId))
        return MvcHtmlString.Empty;
      IRelationshipCall relationshipCall = (IRelationshipCall) null;
      try
      {
        relationshipCall = AbstractNHEntityManager<IRelationshipCall, long>.Instance.LoadOrNull(Convert.ToInt64(eventItem.SourceId));
      }
      catch (SecurityException ex)
      {
      }
      if (relationshipCall == null)
        return MvcHtmlString.Empty;
      if (relationshipCall.Contact != null && relationshipCall.Contact.Phone != null && relationshipCall.Contact.Phone.Any<IPhone>())
        return html.Partial("DisplayTemplates/Entities/PhoneSet", (object) relationshipCall.Contact.Phone);
      if (relationshipCall.Contractor != null && relationshipCall.Contractor.Phone != null && relationshipCall.Contractor.Phone.Any<IPhone>())
        return html.Partial("DisplayTemplates/Entities/PhoneSet", (object) relationshipCall.Contractor.Phone);
      return relationshipCall.Lead != null && relationshipCall.Lead.Phone != null && relationshipCall.Lead.Phone.Any<IPhone>() ? html.Partial("DisplayTemplates/Entities/PhoneSet", (object) relationshipCall.Lead.Phone) : MvcHtmlString.Empty;
    });
  }
}
