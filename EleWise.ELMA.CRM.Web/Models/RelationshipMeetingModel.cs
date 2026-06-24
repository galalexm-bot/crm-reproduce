// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.RelationshipMeetingModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Html.ChekBoxes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  [Component]
  public class RelationshipMeetingModel : RelationshipModel<IRelationshipMeeting>
  {
    private IEnumerable<CheckBoxListItem> _schdulesList;

    public RelationshipMeetingModel(IRelationshipMeeting relationship)
      : base(relationship)
    {
      this.AllowSchedules = RelationshipMeetingModel.GetAvalibleSchedules();
    }

    public RelationshipMeetingModel()
    {
      this.Entity.EndDate = this.Entity.EndDate.AddMinutes(15.0);
      this.AllowSchedules = RelationshipMeetingModel.GetAvalibleSchedules();
    }

    public RelationshipMeetingModel(ViewType viewType)
      : base(viewType)
    {
      this.Entity.EndDate = this.Entity.EndDate.AddMinutes(15.0);
      this.AllowSchedules = RelationshipMeetingModel.GetAvalibleSchedules();
    }

    public RelationshipMeetingModel(IRelationshipMeeting relationship, ViewType viewType)
      : base(relationship, viewType)
    {
      this.AllowSchedules = RelationshipMeetingModel.GetAvalibleSchedules();
    }

    public static ICollection<ISchedule> GetAvalibleSchedules()
    {
      IScheduleFilter filter = InterfaceActivator.Create<IScheduleFilter>();
      filter.Shared = new bool?(true);
      filter.PermissionId = new Guid?(PermissionProvider.ScheduleEditPermission.Id);
      return ScheduleManager.Instance.Find((IEntityFilter) filter, FetchOptions.All);
    }

    public bool WholeDay { get; set; }

    public long[] Schedules { get; set; }

    public ICollection<ISchedule> AllowSchedules { get; private set; }

    public IEnumerable<CheckBoxListItem> SchedulesList
    {
      get
      {
        if (this._schdulesList == null)
          this._schdulesList = this.AllowSchedules == null || this.AllowSchedules.Count == 0 || this.Entity == null ? (IEnumerable<CheckBoxListItem>) new List<CheckBoxListItem>() : this.AllowSchedules.Select<ISchedule, CheckBoxListItem>((Func<ISchedule, CheckBoxListItem>) (s =>
          {
            return new CheckBoxListItem(s.Id.ToString(), s.Name, this.Entity.Schedules.Any<ISchedule>((Func<ISchedule, bool>) (e => e.Id == s.Id)))
            {
              Description = s.Description
            };
          }));
        return this._schdulesList;
      }
    }

    public void BindSchedules(ICollection<ISchedule> allow)
    {
      this.Entity.Schedules.Clear();
      if (this.Schedules == null || !((IEnumerable<long>) this.Schedules).Any<long>())
        return;
      for (int i = 0; i < ((IEnumerable<long>) this.Schedules).Count<long>(); i++)
      {
        if (allow.Any<ISchedule>((Func<ISchedule, bool>) (s => s.Id == this.Schedules[i])))
          this.Entity.Schedules.Add(allow.First<ISchedule>((Func<ISchedule, bool>) (s => s.Id == this.Schedules[i])));
      }
    }

    public bool ShowSchedules => this.Entity.Schedules.Any<ISchedule>();

    protected override void SaveEntityAndCreateNew()
    {
      this.SaveEntity();
      IRelationshipMeeting relationshipMeeting = this.BaseCreateNew<IRelationshipMeeting>();
      relationshipMeeting.EndDate = this.Entity.EndDate.AddMinutes((double) this.Interval.Minute);
      relationshipMeeting.EndDate = relationshipMeeting.EndDate.AddHours((double) this.Interval.Hour);
      relationshipMeeting.Place = this.Entity.Place;
      relationshipMeeting.TimeNotSet = this.Entity.TimeNotSet;
      this.Entity = relationshipMeeting;
    }

    protected override void SaveEntity()
    {
      if (!this.Entity.TimeNotSet && this.WholeDay)
      {
        this.Entity.StartDate = this.Entity.StartDate.Date.NormalizeStartDate(false);
        this.Entity.EndDate = this.Entity.StartDate.NormalizeEndDate(false);
      }
      base.SaveEntity();
    }

    protected override IRelationshipBaseModel CreateConcreteModel(
      IRelationshipMeeting entity,
      ViewType viewType,
      Guid? customFormUid)
    {
      entity.EndDate = entity.EndDate.AddMinutes(15.0);
      RelationshipMeetingModel concreteModel = new RelationshipMeetingModel(entity, ViewType.Create);
      concreteModel.FormUid = customFormUid;
      return (IRelationshipBaseModel) concreteModel;
    }

    public override string EditorViewName => "RelationshipMeeting/Editors/RelationshipMeetingEdit";
  }
}
