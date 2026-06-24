// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.MarketingBaseQuestionEventRender
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Tasks.Models.History;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.History;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 50)]
  public class MarketingBaseQuestionEventRender : BaseAuditQuestionEventRender
  {
    protected override IEnumerable<Guid> Actions
    {
      get
      {
        yield return DefaultEntityActions.CreateGuid;
      }
    }

    protected override IEnumerable<Guid> Objects
    {
      get
      {
        yield return InterfaceActivator.UID<IQuestion>();
      }
    }

    public virtual bool CanRender(EntityActionEventArgs @event)
    {
      // ISSUE: explicit non-virtual call
      if (!((BaseAuditEventRender) this).CanRender(@event))
        return false;
      bool flag = this.CheckShowAll(@event);
      return typeof (IMarketingBase).IsAssignableFrom(((IQuestion) @event.New).RefObject.ObjectType) & flag;
    }

    protected override IHistoryBaseModel CreateEventData(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader)
    {
      return (IHistoryBaseModel) new QuestionTaskHistoryModel(@event, EleWise.ELMA.SR.T("Задан вопрос"))
      {
        Question = (IQuestion) @event.New
      };
    }
  }
}
