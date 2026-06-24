using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks;

[Serializable]
public class TaskCalendarItem : ICalendarItem
{
	[ScriptIgnore]
	public readonly ITaskTimePlan TimePlan;

	[ScriptIgnore]
	public IUser CurrentUser { get; set; }

	public string Id => TimePlan.Id.ToString();

	public Guid Uid => TimePlan.Uid;

	public string SourceId => TimePlan.Task.Id.ToString();

	public Guid SourceTypeUid => TimePlan.Task.TypeUid;

	public DateTime StartDate { get; set; }

	public DateTime EndDate { get; set; }

	public DateTime? LimitStartDate { get; set; }

	public DateTime? LimitEndDate { get; set; }

	public CalendarEventPeriod Period { get; set; }

	public bool Completed { get; set; }

	public bool MarkExpired => false;

	public bool ToInform { get; set; }

	public string Theme { get; set; }

	public string Place { get; set; }

	public string To { get; set; }

	public IDictionary<string, string> EventUsers { get; set; }

	public string Description { get; set; }

	public bool Periodical
	{
		get
		{
			if (TimePlan.Task is ITask)
			{
				return ((ITask)TimePlan.Task).Period != CalendarEventPeriod.Once;
			}
			return false;
		}
	}

	public ICalendarItem Template { get; set; }

	public bool HasCopy { get; set; }

	public bool OnlyInfo { get; set; }

	public long CreationAuthor { get; set; }

	public bool ReadOnly { get; set; }

	public ICollection<IComment> Comments => (ICollection<IComment>)TimePlan.Task.Comments;

	public bool PrivateAccess => false;

	public TaskCalendarItem(ITaskTimePlan timePlan, IUser currentUser = null)
	{
		if (timePlan == null)
		{
			throw new ArgumentNullException("timePlan");
		}
		CurrentUser = currentUser;
		TimePlan = timePlan;
		StartDate = TimePlan.StartTime;
		EndDate = TimePlan.EndTime;
		Completed = TimePlan.Task.IsComplete();
		Theme = TimePlan.Task.Subject;
		Place = "";
		List<IUser> list = new List<IUser> { TimePlan.Task.Executor };
		if (((IEnumerable<IUser>)TimePlan.Task.InformTo).Any())
		{
			list.AddRange((IEnumerable<IUser>)TimePlan.Task.InformTo);
		}
		EventUsers = list.Distinct((IUser a, IUser b) => a.Id == b.Id, (IUser c) => c.Id.GetHashCode()).ToDictionary((IUser u) => u.Id.ToString(), (IUser u) => u.GetShortName());
		Description = TimePlan.Task.Description;
		HasCopy = true;
		ToInform = CurrentUser != null && TimePlan.Task.Executor != CurrentUser && ((IEnumerable<IUser>)TimePlan.Task.InformTo).Any((IUser u) => u == CurrentUser);
		CreationAuthor = TimePlan.Author.Id;
		ReadOnly = false;
	}

	public ICalendarItem Clone()
	{
		return new TaskCalendarItem(TimePlan, CurrentUser);
	}
}
