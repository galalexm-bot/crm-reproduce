using System;
using System.Collections.Generic;
using System.Linq;
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

namespace EleWise.ELMA.CRM.Web.Models;

[Component]
public class RelationshipMeetingModel : RelationshipModel<IRelationshipMeeting>
{
	private IEnumerable<CheckBoxListItem> _schdulesList;

	public bool WholeDay { get; set; }

	public long[] Schedules { get; set; }

	public ICollection<ISchedule> AllowSchedules { get; private set; }

	public IEnumerable<CheckBoxListItem> SchedulesList
	{
		get
		{
			if (_schdulesList == null)
			{
				if (AllowSchedules == null || AllowSchedules.Count == 0 || base.Entity == null)
				{
					_schdulesList = new List<CheckBoxListItem>();
				}
				else
				{
					_schdulesList = AllowSchedules.Select((ISchedule s) => new CheckBoxListItem(s.Id.ToString(), s.Name, ((IEnumerable<ISchedule>)base.Entity.Schedules).Any((ISchedule e) => e.Id == s.Id))
					{
						Description = s.Description
					});
				}
			}
			return _schdulesList;
		}
	}

	public bool ShowSchedules => ((IEnumerable<ISchedule>)base.Entity.Schedules).Any();

	public override string EditorViewName => "RelationshipMeeting/Editors/RelationshipMeetingEdit";

	public RelationshipMeetingModel(IRelationshipMeeting relationship)
		: base(relationship)
	{
		AllowSchedules = GetAvalibleSchedules();
	}

	public RelationshipMeetingModel()
	{
		base.Entity.EndDate = base.Entity.EndDate.AddMinutes(15.0);
		AllowSchedules = GetAvalibleSchedules();
	}

	public RelationshipMeetingModel(ViewType viewType)
		: base(viewType)
	{
		base.Entity.EndDate = base.Entity.EndDate.AddMinutes(15.0);
		AllowSchedules = GetAvalibleSchedules();
	}

	public RelationshipMeetingModel(IRelationshipMeeting relationship, ViewType viewType)
		: base(relationship, viewType)
	{
		AllowSchedules = GetAvalibleSchedules();
	}

	public static ICollection<ISchedule> GetAvalibleSchedules()
	{
		IScheduleFilter scheduleFilter = InterfaceActivator.Create<IScheduleFilter>();
		scheduleFilter.Shared = true;
		scheduleFilter.PermissionId = PermissionProvider.ScheduleEditPermission.Id;
		return ScheduleManager.Instance.Find(scheduleFilter, FetchOptions.All);
	}

	public void BindSchedules(ICollection<ISchedule> allow)
	{
		((ICollection<ISchedule>)base.Entity.Schedules).Clear();
		if (Schedules == null || !Schedules.Any())
		{
			return;
		}
		int i;
		for (i = 0; i < Schedules.Count(); i++)
		{
			if (allow.Any((ISchedule s) => s.Id == Schedules[i]))
			{
				base.Entity.Schedules.Add(allow.First((ISchedule s) => s.Id == Schedules[i]));
			}
		}
	}

	protected override void SaveEntityAndCreateNew()
	{
		SaveEntity();
		IRelationshipMeeting relationshipMeeting = BaseCreateNew<IRelationshipMeeting>();
		relationshipMeeting.EndDate = base.Entity.EndDate.AddMinutes(base.Interval.Minute);
		relationshipMeeting.EndDate = relationshipMeeting.EndDate.AddHours(base.Interval.Hour);
		relationshipMeeting.Place = base.Entity.Place;
		relationshipMeeting.TimeNotSet = base.Entity.TimeNotSet;
		base.Entity = relationshipMeeting;
	}

	protected override void SaveEntity()
	{
		if (!base.Entity.TimeNotSet && WholeDay)
		{
			base.Entity.StartDate = base.Entity.StartDate.Date.NormalizeStartDate(time: false);
			base.Entity.EndDate = base.Entity.StartDate.NormalizeEndDate(time: false);
		}
		base.SaveEntity();
	}

	protected override IRelationshipBaseModel CreateConcreteModel(IRelationshipMeeting entity, ViewType viewType, Guid? customFormUid)
	{
		entity.EndDate = entity.EndDate.AddMinutes(15.0);
		return new RelationshipMeetingModel(entity, ViewType.Create)
		{
			FormUid = customFormUid
		};
	}
}
