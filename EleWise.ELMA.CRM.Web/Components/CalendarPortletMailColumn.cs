// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CalendarPortletMailColumn
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
  [Component]
  public class CalendarPortletMailColumn : ICalendarPortletLastColumn
  {
    public Guid EntityTypeUid => InterfaceActivator.UID<IRelationshipMail>();

    public Func<ICalendarItem, MvcHtmlString> LastColumnCellData(HtmlHelper html) => (Func<ICalendarItem, MvcHtmlString>) (eventItem =>
    {
      if (string.IsNullOrWhiteSpace(eventItem.SourceId))
        return MvcHtmlString.Empty;
      IRelationshipMail relationshipMail = (IRelationshipMail) null;
      try
      {
        relationshipMail = AbstractNHEntityManager<IRelationshipMail, long>.Instance.LoadOrNull(Convert.ToInt64(eventItem.SourceId));
      }
      catch (SecurityException ex)
      {
      }
      if (relationshipMail == null)
        return MvcHtmlString.Empty;
      if (relationshipMail.Contact != null && relationshipMail.Contact.Email != null && relationshipMail.Contact.Email.Any<IEmail>())
        return html.Partial("DisplayTemplates/Entities/EmailSet", (object) relationshipMail.Contact.Email);
      if (relationshipMail.Contractor != null && relationshipMail.Contractor.Email != null && relationshipMail.Contractor.Email.Any<IEmail>())
        return html.Partial("DisplayTemplates/Entities/EmailSet", (object) relationshipMail.Contractor.Email);
      return relationshipMail.Lead != null && relationshipMail.Lead.Email != null && relationshipMail.Lead.Email.Any<IEmail>() ? html.Partial("DisplayTemplates/Entities/EmailSet", (object) relationshipMail.Lead.Email) : MvcHtmlString.Empty;
    });
  }
}
