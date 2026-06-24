using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Calendar.API.Models;

[Serializable]
[DataContract(Name = "CalendarItem")]
public class CalendarItemWCF
{
	[DataMember]
	public Guid TypeUid { get; set; }

	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public DateTime StartDate { get; set; }

	[DataMember]
	public DateTime EndDate { get; set; }

	[DataMember]
	public bool Completed { get; set; }

	[DataMember]
	public bool MarkExpired { get; set; }

	[DataMember]
	public bool ToInform { get; set; }

	[DataMember]
	public string Theme { get; set; }

	[DataMember]
	public string Place { get; set; }

	[DataMember]
	public string To { get; set; }

	[DataMember]
	public string Description { get; set; }

	[DataMember]
	public bool HasCopy { get; set; }

	[DataMember]
	public bool OnlyInfo { get; set; }

	[DataMember]
	public long CreationAuthor { get; set; }

	[DataMember]
	public bool ReadOnly { get; set; }

	[DataMember]
	public bool PrivateAccess { get; set; }

	public CalendarItemWCF(ICalendarItem calendarItem)
	{
		TypeUid = calendarItem.SourceTypeUid;
		Id = long.Parse(calendarItem.Id);
		Uid = calendarItem.Uid;
		StartDate = calendarItem.StartDate;
		EndDate = calendarItem.EndDate;
		Completed = calendarItem.Completed;
		MarkExpired = calendarItem.MarkExpired;
		ToInform = calendarItem.ToInform;
		Theme = calendarItem.Theme;
		Place = calendarItem.Place;
		To = calendarItem.To;
		Description = calendarItem.Description;
		HasCopy = calendarItem.HasCopy;
		OnlyInfo = calendarItem.OnlyInfo;
		CreationAuthor = calendarItem.CreationAuthor;
		ReadOnly = calendarItem.ReadOnly;
		PrivateAccess = calendarItem.PrivateAccess;
	}
}
